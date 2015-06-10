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
using ArcEngine;
using ArcEngine.Graphic;
using ArcEngine.Input;

namespace DungeonEye.Gui
{
	/// <summary>
	/// Dialog box window asking for a simple yes no question
	/// </summary>
	public class MessageBox
	{

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="text">Text to display</param>
		public MessageBox(string text) : this(text, MessageBoxButtons.OK)
		{
		}


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="text">Text to display</param>
		/// <param name="buttons">Buttons to display</param>
		public MessageBox(string text, MessageBoxButtons buttons)
		{
			Text = text;
			DialogResult = DialogResult.None;

			// Background
			Rectangle = new Rectangle(16, 40, 320, 112);

			Buttons = new List<ScreenButton>();
			ScreenButton button = null;
			switch (buttons)
			{
				case MessageBoxButtons.OK:
				break;
				case MessageBoxButtons.OKCancel:
				break;
				case MessageBoxButtons.AbortRetryIgnore:
				break;
				case MessageBoxButtons.YesNoCancel:
				break;
				case MessageBoxButtons.YesNo:
				{
					button = new ScreenButton("Yes", new Rectangle(16, 74, 64, 28));
					button.Selected += new EventHandler(Yes_Selected);
					Buttons.Add(button);

					button = new ScreenButton("No", new Rectangle(240, 74, 64, 28));
					button.Selected += new EventHandler(No_Selected);
					Buttons.Add(button);
				}
				break;
				case MessageBoxButtons.RetryCancel:
				break;
			}
		}


		#region Events

		/// <summary>
		/// Yes selected
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Yes_Selected(object sender, EventArgs e)
		{
			DialogResult = Gui.DialogResult.Yes;
			Closing = true;
			OnSelectEntry();
		}


		/// <summary>
		/// No selected
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void No_Selected(object sender, EventArgs e)
		{
			DialogResult = Gui.DialogResult.No;
			Closing = true;
			OnSelectEntry();
		}

		#endregion

		/// <summary>
		/// Converts the client coordinates of a specified point to screen coordinates. 
		/// </summary>
		/// <param name="offset">Offset</param>
		/// <param name="rectangle">Screen rectangle</param>
		/// <returns></returns>
		Rectangle ClientToScreen(Point offset, Rectangle rectangle)
		{
			return new Rectangle(
					offset.X + rectangle.X,
					offset.Y + rectangle.Y,
					rectangle.Width,
					rectangle.Height);
		}


		/// <summary>
		/// Draws the window
		/// </summary>
		/// <param name="batch">SpriteBatch to use</param>
		public void Draw(CampDialog camp, SpriteBatch batch)
		{
			if (batch == null)
				return;

			// Draw bevel background
			GUI.DrawDoubleBevel(batch, Rectangle, GameColors.Main, GameColors.Light, GameColors.Dark, false);

			// Draw message
			Point point = Rectangle.Location;
			point.Offset(6, 6);
			batch.DrawString(GUI.MenuFont, point, Color.White, Text);

			// Draw buttons
			foreach (ScreenButton button in Buttons)
			{
				Rectangle rect = ClientToScreen(Rectangle.Location, button.Rectangle);
				GUI.DrawDoubleBevel(batch, rect, GameColors.Main, GameColors.Light, GameColors.Dark, false);

				// Text
				point = rect.Location;
				point.Offset(6, 6);
				batch.DrawString(GUI.MenuFont, point, button.TextColor, button.Text);
			}
			
		}


		/// <summary>
		/// Updates the window
		/// </summary>
		/// <param name="time">Elapsed game time</param>
		public void Update(GameTime time)
		{
			if (Closing)
				return;

			// Update buttons
			Point mousePos = Mouse.Location;
			foreach (ScreenButton button in Buttons)
			{
				Rectangle rect = ClientToScreen(Rectangle.Location, button.Rectangle);
				if (rect.Contains(mousePos))
				{
					button.TextColor = Color.FromArgb(255, 85, 85);
					if (Mouse.IsNewButtonDown(System.Windows.Forms.MouseButtons.Left))
						button.OnSelectEntry();
				}
				else
				{
					button.TextColor = Color.White;
				}
			}
		}



		#region Events


		/// <summary>
		/// Event raised when the menu is selected.
		/// </summary>
		public event EventHandler Selected;


		/// <summary>
		/// Method for raising the Selected event.
		/// </summary>
		public virtual void OnSelectEntry()
		{
			if (Selected != null)
				Selected(this, null);
		}


		#endregion


		#region Properties

		/// <summary>
		/// Message
		/// </summary>
		public string Text
		{
			get;
			set;
		}


		/// <summary>
		/// Buttons to display
		/// </summary>
		List<ScreenButton> Buttons;


		/// <summary>
		/// Window closing
		/// </summary>
		public bool Closing
		{
			get;
			private set;
		}


		/// <summary>
		/// Gets the dialog result for the form.
		/// </summary>
		public DialogResult DialogResult
		{
			get;
			private set;
		}


		/// <summary>
		/// 
		/// </summary>
		Rectangle Rectangle;

		#endregion
	}



	/// <summary>
	/// Specifies identifiers to indicate the return value of a dialog box.
	/// </summary>
	public enum DialogResult
	{
		/// <summary>
		/// Nothing is returned from the dialog box. This means that the modal dialog continues running.
		/// </summary>
		None = 0,

		/// <summary>
		/// The dialog box return value is OK
		/// </summary>
		OK = 1,

		/// <summary>
		/// The dialog box return value is Cancel 
		/// </summary>
		Cancel = 2,

		/// <summary>
		/// The dialog box return value is Abort 
		/// </summary>
		Abort = 3,

		/// <summary>
		/// The dialog box return value is Retry 
		/// </summary>
		Retry = 4,

		/// <summary>
		/// The dialog box return value is Ignore 
		/// </summary>
		Ignore = 5,

		/// <summary>
		/// The dialog box return value is Yes 
		/// </summary>
		Yes = 6,

		/// <summary>
		/// The dialog box return value is No 
		/// </summary>
		No = 7,
	}


	/// <summary>
	/// Specifies constants defining which buttons to display on a MessageBox.
	/// </summary>
	public enum MessageBoxButtons
	{
		/// <summary>
		/// The message box contains an OK button.
		/// </summary>
		OK = 0,

		/// <summary>
		/// The message box contains OK and Cancel buttons.
		/// </summary>
		OKCancel = 1,

		/// <summary>
		/// The message box contains Abort, Retry, and Ignore buttons.
		/// </summary>
		AbortRetryIgnore = 2,

		/// <summary>
		/// The message box contains Yes, No, and Cancel buttons.
		/// </summary>
		YesNoCancel = 3,

		/// <summary>
		/// The message box contains Yes and No buttons.
		/// </summary>
		YesNo = 4,

		/// <summary>
		/// The message box contains Retry and Cancel buttons.
		/// </summary>
		RetryCancel = 5,
	}

}
