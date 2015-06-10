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
using ArcEngine;
using ArcEngine.Graphic;
using ArcEngine.Input;

namespace DungeonEye.Gui.CampWindows
{
	/// <summary>
	/// Load game window
	/// </summary>
	public class SaveGameWindow : Window
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="camp">Camp window handle</param>
		public SaveGameWindow(CampDialog camp)
			: base(camp, "Save Game:")
		{
			GameSettings.SavedGames.Load();

			ScreenButton button;
			for (int id = 0; id < GameSettings.MaxGameSaveSlot; id++)
			{
				SaveGameSlot slot = GameSettings.SavedGames.Slots[id];

				button = new ScreenButton(slot != null ? slot.Name : "", new Rectangle(16, 40 + id * 34, 320, 28));
				button.Selected += new EventHandler(slot_Selected);
				button.Tag = slot == null ? -1 : id;
				Buttons.Add(button);
			}


			button = new ScreenButton("Cancel", new Rectangle(230, 244, 106, 28));
			button.Selected += new EventHandler(Cancel_Selected);
			Buttons.Add(button);


			SelectedSlot = -1;
		}


		#region Events


		/// <summary>
		/// Exit button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Cancel_Selected(object sender, EventArgs e)
		{
			Closing = true;
		}


		/// <summary>
		/// Exit button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void slot_Selected(object sender, EventArgs e)
		{
			ScreenButton button = sender as ScreenButton;

			SelectedSlot = (int)(button.Tag);

			// Slot not empty, ask confirmation
			if (!string.IsNullOrEmpty(button.Text))
			{
				MessageBox = new MessageBox("Are you sure you<br />wish to SAVE<br />the game ?", MessageBoxButtons.YesNo);
				MessageBox.Selected += new EventHandler(MessageBox_Selected);

				return;
			}



			// If ingame, then load the savegame
			if (Camp != null)
			{
				Camp.Game.SaveGameSlot(SelectedSlot);
				Camp.Exit();
			}

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void MessageBox_Selected(object sender, EventArgs e)
		{
			if (((MessageBox)sender).DialogResult == DialogResult.Yes && Camp != null)
			{
				Camp.Game.SaveGameSlot(SelectedSlot);
				Camp.Exit();
			}

		}


		#endregion



		#region Properties


		/// <summary>
		/// Windows offset
		/// </summary>
		//		public Point Offset;


		/// <summary>
		/// Selected game slot
		/// </summary>
		public int SelectedSlot
		{
			get;
			private set;
		}


		#endregion

	}
}
