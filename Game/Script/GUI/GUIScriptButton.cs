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
using System.Xml;
using ArcEngine;
using ArcEngine.Graphic;
using ArcEngine.Input;
using DungeonEye.Gui;

namespace DungeonEye.Script
{
	//TODO: Maybe melted with DungeonEye.Gui.ScreenButton

	/// <summary>
	/// GUI Script button
	/// </summary>
	public class GUIScriptButton
	{

		/// <summary>
		/// Empty constructor
		/// </summary>
		public GUIScriptButton() : this(string.Empty, Rectangle.Empty)
		{

		}


		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="text">Text to display</param>
		/// <param name="rectangle">Bound of the button</param>
		public GUIScriptButton(string text, Rectangle rectangle)
		{
			Text = text;
			Rectangle = rectangle;
			IsVisible = true;
			TextColor = Color.White;
			BackColor = GameColors.Main;
		}


		/// <summary>
		/// Button logic
		/// </summary>
		/// <param name="time">Elapsed game time</param>
		public virtual void Update(GameTime time)
		{
			// Mouse over
			if (Rectangle.Contains(Mouse.Location))
			{
				// Mouse over
				if (!IsMouseOver)
					OnMouseEnter();

				// Mouse move
				if (!Mouse.MoveDelta.IsEmpty)
					OnMouseMove();

				// Mouse click
				if (Mouse.IsNewButtonDown(System.Windows.Forms.MouseButtons.Left))
					OnMouseClick();

				// Mouse down
				if (Mouse.IsButtonDown(System.Windows.Forms.MouseButtons.Left))
					OnMouseDown();

				// Mouse up
				if (Mouse.IsNewButtonUp(System.Windows.Forms.MouseButtons.Left))
					OnMouseUp();
			}
			else
			{
				// Mouse leave
				if (IsMouseOver)
					OnMouseLeave();
			}

			// Mouse click
			if (Mouse.IsNewButtonUp(System.Windows.Forms.MouseButtons.Left) && IsMouseOver)
				OnMouseClick();
		}


		/// <summary>
		/// Draws the button
		/// </summary>
		/// <param name="batch">Spritebatch handle</param>
		public virtual void Draw(SpriteBatch batch)
		{
			if (batch == null || !IsVisible)
				return;

			// Border
			bool reverse = false;
			if (IsMouseOver && Mouse.IsButtonDown(System.Windows.Forms.MouseButtons.Left))
				reverse = true;
			GUI.DrawSimpleBevel(batch, Rectangle, BackColor, GameColors.Light, GameColors.Dark, reverse);

			// Text size
			Size textsize = GUI.DialogFont.GetTextSize(Text);

			// Get text location
			Point pos = new Point
			(
				Rectangle.X + (Rectangle.Width - textsize.Width) / 2,
				Rectangle.Y + (Rectangle.Height - textsize.Height) / 2
			);

			// Color
			Color color = IsMouseOver ? GameColors.Cyan : Color.White;


			batch.DrawString(GUI.DialogFont, pos, color, Text);
		}


		#region Events

		#region MouseMove
		/// <summary>
		/// Event raised when the mouse is over.
		/// </summary>
		public event EventHandler MouseMove;

		/// <summary>
		/// Method for raising the MouseMove event.
		/// </summary>
		public virtual void OnMouseMove()
		{
			if (MouseMove != null)
				MouseMove(this, null);
		}
		#endregion

		#region MouseOver
		/// <summary>
		/// Event raised when the mouse is over.
		/// </summary>
		public event EventHandler MouseOver;

		/// <summary>
		/// Method for raising the MouseOver event.
		/// </summary>
		public virtual void OnMouseOver()
		{
			if (MouseOver != null)
				MouseOver(this, null);
		}
		#endregion

		#region Click
		/// <summary>
		/// Event raised when the mouse click.
		/// </summary>
		public event EventHandler Click;

		/// <summary>
		/// Method for raising the Click event.
		/// </summary>
		public virtual void OnMouseClick()
		{
			if (Click != null)
				Click(this, null);
		}
		#endregion

		#region MouseUp
		/// <summary>
		/// Event raised when the mouse up.
		/// </summary>
		public event EventHandler MouseUp;

		/// <summary>
		/// Method for raising the MouseUp event.
		/// </summary>
		public virtual void OnMouseUp()
		{
			if (MouseUp != null)
				MouseUp(this, null);
		}
		#endregion

		#region MouseDown

		/// <summary>
		/// Event raised when the mouse down.
		/// </summary>
		public event EventHandler MouseDown;

		/// <summary>
		/// Method for raising the MouseDown event.
		/// </summary>
		public virtual void OnMouseDown()
		{
			if (MouseDown != null)
				MouseDown(this, null);
		}

		#endregion

		#region MouseEnter

		/// <summary>
		/// Event raised when the mouse down.
		/// </summary>
		public event EventHandler MouseEnter;

		/// <summary>
		/// Method for raising the MouseEnter event.
		/// </summary>
		public virtual void OnMouseEnter()
		{
			IsMouseOver = true;
			if (MouseEnter != null)
				MouseEnter(this, null);
		}

		#endregion

		#region MouseLeave

		/// <summary>
		/// Event raised when the mouse down.
		/// </summary>
		public event EventHandler MouseLeave;

		/// <summary>
		/// Method for raising the MouseLeave event.
		/// </summary>
		public virtual void OnMouseLeave()
		{
			IsMouseOver = false;

			if (MouseLeave != null)
				MouseLeave(this, null);
		}

		#endregion

		#region Paint

		/// <summary>
		/// Paint event handler
		/// </summary>
		/// <param name="sender">Sender object</param>
		/// <param name="batch">SpriteBatch handle</param>
		public delegate void PaintEventHandler(object sender, SpriteBatch batch);

		/// <summary>
		/// Event raised when the paint
		/// </summary>
		public event PaintEventHandler Paint;

		/// <summary>
		/// Method for raising the Paint event.
		/// </summary>
		/// <param name="batch">Spritebatch handle</param>
		public virtual void OnPaint(SpriteBatch batch)
		{
			if (Paint != null)
				Paint(this, batch);
			else
				Draw(batch);
		}

		#endregion

		#endregion


		#region Properties

		/// <summary>
		/// Text of the button
		/// </summary>
		public string Text
		{
			get;
			set;
		}


		/// <summary>
		/// Rectangle
		/// </summary>
		public Rectangle Rectangle
		{
			get;
			set;
		}


		/// <summary>
		/// Background color
		/// </summary>
		public Color BackColor
		{
			get;
			set;
		}


		/// <summary>
		/// Color of the text
		/// </summary>
		public Color TextColor
		{
			get;
			set;
		}


		/// <summary>
		/// Shows or hides the button
		/// </summary>
		public bool IsVisible
		{
			get;
			set;
		}


		/// <summary>
		/// Is mouse over
		/// </summary>
		public bool IsMouseOver
		{
			get;
			private set;
		}


		/// <summary>
		/// Tag object used to attach something
		/// </summary>
		public object Tag
		{
			get;
			set;
		}
		#endregion
	}
}
