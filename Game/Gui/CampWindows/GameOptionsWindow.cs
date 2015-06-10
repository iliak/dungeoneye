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
	/// Game option window
	/// </summary>
	public class GameOptionsWindow : Window
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public GameOptionsWindow(CampDialog camp) : base(camp, "Game Options:")
		{
			ScreenButton button;
			button = new ScreenButton("Load Game", new Rectangle(16, 40, 320, 28));
			button.Selected += new EventHandler(Load_Selected);
			Buttons.Add(button);

			button = new ScreenButton("Save Game", new Rectangle(16, 74, 320, 28));
			button.Selected += new EventHandler(Save_Selected);
			Buttons.Add(button);

			button = new ScreenButton("Drop Character", new Rectangle(16, 108, 320, 28));
			button.Selected += new EventHandler(DropHero_Selected);
			Buttons.Add(button);

			button = new ScreenButton("Quit Game", new Rectangle(16, 142, 320, 28));
			button.Selected += new EventHandler(Quit_Selected);
			Buttons.Add(button);

			button = new ScreenButton("Exit", new Rectangle(256, 244, 80, 28));
			button.Selected += new EventHandler(Exit_Selected);
			Buttons.Add(button);

		}


		#region Events


		/// <summary>
		/// Exit button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Exit_Selected(object sender, EventArgs e)
		{
			Closing = true;
		}


		/// <summary>
		/// Exit button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Load_Selected(object sender, EventArgs e)
		{
			Camp.AddWindow(new LoadGameWindow(Camp));
			//MessageBox = new MessageBox("Are you sure you<br />wish to LOAD a<br />saved game ?", MessageBoxButtons.YesNo);
			//MessageBox.Selected +=new EventHandler(LoadAnswer);
		}

/*
		/// <summary>
		/// Load game answer
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void LoadAnswer(object sender, EventArgs e)
		{
			if (((MessageBox) sender).DialogResult == DialogResult.Yes)
			{
				GameScreen.Team.LoadParty();
				Camp.Exit();
			}
		}
*/

		/// <summary>
		/// Exit button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Save_Selected(object sender, EventArgs e)
		{
			Camp.AddWindow(new SaveGameWindow(Camp));
			
			//MessageBox = new MessageBox("Are you sure you<br />wish to SAVE<br />the game ?", MessageBoxButtons.YesNo);
			//MessageBox.Selected +=new EventHandler(SaveAnswer);
		}


		/// <summary>
		/// Save game answer
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void SaveAnswer(object sender, EventArgs e)
		{
			if (((MessageBox) sender).DialogResult == DialogResult.Yes)
			{
				//GameScreen.Team.SaveParty();
				Camp.Exit();
			}
		}


		/// <summary>
		/// Exit button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void DropHero_Selected(object sender, EventArgs e)
		{
			Camp.AddWindow(new DropNPCWindow(Camp));
		}


		/// <summary>
		/// Exit button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Quit_Selected(object sender, EventArgs e)
		{
			MessageBox = new MessageBox("Are you sure you<br />wish to EXIT the<br />game ?", MessageBoxButtons.YesNo);
			MessageBox.Selected +=new EventHandler(QuitAnswer);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void QuitAnswer(object sender, EventArgs e)
		{
			if (((MessageBox) sender).DialogResult == DialogResult.Yes)
				Game.Exit();
		}


		#endregion



		#region Properties




		#endregion

	}
}
