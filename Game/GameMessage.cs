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
	/// In game message logger
	/// </summary>
	static public class GameMessage
	{

		/// <summary>
		/// Constructor
		/// </summary>
		static GameMessage()
		{
			Messages = new List<ScreenMessage>();
		}


		/// <summary>
		/// Initialize the message system
		/// </summary>
		/// <returns>True on success</returns>
		static public bool Init()
		{

			// Language
			Language = ResourceManager.CreateAsset<StringTable>("game");
			if (Language == null)
			{
				Trace.WriteLine("ERROR !!! No StringTable defined for the game !!!");
				//ExitScreen();
				return false;
			}
			Language.LanguageName = Game.LanguageName;


			Font = ResourceManager.CreateSharedAsset<BitmapFont>("inventory", "inventory");

			return true;
		}


		/// <summary>
		/// Dispose resources
		/// </summary>
		static public void Dispose()
		{
			ResourceManager.UnlockSharedAsset<BitmapFont>(Font);
			Font = null;
		}


		/// <summary>
		/// Clears all messages
		/// </summary>
		static public void Clear()
		{
			Messages.Clear();
		}


		/// <summary>
		/// Update messages
		/// </summary>
		/// <param name="time">Elpased game time</param>
		static public void Update(GameTime time)
		{
			// Remove older screen messages and display them
			while (Messages.Count > 3)
				Messages.RemoveAt(0);

			foreach (ScreenMessage msg in Messages)
				msg.Life = msg.Life.Add(-time.ElapsedGameTime);

			// Remove old messages
			Messages.RemoveAll(msg => msg.Life.Seconds <= 0);
		}


		/// <summary>
		/// Draws the game messages
		/// </summary>
		/// <param name="Batch">Spritebatch handle</param>
		public static void Draw(SpriteBatch batch)
		{

			// Display the last 3 messages
			int i = 0;
			foreach (ScreenMessage msg in GameMessage.Messages)
			{
				batch.DrawString(Font, new Point(8, 360 + i * 12), msg.Color, msg.Message);
				i++;
			}

		}


		/// <summary>
		/// Build a message from a string and arguments
		/// </summary>
		/// <param name="id">ID of the string</param>
		/// <param name="args">Arguments</param>
		static public void BuildMessage(int id, params object[] args)
		{
			AddMessage(Language.BuildMessage(id, args));
		}
		

		#region On screen messages

		/// <summary>
		/// Adds a message to the interface
		/// </summary>
		/// <param name="msg">Message</param>
		public static void AddMessage(string msg)
		{
			AddMessage(msg, GameColors.White);
		}



		/// <summary>
		/// Adds a messgae to the interface
		/// </summary>
		/// <param name="msg">Message</param>
		/// <param name="color">Color</param>
		public static void AddMessage(string msg, Color color)
		{
			// Split all new lines
			string[] lines = msg.Split('\n');

			// Lines too long
			int maxlen = 47;
			foreach (string line in lines)
			{
				for (int i = 0 ; i < line.Length ; i += maxlen)
					Messages.Add(new ScreenMessage(line.Substring(i, Math.Min(line.Length - i, maxlen)), color));
			}

		}


		#endregion


		#region Properties

		/// <summary>
		/// Messages to display
		/// </summary>
		static public List<ScreenMessage> Messages
		{
			get;
			private set;
		}


		/// <summary>
		/// Current language
		/// </summary>
		static StringTable Language;

			/// <summary>
			/// Message font
			/// </summary>
			static BitmapFont Font;



		#endregion


	}
}
