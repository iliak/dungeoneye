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
	/// Force field form editor
	/// </summary>
	public partial class ForceFieldControl : UserControl
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="field"></param>
		/// <param name="dungeon"></param>
		public ForceFieldControl(ForceField field, Dungeon dungeon)
		{
			InitializeComponent();

			switch (field.Type)
			{
				case ForceFieldType.Spin:
				SpinRadioBox.Checked = true;
				break;
				case ForceFieldType.Move:
				MoveRadioBox.Checked = true;
				break;
				case ForceFieldType.Block:
				BlockRadioBox.Checked = true;
				break;
				case ForceFieldType.FaceTo:
				FaceToBox.Checked = true;
				break;
			}

			AffectItemsBox.Checked = field.AffectItems;
			AffectMonstersBox.Checked = field.AffectMonsters;
			AffectTeamBox.Checked = field.AffectTeam;
			MoveDirectionBox.DataSource = Enum.GetValues(typeof(CardinalPoint));
			MoveDirectionBox.SelectedItem = field.Direction;
			SpinDirectionBox.DataSource = Enum.GetValues(typeof(CompassRotation));
			SpinDirectionBox.SelectedItem = field.Spin;


			Field = field;
		}



		#region Form events


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MoveDirectionBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Field == null)
				return;

			Field.Direction = (CardinalPoint) MoveDirectionBox.SelectedItem;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SpinDirectionBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Field == null)
				return;

			Field.Spin = (CompassRotation)SpinDirectionBox.SelectedItem;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MoveRadioBox_CheckedChanged(object sender, EventArgs e)
		{
			SpinDirectionBox.Visible = false;

			if (Field == null)
				return;

			Field.Type = ForceFieldType.Move;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SpinRadioBox_CheckedChanged(object sender, EventArgs e)
		{
			SpinDirectionBox.Visible = true;

			if (Field == null)
				return;

			Field.Type = ForceFieldType.Spin;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BlockBox_CheckedChanged(object sender, EventArgs e)
		{
			SpinDirectionBox.Visible = false;

			if (Field == null)
				return;

			Field.Type = ForceFieldType.Block;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DirectionBox_CheckedChanged(object sender, EventArgs e)
		{
			SpinDirectionBox.Visible = false;

			if (Field == null)
				return;

			Field.Type = ForceFieldType.FaceTo;
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AffectTeamBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Field == null)
				return;

			Field.AffectTeam = AffectTeamBox.Checked;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AffectMonstersBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Field == null)
				return;

			Field.AffectMonsters = AffectMonstersBox.Checked;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AffectItemsBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Field == null)
				return;

			Field.AffectItems = AffectItemsBox.Checked;
		}


		#endregion


		#region Properties


		/// <summary>
		/// 
		/// </summary>
		ForceField Field;

		#endregion


	}
}
