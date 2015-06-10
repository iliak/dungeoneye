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
using DungeonEye.Script.Actions;


namespace DungeonEye.Forms
{
	/// <summary>
	/// Activate Target control
	/// </summary>
	public partial class SetToControl : ActionBaseControl
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="script">Script handle</param>
		/// <param name="dungeon">Dungeon handle</param>
		public SetToControl(SetTo script, Dungeon dungeon)
		{
			if (dungeon == null || script == null)
			{
				MessageBox.Show("Dungeon == NULL or script == NULL !", "SetToControl", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			InitializeComponent();

			Action = script;
			Dungeon = dungeon;
			SquareControl.SetSquare(script.Square);
			TargetBox.SetTarget(Dungeon, Action.Target);
		}


		#region Events


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		private void TargetBox_TargetChanged(object sender, DungeonLocation target)
		{
			if (Action == null)
				return;

			// Change the target
			((SetTo) Action).Target = target;


			// Change the maze of the square control
			if (Dungeon != null && target != null)
			{
				SquareControl.Maze = Dungeon.GetMaze(target.Maze);
			}
			else
			{
				// Default start location
				SquareControl.Maze = Dungeon.GetMaze(Dungeon.StartLocation.Maze);
			}
		}

		#endregion


		#region Properties


		/// <summary>
		/// Dungeon handle
		/// </summary>
		Dungeon Dungeon;


		#endregion

	}
}
