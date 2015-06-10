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
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DungeonEye.Forms
{

	/// <summary>
	/// Target location control
	/// </summary>
	public partial class TargetControl : UserControl
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public TargetControl()
		{
			InitializeComponent();
			Target = new DungeonLocation();
		}


		/// <summary>
		/// Changes target
		/// </summary>
		/// <param name="dungeon">Dungeon handle</param>
		/// <param name="target">Target handle</param>
		public void SetTarget(Dungeon dungeon, DungeonLocation target)
		{
			Dungeon = dungeon;
			SetTarget(target);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="target"></param>
		public void SetTarget(DungeonLocation target)
		{
			Target = target;

			if (Target == null)
			{
				MazeNameBox.Text = "";
				CoordinateBox.Text = "";

				return;
			}

			MazeNameBox.Text = Target.Maze;
			CoordinateBox.Text = Target.Coordinate.X + " x " + Target.Coordinate.Y;

			OnTargetChanged(EventArgs.Empty);
		}


		#region Events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public delegate void TargetChangedEventHandler(object sender, DungeonLocation target);

		/// <summary>
		/// Fired when the target location is changed
		/// </summary>
		public event TargetChangedEventHandler TargetChanged;


		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected virtual void OnTargetChanged(EventArgs e)
		{
			if (TargetChanged != null)
				TargetChanged(this, Target);
		}

		#endregion


		#region Form events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FromMapBox_Click(object sender, EventArgs e)
		{
			if (Dungeon == null)
			{
				MessageBox.Show("Dungeon handle == null\nSet a dungeon first !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			DungeonLocationForm form = new DungeonLocationForm(Dungeon, MazeName, Coordinate);
			form.ShowDialog();

			SetTarget(form.Target);
		}

		#endregion


		#region Properties

		/// <summary>
		/// Dungeon to use
		/// </summary>
		public Dungeon Dungeon
		{
			get;
			set;
		}


		/// <summary>
		/// Target
		/// </summary>
		public DungeonLocation Target
		{
			get;
			private set;
		}


		/// <summary>
		/// Maze name
		/// </summary>
		public string MazeName
		{
			get
			{
				if (Target == null)
					return string.Empty;

				return Target.Maze;
			}			
		}


		/// <summary>
		/// Coordinate
		/// </summary>
		public Point Coordinate
		{
			get
			{
				if (Target == null)
					return Point.Empty;

				return Target.Coordinate;
			}
		}


		/// <summary>
		/// Display title
		/// </summary>
		public string Title
		{
			get
			{
				return groupBox1.Text;
			}
			set
			{
				groupBox1.Text = value;
			}
		}

		#endregion
	}
}
