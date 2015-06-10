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
	/// 
	/// </summary>
	public partial class ActorChooserControl : UserControl
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent">Parent square control handle</param>
		public ActorChooserControl(Square square)
		{
			InitializeComponent();

			Square = square;
		}


		#region Control events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AlcoveBox_Click(object sender, EventArgs e)
		{
			if (Square == null)
				return;

			Square.Actor = new AlcoveActor(Square);
			OnActorSelected();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DoorBox_Click(object sender, EventArgs e)
		{
			if (Square == null)
				return;

			Square.Actor = new Door(Square);
			OnActorSelected();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EventBox_Click(object sender, EventArgs e)
		{
			if (Square == null)
				return;

			Square.Actor = new EventSquare(Square);
			OnActorSelected();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ForceFieldBox_Click(object sender, EventArgs e)
		{
			if (Square == null)
				return;

			Square.Actor = new ForceField(Square);
			OnActorSelected();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LauncherBox_Click(object sender, EventArgs e)
		{
			if (Square == null)
				return;

			Square.Actor = new Launcher(Square);
			OnActorSelected();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PitBox_Click(object sender, EventArgs e)
		{
			if (Square == null)
				return;

			Square.Actor = new Pit(Square);
			OnActorSelected();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PressurePlateBox_Click(object sender, EventArgs e)
		{
			if (Square == null)
				return;

			Square.Actor = new PressurePlate(Square);
			OnActorSelected();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void StairBox_Click(object sender, EventArgs e)
		{
			if (Square == null)
				return;

			Square.Actor = new Stair(Square);
			OnActorSelected();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TeleporterBox_Click(object sender, EventArgs e)
		{
			if (Square == null)
				return;

			Square.Actor = new Teleporter(Square);
			OnActorSelected();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WallSwitchBox_Click(object sender, EventArgs e)
		{
			if (Square == null)
				return;

			Square.Actor = new WallSwitch(Square);
			OnActorSelected();
		}

		#endregion



		#region Events

		/// <summary>
		/// Selected view position changer
		/// </summary>
		/// <param name="sender">Controler handle</param>
		/// <param name="position">Selected position</param>
		public delegate void ActorSelectedHandler(object sender);


		/// <summary>
		/// 
		/// </summary>
		public event ActorSelectedHandler ActorSelected;


		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected virtual void OnActorSelected()
		{
			if (ActorSelected != null)
				ActorSelected(this);
		}

		#endregion



		#region Properties

		/// <summary>
		/// 
		/// </summary>
		Square Square;

		#endregion
	}
}
