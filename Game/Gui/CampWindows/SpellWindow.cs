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
using System.Windows.Forms;

namespace DungeonEye.Gui.CampWindows
{
	/// <summary>
	/// Select a hero by its class
	/// </summary>
	public class SpellWindow : Window
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public SpellWindow(CampDialog camp) : base(camp, "")
		{
			Interface = ResourceManager.LockSharedAsset<TileSet>("Interface");
	
			// Adds buttons
			ScreenButton button;

			button = new ScreenButton("Exit", new Rectangle(256, 244, 80, 28));
			button.Selected += new EventHandler(Exit_Selected);
			Buttons.Add(button);


			Levels = new ScreenButton[6];
			for (int i = 0 ; i < 6 ; i++)
			{
				Levels[i] = new ScreenButton((i + 1).ToString(), new Rectangle(22 + i * 54, 32, 40, 36));
				Levels[i].Selected += new EventHandler(Level_Selected);
				Levels[i].ReactOnMouseOver = false;
				Levels[i].IsVisible = false;
				Buttons.Add(Levels[i]);
			}

			RectangleColor = Color.White;
		}


		/// <summary>
		/// Draws the window
		/// </summary>
		/// <param name="batch">Spritebatch handle</param>
		public override void Draw(SpriteBatch batch)
		{
			base.Draw(batch);

			Team team = GameScreen.Team;

			// Display message
			if (Hero == null)
			{
				batch.DrawString(GUI.MenuFont, new Point(26, 58), RectangleColor, Message);
			}
			else
			{
				batch.DrawString(GUI.MenuFont, new Point(16, 76), Color.White, "0 of 0 remaining.");
			}

			#region Draw heroes
			for (int y = 0 ; y < 3 ; y++)
			{
				for (int x = 0 ; x < 2 ; x++)
				{
					Hero hero = team.Heroes[y * 2 + x];
					if (hero == null)
						continue;

					// Draw rectangle around the hero
					if (hero == Hero)
					{
						float col = (float)Math.Sin(1.0f);
						batch.DrawRectangle(new Rectangle(366 + x * 144, 2 + y * 104, 130, 104), Color.White);
						batch.DrawRectangle(new Rectangle(367 + x * 144, 4 + y * 104, 128, 101), Color.White);
					}
					else if (!hero.CheckClass(Filter))
					{
						// Ghost name
						batch.DrawTile(Interface, 31, new Point(368 + 144 * x, y * 104 + 4));
					}
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
			if (Mouse.IsNewButtonDown(MouseButtons.Left))
			{
				for (int y = 0 ; y < 3 ; y++)
				{
					for (int x = 0 ; x < 2 ; x++)
					{
						Hero hero = GameScreen.Team.Heroes[y * 2 + x];
						if (hero == null)
							continue;

						// Hero don't apply
						if (!hero.CheckClass(Filter))
							continue;

						if (new Rectangle(368 + x * 144, 4 + y * 104, 126, 100).Contains(Mouse.Location))
						{
							HeroSelected();
							Hero = hero;
							break;
						}
					}
				}
			}
			#endregion
		}



		/// <summary>
		/// Change GUI elements when a new hero is selected
		/// </summary>
		void HeroSelected()
		{
			// Buttons already present
			if (Hero != null)
				return;


			Title = "Spells Available :";

			ScreenButton button;
			button = new ScreenButton("Clear", new Rectangle(16, 244, 96, 28));
			button.Selected += new EventHandler(Clear_Selected);
			Buttons.Add(button);

			for (int i = 0 ; i < 6 ; i++)
				Levels[i].IsVisible = true;

			Levels[0].TextColor = GameColors.Red;
			SpellLevel = 1;
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
		void Level_Selected(object sender, EventArgs e)
		{
			for (int i = 0 ; i < 6 ; i++)
				Levels[i].TextColor = Color.White;

			ScreenButton button = sender as ScreenButton;
			button.TextColor = GameColors.Red;
		}



		/// <summary>
		/// Clear button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Clear_Selected(object sender, EventArgs e)
		{
		}

		#endregion


		#region Properties


		/// <summary>
		/// Rectangle color around selected hero
		/// </summary>
		Color RectangleColor;


		/// <summary>
		/// Number of hero who apply to the filter
		/// </summary>
		public int Count
		{
			get
			{
				int count = 0;
				foreach (Hero hero in GameScreen.Team.Heroes)
				{
					// Hero applies
					if (hero != null && hero.CheckClass(Filter))
						count++;
				}

				return count;
			}
		}


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
		/// Class filter
		/// </summary>
		public HeroClass Filter
		{
			get;
			set;
		}


		/// <summary>
		/// Tileset
		/// </summary>
		TileSet Interface;


		/// <summary>
		/// Levels buttons
		/// </summary>
		ScreenButton[] Levels;


		/// <summary>
		/// Current spell level
		/// </summary>
		int SpellLevel;

		#endregion

	}
}
