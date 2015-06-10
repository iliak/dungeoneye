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
using System.Windows.Forms;
using ArcEngine;
using ArcEngine.Graphic;
using ArcEngine.Asset;

namespace DungeonEye.Forms
{
	public partial class SquareForm : Form
	{

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="maze">Maze handle</param>
		/// <param name="square">Square handle</param>
		public SquareForm(Maze maze, Square square)
		{
			InitializeComponent();


			SquareControlBox.Maze = maze;
			SquareControlBox.SetSquare(square);
		}



		/// <summary>
		/// Activate the actor tab
		/// </summary>
		public void ActivateActorTab()
		{
			SquareControlBox.ActivateActorTab();
		}



		#region Form events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SquareForm_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Escape:
				{
					Close();
				}
				break;
			}
		}

		#endregion



	}
}
