#region Licence
//
//This file is part of ArcEngine.
//Copyright (C)2008-2011 Adrien Hémery ( iliak@mimicprod.net )
//
//ArcEngine is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//any later version.
//
//ArcEngine is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//
//You should have received a copy of the GNU General Public License
//along with Foobar.  If not, see <http://www.gnu.org/licenses/>.
//
#endregion
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Forms;
using ArcEngine.Graphic;
using ArcEngine.Interface;
using System.Drawing;
using System;


namespace DungeonEye.Forms
{
	/// <summary>
	/// Decoration form
	/// </summary>
	public partial class DecorationSetForm : AssetEditorBase
	{

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="node">XmlNode handle</param>
		public DecorationSetForm(XmlNode node)
		{
			InitializeComponent();

			LastMousePosition = Control.MousePosition;

			BgTileSet = new TileSet();

			DecorationSet = new DecorationSet();
			DecorationSet.Load(node);
			ChangeDecorationId(0);
		}



		/// <summary>
		/// Change the background tileset
		/// </summary>
		/// <param name="name">Name of the tileset</param>
		/// <returns>True on success</returns>
		bool ChangeBackgroundTileSet(string name)
		{
			if (BgTileSet != null)
				BgTileSet.Dispose();
			BgTileSet = null;

			if (string.IsNullOrEmpty(name))
				return false;

			BgTileSet = ResourceManager.CreateAsset<TileSet>(name);

			DecorationSet.BackgroundTileset = name;

			return BgTileSet != null;
		}


		/// <summary>
		/// Changes the decoration tileset
		/// </summary>
		/// <param name="name">TileSet name</param>
		/// <returns>True on success</returns>
		bool ChangeDecorationTileSet(string name)
		{
			return DecorationSet.LoadTileSet(name);
		}


		/// <summary>
		/// Render the scene
		/// </summary>
		void RenderScene()
		{
			OpenGLBox.MakeCurrent();
			Display.ClearBuffers();

			Batch.Begin();

			// Background
			Batch.DrawTile(BgTileSet, 0, Point.Empty);

			// Render the walls
			if (DisplayWallBox.Checked)
			{
				foreach (TileDrawing tmp in DisplayCoordinates.GetWalls(ViewPositionBox.Position))
					Batch.DrawTile(BgTileSet, tmp.ID, tmp.Location, Color.White, 0.0f, tmp.Effect, 0.0f);
			}


			#region Draw the decoration
			if (Decoration != null && DecorationSet.Tileset != null)
			{
				DecorationSet.Draw(Batch, (int) DecorationIdBox.Value, ViewPositionBox.Position);

				Tile tile = DecorationSet.Tileset.GetTile(Decoration.GetTileId(ViewPositionBox.Position));
				if (tile != null)
				{
					Point start = Decoration.GetLocation(ViewPositionBox.Position);
					Rectangle rect = new Rectangle(start, tile.Size);

					// Red rectangle around tile
					if (rect.Contains(OpenGLBox.PointToClient(Control.MousePosition)) && !ItemsModeSelected)
						Batch.DrawRectangle(rect, Color.Red);
				}

				TileLocationBox.Text = Decoration.GetLocation(ViewPositionBox.Position).ToString();
			}
			else
			{
				TileLocationBox.Text = "";
			}
			#endregion


			#region Display item
			if (ItemsModeSelected && ItemTileset != null &&
				(ViewPositionBox.Position == ViewFieldPosition.L || 
				ViewPositionBox.Position == ViewFieldPosition.H || 
				ViewPositionBox.Position == ViewFieldPosition.C))
			{

				// Offset the item locations according to the distance
				Vector2 vect = DisplayCoordinates.GetMonsterScaleFactor(ViewPositionBox.Position);
				Point loc = Decoration.PrepareLocation(ViewPositionBox.Position);
				loc.Offset((int) (Decoration.ItemLocation.X * vect.X), (int) (Decoration.ItemLocation.Y * vect.Y));


				Batch.DrawTile(ItemTileset, (int) ItemIdBox.Value, loc,
					DisplayCoordinates.GetDistantColor(ViewPositionBox.Position), 0.0f,
					DisplayCoordinates.GetItemScaleFactor(ViewPositionBox.Position), SpriteEffects.None, 0.0f);

				ItemPositionBox.Text = Decoration.ItemLocation.ToString();
			}
			#endregion

			Batch.End();

			OpenGLBox.SwapBuffers();
		}


		/// <summary>
		/// Update each viewposition status in the View box
		/// </summary>
		void UpdateViewBoxStatus()
		{

			if (Decoration != null)
			{
				foreach (ViewFieldPosition pos in Enum.GetValues(typeof(ViewFieldPosition)))
				{
					ViewPositionBox.HighlightPosition(pos, Decoration.GetTileId(pos) != -1);
				}
			}
			else
			{
				foreach (ViewFieldPosition pos in Enum.GetValues(typeof(ViewFieldPosition)))
					ViewPositionBox.HighlightPosition(pos, false);
			}


			PasteBox.Enabled = CopyId != -1;
		}


		/// <summary>
		/// Change the curent decoration
		/// </summary>
		/// <param name="id">Id of the decoration</param>
		void ChangeDecorationId(int id)
		{
			Decoration = DecorationSet.GetDecoration(id);

			if (Decoration != null)
			{
				TileIdBox.Value = Decoration.GetTileId(ViewPositionBox.Position);
				HorizontalSwapBox.Checked = Decoration.GetSwap(ViewPositionBox.Position);
				BlockBox.Checked = Decoration.IsBlocking;
				ForceDisplayBox.Checked = Decoration.ForceDisplay;
				OnHackIdBox.Value = Decoration.OnHackId;
				OnBashIdBox.Value = Decoration.OnBashId;
				OnClickIdBox.Value = Decoration.OnClickId;
				HideItemsBox.Checked = Decoration.HideItems;
			}
			else
			{
				TileIdBox.Value = -1;
				HorizontalSwapBox.Checked = false;
				BlockBox.Checked = false;
				ForceDisplayBox.Checked = false;
				OnHackIdBox.Value = -1;
				OnBashIdBox.Value = -1;
				OnClickIdBox.Value = -1;
				HideItemsBox.Checked = false;
			}

			UpdateViewBoxStatus();
		}


		/// <summary>
		/// Save the asset to the manager
		/// </summary>
		public override void Save()
		{
			ResourceManager.AddAsset<DecorationSet>(DecorationSet.Name, ResourceManager.ConvertAsset(DecorationSet));
		}



		#region Form events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CopyBox_Click(object sender, EventArgs e)
		{
			CopyId = (int) DecorationIdBox.Value;
			UpdateViewBoxStatus();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PasteBox_Click(object sender, EventArgs e)
		{
			if (CopyId == -1)
				return;

			if (Decoration == null)
				Decoration = DecorationSet.AddDecoration((int) DecorationIdBox.Value);

			Decoration deco = DecorationSet.GetDecoration(CopyId);
			if (deco == null)
				return;

			foreach (ViewFieldPosition view in Enum.GetValues(typeof(ViewFieldPosition)))
			{
				Decoration.SetTileId(view, deco.GetTileId(view));
				Decoration.SetLocation(view, deco.GetLocation(view));
				Decoration.SetSwap(view, deco.GetSwap(view));
			}
			Decoration.ForceDisplay = deco.ForceDisplay;
			Decoration.IsBlocking = deco.IsBlocking;
			Decoration.HideItems = deco.HideItems;

			UpdateViewBoxStatus();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearAllBox_Click(object sender, EventArgs e)
		{
			if (Decoration == null)
				return;

			Decoration.Clear();

			UpdateViewBoxStatus();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DecorationForm_Load(object sender, System.EventArgs e)
		{
			OpenGLBox.MakeCurrent();
			Display.ViewPort = new Rectangle(Point.Empty, OpenGLBox.Size);
			Display.RenderState.ClearColor = Color.Black;
			Display.RenderState.Blending = true;
			Display.BlendingFunction(BlendingFactorSource.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);

			Batch = new SpriteBatch();

			// Collect all Tileset definition
			List<string> list = ResourceManager.GetAssets<TileSet>();
			BackgroundTileSetBox.Items.AddRange(list.ToArray());


			// Background tileset
			if (list.Contains(DecorationSet.BackgroundTileset))
				BackgroundTileSetBox.SelectedItem = DecorationSet.BackgroundTileset;
			else if (BackgroundTileSetBox.Items.Count > 0)
			{
				ChangeBackgroundTileSet((string) BackgroundTileSetBox.Items[0]);
				BackgroundTileSetBox.SelectedIndex = 0;
			}


			// Decoration TileSet
			list = ResourceManager.GetAssets<TileSet>();
			TilesetBox.Items.AddRange(list.ToArray());
			if (list.Contains(DecorationSet.TileSetName))
				TilesetBox.SelectedItem = DecorationSet.TileSetName;

			//list = ResourceManager.GetAssets<TileSet>();
			ItemTileSetBox.Items.AddRange(list.ToArray());


			OpenGLBox.MouseWheel += new MouseEventHandler(OpenGLBox_MouseWheel);

			DrawTimer.Start();
		}


		/// <summary>
		/// Form closing
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DecorationForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (DrawTimer != null)
				DrawTimer.Dispose();
			DrawTimer = null;

			if (Batch != null)
				Batch.Dispose();
			Batch = null;

			if (BgTileSet != null)
				BgTileSet.Dispose();
			BgTileSet = null;

			if (DecorationSet != null)
				DecorationSet.Dispose();
			DecorationSet = null;

			if (ItemTileset != null)
				ItemTileset.Dispose();
			ItemTileset = null;

			if (OpenGLBox != null)
				OpenGLBox.Dispose();
			OpenGLBox = null;

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HorizontalSwapBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Decoration == null)
				return;

			Decoration.SetSwap(ViewPositionBox.Position, HorizontalSwapBox.Checked);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BlockBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Decoration == null)
				return;

			Decoration.IsBlocking = BlockBox.Checked;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AlwaysVisibleBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Decoration == null)
				return;

			Decoration.ForceDisplay = ForceDisplayBox.Checked;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BgTileSetBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (BackgroundTileSetBox.SelectedIndex == -1)
				return;

			ChangeBackgroundTileSet((string) BackgroundTileSetBox.SelectedItem);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TilesetBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (TilesetBox.SelectedIndex == -1)
				return;

			ChangeDecorationTileSet((string) TilesetBox.SelectedItem);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TileIdBox_ValueChanged(object sender, System.EventArgs e)
		{
			if (Decoration == null)
				Decoration = DecorationSet.AddDecoration((int) DecorationIdBox.Value);

			Decoration.SetTileId(ViewPositionBox.Position, (int) TileIdBox.Value);


			// If position is empty (aka X=-999 & y=-999), set it to zero
			if (Decoration.GetLocation(ViewPositionBox.Position).X < -500 && Decoration.GetLocation(ViewPositionBox.Position).Y < -500)
				Decoration.SetLocation(ViewPositionBox.Position, Point.Empty);


			UpdateViewBoxStatus();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DecorationIdBox_ValueChanged(object sender, System.EventArgs e)
		{
			ChangeDecorationId((int) DecorationIdBox.Value);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DrawTimer_Tick(object sender, System.EventArgs e)
		{
			RenderScene();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="position"></param>
		private void ViewPositionBox_PositionChanged(object sender, ViewFieldPosition position)
		{
			if (Decoration != null)
			{
				TileIdBox.Value = Decoration.GetTileId(position);
				HorizontalSwapBox.Checked = Decoration.GetSwap(ViewPositionBox.Position);
			}
			else
				TileIdBox.Value = -1;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnBashIdBox_ValueChanged(object sender, EventArgs e)
		{
			if (Decoration == null)
				return;

			Decoration.OnBashId = (int)OnBashIdBox.Value;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnClickIdBox_ValueChanged(object sender, EventArgs e)
		{
			if (Decoration == null)
				return;

			Decoration.OnClickId = (int)OnClickIdBox.Value;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnHackIdBox_ValueChanged(object sender, EventArgs e)
		{
			if (Decoration == null)
				return;

			Decoration.OnHackId = (int)OnHackIdBox.Value;
		}


		#endregion


		#region OpenGL control events


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OpenGLBox_MouseWheel(object sender, MouseEventArgs e)
		{
			if (ItemsModeSelected)
			{
				if (ItemTileset == null)
					return;

				if (e.Delta > 0)
					ItemIdBox.Value++;
				else if (ItemIdBox.Value > -1)
					ItemIdBox.Value--;
			}
			else
			{
				if (e.Delta > 0)
					TileIdBox.Value++;
				else if (TileIdBox.Value > -1)
					TileIdBox.Value--;
			}
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OpenGLBox_MouseMove(object sender, MouseEventArgs e)
		{
			if (Decoration == null)
				return;


			// Left mouse button
			if (e.Button == MouseButtons.Left)
			{
				Point offset = new Point(LastMousePosition.X - e.Location.X, LastMousePosition.Y - e.Location.Y);


				if (ItemsModeSelected)
				{
					if (ItemTileset != null && ViewPositionBox.Position == ViewFieldPosition.L)
					{
						// Offset item location
						Decoration.ItemLocation  = new Point(Decoration.ItemLocation.X - offset.X, Decoration.ItemLocation.Y - offset.Y);
						Cursor = Cursors.SizeAll;
					}
				}
				else
				{
					int tileid = Decoration.GetTileId(ViewPositionBox.Position);
					Point location = Decoration.GetLocation(ViewPositionBox.Position);
					if (DecorationSet.Tileset != null)
					{
						Tile tile = DecorationSet.Tileset.GetTile(tileid);
						if (tile != null)
						{


							// Mouse over tile, so pan the tile
							Rectangle rect = new Rectangle(location, tile.Size);
							Decoration.SetLocation(ViewPositionBox.Position, new Point(location.X - offset.X, location.Y - offset.Y));

							Cursor = Cursors.SizeAll;
						}
					}
				}
			}
			else
			{
				Cursor = Cursors.Default;
			}


			// Update last mouse position
			LastMousePosition = e.Location;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OpenGLBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (Decoration == null)
				return;

			Point location = Decoration.GetLocation(ViewPositionBox.Position);
			Point item = Decoration.ItemLocation;

			switch (e.KeyCode)
			{
				case Keys.Up:
				{
					if (ItemsModeSelected)
						item.Y--;
					else
						location.Y--;

					e.IsInputKey = true;
				}
				break;

				case Keys.Down:
				{
					if (ItemsModeSelected)
						item.Y++;
					else
						location.Y++;

					e.IsInputKey = true;
				}
				break;

				case Keys.Left:
				{
					if (ItemsModeSelected)
						item.X--;
					else
						location.X--;

					e.IsInputKey = true;
				}
				break;

				case Keys.Right:
				{
					if (ItemsModeSelected)
						item.X++;
					else
						location.X++;

					e.IsInputKey = true;
				}
				break;
			}

			Decoration.SetLocation(ViewPositionBox.Position, location);
			Decoration.ItemLocation = item;
		}


		#endregion


		#region Items


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ItemTileSetBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ItemTileSetBox.SelectedIndex == -1)
				return;

			if (ItemTileset != null)
				ItemTileset.Dispose();

			ItemTileset = ResourceManager.CreateAsset<TileSet>((string) ItemTileSetBox.SelectedItem);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HideItemsBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Decoration == null)
				return;

			Decoration.HideItems = HideItemsBox.Checked;
		}

		#endregion


		#region Properties

		/// <summary>
		/// 
		/// </summary>
		public override IAsset Asset
		{
			get
			{
				return DecorationSet;
			}
		}


		/// <summary>
		/// Enable items mode
		/// </summary>
		bool ItemsModeSelected
		{
			get
			{
				return tabControl1.SelectedTab == ItemsTab;
			}
		}


		/// <summary>
		/// Items tileset
		/// </summary>
		TileSet ItemTileset;

		/// <summary>
		/// Decoration handle
		/// </summary>
		DecorationSet DecorationSet;


		/// <summary>
		/// Current decoration handle
		/// </summary>
		Decoration Decoration;


		/// <summary>
		/// ID of the decoration to copy
		/// </summary>
		int CopyId = -1;


		/// <summary>
		/// Sprite batch
		/// </summary>
		SpriteBatch Batch;


		/// <summary>
		/// Background tileset
		/// </summary>
		TileSet BgTileSet;


		/// <summary>
		/// Last mouse position
		/// </summary>
		Point LastMousePosition;

		#endregion

	}


}
