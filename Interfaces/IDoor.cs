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
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonEye.Interfaces
{


	public interface IDoor
	{

		/// <summary>
		/// Update the door state
		/// </summary>
		/// <param name="door">Door handle</param>
		void OnUpdate(Door door);


		/// <summary>
		/// Draw the door
		/// </summary>
		/// <param name="door">Door handle</param>
		void OnDraw(Door door);


		/// <summary>
		/// Open the door
		/// </summary>
		/// <param name="door">Door handle</param>
		void OnOpen(Door door);


		/// <summary>
		/// Close the door
		/// </summary>
		/// <param name="door">Door handle</param>
		void OnClose(Door door);


		/// <summary>
		/// Mouse click on the door
		/// </summary>
		/// <param name="door">Door handle</param>
		/// <param name="location">Location of the cursor</param>
		void OnClick(Door door, Point location);



	}
}
