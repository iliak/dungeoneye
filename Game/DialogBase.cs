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
using System;

namespace DungeonEye
{
	/// <summary>
	/// Dialog base class
	/// </summary>
	public abstract class DialogBase : IDisposable
	{

		/// <summary>
		/// Closes the dialog
		/// </summary>
		public virtual void Exit()
		{
			Quit = true;
		}


		/// <summary>
		/// Updates the window
		/// </summary>
		/// <param name="time">Elapsed game time</param>
		public virtual void Update(GameTime time)
		{
		}


		/// <summary>
		/// Draws the Window
		/// </summary>
		/// <param name="batch">SpriteBatch to use</param>
		public virtual void Draw(SpriteBatch batch)
		{
		}


		/// <summary>
		/// 
		/// </summary>
		public virtual void Dispose()
		{
		}



		#region Properties


		/// <summary>
		/// Dialog is over
		/// </summary>
		public bool Quit
		{
			get;
			private set;
		}


		/// <summary>
		/// 
		/// </summary>
		public Font ScriptFont
		{
			get;
			set;
		}

		#endregion
	}
}
