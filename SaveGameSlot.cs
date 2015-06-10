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
using System.Windows.Forms;
using System.Xml;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Editor;
using ArcEngine.Forms;
using DungeonEye;

namespace DungeonEye
{
	/// <summary>
	/// Savegame managemnt class
	/// </summary>
	public class SaveGameSlot
	{

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			if (string.IsNullOrEmpty(Name))
				return "Empty";

			return Name;
		}
		
		#region Properties

		/// <summary>
		/// Team handle
		/// </summary>
		public XmlNode Team;


		/// <summary>
		/// Dungeon handle
		/// </summary>
		public XmlNode Dungeon;


		/// <summary>
		/// Name of the slot
		/// </summary>
		public string Name;

		#endregion
	}
}
