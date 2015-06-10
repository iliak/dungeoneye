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
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Graphic;

namespace DungeonEye.Forms.Wizards
{
	/// <summary>
	/// New maze wizard
	/// </summary>
	public partial class NewMazeWizard : Form
	{

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="dungeon">Dungeon handle</param>
		public NewMazeWizard(Dungeon dungeon)
		{
			if (dungeon == null)
				throw new ArgumentNullException("dungeon");

			InitializeComponent();

			Dungeon = dungeon;


			WallTilSetBox.DataSource = ResourceManager.GetAssets<TileSet>();
			OverlayTileSetBox.DataSource = ResourceManager.GetAssets<TileSet>();
		}


		/// <summary>
		/// FormClosing event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			// 
			if (DialogResult != DialogResult.OK)
				return;

			// Maze already exists ?
			if (string.IsNullOrEmpty(MazeName.Text) || Dungeon.GetMaze(MazeName.Text) != null)
			{
				MessageBox.Show("Maze name already in use or invalid. Use another name !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Cancel = true;
				return;
			}


			// Create the maze
			Maze maze = new Maze(Dungeon);
			maze.Name = MazeName.Text;
			maze.Size = new Size((int)MazeWidthBox.Value, (int)MazeHeightBox.Value);
			maze.WallTilesetName = (string)WallTilSetBox.SelectedItem;
			maze.DecorationName = (string)OverlayTileSetBox.SelectedItem;
			Dungeon.AddMaze(maze);

		}



		#region Properties

		/// <summary>
		/// Dungeon handle
		/// </summary>
		Dungeon Dungeon;

		#endregion

	}
}
