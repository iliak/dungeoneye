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
using System.Windows.Forms;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Graphic;
using ArcEngine.Input;
using ArcEngine.Utility.ScreenManager;
using DungeonEye.Gui;

namespace DungeonEye
{
	public class AutoMap : GameScreenBase
	{

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="batch">SpriteBatch to use</param>
        public AutoMap(SpriteBatch batch)
        {
            Batch = batch;
        }

		/// <summary>
		/// 
		/// </summary>
		public override void LoadContent()
		{
			Trace.WriteDebugLine("[AutoMap] : LoadContent()");
			
			Tileset = ResourceManager.CreateAsset<TileSet>("AutoMap");

		}


		/// <summary>
		/// Unload content
		/// </summary>
		public override void UnloadContent()
		{
			Trace.WriteDebugLine("[AutoMap] : UnloadContent()");

			//Font = null;
			Batch = null;

			if (Tileset != null)
				Tileset.Dispose();
			Tileset = null;
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
			if (Keyboard.IsNewKeyPress(Keys.Escape) || Keyboard.IsNewKeyPress(Keys.Tab))
				ExitScreen();
		}


		/// <summary>
		/// 
		/// </summary>
		public override void Draw()
		{
			// Clears the background
			Display.ClearBuffers();

			Batch.Begin();

			// Background
			Batch.DrawTile(Tileset, 1, Point.Empty, Color.White);

			for (int y = 0; y < 20; y++)
				for (int x = 0; x < 30; x++)
					Batch.DrawTile(Tileset, 3, new Point(68 + x * 12, 90 + y * 12));

			// Some WIP
			Batch.DrawString(GUI.MenuFont, new Vector2(100, 100), Color.White, "TODO...");	

			// Draw the cursor or the item in the hand
			Batch.DrawTile(Tileset, 0, Mouse.Location, Color.White);

			Batch.End();
		}

		#endregion



		#region Properties

		/// <summary>
		/// Tileset
		/// </summary>
		TileSet Tileset;


		/// <summary>
		/// Font
		/// </summary>
		//BitmapFont Font;


		/// <summary>
		/// Spritebatch
		/// </summary>
		SpriteBatch Batch;

		#endregion

	}
}
