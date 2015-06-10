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
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Forms;
using ArcEngine.Graphic;
using DungeonEye.Interfaces;
using ArcEngine.Interface;

namespace DungeonEye.Forms
{
	/// <summary>
	/// Itemset form editor class
	/// </summary>
	public partial class ItemForm : AssetEditorBase
	{

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="node">node to edit</param>
		public ItemForm(XmlNode node)
		{
			InitializeComponent();


			// TileSetNameBox
			TileSetNameBox.BeginUpdate();
			foreach (string name in ResourceManager.GetAssets<TileSet>())
			{
				TileSetNameBox.Items.Add(name);
			}
			TileSetNameBox.EndUpdate();


			TypeBox.BeginUpdate();
			TypeBox.Items.Clear();
			foreach(string name in Enum.GetNames(typeof(ItemType)))
				TypeBox.Items.Add(name);
			TypeBox.EndUpdate();


			Item = new Item();
			Item.Load(node);

		}


		/// <summary>
		/// Saves the asset to the manager
		/// </summary>
		public override void Save()
		{
			ResourceManager.AddAsset<Item>(Item.Name, ResourceManager.ConvertAsset(Item));
		}


		/// <summary>
		/// Update controls
		/// </summary>
		void UpdateControls()
		{
			if (Item == null)
			{
			}
			else
			{
				CriticalMinBox.Value = Item.Critical.X;
				CriticalMaxBox.Value = Item.Critical.Y;
				MultiplierBox.Value = Item.CriticalMultiplier;
				SpeedBox.Value = (int)Item.AttackSpeed.TotalMilliseconds;
				WeightBox.Value = Item.Weight;
				TypeBox.SelectedItem = Item.Type.ToString();
				TileSetNameBox.SelectedItem = Item.TileSetName;
				GroundTileBox.Value = Item.GroundTileID;
				InventoryTileBox.Value = Item.TileID;
				ThrownTileBox.Value = Item.ThrowTileID;
				IncomingTileBox.Value = Item.IncomingTileID;


				PrimaryBox.Checked = (Item.Slot & BodySlot.Primary) == BodySlot.Primary;
				SecondaryBox.Checked = (Item.Slot & BodySlot.Secondary) == BodySlot.Secondary;
				QuiverBox.Checked = (Item.Slot & BodySlot.Quiver) == BodySlot.Quiver;
				BodyBox.Checked = (Item.Slot & BodySlot.Torso) == BodySlot.Torso;
				RingBox.Checked = (Item.Slot & BodySlot.Fingers) == BodySlot.Fingers;
				WristBox.Checked = (Item.Slot & BodySlot.Wrists) == BodySlot.Wrists;
				FeetBox.Checked = (Item.Slot & BodySlot.Feet) == BodySlot.Feet;
				HeadBox.Checked = (Item.Slot & BodySlot.Head) == BodySlot.Head;
				WaistBox.Checked = (Item.Slot & BodySlot.Belt) == BodySlot.Belt;
				NeckBox.Checked = (Item.Slot & BodySlot.Neck) == BodySlot.Neck;

				FighterBox.Checked = (Item.AllowedClasses & HeroClass.Fighter) == HeroClass.Fighter;
				PaladinBox.Checked = (Item.AllowedClasses & HeroClass.Paladin) == HeroClass.Paladin;
				ClericBox.Checked = (Item.AllowedClasses & HeroClass.Cleric) == HeroClass.Cleric;
				MageBox.Checked = (Item.AllowedClasses & HeroClass.Mage) == HeroClass.Mage;
				ThiefBox.Checked = (Item.AllowedClasses & HeroClass.Thief) == HeroClass.Thief;
				RangerBox.Checked = (Item.AllowedClasses & HeroClass.Ranger) == HeroClass.Ranger;

				scriptControl1.SetValues<IItem>(Item.Script);

				ACBonusBox.Value = Item.ArmorClass;
				DamageBox.Dice = Item.Damage;
				//DamageVsSmallBox.Dice = Item.DamageVsSmall;
				//DamageVsBigBox.Dice = Item.DamageVsBig;

				CanIdentifyBox.Checked = Item.CanIdentify;
				IdentifiedBox.Checked = Item.IsIdentified;
				ShortNameBox.Text = Item.ShortName;
				IdentifiedNameBox.Text = Item.IdentifiedName;
				IsBigBox.Checked = Item.IsBig;


				PiercingBox.Checked = (Item.DamageType & DamageType.Pierce) == DamageType.Pierce;
				SlashBox.Checked = (Item.DamageType & DamageType.Slash) == DamageType.Slash;
				BludgeBox.Checked = (Item.DamageType & DamageType.Bludge) == DamageType.Bludge;
				IsCursedBox.Checked = Item.IsCursed;
				AllowedHandPrimaryBox.Checked = (Item.AllowedHands & HeroHand.Primary) == HeroHand.Primary;
				AllowedHandSecondaryBox.Checked = (Item.AllowedHands & HeroHand.Secondary) == HeroHand.Secondary;
			}
		}


		/// <summary>
		/// Rebuild all visual controls
		/// </summary>
		void RebuildDisplay()
		{
			DrawTiles(GLInventoryTile, (int)InventoryTileBox.Value);
			DrawTiles(GLGroundTile, (int) GroundTileBox.Value);
			DrawTiles(GLThrownTile, (int) ThrownTileBox.Value);
			DrawTiles(GLIncomingTile, (int) IncomingTileBox.Value);
		}

		#region Events



	
		/// <summary>
		/// Form closing
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ItemForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (TileSet != null) 
				TileSet.Dispose();
			TileSet = null;

			if (SpriteBatch != null) 
				SpriteBatch.Dispose();
			SpriteBatch = null;

			if (CheckerBoard != null)
				CheckerBoard.Dispose();
			CheckerBoard = null;
		}



		/// <summary>
		/// Draws all visual
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Paint_Tiles(object sender, PaintEventArgs e)
		{
			RebuildDisplay();
		}


		/// <summary>
		/// Paint a control
		/// </summary>
		/// <param name="control">Control to paint</param>
		/// <param name="tileid">Id of the tile to draw</param>
		private void DrawTiles(OpenTK.GLControl control, int tileid)
		{
			control.MakeCurrent();
			Display.ClearBuffers();

			SpriteBatch.Begin();

			// Background texture
			Rectangle dst = new Rectangle(Point.Empty, control.Size);
			SpriteBatch.Draw(CheckerBoard, dst, dst, Color.White);


			// Tile to draw
			if (TileSet != null)
			{
				Tile tile = TileSet.GetTile(tileid);
				if (tile != null)
				{
					Point location = new Point((control.Width - tile.Size.Width) / 2, (control.Height - tile.Size.Height) / 2);
					location.Offset(tile.Pivot);
					SpriteBatch.DrawTile(TileSet, tileid, location);
				}
			}

			SpriteBatch.End();
			control.SwapBuffers();
		}


		/// <summary>
		/// Form load
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form_Load(object sender, EventArgs e)
		{
			SpriteBatch = new SpriteBatch();

			// Preload background texture resource
			CheckerBoard = new Texture2D(ResourceManager.GetInternalResource("ArcEngine.Resources.checkerboard.png"));
			CheckerBoard.HorizontalWrap = TextureWrapFilter.Repeat;
			CheckerBoard.VerticalWrap = TextureWrapFilter.Repeat;

			UpdateControls();
		}



		#region Control loadings

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GLInventoryTile_Load(object sender, EventArgs e)
		{
			GLInventoryTile.MakeCurrent();
			Display.Init();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GLGroundTile_Load(object sender, EventArgs e)
		{
			GLGroundTile.MakeCurrent();
			Display.Init();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GLThrownTile_Load(object sender, EventArgs e)
		{
			GLThrownTile.MakeCurrent();
			Display.Init();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GLIncomingTile_Load(object sender, EventArgs e)
		{
			GLIncomingTile.MakeCurrent();
			Display.Init();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GLInventoryTile_Resize(object sender, EventArgs e)
		{
			GLInventoryTile.MakeCurrent();
			Display.ViewPort = new Rectangle(new Point(), GLInventoryTile.Size);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GLGroundTile_Resize(object sender, EventArgs e)
		{
			GLGroundTile.MakeCurrent();
			Display.ViewPort = new Rectangle(new Point(), GLGroundTile.Size);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GLIncomingTile_Resize(object sender, EventArgs e)
		{
			GLIncomingTile.MakeCurrent();
			Display.ViewPort = new Rectangle(new Point(), GLIncomingTile.Size);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GLThrownTile_Resize(object sender, EventArgs e)
		{
			GLThrownTile.MakeCurrent();
			Display.ViewPort = new Rectangle(new Point(), GLThrownTile.Size);
		}


		#endregion


		/// <summary>
		/// Change TileSet
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TileSetOnSelectedChanged(object sender, EventArgs e)
		{
			if (TileSetNameBox.SelectedIndex == -1)
				return;

			// Dispose od tileset
			if (TileSet != null)
				TileSet.Dispose();

			// Create new tileset
			TileSet = ResourceManager.CreateAsset<TileSet>(TileSetNameBox.SelectedItem as string);
			if (Item != null)
				Item.TileSetName = TileSetNameBox.SelectedItem as string;

			// Display change
			RebuildDisplay();
		}



		#endregion


		#region Item slots

		private void PrimaryBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			if (PrimaryBox.Checked)
				Item.Slot |= BodySlot.Primary;
			else
				Item.Slot ^= BodySlot.Primary;
		}

		private void QuiverBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			if (QuiverBox.Checked)
				Item.Slot |= BodySlot.Quiver;
			else
				Item.Slot ^= BodySlot.Quiver;
		}

		private void NeckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			if (NeckBox.Checked)
				Item.Slot |= BodySlot.Neck;
			else
				Item.Slot ^= BodySlot.Neck;

		}

		private void WristBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			if (WristBox.Checked)
				Item.Slot |= BodySlot.Wrists;
			else
				Item.Slot ^= BodySlot.Wrists;
		}

		private void HeadBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			if (HeadBox.Checked)
				Item.Slot |= BodySlot.Head;
			else
				Item.Slot ^= BodySlot.Head;
		}

		private void SecondaryBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			if (SecondaryBox.Checked)
				Item.Slot |= BodySlot.Secondary;
			else
				Item.Slot ^= BodySlot.Secondary;
		}

		private void BodyBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			if (BodyBox.Checked)
				Item.Slot |= BodySlot.Torso;
			else
				Item.Slot ^= BodySlot.Torso;
		}

		private void RingBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			if (RingBox.Checked)
				Item.Slot |= BodySlot.Fingers;
			else
				Item.Slot ^= BodySlot.Fingers;
		}

		private void FeetBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			if (FeetBox.Checked)
				Item.Slot |= BodySlot.Feet;
			else
				Item.Slot ^= BodySlot.Feet;

		}

		private void WaistBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			if (WaistBox.Checked)
				Item.Slot |= BodySlot.Belt;
			else
				Item.Slot ^= BodySlot.Belt;
		}

		#endregion


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;
			Item.Type = (ItemType)Enum.Parse(typeof(ItemType), (string)TypeBox.SelectedItem);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SpeedBox_ValueChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			Item.AttackSpeed = TimeSpan.FromMilliseconds((int)SpeedBox.Value);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WeightBox_ValueChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			Item.Weight = (int)WeightBox.Value;
		}


		#region Profesions

		private void FighterBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			if (FighterBox.Checked)
				Item.AllowedClasses |= HeroClass.Fighter;
			else
				Item.AllowedClasses ^= HeroClass.Fighter;
		}

		private void PaladinBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			if (PaladinBox.Checked)
				Item.AllowedClasses |= HeroClass.Paladin;
			else
				Item.AllowedClasses ^= HeroClass.Paladin;

		}

		private void ClericBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			if (ClericBox.Checked)
				Item.AllowedClasses |= HeroClass.Cleric;
			else
				Item.AllowedClasses ^= HeroClass.Cleric;
		}

		private void RangerBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;


			if (RangerBox.Checked)
				Item.AllowedClasses |= HeroClass.Ranger;
			else
				Item.AllowedClasses ^= HeroClass.Ranger;
		}

		private void MageBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;


			if (MageBox.Checked)
				Item.AllowedClasses |= HeroClass.Mage;
			else
				Item.AllowedClasses ^= HeroClass.Mage;
		}

		private void ThiefBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			if (ThiefBox.Checked)
				Item.AllowedClasses |= HeroClass.Thief;
			else
				Item.AllowedClasses ^= HeroClass.Thief;

		}

		#endregion


		#region Hands

		#endregion


		#region Critical

		private void CriticalMinBox_ValueChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

		}

		private void CriticalMaxBox_ValueChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

		}

		private void MultiplierBox_ValueChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

		}
		#endregion


		#region Events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void IsBigBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			Item.IsBig = IsBigBox.Checked;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CanIdentifyBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void IdentifiedBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			Item.IsIdentified = IdentifiedBox.Checked;
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ShortNameBox_TextChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			Item.ShortName = ShortNameBox.Text;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void IdentifiedNameBox_TextChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			Item.IdentifiedName = IdentifiedNameBox.Text;

		}


		/// <summary>
		/// Change damage
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DamageBox_ValueChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;


			Item.Damage.Modifier = DamageBox.Dice.Modifier;
			Item.Damage.Faces = DamageBox.Dice.Faces;
			Item.Damage.Throws = DamageBox.Dice.Throws;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ACBonusBox_ValueChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			Item.ArmorClass = (byte)ACBonusBox.Value;
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PiercingBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			if (PiercingBox.Checked)
				Item.DamageType |= DamageType.Pierce;
			else
				Item.DamageType ^= DamageType.Pierce;

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BludgeBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			if (BludgeBox.Checked)
				Item.DamageType |= DamageType.Bludge;
			else
				Item.DamageType ^= DamageType.Bludge;

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SlashBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			if (SlashBox.Checked)
				Item.DamageType |= DamageType.Slash;
			else
				Item.DamageType ^= DamageType.Slash;

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RangeBox_ValueChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			Item.Range = (int)RangeBox.Value;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void InventoryTileID_OnChange(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			Item.TileID = (int)InventoryTileBox.Value;
			DrawTiles(GLInventoryTile, (int)InventoryTileBox.Value);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GroundTileID_OnChange(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			Item.GroundTileID = (int)GroundTileBox.Value;
			DrawTiles(GLGroundTile, (int)GroundTileBox.Value);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ThrownID_OnChange(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			Item.ThrowTileID = (int) ThrownTileBox.Value;
			DrawTiles(GLThrownTile, (int)ThrownTileBox.Value);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void IncomingTile_OnChange(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			Item.IncomingTileID = (int)IncomingTileBox.Value;
			DrawTiles(GLIncomingTile, (int)IncomingTileBox.Value);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CursedBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Item != null)
				Item.IsCursed = IsCursedBox.Checked;

		}


		/// <summary>
		/// Allowed hand
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AllowedHands_CheckedChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			if (AllowedHandPrimaryBox.Checked && AllowedHandSecondaryBox.Checked)
				Item.AllowedHands = HeroHand.Primary | HeroHand.Secondary;
			else if (AllowedHandPrimaryBox.Checked)
				Item.AllowedHands = HeroHand.Primary;
			else if (AllowedHandSecondaryBox.Checked)
				Item.AllowedHands = HeroHand.Secondary;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void scriptControl1_ScriptChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;
			Item.Script.ScriptName = scriptControl1.ScriptName;

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void scriptControl1_InterfaceChanged(object sender, EventArgs e)
		{
			if (Item == null)
				return;

			Item.Script.InterfaceName = scriptControl1.InterfaceName;
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
				return Item;
			}
		}


		/// <summary>
		/// Item 
		/// </summary>
		Item Item;


		/// <summary>
		/// Tileset
		/// </summary>
		TileSet TileSet;


		/// <summary>
		/// Spritebatch
		/// </summary>
		SpriteBatch SpriteBatch;


		/// <summary>
		/// Background texture
		/// </summary>
		Texture2D CheckerBoard;

		#endregion


	}
}
