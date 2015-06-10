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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DungeonEye.Forms
{
	/// <summary>
	/// Stair form editor
	/// </summary>
	public partial class StairControl : UserControl
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="stair"></param>
		/// <param name="dungeon"></param>
		public StairControl(Stair stair, Dungeon dungeon)
		{
			InitializeComponent();


			TargetBox.SetTarget(dungeon, stair.Target);
			DirectionBox.DataSource = Enum.GetValues(typeof(StairType));
			DirectionBox.SelectedItem = stair.Type;
			

			Stair = stair;
		}




		#region Form events


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		private void TargetBox_TargetChanged(object sender, DungeonLocation target)
		{
			if (Stair == null)
				return;

			Stair.Target = target;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DirectionBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Stair == null)
				return;

			Stair.Type = (StairType)DirectionBox.SelectedItem;
		}

		#endregion


		#region Properties


		/// <summary>
		/// 
		/// </summary>
		Stair Stair;

		#endregion

	}
}
