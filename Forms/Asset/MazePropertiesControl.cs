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
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Forms;
using ArcEngine.Graphic;
using ArcEngine.Interface;
using DungeonEye.Script;
using DungeonEye.Script.Actions;

namespace DungeonEye.Forms
{
	/// <summary>
	/// 
	/// </summary>
	public partial class MazePropertiesControl : UserControl
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="maze"></param>
		public MazePropertiesControl()
		{
			InitializeComponent();



			DecorationNameBox.Items.AddRange(ResourceManager.GetAssets<DecorationSet>().ToArray());
			DecorationNameBox.Items.Insert(0, "");
			WallTileSetNameBox.Items.AddRange(ResourceManager.GetAssets<TileSet>().ToArray());
			WallTileSetNameBox.Items.Insert(0, "");
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="maze"></param>
		public void SetMaze(Maze maze)
		{
			Maze = maze;
			UpdateUI();
		}


		/// <summary>
		/// 
		/// </summary>
		void UpdateUI()
		{
			if (Maze == null)
				return;

			DecorationNameBox.SelectedItem = Maze.DecorationName;
			WallTileSetNameBox.SelectedItem = Maze.WallTileset;
		}



		#region Control events

		#region Pit

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FloorIdBox_ValueChanged(object sender, EventArgs e)
		{
			if (Maze == null)
				return;

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CeilingIdBox_ValueChanged(object sender, EventArgs e)
		{
			if (Maze == null)
				return;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FloorControl_Load(object sender, EventArgs e)
		{
			FloorControl.MakeCurrent();
			Display.Init();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CeilingControl_Load(object sender, EventArgs e)
		{
			CeilingControl.MakeCurrent();
			Display.Init();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FloorControl_Paint(object sender, PaintEventArgs e)
		{
			if (SpriteBatch == null)
				return;

			FloorControl.MakeCurrent();

			Display.ClearBuffers();

			if (Maze != null)
			{
				SpriteBatch.Begin();
				//Maze.Draw(SpriteBatch, PreviewLoc);
				SpriteBatch.End();
			}

			FloorControl.SwapBuffers();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CeilingControl_Paint(object sender, PaintEventArgs e)
		{
			if (SpriteBatch == null)
				return;
			
			CeilingControl.MakeCurrent();

			Display.ClearBuffers();

			if (Maze != null)
			{

				SpriteBatch.Begin();
				//Maze.Draw(SpriteBatch, PreviewLoc);
				SpriteBatch.End();
			}

			CeilingControl.SwapBuffers();

		}


		#endregion


		#region Tileset

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DecorationNameBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Maze == null)
				return;

			Maze.DecorationName = (string)DecorationNameBox.SelectedItem;
			Maze.LoadDecoration();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WallTileSetNameBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Maze == null)
				return;

			Maze.WallTilesetName = (string)WallTileSetNameBox.SelectedItem;
			Maze.LoadWallTileSet();
		}

		#endregion

		#endregion


		#region Propeties

		/// <summary>
		/// Maze handle
		/// </summary>
		Maze Maze;


		/// <summary>
		/// Spritebtach
		/// </summary>
		SpriteBatch SpriteBatch;


		#endregion
	}
}
