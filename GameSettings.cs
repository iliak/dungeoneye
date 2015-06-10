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
using System.Windows.Forms;
using System.Xml;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Graphic;
using ArcEngine.Input;
using ArcEngine.Utility.ScreenManager;
using DungeonEye.Gui;

namespace DungeonEye
{

	/// <summary>
	/// Game settings
	/// </summary>
	static public class GameSettings
	{


		/// <summary>
		/// Constructor
		/// </summary>
		static GameSettings()
		{
			DrawHPAsBar = Settings.GetBool("HPAsBar");
			SaveGameName = @"data/savegame.xml";
			MaxGameSaveSlot = 6;
			SavedGames = new SaveGame(SaveGameName);
		}



		#region IO


		/// <summary>
		/// 
		/// </summary>
		/// <param name="node"></param>
		/// <returns></returns>
		static public bool Load(XmlNode node)
		{
			return false;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="writer"></param>
		/// <returns></returns>
		static public bool Save(XmlWriter writer)
		{

			Settings.SetToken("HPAsBar", GameSettings.DrawHPAsBar);

			return false;
		}

		#endregion


		#region Properties

		/// <summary>
		/// Draw HP as bar
		/// </summary>
		static public bool DrawHPAsBar
		{
			get;
			set;
		}


		/// <summary>
		/// File save game name
		/// </summary>
		static public string SaveGameName
		{
			get;
			set;
		}


		/// <summary>
		/// Maximum number of gamesave slot
		/// </summary>
		static public int MaxGameSaveSlot
		{
			get;
			private set;
		}


		/// <summary>
		/// saved games
		/// </summary>
		static public SaveGame SavedGames
		{
			get;
			private set;
		}


		#endregion
	}
}
