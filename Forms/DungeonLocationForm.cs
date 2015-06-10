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
using System;
using System.Drawing;
using System.Windows.Forms;
using ArcEngine;
using ArcEngine.Forms;
using ArcEngine.Graphic;
using ArcEngine.Asset;
using DungeonEye;



namespace DungeonEye.Forms
{
	/// <summary>
	/// Dungeon location form
	/// </summary>
	public partial class DungeonLocationForm : Form
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="dungeon"></param>
		/// <param name="maze"></param>
		/// <param name="coordinate"></param>
		public DungeonLocationForm(Dungeon dungeon, string maze, Point coordinate) : this (dungeon, new DungeonLocation(maze, coordinate))
		{
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="dungeon"></param>
		/// <param name="maze"></param>
		/// <param name="coordinate"></param>
		public DungeonLocationForm(Dungeon dungeon, DungeonLocation location)
		{
			InitializeComponent();

			DungeonControl.Dungeon = dungeon;
			DungeonControl.Target = location;
			DungeonControl.GlControlBox.Click += new EventHandler(DungeonControl_Click);
			DungeonControl.GlControlBox.DoubleClick += new EventHandler(GlControlBox_DoubleClick);

			DirectionBox.Items.AddRange(Enum.GetNames(typeof(CardinalPoint)));
			GroundPositionBox.Items.AddRange(Enum.GetNames(typeof(SquarePosition)));

			Init();
		}


		/// <summary>
		/// Initialization
		/// </summary>
		void Init()
		{
			if (DungeonControl.Dungeon == null)
				return;

			MazeBox.BeginUpdate();
			MazeBox.Items.Clear();
			foreach (Maze maze in DungeonControl.Dungeon.MazeList)
				MazeBox.Items.Add(maze.Name);
			MazeBox.EndUpdate();


			if (!string.IsNullOrEmpty(DungeonControl.Target.Maze))
				MazeBox.SelectedItem = DungeonControl.Target.Maze;
			DirectionBox.SelectedItem = DungeonControl.Target.Direction.ToString();
			GroundPositionBox.SelectedItem = DungeonControl.Target.Position.ToString();


		}


		#region Form events


		/// <summary>
		/// OnDoubleClick
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GlControlBox_DoubleClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void DungeonControl_Click(object sender, EventArgs e)
		{
			DungeonControl.Target.Coordinate = DungeonControl.BlockUnderMouse;
			DungeonControl.Target.Maze = (string)MazeBox.SelectedItem;

			MouseLocationBox.Text = DungeonControl.BlockUnderMouse.ToString();
		}

	
		/// <summary>
		/// Change maze
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MazeBox_Click(object sender, EventArgs e)
		{
			if (DungeonControl.Dungeon == null)
				return;

			DungeonControl.Maze = DungeonControl.Dungeon.GetMaze((string)MazeBox.SelectedItem);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DirectionBox_Click(object sender, EventArgs e)
		{
			if (DirectionBox.SelectedIndex == -1)
				return;

			DungeonControl.Target.Direction = (CardinalPoint)Enum.Parse(typeof(CardinalPoint), (string)DirectionBox.SelectedItem);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SelectBox_Click(object sender, EventArgs e)
		{

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GroundPositionBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (GroundPositionBox.SelectedIndex == -1)
				return;

			DungeonControl.Target.Position = (SquarePosition)Enum.Parse(typeof(SquarePosition), (string)GroundPositionBox.SelectedItem);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DungeonControl_MouseMove(object sender, MouseEventArgs e)
		{
			MouseLocationBox.Text = DungeonControl.BlockUnderMouse.ToString();
		}

		#endregion



		#region Properties


		/// <summary>
		/// 
		/// </summary>
		public DungeonLocation Target
		{
			get
			{
				return DungeonControl.Target;
			}
		}
		#endregion



	}
}
