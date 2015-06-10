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
using System.Collections.Generic;
using System.Drawing;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Graphic;
using ArcEngine.Input;
using DungeonEye.Gui.CampWindows;
using DungeonEye.Gui;

namespace DungeonEye
{
	/// <summary>
	/// Camp window class
	/// </summary>
	public class CampDialog : DialogBase
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public CampDialog(GameScreen game)
		{
			Game = game;
			Windows = new Stack<Window>();

			Buttons = new List<ScreenButton>();

			Rectangle = new Rectangle(0, 0, 352, 288);

			AddWindow(new MainWindow(this));

			// Set default cursor
			Mouse.SetTile(0);
		}




		/// <summary>
		/// Close the camp window
		/// </summary>
		public override void Exit()
		{
			Team team = GameScreen.Team;

			Windows.Clear();

			// Restore item in hand cursor
			if (team.ItemInHand != null)
				Mouse.SetTile(team.ItemInHand.TileID);

			base.Exit();
		}


		/// <summary>
		/// Adds a window to the stack
		/// </summary>
		/// <param name="window">Window handle</param>
		public void AddWindow(Window window)
		{
			if (window == null)
				return;

			Windows.Push(window);
		}


		#region Update & Draw


		/// <summary>
		/// Updates the window
		/// </summary>
		/// <param name="time">Elapsed game time</param>
		public override void Update(GameTime time)
		{
			if (Windows.Count > 0)
			{
				// Remove closing windows
				while (Windows.Count > 0 && Windows.Peek().Closing)
					Windows.Pop();


				if (Windows.Count == 0)
					Exit();
				else
					Windows.Peek().Update(time);
			}
		}


		/// <summary>
		/// Draws the Window
		/// </summary>
		/// <param name="batch"></param>
		public override void Draw(SpriteBatch batch)
		{
			if (Windows.Count > 0)
				Windows.Peek().Draw(batch);
		}



		#endregion
		

		#region Properties

		/// <summary>
		/// Gamescreen
		/// </summary>
		public GameScreen Game
		{
			get;
			private set;
		}

		/// <summary>
		/// List of buttons
		/// </summary>
		protected List<ScreenButton> Buttons;


		/// <summary>
		/// Rectangle of the Window
		/// </summary>
		Rectangle Rectangle;


		/// <summary>
		/// Panels
		/// </summary>
		Stack<Window> Windows;

		#endregion
	}


}
