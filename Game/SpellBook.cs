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
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Graphic;
using ArcEngine.Input;
using DungeonEye.Gui;

namespace DungeonEye
{
	/// <summary>
	/// Speel window
	/// </summary>
	public class SpellBook : IDisposable
	{

		/// <summary>
		/// Constructor
		/// </summary>
		public SpellBook()
		{
			SpellLevel = 1;
		}


		/// <summary>
		/// Loads content
		/// </summary>
		public void LoadContent()
		{
			Tileset = ResourceManager.LockSharedAsset<TileSet>("Interface");
		}


		/// <summary>
		/// Dispose resources
		/// </summary>
		public void Dispose()
		{
			ResourceManager.UnlockSharedAsset<TileSet>(Tileset);
			Tileset = null;
		}


		/// <summary>
		/// Open the Spell Window
		/// </summary>
		/// <param name="hero">Hero handle</param>
		/// <param name="item">Item used to open the spell book</param>
		public void Open(Hero hero, Item item)
		{
			if (hero == null)
				return;

			Hero = hero;

			if (item.Type == ItemType.Book)
				Class = HeroClass.Mage;
			else if (item.Type == ItemType.HolySymbol)
				Class = HeroClass.Cleric;
			else
				return;

			IsVisible = true;
		}


		/// <summary>
		/// Close the Spell Window
		/// </summary>
		public void Close()
		{
			IsVisible = false;
		}


		#region Draw


		/// <summary>
		/// Display the window
		/// </summary>
		/// <param name="batch">Spritebatch to use</param>
		public void Draw(SpriteBatch batch)
		{
			if (!IsVisible)
				return;

			Color color;

			// Main window
			batch.DrawTile(Tileset, 23, new Point(MainRectangle.Location.X, MainRectangle.Location.Y - 2));

			// Levels
			for (int level = 1; level <= 6; level++)
			{
				int id = SpellLevel == level ? 24 : 25;
				batch.DrawTile(Tileset, id, new Point(MainRectangle.X + level * 36 - 36, MainRectangle.Top - 20));
				batch.DrawString(GUI.DialogFont, new Point(MainRectangle.X + level * 36 + 12 - 36, MainRectangle.Top - 20 + 4), Color.Black, level.ToString());
			}


			// Get a list of available spells for this level
			List<Spell> spells = Hero.GetSpells(Class, SpellLevel);


			// Display at max 6 spells
			Point pos = new Point(146, 264);
			for (int id = 0; id < Math.Min(spells.Count, 6); id++)
			{
				color = GameColors.White;

				if (new Rectangle(pos.X, pos.Y, 212, 12).Contains(Mouse.Location))
					color = GameColors.Black;

				batch.DrawString(GUI.DialogFont, pos, color, spells[id].Name);
				pos.Offset(0, 12);
			}


			// Abort spell
			batch.DrawTile(Tileset, 30, new Point(142, 336));

			// Abort spell
			if (new Rectangle(MainRectangle.X + 2, MainRectangle.Bottom - 14, MainRectangle.Width - 56, 18).Contains(Mouse.Location))
				color = GameColors.Red;
			else
				color = GameColors.White;
			batch.DrawString(GUI.DialogFont, new Point(146, 340), color, "Abort spell");

			// Next & previous buttons
			batch.DrawTile(Tileset, 28, new Point(298, 336));
			batch.DrawTile(Tileset, 29, new Point(326, 336));
		}

		#endregion



		#region Update

		/// <summary>
		/// Update the window
		/// </summary>
		/// <param name="time">Game time</param>
		public void Update(GameTime time)
		{
			if (!IsVisible)
				return;

			Hero.GetMaxSpellCount(HeroClass.Cleric, 3);

			// Left mouse button
			if (Mouse.IsNewButtonDown(MouseButtons.Left))
			{
				// Change spell level
				for (int level = 0; level < 6; level++)
				{
					if (new Rectangle(MainRectangle.X + level * 36, MainRectangle.Top - 18, 36, 18).Contains(Mouse.Location))
					{
						SpellLevel = level + 1;
					}
				}

				// Cast a spell
				Rectangle line = new Rectangle(144, 262, 212, 12);
				for (int i = 0; i < 6; i++)
				{
					// Cast a spell
					if (line.Contains(Mouse.Location))
					{

						Spell spell = Hero.PopSpell(Class, SpellLevel, i + 1);
						if (spell != null && spell.Script.Instance != null)
							spell.Script.Instance.OnCast(spell, Hero);
					}

					// Next spell line
					line.Offset(0, 12);
				}


				// Abort spell
				if (new Rectangle(MainRectangle.X + 2, MainRectangle.Bottom - 14, MainRectangle.Width - 56, 18).Contains(Mouse.Location))
					IsVisible = false;


				// Previous line
				if (new Rectangle(298, 336, 30, 18).Contains(Mouse.Location))
				{
				}


				// Next line
				if (new Rectangle(328, 336, 30, 18).Contains(Mouse.Location))
				{
				}
			}


		}

		#endregion



		#region Properties

		/// <summary>
		/// Concerned hero
		/// </summary>
		public Hero Hero
		{
			get;
			private set;
		}


		/// <summary>
		/// Current class
		/// </summary>
		public HeroClass Class
		{
			get;
			private set;
		}



		/// <summary>
		/// Rectangle of the window
		/// </summary>
		Rectangle MainRectangle = new Rectangle(142, 262, 212, 90);



		/// <summary>
		/// Spell level selected
		/// </summary>
		public int SpellLevel
		{
			get;
			set;
		}



		/// <summary>
		/// Shows / hides the spell window
		/// </summary>
		public bool IsVisible
		{
			get;
			private set;
		}


		/// <summary>
		/// Tileset
		/// </summary>
		TileSet Tileset;

		#endregion
	}
}
