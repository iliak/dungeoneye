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
using ArcEngine.Graphic;
using ArcEngine;
using ArcEngine.Asset;




namespace DungeonEye.Gui
{
	/// <summary>
	/// Gui buttons
	/// </summary>
	public class ScreenButton
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="text">Text to display</param>
		/// <param name="rectangle">Rectangle of the button</param>
		public ScreenButton(string text, Rectangle rectangle)
		{
			Text = text;
			Rectangle = rectangle;
			IsVisible = true;
			TextColor = Color.White;
			ReactOnMouseOver = true;
		}





		#region Events


		/// <summary>
		/// Event raised when the button is selected.
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
		/// Text of the button
		/// </summary>
		public string Text;


		/// <summary>
		/// Rectangle
		/// </summary>
		public Rectangle Rectangle;


		/// <summary>
		/// Color of the text
		/// </summary>
		public Color TextColor;


		/// <summary>
		/// Shows or hides the button
		/// </summary>
		public bool IsVisible
		{
			get;
			set;
		}


		/// <summary>
		/// Change text color on mouse over
		/// </summary>
		public bool ReactOnMouseOver
		{
			get;
			set;
		}


		/// <summary>
		/// Personal tag
		/// </summary>
		public object Tag;

		#endregion
	}
}
