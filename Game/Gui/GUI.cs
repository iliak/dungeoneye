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
using ArcEngine.Asset;
using ArcEngine.Graphic;
using ArcEngine.Input;

namespace DungeonEye.Gui
{
	/// <summary>
	/// GUI class
	/// </summary>
	public static class GUI
	{

		/// <summary>
		/// Constructor
		/// </summary>
		static GUI()
		{
			MenuFont = ResourceManager.LockSharedAsset<BitmapFont>("intro");
			DialogFont = ResourceManager.LockSharedAsset<BitmapFont>("inventory");
		}


		/// <summary>
		/// Dispose resources
		/// </summary>
        public static void Dispose()
        {
			if (MenuFont != null)
				MenuFont.Dispose();
			MenuFont = null;

			if (DialogFont != null)
				DialogFont.Dispose();
			DialogFont = null;
        }


		#region Bevels

		/// <summary>
		/// Draws a double beveled rectangle
		/// </summary>
		/// <param name="batch">SpriteBatch to use</param>
		/// <param name="rectangle">Rectangle</param>
		/// <param name="reverse">Inverse the color, giving a raise effect</param>
		public static void DrawDoubleBevel(SpriteBatch batch, Rectangle rectangle)
		{
			DrawDoubleBevel(batch, rectangle, GameColors.Main, GameColors.Light, GameColors.Dark, false);
		}


		/// <summary>
		/// Draws a double beveled rectangle
		/// </summary>
		/// <param name="batch">SpriteBatch to use</param>
		/// <param name="rectangle"></param>
		/// <param name="reverse"></param>
		public static void DrawDoubleBevel(SpriteBatch batch, Rectangle rectangle, bool reverse)
		{
			DrawDoubleBevel(batch, rectangle, GameColors.Main, GameColors.Light, GameColors.Dark, reverse);
		}


		/// <summary>
		/// Draws a beveled rectangle
		/// </summary>
		/// <param name="batch">SpriteBatch to use</param>
		/// <param name="rect">Rectangle</param>
		/// <param name="bg">Background color</param>
		/// <param name="light">Light color</param>
		/// <param name="dark">Dark color</param>
		/// <param name="reverse">Inverse the color, giving a raise effect</param>
		public static void DrawDoubleBevel(SpriteBatch batch, Rectangle rect, Color bg, Color light, Color dark, bool reverse)
		{
			batch.FillRectangle(rect, bg);

			Point point = rect.Location;
			Size size = rect.Size;

				batch.FillRectangle(new Rectangle(point.X + 2, point.Y, size.Width - 2, 2), reverse ? dark : light);
				batch.FillRectangle(new Rectangle(point.X + 4, point.Y + 2, size.Width - 4, 2), reverse ? dark : light);
				batch.FillRectangle(new Rectangle(rect.Right - 4, point.Y + 4, 2, size.Height - 8), reverse ? dark : light);
				batch.FillRectangle(new Rectangle(rect.Right - 2, point.Y + 4, 2, size.Height - 6), reverse ? dark : light);

				batch.FillRectangle(new Rectangle(point.X, point.Y + 2, 2, size.Height - 4), reverse ? light : dark);
				batch.FillRectangle(new Rectangle(point.X + 2, point.Y + 4, 2, size.Height - 6), reverse ? light : dark);
				batch.FillRectangle(new Rectangle(point.X, point.Y + size.Height - 2, size.Width - 2, 2), reverse ? light : dark);
				batch.FillRectangle(new Rectangle(point.X, point.Y + size.Height - 4, size.Width - 4, 2), reverse ? light : dark);
		}


		/// <summary>
		/// Draws a beveled rectangle
		/// </summary>
		/// <param name="batch">SpriteBatch to use</param>
		/// <param name="rect">Rectangle</param>
		public static void DrawSimpleBevel(SpriteBatch batch, Rectangle rectangle)
		{
			DrawSimpleBevel(batch, rectangle, GameColors.Main, GameColors.Light, GameColors.Dark, false);
		}

		/// <summary>
		/// Draws a beveled rectangle
		/// </summary>
		/// <param name="batch">SpriteBatch to use</param>
		/// <param name="rect">Rectangle</param>
		/// <param name="rectangle">Reverse color to give a raise effect</param>
		public static void DrawSimpleBevel(SpriteBatch batch, Rectangle rectangle, bool reverse)
		{
			DrawSimpleBevel(batch, rectangle, GameColors.Main, GameColors.Light, GameColors.Dark, reverse);
		}


		/// <summary>
		/// Draws a beveled rectangle
		/// </summary>
		/// <param name="batch">SpriteBatch to use</param>
		/// <param name="rectangle">Rectangle</param>
		/// <param name="bg">Background color</param>
		/// <param name="light">Light color</param>
		/// <param name="dark">Dark color</param>
		/// <param name="rectangle">Reverse color to give a raise effect</param>
		public static void DrawSimpleBevel(SpriteBatch batch, Rectangle rectangle, Color bg, Color light, Color dark, bool reverse)
		{
			batch.FillRectangle(rectangle, bg);

			Point point = rectangle.Location;
			Size size = rectangle.Size;

			batch.FillRectangle(new Rectangle(point.X + 2, point.Y, size.Width - 2, 2), reverse ? dark : light);
			batch.FillRectangle(new Rectangle(rectangle.Right - 2, point.Y + 2, 2, size.Height - 4), reverse ? dark : light);

			batch.FillRectangle(new Rectangle(point.X, point.Y + 2, 2, size.Height - 2), reverse ? light : dark);
			batch.FillRectangle(new Rectangle(point.X + 2, point.Y + size.Height - 2, size.Width - 4, 2), reverse ? light : dark);
		}


		#endregion


		#region Properties

		/// <summary>
		/// Menu font
		/// </summary>
		public static BitmapFont MenuFont
		{
			get;
			private set;
		}

		/// <summary>
		/// Dialog font
		/// </summary>
		public static BitmapFont DialogFont
		{
			get;
			private set;
		}

		#endregion

	}
}
