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
using System.Windows.Forms;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Graphic;
using ArcEngine.Input;
using ArcEngine.Utility.ScreenManager;
using DungeonEye.Gui;
using ArcEngine.Storage;

namespace DungeonEye
{
	/// <summary>
	/// Introduction screen
	/// </summary>
	public class IntroScreen : GameScreenBase
	{

		/// <summary>
		/// 
		/// </summary>
		public IntroScreen()
		{
			Display.Init();
		}


		/// <summary>
		/// 
		/// </summary>
		public override void LoadContent()
		{
			Scene = ResourceManager.CreateAsset<Scene>("intro");
			// Scene.Font.GlyphTileset.Scale = new Vector2(2, 2);
			Scene.StringTable.LanguageName = Game.LanguageName;

			Font = ResourceManager.CreateAsset<BitmapFont>("intro");
			// Font.GlyphTileset.Scale = new Vector2(2, 2);

			SpriteBatch = new SpriteBatch();
		}



		/// <summary>
		/// 
		/// </summary>
		public override void UnloadContent()
		{
			if (SpriteBatch != null)
				SpriteBatch.Dispose();
			SpriteBatch = null;

			if (Font != null)
				Font.Dispose();
			Font = null;

			if (Scene != null)
				Scene.Dispose();
			Scene = null;
		}


		#region Update & draw


		/// <summary>
		/// Update logic
		/// </summary>
		/// <param name="time"></param>
		/// <param name="hasFocus"></param>
		/// <param name="isCovered"></param>
		public override void Update(GameTime time, bool hasFocus, bool isCovered)
		{
			// No focus byebye
			if (!hasFocus)
				return;

			// Bye bye
			if (Keyboard.IsNewKeyPress(Keys.Escape))
				ScreenManager.RemoveScreen(this);
			//ScreenManager.Game.Exit();

			// Pause animation
			if (Keyboard.IsNewKeyPress(Keys.Space))
				Scene.Pause = !Scene.Pause;

			// Rewind animation
			if (Keyboard.IsNewKeyPress(Keys.Left))
				Scene.Time = TimeSpan.Zero;



			// Update animation 
			if (Scene != null)
				Scene.Update(time);
		}


		/// <summary>
		/// Draws the scene
		/// </summary>
		public override void Draw()
		{
			// Clears the background
			Display.ClearBuffers();

			SpriteBatch.Begin();

			if (Scene != null)
				Scene.Draw(SpriteBatch);


			// Debug info
			SpriteBatch.DrawString(Font, new Vector2(20, 160), Color.White, Scene.Time.TotalSeconds.ToString());

			SpriteBatch.End();
		}

		#endregion



		#region Properties

		/// <summary>
		/// 
		/// </summary>
		Scene Scene;


		/// <summary>
		/// 
		/// </summary>
		BitmapFont Font;


		/// <summary>
		/// 
		/// </summary>
		SpriteBatch SpriteBatch;


		#endregion

	}
}
