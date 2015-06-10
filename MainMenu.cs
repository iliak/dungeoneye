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
using ArcEngine.Audio;
using ArcEngine.Graphic;
using ArcEngine.Input;
using ArcEngine.Utility.ScreenManager;
using DungeonEye.Gui;
using DungeonEye.Gui.CampWindows;

namespace DungeonEye
{
	/// <summary>
	/// Main menu class
	/// </summary>
	public class MainMenu : GameScreenBase
	{

		/// <summary>
		/// Constructor
		/// </summary>
		public MainMenu()
		{
			Buttons = new List<ScreenButton>(3);

		}


		/// <summary>
		/// Load content
		/// </summary>
		public override void LoadContent()
		{
			Trace.WriteLine("[MainMenu] LoadContent()");

			Batch = new SpriteBatch();
	
			Tileset = ResourceManager.CreateAsset<TileSet>("Main Menu");

			Font = ResourceManager.CreateSharedAsset<BitmapFont>("intro", "intro");

			StringTable = ResourceManager.CreateAsset<StringTable>("main");

			Buttons.Add(new ScreenButton("", new Rectangle(156, 324, 340, 14)));
			Buttons[0].Selected += new EventHandler(LoadGameEvent);

			Buttons.Add(new ScreenButton("", new Rectangle(156, 342, 340, 14)));
			Buttons[1].Selected += new EventHandler(StartNewGameEvent);

			Buttons.Add(new ScreenButton("", new Rectangle(156, 360, 340, 14)));
			Buttons[2].Selected += new EventHandler(OptionEvent);

			Buttons.Add(new ScreenButton("", new Rectangle(156, 378, 340, 14)));
			Buttons[3].Selected += new EventHandler(QuitEvent);

			Theme = new AudioStream();
			Theme.LoadOgg("main.ogg");
			Theme.Loop = true;
			//Theme.Play();


		}



		/// <summary>
		/// Unload contents
		/// </summary>
		public override void UnloadContent()
		{
			Trace.WriteDebugLine("[MainMenu] : UnloadContent");

			if (Tileset != null)
				Tileset.Dispose();
			Tileset = null;

			ResourceManager.UnlockSharedAsset<BitmapFont>(Font);
			Font = null;

			if (Theme != null)
				Theme.Dispose();
			Theme = null;

			if (Batch != null)
				Batch.Dispose();
			Batch = null;

			StringTable.Dispose();
			StringTable = null;

			Buttons.Clear();
		//	Buttons = null;
		}


		#region Events

		/// <summary>
		/// Option entry event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OptionEvent(object sender, EventArgs e)
		{
			ScreenManager.AddScreen(new OptionMenu(Batch));
		}



		/// <summary>
		/// Quits the game
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void QuitEvent(object sender, EventArgs e)
		{
			//Theme.Stop();
			Game.Exit();
		}


		/// <summary>
		/// Start a new party
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void StartNewGameEvent(object sender, EventArgs e)
		{
			//Theme.Stop();
			ScreenManager.AddScreen(new CharGen());
			ExitScreen();
		}



		/// <summary>
		/// Load a party in progress
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void LoadGameEvent(object sender, EventArgs e)
		{
			//if (!System.IO.File.Exists("data/savegame.xml"))
			//    return;

			LoadGame = new LoadGameWindow(null);
		}


		#endregion


		/// <summary>
		/// Leave this game screen
		/// </summary>
		public override void OnLeave()
		{
			base.OnLeave();

			if (Theme != null)
				Theme.Stop();

		}


		/// <summary>
		/// Enter this gamescreen
		/// </summary>
		public override void OnEnter()
		{
			base.OnEnter();

			if (Theme != null)
				Theme.Play();
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

			// Play sound
		//	if (Theme.State != AudioSourceState.Playing)
		//		Theme.Play();

			if (Keyboard.IsNewKeyPress(System.Windows.Forms.Keys.S))
				Theme.Stop();

			if (Keyboard.IsNewKeyPress(System.Windows.Forms.Keys.P))
				Theme.Play();


			// Does the default language changed ?
			if (Game.LanguageName != StringTable.LanguageName)
			{
				StringTable.LanguageName = Game.LanguageName;

				for (int id = 0; id < Buttons.Count; id++)
					Buttons[id].Text = StringTable.GetString(id+1);
			}


			// Mouse interaction
			Point mousePos = Mouse.Location;


			if (LoadGame == null)
			#region Main menu
			{
				for (int id = 0; id < Buttons.Count; id++)
				{
					ScreenButton button = Buttons[id];

					// Mouse over ?
					if (button.Rectangle.Contains(mousePos))
					{
						//button.TextColor = Color.FromArgb(255, 85, 85);
						MenuID = id;
						if (Mouse.IsNewButtonDown(System.Windows.Forms.MouseButtons.Left))
							button.OnSelectEntry();
					}

				}

				// Bye bye
				if (Keyboard.IsNewKeyPress(System.Windows.Forms.Keys.Escape))
					Game.Exit();

				// Run intro
				if (Keyboard.IsNewKeyPress(System.Windows.Forms.Keys.I))
					ScreenManager.AddScreen(new IntroScreen());


				// Key up
				if (Keyboard.IsNewKeyPress(System.Windows.Forms.Keys.Up))
				{
					MenuID--;
					if (MenuID < 0)
						MenuID = Buttons.Count - 1;
				}
				// Key down
				else if (Keyboard.IsNewKeyPress(System.Windows.Forms.Keys.Down))
				{
					MenuID++;
					if (MenuID >= Buttons.Count)
						MenuID = 0;
				}
				// Enter
				else if (Keyboard.IsNewKeyPress(System.Windows.Forms.Keys.Enter))
				{
					Buttons[MenuID].OnSelectEntry();
				}
			}
			#endregion
			else
			#region Load game
			{

				// Load a game
				LoadGame.Update(time);

				// A slot is selected
				if (LoadGame.SelectedSlot != -1)
				{
					// close window
					LoadGame.Close();

					// Run the game
					GameScreen scr = new GameScreen();
					ScreenManager.AddScreen(scr);

					// Load saved game
					scr.LoadGameSlot(LoadGame.SelectedSlot);
				}


				// Close the window
				if (LoadGame.Closing)
					LoadGame = null;

			}
			#endregion
		}


		/// <summary>
		/// Drawing
		/// </summary>
		public override void Draw()
		{
			// Clears the background
			Display.ClearBuffers();

			Batch.Begin();


			// Background
			Batch.DrawTile(Tileset, 1, Point.Empty);


			// Draw buttons
			for (int id = 0; id < Buttons.Count; id++)
			{
				ScreenButton button = Buttons[id];


				Batch.DrawString(Font,
					new Vector2(button.Rectangle.Location.X, button.Rectangle.Location.Y), 
					id == MenuID ? Color.FromArgb(255, 85, 85) : Color.White, 
					button.Text);
			}

			if (LoadGame != null)
				LoadGame.Draw(Batch);


			Batch.End();
		}

		#endregion



		#region Properties

		/// <summary>
		/// Loading save game window handle
		/// </summary>
		LoadGameWindow LoadGame;


		/// <summary>
		/// Main theme
		/// </summary>
		AudioStream Theme;


		/// <summary>
		/// Tileset
		/// </summary>
		TileSet Tileset;


		/// <summary>
		/// Font
		/// </summary>
		BitmapFont Font;


		/// <summary>
		/// List of buttons
		/// </summary>
		List<ScreenButton> Buttons;


		/// <summary>
		/// Current MenuID
		/// </summary>
		int MenuID;


		/// <summary>
		/// String table
		/// </summary>
		StringTable StringTable;


		/// <summary>
		/// Spritebatch
		/// </summary>
		SpriteBatch Batch;


		#endregion

	}
}
