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
using System.Windows.Forms;
using System.Xml;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Forms;
using ArcEngine.Interface;

namespace DungeonEye.Forms
{

	/// <summary>
	/// Door editor form
	/// </summary>
	public partial class DoorControl : UserControl
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="door">Door handle</param>
		public DoorControl(Door door)
		{
			InitializeComponent();


			DoorTypeBox.DataSource = Enum.GetValues(typeof(DoorType));
			DoorStateBox.DataSource = Enum.GetValues(typeof(DoorState));
			SwitchCountBox.SwitchCount = door.Count;
			ActorPropertiesBox.Actor = door;

			Door = door;
		}


		/// <summary>
		/// Update user interface
		/// </summary>
		void UpdateUI()
		{
			if (Door == null)
				return;


			DoorStateBox.SelectedItem = Door.State;
			DoorTypeBox.SelectedItem = Door.Type;
			DoorTypeBox.SelectedItem = Door.Type;
			PicklockBox.Value = Door.PickLock;
			SpeedBox.Value = (int) Door.Speed.TotalSeconds;
			IsBreakableBox.Checked = Door.IsBreakable;
			BreakValueBox.Value = Door.Strength;
			BreakValueBox.Visible = Door.IsBreakable;
			SmallItemPassThroughBox.Checked = Door.SmallItemPassThrough;
		}


		#region Events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ItemPassThroughBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Door == null)
				return;

			Door.SmallItemPassThrough = SmallItemPassThroughBox.Checked;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void IsBreakableBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Door == null)
				return;

			Door.IsBreakable = IsBreakableBox.Checked;
			BreakValueBox.Visible = Door.IsBreakable;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BreakValueBox_ValueChanged(object sender, EventArgs e)
		{
			if (Door == null)
				return;

			Door.Strength = (int) BreakValueBox.Value;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PicklockBox_ValueChanged(object sender, EventArgs e)
		{
			if (Door == null)
				return;

			Door.PickLock = (int) PicklockBox.Value;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DoorTypeBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Door == null)
				return;

			Door.Type = (DoorType) DoorTypeBox.SelectedItem;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DoorStateBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Door == null)
				return;

			Door.State = (DoorState) DoorStateBox.SelectedItem;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SpeedBox_ValueChanged(object sender, EventArgs e)
		{
			if (Door == null)
				return;

			Door.Speed = TimeSpan.FromSeconds((int) SpeedBox.Value);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HasButtonBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Door == null)
				return;

			Door.HasButton = HasButtonBox.Checked;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DoorControl_Load(object sender, EventArgs e)
		{
			UpdateUI();
		}



		#endregion



		#region Properties

		/// <summary>
		/// Door handle
		/// </summary>
		Door Door;

		#endregion

	}
}
