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
using System.Text;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Graphic;
using ArcEngine.Input;
using DungeonEye.Gui;

namespace DungeonEye.Gui.CampWindows
{
	/// <summary>
	/// Drops a NPC Hero
	/// </summary>
	public class DropNPCWindow : Window
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public DropNPCWindow(CampDialog camp) : base(camp, "Drop Character")
		{
			if (GameScreen.Team.HeroCount <= 4)
			{
				Closing = true;
				return;
			}

			Interface = ResourceManager.LockSharedAsset<TileSet>("Interface");

			// Adds buttons
			ScreenButton button;
			button = new ScreenButton("Exit", new Rectangle(256, 244, 80, 28));
			button.Selected += new EventHandler(Exit_Selected);
			Buttons.Add(button);

			RectangleColor = Color.White;
			Message = "Select a character<br />from your party<br />who would like to<br />drop.";
		}


		/// <summary>
		/// Draws
		/// </summary>
		/// <param name="batch"></param>
		public override void Draw(SpriteBatch batch)
		{
			base.Draw(batch);


			// Display message
			if (Hero == null)
			{
				batch.DrawString(GUI.MenuFont, new Point(26, 58), RectangleColor, Message);
			}
			else
			{
				//batch.DrawString(Camp.Font, new Point(16, 76), Color.White, "0 of 0 remaining.");
			}

			#region Draw heroes
			for (int y = 0; y < 3; y++)
			{
				for (int x = 0; x < 2; x++)
				{
					Hero hero = GameScreen.Team.Heroes[y * 2 + x];
					if (hero == null)
						continue;

					float col = (float)Math.Sin(1.0f);
					batch.DrawRectangle(new Rectangle(366 + x * 144, 2 + y * 104, 130, 104), Color.White);
					batch.DrawRectangle(new Rectangle(367 + x * 144, 4 + y * 104, 128, 101), Color.White);
				}
			}
			#endregion
		}


		/// <summary>
		/// Update
		/// </summary>
		/// <param name="time">Elapsed game time</param>
		public override void Update(GameTime time)
		{
			base.Update(time);

			//	int col = (int) (Math.Sin(time.ElapsedGameTime.Milliseconds) * 255.0f);
			//	RectangleColor = Color.FromArgb(255, col, col, col);

			#region Select a new hero
			if (Mouse.IsNewButtonDown(System.Windows.Forms.MouseButtons.Left) && Hero == null)
			{
				for (int y = 0; y < 3; y++)
				{
					for (int x = 0; x < 2; x++)
					{
						Hero hero = GameScreen.Team.Heroes[y * 2 + x];
						if (hero == null)
							continue;

						if (new Rectangle(368 + x * 144, 4 + y * 104, 126, 100).Contains(Mouse.Location))
						{
							Hero = hero;
							MessageBox = new MessageBox("Are you sure you<br />wish to DROP<br />" + Hero.Name + " ?", MessageBoxButtons.YesNo);
							MessageBox.Selected += new EventHandler(DropAnswer);
							break;
						}
					}
				}
			}
			#endregion
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
		/// Save game answer
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void DropAnswer(object sender, EventArgs e)
		{
			if (((MessageBox)sender).DialogResult == DialogResult.Yes)
			{
				GameScreen.Team.DropHero(Hero);
				Camp.Exit();
			}

			Hero = null;
		}


		#endregion


		#region Properties


		/// <summary>
		/// Rectangle color around selected hero
		/// </summary>
		Color RectangleColor;


		/// <summary>
		/// Message to display
		/// </summary>
		public string Message
		{
			get;
			set;
		}


		/// <summary>
		/// Selected hero
		/// </summary>
		public Hero Hero
		{
			get;
			private set;
		}


		/// <summary>
		/// Tileset
		/// </summary>
		TileSet Interface;

		#endregion

	}
}
