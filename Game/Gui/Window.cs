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
using System.Text;
using ArcEngine;
using ArcEngine.Graphic;
using System.Drawing;
using ArcEngine.Input;


namespace DungeonEye.Gui
{
	/// <summary>
	/// This class represents a page in the camp menu
	/// </summary>
	public class Window
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="camp">Camp window handle</param>
		/// <param name="title">Window title</param>
		public Window(CampDialog camp, string title)
		{
			Camp = camp;
			Title = title;
			Buttons = new List<ScreenButton>();
			Closing = false;
		}


		/// <summary>
		/// Close the window
		/// </summary>
		public void Close()
		{
			Closing = true;
		}


		/// <summary>
		/// Updates the window
		/// </summary>
		/// <param name="time"></param>
		public virtual void Update(GameTime time)
		{
			if (MessageBox != null && MessageBox.Closing)
				MessageBox = null;


			// Update
			if (MessageBox != null)
				MessageBox.Update(time);
			else
				UpdateButtons(time, Buttons);
		}


		/// <summary>
		/// Draws the window
		/// </summary>
		/// <param name="batch"></param>
		public virtual void Draw(SpriteBatch batch)
		{
			// Draw background
			DrawBackground(batch);


			// Draw buttons
			DrawButtons(batch, Buttons);
		}


		/// <summary>
		/// Draws a list of buttons
		/// </summary>
		/// <param name="batch">Spritebatch to use</param>
		/// <param name="buttons">Button list</param>
		protected void DrawButtons(SpriteBatch batch, List<ScreenButton> buttons)
		{

			// Draw buttons
			foreach (ScreenButton button in buttons)
			{
				if (!button.IsVisible)
					continue;

				GUI.DrawDoubleBevel(batch, button.Rectangle);//, GameColors.Main, GameColors.Light, GameColors.Dark);

				// Text
				Point point = button.Rectangle.Location;
				point.Offset(6, 6);
				batch.DrawString(GUI.MenuFont, point, button.TextColor, button.Text);
			}

			// Message box
			if (MessageBox != null)
				MessageBox.Draw(Camp, batch);

		}


		/// <summary>
		/// Draw the background window
		/// </summary>
		/// <param name="batch">Spritebatch to use</param>
		protected void DrawBackground(SpriteBatch batch)
		{
			Rectangle rect = new Rectangle(0, 0, 352, 288);
			GUI.DrawDoubleBevel(batch, rect, GameColors.Main, GameColors.Light, GameColors.Dark, false);

			batch.DrawString(GUI.MenuFont, new Point(8, 10), GameColors.Cyan, Title);
		}


		/// <summary>
		/// Update butons int he window
		/// </summary>
		/// <param name="time"></param>
		/// <param name="buttons">List of buttons</param>
		protected void UpdateButtons(GameTime time, List<ScreenButton> buttons)
		{

			// update message box
			if (MessageBox != null)
			{
				MessageBox.Update(time);

				return;
			}

			// Update buttons
			Point mousePos = Mouse.Location;
			foreach (ScreenButton button in buttons)
			{
				if (!button.IsVisible)
					continue;

				if (button.Rectangle.Contains(mousePos))
				{
					if (button.ReactOnMouseOver)
						button.TextColor = GameColors.Red;

					// Click on button
					if (Mouse.IsNewButtonDown(System.Windows.Forms.MouseButtons.Left))
						button.OnSelectEntry();
				}
				else if (button.ReactOnMouseOver)
				{
					button.TextColor = Color.White;
				}
			}
		}



		#region Properties


		/// <summary>
		/// Window title
		/// </summary>
		public string Title
		{
			get;
			protected set;
		}


		/// <summary>
		/// List of buttons
		/// </summary>
		protected List<ScreenButton> Buttons
		{
			get;
			private set;
		}


		/// <summary>
		/// Sets to true to close the window
		/// </summary>
		public bool Closing
		{
			get;
			protected set;
		}


		/// <summary>
		/// Camp window
		/// </summary>
		protected CampDialog Camp
		{
			get;
			private set;
		}


		/// <summary>
		/// Message box
		/// </summary>
		protected MessageBox MessageBox;

		#endregion

	}
}
