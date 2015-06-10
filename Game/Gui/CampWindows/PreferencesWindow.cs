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
using ArcEngine.Audio;


namespace DungeonEye.Gui.CampWindows
{
	/// <summary>
	/// Preference window
	/// </summary>
	public class PreferencesWindow : Window
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public PreferencesWindow(CampDialog camp)
			: base(camp, "Preferences :")
		{
			ScreenButton button;
			button = new ScreenButton("", new Rectangle(16, 40, 320, 28));
			button.Selected += new EventHandler(Tunes_Selected);
			if (AudioManager.PlayTunes)
				button.Text = "Tunes are ON";
			else
				button.Text = "Tunes are OFF";
			Buttons.Add(button);

			button = new ScreenButton("", new Rectangle(16, 74, 320, 28));
			button.Selected += new EventHandler(Sounds_Selected);
			if (AudioManager.PlayTunes)
				button.Text = "Sounds are ON";
			else
				button.Text = "Sounds are OFF";
			Buttons.Add(button);

			button = new ScreenButton("", new Rectangle(16, 108, 320, 28));
			button.Selected += new EventHandler(Bar_Selected);
			if (GameSettings.DrawHPAsBar)
				button.Text = "Bar Graphs are ON";
			else
				button.Text = "Bar Graphs are OFF";
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
			Settings.Save();
			Closing = true;
		}



		/// <summary>
		/// Tunes button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Tunes_Selected(object sender, EventArgs e)
		{
			ScreenButton button = sender as ScreenButton;

			if (AudioManager.PlayTunes)
			{
				button.Text = "Tunes are OFF";
				AudioManager.PlayTunes = false;
			}
			else
			{
				button.Text = "Tunes are ON";
				AudioManager.PlayTunes = true;
			}

			Settings.SetToken("Tunes", AudioManager.PlayTunes);
		}



		/// <summary>
		/// Sounds button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Sounds_Selected(object sender, EventArgs e)
		{
			ScreenButton button = sender as ScreenButton;

			if (AudioManager.PlaySounds)
			{
				button.Text = "Sounds are OFF";
				AudioManager.PlaySounds = false;
			}
			else
			{
				button.Text = "Sounds are ON";
				AudioManager.PlaySounds = true;
			}

			Settings.SetToken("Sounds", AudioManager.PlaySounds);
		}



		/// <summary>
		/// Bar button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Bar_Selected(object sender, EventArgs e)
		{
			ScreenButton button = sender as ScreenButton;

			if (GameSettings.DrawHPAsBar)
			{
				button.Text = "Bar Graphs are OFF";
				GameSettings.DrawHPAsBar = false;
			}
			else
			{
				button.Text = "Bar Graphs are ON";
				GameSettings.DrawHPAsBar = true;
			}

		}


		#endregion


		#region Properties




		#endregion

	}
}
