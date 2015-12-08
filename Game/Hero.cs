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
using System.Xml;
using ArcEngine;
using ArcEngine.Input;
using ArcEngine.Interface;

// Generate a new hero with random values
// <see cref="http://www.aidedd.org/regles-f97/creation-de-perso-t1456.html"/>
// <see cref="http://christiansarda.free.fr/anc_jeux/eob1_intro.html"/>


namespace DungeonEye
{
	/// <summary>
	/// Represents a hero in the team
	/// 
	/// 
	/// 
	/// 
	/// http://uaf.wiki.sourceforge.net/Player%27s+Guide
	/// </summary>
	public class Hero : Entity, IAsset
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Hero()
		{
			Professions = new List<Profession>();
			LearnedSpells = new List<string>();
			ClericSpells = new List<Spell>[6]
			{
				new List<Spell>(),
				new List<Spell>(),
				new List<Spell>(),
				new List<Spell>(),
				new List<Spell>(),
				new List<Spell>(),
			};
			MageSpells = new List<Spell>[6]
			{
				new List<Spell>(),
				new List<Spell>(),
				new List<Spell>(),
				new List<Spell>(),
				new List<Spell>(),
				new List<Spell>(),
			};

			IsDisposed = false;

			Head = -1;
			Inventory = new Item[26];
			BackPack = new Item[14];
			WaistPack = new Item[3];
			Attacks = new Attack[2];
			HandActions = new HandAction[2];
			HandActions[0] = new HandAction(ActionResult.Ok);
			HandActions[1] = new HandAction(ActionResult.Ok);
			HandPenality = new DateTime[2];
			HandPenality[0] = DateTime.Now;
			HandPenality[1] = DateTime.Now;

            Food = (byte)Game.Random.Next(80, 101);

		}


		/// <summary>
		/// 
		/// </summary>
		public void Dispose()
		{
			IsDisposed = true;
		}


		/// <summary>
		/// Roll abilities
		/// </summary>
		public override void RollAbilities()
		{
			base.RollAbilities();

			SetExperience(69000);
		}


		/// <summary>
		/// Updates hero
		/// </summary>
		/// <param name="time">Elapsed gametime</param>
		public void Update(GameTime time)
		{
			//	Point mousePos = Mouse.Location;


			if (Food > 100)
				Food = 100;

			// Remove olds attacks
			//Attacks.RemoveAll(
			//   delegate(AttackResult attack)
			//   {
			//      return attack.Date + attack.Hold < DateTime.Now;
			//   });
		}



		/// <summary>
		/// Add experience to the hero
		/// </summary>
		/// <param name="amount">XP to add</param>
		public void AddExperience(int amount)
		{
			if (amount == 0)
				return;

			foreach (Profession prof in Professions)
			{
				if (prof.AddXP(amount / ProfessionCount))
				{

					// New level gained
					GameMessage.AddMessage(Name + " gained a level in " + prof.Class + " !");
				}
			}
		}

        /// <summary>
        /// Sets hero experience to a specific value. 
        /// </summary>
        /// <param name="amount">XP to add</param>
        public void SetExperience(int amount)
        {
            if (Professions.Count == 0)
                return;

            List<Profession> oldProfessions = Professions;
            Professions = new List<Profession>();

            var xp = amount / oldProfessions.Count;
            
            // Reset XP to 0
            foreach (Profession prof in oldProfessions)
                Professions.Add(new Profession(0, prof.Class));

            AddExperience(amount);
        }


        /// <summary>
        /// Gets a new HP bonus according to professions
        /// </summary>
        public int GetNewHPBonus()
		{

			#region Fighter
			int[] Fighter = new int[]
			{
				1,10,
				1,10,
				1,10,
				1,10,
				1,10,
				1,10,
				1,10,
				1,10,
				1,10,
				3,3,
				3,3,
				3,3,
				3,3
			};
			#endregion

			#region Clerc
			int[] Cleric = new int[]
			{
				1,8,
				1,8,
				1,8,
				1,8,
				1,8,
				1,8,
				1,8,
				1,8,
				1,8,
				2,2,
				2,2,
				2,2,
				2,2,
			};
			#endregion

			#region Paladin
			int[] Paladin = new int[]
			{
				1,10,
				1,10,
				1,10,
				1,10,
				1,10,
				1,10,
				1,10,
				1,10,
				1,10,
				3,3,
				3,3,
				3,3,
				3,3,
			};
			#endregion

			#region Mage
			int[] Mage = new int[]
			{
				1,4,
				1,4,
				1,4,
				1,4,
				1,4,
				1,4,
				1,4,
				1,4,
				1,4,
				1,4,
				1,1,
				1,1,
				1,1,
			};
			#endregion

			#region Ranger
			int[] Ranger = new int[]
			{
				1,10,
				1,10,
				1,10,
				1,10,
				1,10,
				1,10,
				1,10,
				1,10,
				1,10,
				3,3,
				3,3,
				3,3,
				3,3,
			};
			#endregion

			#region Thief
			int[] Thief = new int[]
			{
				1,6,
				1,6,
				1,6,
				1,6,
				1,6,
				1,6,
				1,6,
				1,6,
				1,6,
				1,6,
				2,2,
				2,2,
				2,2,
			};
			#endregion


			int bonus = 0;
			int[] data = null;

			foreach (Profession prof in Professions)
			{
				switch (prof.Class)
				{
					case HeroClass.Fighter:
					data = Fighter;
					break;
					case HeroClass.Ranger:
					data = Ranger;
					break;
					case HeroClass.Paladin:
					data = Paladin;
					break;
					case HeroClass.Mage:
					data = Mage;
					break;
					case HeroClass.Cleric:
					data = Cleric;
					break;
					case HeroClass.Thief:
					data = Thief;
					break;
					default:
					return 0;
				}

				bonus = Math.Max(bonus, Game.Random.Next(data[prof.Level * 2], 1 + data[prof.Level * 2 + 1]));
			}

			return bonus;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{

			string txt = string.Empty;
			foreach (Profession prof in Professions)
			{
				txt = string.Format("{0} {1} ", txt, prof);
			}

			return string.Format("{0} ({1}), {2}", Name, HitPoint, txt);
		}


		#region Spells

		/// <summary>
		/// Returns the maximum number of spell for a certain class
		/// </summary>
		/// <param name="classe">Cleric, Mage or Paladin</param>
		/// <param name="level">Spell level</param>
		/// <returns>Maximum spell count</returns>
		public int GetMaxSpellCount(HeroClass classe, int level)
		{
			#region Clerc
			List<int>[] ClercLevels = new List<int>[]
			{
				new List<int> {1, 0, 0, 0, 0, 0},	// 1
				new List<int> {2, 0, 0, 0, 0, 0},	// 2
				new List<int> {2, 1, 0, 0, 0, 0},	// 3 
				new List<int> {3, 2, 0, 0, 0, 0},	// 4
				new List<int> {3, 3, 1, 0, 0, 0},	// 5
				new List<int> {3, 3, 2, 0, 0, 0},	// 6
				new List<int> {3, 3, 2, 1, 0, 0},	// 7
				new List<int> {3, 3, 3, 2, 0, 0},	// 8
				new List<int> {4, 4, 3, 2, 1, 0},	// 9
				new List<int> {4, 4, 3, 3, 2, 0},	// 10
				new List<int> {5, 4, 4, 3, 2, 1},	// 11
				new List<int> {6, 5, 5, 3, 2, 2},	// 12
				new List<int> {6, 6, 6, 4, 2, 2},	// 13
			};

			List<int>[] ClercBonus = new List<int>[] 
			{
				new List<int> {0, 0, 0, 0, 0, 0},
				new List<int> {0, 0, 0, 0, 0, 0},
				new List<int> {0, 0, 0, 0, 0, 0},
				new List<int> {0, 0, 0, 0, 0, 0},
				new List<int> {0, 0, 0, 0, 0, 0},
				new List<int> {0, 0, 0, 0, 0, 0},
				new List<int> {0, 0, 0, 0, 0, 0},
				new List<int> {0, 0, 0, 0, 0, 0},
				new List<int> {0, 0, 0, 0, 0, 0},
				new List<int> {0, 0, 0, 0, 0, 0},
				new List<int> {0, 0, 0, 0, 0, 0},
				new List<int> {0, 0, 0, 0, 0, 0},
				new List<int> {1, 0, 0, 0, 0, 0},
				new List<int> {2, 0, 0, 0, 0, 0},
				new List<int> {2, 1, 0, 0, 0, 0},
				new List<int> {2, 2, 0, 0, 0, 0},
				new List<int> {2, 2, 1, 0, 0, 0},
				new List<int> {2, 2, 1, 1, 0, 0},
				new List<int> {3, 2, 1, 2, 0, 0},
			};
			#endregion

			#region Mage
			List<int>[] MageLevels = new List<int>[]
			{
				new List<int> {1, 0, 0, 0, 0, 0},		// 1
				new List<int> {2, 0, 0, 0, 0, 0},		// 2
				new List<int> {2, 1, 0, 0, 0, 0},		// 3 
				new List<int> {3, 2, 0, 0, 0, 0},		// 4
				new List<int> {4, 2, 1, 0, 0, 0},		// 5
				new List<int> {4, 2, 2, 0, 0, 0},		// 6
				new List<int> {4, 3, 2, 1, 0, 0},		// 7
				new List<int> {4, 3, 3, 2, 0, 0},		// 8
				new List<int> {4, 3, 3, 2, 1, 0},		// 9
				new List<int> {4, 4, 3, 2, 2, 0},		// 10
				new List<int> {4, 4, 4, 3, 3, 0},		// 11
				new List<int> {4, 4, 4, 4, 4, 1},		// 12
				new List<int> {5, 5, 5, 4, 4, 2},		// 13
			};
			#endregion

			#region Paladin
			List<int>[] PaladinLevels = new List<int>[]
			{
				new List<int> {0, 0, 0},
				new List<int> {0, 0, 0},
				new List<int> {0, 0, 0},
				new List<int> {0, 0, 0},
				new List<int> {0, 0, 0},
				new List<int> {0, 0, 0},
				new List<int> {0, 0, 0},
				new List<int> {0, 0, 0},
				new List<int> {1, 0, 0},
				new List<int> {2, 0, 0},
				new List<int> {2, 1, 0},
				new List<int> {2, 2, 0},
				new List<int> {2, 2, 1},
			};
			#endregion


			Profession prof = GetProfession(classe);
			if (prof == null)
				return 0;

			int count = 0;
			switch (classe)
			{
				case HeroClass.Paladin:
				{
					count = PaladinLevels[Math.Min(13, prof.Level - 1)][level - 1];
				}
				break;

				case HeroClass.Mage:
				{
					count = MageLevels[Math.Min(13, prof.Level - 1)][level - 1];
				}
				break;

				case HeroClass.Cleric:
				{
					// Base
					count = ClercLevels[Math.Min(13, prof.Level - 1)][level - 1];

					// Bonus
					if (prof.Level >= 13)
						count += ClercBonus[Math.Min(13, Wisdom.Value - 1)][level - 1];
				}
				break;
			}

			return count;
		}


		/// <summary>
		/// Gets and removes a spell from the spell list
		/// </summary>
		/// <param name="classe">Cleric, Mage or Paladin</param>
		/// <param name="level">Spell level</param>
		/// <param name="number">Spell number</param>
		/// <returns>Spell handle or null</returns>
		public Spell PopSpell(HeroClass classe, int level, int number)
		{
			// Out of border
			if (level > 6 || number < 0)
				return null;

			Profession prof = GetProfession(classe);
			if (prof == null)
				return null;

			// Get the spells of the desired level
			List<Spell>[] spells = GetSpellsFromHeroClass(classe);
			if (spells[level - 1].Count <= number - 1)
				return null;

			// Remove it
			Spell spell = spells[level - 1][number - 1];
			spells[level - 1].RemoveAt(number - 1);

			return spell;
		}


		/// <summary>
		/// Gets all available spells from a class
		/// </summary>
		/// <param name="classe">Desired class</param>
		/// <returns>List of spells</returns>
		List<Spell>[] GetSpellsFromHeroClass(HeroClass classe)
		{
			List<Spell>[] spells;
			if ((classe & HeroClass.Paladin) > 0 || (classe & HeroClass.Cleric) > 0)
				spells = ClericSpells;
			else if ((classe & HeroClass.Mage) > 0)
				spells = MageSpells;
			else
				spells = NoSpells;
			return spells;
		}


		/// <summary>
		/// Push a spell in the spellbook
		/// </summary>
		/// <param name="spell">Handle to the spell</param>
		/// <returns>True on success</returns>
		public bool PushSpell(Spell spell)
		{
			if (spell == null)
				return false;

			List<Spell>[] spells = GetSpellsFromHeroClass(Classes);
			spells[spell.Level - 1].Add(spell);

			return true;
		}

	
		/// <summary>
		/// Get avaiable spell for a level
		/// </summary>
		/// <param name="classe">Cleric, Mage or Paladin</param>
		/// <param name="level">Spell level</param>
		/// <returns>Available spells</returns>
		public List<Spell> GetSpells(HeroClass classe, int level)
		{
			List<Spell> lspells = new List<Spell>();
			List<Spell>[] spells = GetSpellsFromHeroClass(Classes);

			// Bad level
			if (level < 0 || level > 6)
				return lspells;

			// Wrong profession
			if (GetProfession(classe) == null)
				return lspells;


			// Get a list of available spells for this level
			foreach (Spell spell in spells[level - 1])
			{
				if (spell.Class == classe)
					lspells.Add(spell);
			}


			return lspells;
		}

		#endregion


		#region Inventory



		/// <summary>
		/// Returns the item at a given inventory location
		/// </summary>
		/// <param name="position">Inventory position</param>
		/// <returns>Item or null</returns>
		public Item GetInventoryItem(InventoryPosition position)
		{
			return Inventory[(int)position];
		}



		/// <summary>
		/// Sets the item at a given inventory position
		/// </summary>
		/// <param name="position">Position in the inventory</param>
		/// <param name="item">Item to set</param>
		/// <returns>True if the item can be set at the given inventory location</returns>
		public bool SetInventoryItem(InventoryPosition position, Item item)
		{
			if (item == null)
			{
				Inventory[(int)position] = item;
				return true;
			}


			bool res = false;
			switch (position)
			{
				case InventoryPosition.Armor:
				if ((item.Slot & BodySlot.Torso) == BodySlot.Torso)
					res = true;
				break;

				case InventoryPosition.Wrist:
				if ((item.Slot & BodySlot.Wrists) == BodySlot.Wrists)
					res = true;
				break;

				case InventoryPosition.Secondary:
				if ((item.Slot & BodySlot.Secondary) == BodySlot.Secondary)
					res = true;
				break;

				case InventoryPosition.Ring_Left:
				case InventoryPosition.Ring_Right:
				if ((item.Slot & BodySlot.Fingers) == BodySlot.Fingers)
					res = true;
				break;

				case InventoryPosition.Feet:
				if ((item.Slot & BodySlot.Feet) == BodySlot.Feet)
					res = true;
				break;

				case InventoryPosition.Primary:
				if ((item.Slot & BodySlot.Primary) == BodySlot.Primary)
					res = true;
				break;

				case InventoryPosition.Neck:
				if ((item.Slot & BodySlot.Neck) == BodySlot.Neck)
					res = true;
				break;

				case InventoryPosition.Helmet:
				if ((item.Slot & BodySlot.Head) == BodySlot.Head)
					res = true;
				break;
			}

			if (res)
				Inventory[(int)position] = item;

			return res;
		}


		#endregion


		#region Items

		/// <summary>
		/// Adds an item to the first free slot in the inventory
		/// </summary>
		/// <param name="item">Item handle</param>
		/// <returns>True if enough space, or false if full</returns>
		public bool AddToInventory(Item item)
		{
			if (item == null)
				return false;


			// Arrow
			if ((item.Slot & BodySlot.Quiver) == BodySlot.Quiver)
			{
				Quiver++;
				return true;
			}

			// Neck
			if (item.Slot == BodySlot.Neck && GetInventoryItem(InventoryPosition.Neck) == null)
			{
				SetInventoryItem(InventoryPosition.Neck, item);
				return true;
			}

			// Armor
			if (item.Slot == BodySlot.Torso && GetInventoryItem(InventoryPosition.Armor) == null)
			{
				SetInventoryItem(InventoryPosition.Armor, item);
				return true;
			}


			// Wrists
			if (item.Slot == BodySlot.Wrists && GetInventoryItem(InventoryPosition.Wrist) == null)
			{
				SetInventoryItem(InventoryPosition.Wrist, item);
				return true;
			}

			// Helmet
			if (item.Slot == BodySlot.Head && GetInventoryItem(InventoryPosition.Helmet) == null)
			{
				SetInventoryItem(InventoryPosition.Helmet, item);
				return true;
			}

			// Primary
			if ((item.Slot & BodySlot.Primary) == BodySlot.Primary &&
				(item.Type == ItemType.Weapon || item.Type == ItemType.Shield || item.Type == ItemType.Wand) &&
				GetInventoryItem(InventoryPosition.Primary) == null &&
				CanUseHand(HeroHand.Primary))
			{
				SetInventoryItem(InventoryPosition.Primary, item);
				return true;
			}

			// Secondary
			if ((item.Slot & BodySlot.Secondary) == BodySlot.Secondary &&
				(item.Type == ItemType.Weapon || item.Type == ItemType.Shield || item.Type == ItemType.Wand) &&
				GetInventoryItem(InventoryPosition.Secondary) == null &&
				CanUseHand(HeroHand.Secondary))
			{
				SetInventoryItem(InventoryPosition.Secondary, item);
				return true;
			}

			// Boots
			if (item.Slot == BodySlot.Feet && GetInventoryItem(InventoryPosition.Feet) == null)
			{
				SetInventoryItem(InventoryPosition.Feet, item);
				return true;
			}

			// Fingers
			if (item.Slot == BodySlot.Fingers)
			{
				if (GetInventoryItem(InventoryPosition.Ring_Left) == null)
				{
					SetInventoryItem(InventoryPosition.Ring_Right, item);
					return true;
				}
				//else
				if (GetInventoryItem(InventoryPosition.Ring_Right) == null)
				{
					SetInventoryItem(InventoryPosition.Ring_Left, item);
					return true;
				}
			}

			// Belt
			if ((item.Slot & BodySlot.Belt) == BodySlot.Belt)
			{
				for (int i = 0; i < 3; i++)
				{
					if (GetWaistPackItem(i) == null)
					{
						SetWaistPackItem(i, item);
						return true;
					}
				}
			}


			// Else anywhere in the bag...
			for (int i = 0; i < 14; i++)
			{
				if (BackPack[i] == null)
				{
					BackPack[i] = item;
					return true;
				}
			}
			// Sorry no room !
			return false;
		}


		/// <summary>
		/// Sets an item in the back pack
		/// </summary>
		/// <param name="position">Position</param>
		/// <param name="item">Item handle</param>
		public void SetBackPackItem(int position, Item item)
		{
			if (position < 0 || position > 14)
				return;

			BackPack[position] = item;
		}


		/// <summary>
		/// Gets an item from the backpack
		/// </summary>
		/// <param name="position">Position</param>
		/// <returns>Item handle</returns>
		public Item GetBackPackItem(int position)
		{
			if (position < 0 || position > 13)
				return null;

			return BackPack[position];
		}


		/// <summary>
		/// Sets an item in the waist pack
		/// </summary>
		/// <param name="position">Position</param>
		/// <param name="item">Item handle</param>
		/// <returns></returns>
		public bool SetWaistPackItem(int position, Item item)
		{
			if (position < 0 || position > 2)
				return false;

			if (item == null)
			{
				WaistPack[position] = null;
				return true;
			}

			if ((item.Slot & BodySlot.Belt) != BodySlot.Belt)
				return false;

			WaistPack[position] = item;
			return true;
		}


		/// <summary>
		/// Gets an item from the waistpack
		/// </summary>
		/// <param name="position">Position</param>
		/// <returns>Item handle</returns>
		public Item GetWaistPackItem(int position)
		{
			if (position < 0 || position > 3)
				return null;

			return WaistPack[position];
		}


		/// <summary>
		/// Gets the next item in the waist bag
		/// </summary>
		/// <returns>Item handle or null if empty</returns>
		public Item PopWaistItem()
		{
			return null;

		}


		#endregion


		#region Attacks & Damages


		/// <summary>
		/// Attack the entity
		/// </summary>
		/// <param name="attack">Attack</param>
		public override void Hit(Attack attack)
		{
			if (attack == null)
				return;

			LastAttack = attack;
			if (LastAttack.IsAMiss)
				return;

			HitPoint.Current -= LastAttack.Hit;
		}



		/// <summary>
		/// Add a time penality to a hand
		/// </summary>
		/// <param name="hand">Hand</param>
		/// <param name="duration">Duration</param>
		public void AddHandPenality(HeroHand hand, TimeSpan duration)
		{

			HandPenality[(int)hand] = DateTime.Now + duration;
		}




		/// <summary>
		/// Hero attack with his hands
		/// </summary>
		/// <param name="hand">Attacking hand</param>
		public void UseHand(HeroHand hand)
		{
			// No action possible
			if (!CanUseHand(hand))
				return;

			Team team = GameScreen.Team;

			// Find the entity in front of the hero
			Entity target = team.GetFrontEntity(team.GetHeroGroundPosition(this));


			// Which item is used for the attack
			Item item = GetInventoryItem(hand == HeroHand.Primary ? InventoryPosition.Primary : InventoryPosition.Secondary);
			CardinalPoint side = Compass.GetOppositeDirection(team.Direction);

			// Hand attack
			if (item == null)
			{
				if (team.IsHeroInFront(this))
				{
					if (team.FrontSquare != null)
						team.FrontSquare.OnBash(side, item);
					else
						Attacks[(int)hand] = new Attack(this, target, null);
				}
				else
					HandActions[(int)hand] = new HandAction(ActionResult.CantReach);

				AddHandPenality(hand, TimeSpan.FromMilliseconds(250));
				return;
			}



			// Use item
			DungeonLocation loc = new DungeonLocation(team.Location);
			loc.Position = team.GetHeroGroundPosition(this);
			switch (item.Type)
			{

				#region Ammo
				case ItemType.Ammo:
				{
					// throw ammo
					team.Maze.ThrownItems.Add(new ThrownItem(this, item, loc, TimeSpan.FromSeconds(0.25), int.MaxValue));

					// Empty hand
					SetInventoryItem(hand == HeroHand.Primary ? InventoryPosition.Primary : InventoryPosition.Secondary, null);
				}
				break;
				#endregion


				#region Scroll
				case ItemType.Scroll:
				break;
				#endregion


				#region Wand
				case ItemType.Wand:
				break;
				#endregion


				#region Weapon
				case ItemType.Weapon:
				{
					// Belt weapon
					if (item.Slot == BodySlot.Belt)
					{
					}

					// Weapon use quiver
					else if (item.UseQuiver)
					{
						if (Quiver > 0)
						{
							team.Maze.ThrownItems.Add(
								new ThrownItem(this, ResourceManager.CreateAsset<Item>("Arrow"),
								loc, TimeSpan.FromSeconds(0.25), int.MaxValue));
							Quiver--;
						}
						else
							HandActions[(int)hand] = new HandAction(ActionResult.NoAmmo);

						AddHandPenality(hand, TimeSpan.FromMilliseconds(500));
					}

					else
					{
						// Check is the weapon can reach the target
						if (team.IsHeroInFront(this) && item.Range == 0)
						{
							// Attack front monster
							if (target != null)
							{
								Attacks[(int)hand] = new Attack(this, target, item);
							}
							else if (team.FrontSquare != null)
								team.FrontSquare.OnHack(side, item);
							else
								Attacks[(int)hand] = new Attack(this, target, item);
						}
						else
							HandActions[(int)hand] = new HandAction(ActionResult.CantReach);

						AddHandPenality(hand, item.AttackSpeed);
					}
				}
				break;
				#endregion


				#region Holy symbol or book
				case ItemType.HolySymbol:
				case ItemType.Book:
				{
					GameScreen.SpellBook.Open(this, item);

					//Spell spell = ResourceManager.CreateAsset<Spell>("CreateFood");
					//spell.Init();
					//spell.Script.Instance.OnCast(spell, this);
				}
				break;
				#endregion
			}

		}

		#endregion


		#region Helpers


		/// <summary>
		/// Check for multi class validity
		/// </summary>
		/// <returns></returns>
		public bool CheckMultiClassValidity()
		{
			//Fighter             
			//Ranger              
			//Paladin             
			//Mage                
			//Cleric              
			//Thief               
			//Fighter/Cleric      
			//Fighter/Thief       
			//Fighter/Mage        
			//Fighter/Mage/Thief  
			//Thief/Mage          
			//Cleric/Thief        
			//Fighter/Cleric/Mage 
			//Ranger/Cleric       
			//Cleric/Mage         


			return true;
		}


		/// <summary>
		/// Checks if the hero belgons to a class
		/// </summary>
		/// <param name="classe">Class</param>
		/// <returns>True if the Hero belongs to this class</returns>
		public bool CheckClass(HeroClass classe)
		{
			foreach (Profession prof in Professions)
				if (prof != null)
				{
					if ((prof.Class | classe) == classe)
						return true;
				}

			return false;
		}


		/// <summary>
		/// Get the profession handle
		/// </summary>
		/// <param name="classe">Hero class</param>
		/// <returns>Handle to the profession or null</returns>
		public Profession GetProfession(HeroClass classe)
		{
			foreach (Profession prof in Professions)
				if ((prof.Class | classe) == classe)
					return prof;

			return null;
		}


		/// <summary>
		/// Can use the hand
		/// </summary>
		/// <param name="hand">Hand to attack</param>
		/// <returns>True if the specified hand can be used</returns>
		public bool CanUseHand(HeroHand hand)
		{
			if (IsDead || IsUnconscious)
				return false;

			// Check the item in the other hand
			Item item = GetInventoryItem(hand == HeroHand.Primary ? InventoryPosition.Secondary : InventoryPosition.Primary);
			if (item != null && item.TwoHanded)
				return false;

			return HandPenality[(int)hand] < DateTime.Now;
		}


		/// <summary>
		/// Returns the last attack
		/// </summary>
		/// <param name="hand">Hand of the attack</param>
		/// <returns>Attack result</returns>
		public Attack GetLastAttack(HeroHand hand)
		{
			return Attacks[(int)hand];
		}



		/// <summary>
		/// Gets the last action result
		/// </summary>
		/// <param name="hand">Hand</param>
		/// <returns></returns>
		public HandAction GetLastActionResult(HeroHand hand)
		{
			return HandActions[(int)hand];
		}

		#endregion


		#region IO


		/// <summary>
		/// Loads a hero definition
		/// </summary>
		/// <param name="xml">Xml handle</param>
		/// <returns>True if loaded</returns>
		public override bool Load(XmlNode xml)
		{
			if (xml == null)
				return false;

			Name = xml.Attributes["name"].Value;

			foreach (XmlNode node in xml)
			{
				if (node.NodeType == XmlNodeType.Comment)
					continue;


				switch (node.Name.ToLower())
				{
					case "inventory":
					{
						SetInventoryItem(
							(InventoryPosition)Enum.Parse(typeof(InventoryPosition), node.Attributes["position"].Value),
							ResourceManager.CreateAsset<Item>(node.Attributes["name"].Value));
					}
					break;

					case "waist":
					{
						SetWaistPackItem(int.Parse(node.Attributes["position"].Value),
						ResourceManager.CreateAsset<Item>(node.Attributes["name"].Value));
					}
					break;


					case "backpack":
					{
						SetBackPackItem(int.Parse(node.Attributes["position"].Value),
						ResourceManager.CreateAsset<Item>(node.Attributes["name"].Value));
					}
					break;

					case "quiver":
					{
						Quiver = int.Parse(node.Attributes["count"].Value);
					}
					break;

					case "head":
					{
						Head = int.Parse(node.Attributes["id"].Value);
					}
					break;

					case "food":
					{
						Food = int.Parse(node.Attributes["value"].Value);
					}
					break;

					case "race":
					{
						Race = (HeroRace)Enum.Parse(typeof(HeroRace), node.Attributes["value"].Value, true);
					}
					break;

					case "gender":
					{
						Gender = (HeroGender)Enum.Parse(typeof(HeroGender), node.Attributes["value"].Value, true);
					}
					break;

					case "profession":
					{
						Profession prof = new Profession(node);
						Professions.Add(prof);
					}
					break;

					case "spell":
					{
						Spell spell = ResourceManager.CreateAsset<Spell>(node.Attributes["name"].Value);
						if (spell != null)
						{
							Trace.Write("@Loading Hero Part : Unknown spell " + node.Attributes["name"].Value);
							continue;
						}
						var spells = GetSpellsFromHeroClass(Classes);
						spells[spell.Level - 1].Add(spell);
					}
					break;

					case "learnedspell":
					{
						LearnedSpells.Add(node.Attributes["name"].Value);
					}
					break;

					default:
					{
						base.Load(node);
					}
					break;
				}
			}

			return true;
		}



		/// <summary>
		/// Saves a hero definition
		/// </summary>
		/// <param name="writer">Xml writer handle</param>
		/// <returns>True if saved</returns>
		public override bool Save(XmlWriter writer)
		{
			if (writer == null)
				return false;

			writer.WriteStartElement("hero");
			writer.WriteAttributeString("name", Name);
			base.Save(writer);


			writer.WriteStartElement("quiver");
			writer.WriteAttributeString("count", Quiver.ToString());
			writer.WriteEndElement();

			writer.WriteStartElement("head");
			writer.WriteAttributeString("id", Head.ToString());
			writer.WriteEndElement();

			writer.WriteStartElement("food");
			writer.WriteAttributeString("value", Food.ToString());
			writer.WriteEndElement();

			writer.WriteStartElement("race");
			writer.WriteAttributeString("value", Race.ToString());
			writer.WriteEndElement();

			writer.WriteStartElement("gender");
			writer.WriteAttributeString("value", Gender.ToString());
			writer.WriteEndElement();

			foreach (Profession prof in Professions)
				prof.Save(writer);

			// Inventory
			foreach (InventoryPosition pos in Enum.GetValues(typeof(InventoryPosition)))
			{
				Item item = GetInventoryItem(pos);
				if (item == null)
					continue;

				writer.WriteStartElement("inventory");
				writer.WriteAttributeString("position", pos.ToString());
				writer.WriteAttributeString("name", item.Name);
				writer.WriteEndElement();
			}

			for (int id = 0; id < 3; id++)
				if (WaistPack[id] != null)
				{
					writer.WriteStartElement("waist");
					writer.WriteAttributeString("position", id.ToString());
					writer.WriteAttributeString("name", WaistPack[id].Name);
					writer.WriteEndElement();
				}


			for (int id = 0; id < 14; id++)
				if (BackPack[id] != null)
				{
					writer.WriteStartElement("backpack");
					writer.WriteAttributeString("position", id.ToString());
					writer.WriteAttributeString("name", BackPack[id].Name);
					writer.WriteEndElement();
				}


			for (int i = 0; i < 6; i++)
			{
				var spells = GetSpellsFromHeroClass(Classes);
				foreach (Spell spell in spells[i])
				{
					writer.WriteStartElement("spell");
					writer.WriteAttributeString("name", spell.Name);
					writer.WriteEndElement();
				}
			}

			foreach (string name in LearnedSpells)
			{
				writer.WriteStartElement("learnedspell");
				writer.WriteAttributeString("name", name);
				writer.WriteEndElement();
			}

			writer.WriteEndElement();
			return true;
		}

		#endregion


		#region Magic

		/// <summary>
		/// Does the hero can heal another hero
		/// </summary>
		public bool CanHeal()
		{
			// Check for hero class
			if (!CheckClass(HeroClass.Cleric))
				return false;

			List<Spell> spells = null;

			#region Level 1 - Cure Light Wounds
			spells = GetSpells(HeroClass.Cleric, 1);

			foreach (Spell spell in spells)
				if (spell.Name == "Cure Light Wounds")
					return true;
			#endregion

			#region Level 4 - Cure Serious Wounds
			spells = GetSpells(HeroClass.Cleric, 4);

			foreach (Spell spell in spells)
				if (spell.Name == "Cure Serious Wounds")
					return true;
			#endregion

			#region Level 5 - Cure Critical Wounds
			spells = GetSpells(HeroClass.Cleric, 5);

			foreach (Spell spell in spells)
				if (spell.Name == "Cure Critical Wounds")
					return true;
			#endregion

			#region Level 6 - Heal
			spells = GetSpells(HeroClass.Cleric, 6);

			foreach (Spell spell in spells)
				if (spell.Name == "Heal")
					return true;
			#endregion

			return false;
		}


		/// <summary>
		/// Heal a hero
		/// </summary>
		/// <param name="hero">Hero to heal</param>
		public void Heal(Hero hero)
		{
			if (!CanHeal() || hero == null)
				return;

			//Spell spell = Hero.PopSpell(Class, SpellLevel, i + 1);
			//if (spell != null && spell.Script.Instance != null)
			//    spell.Script.Instance.OnCast(spell, Hero);

			List<Spell> spells = null;

			#region Level 1 - Cure Light Wounds
			spells = GetSpells(HeroClass.Cleric, 1);

			foreach (Spell spell in spells)
			{
				if (spell.Name == "Cure Light Wounds")
				{
					spell.Script.Instance.OnCast(spell, hero);
					return;
				}

			}

			#endregion

			#region Level 4 - Cure Serious Wounds
			spells = GetSpells(HeroClass.Cleric, 4);

			foreach (Spell spell in spells)
				if (spell.Name == "Cure Serious Wounds")
				{
				}
			#endregion

			#region Level 5 - Cure Critical Wounds
			spells = GetSpells(HeroClass.Cleric, 5);

			foreach (Spell spell in spells)
				if (spell.Name == "Cure Critical Wounds")
				{
				}
			#endregion

			#region Level 6 - Heal
			spells = GetSpells(HeroClass.Cleric, 6);

			foreach (Spell spell in spells)
				if (spell.Name == "Heal")
				{
				}
			#endregion

		}

		#endregion


		#region Hero properties

		/// <summary>
		/// Is asset disposed
		/// </summary>
		public bool IsDisposed
		{
			get;
			private set;
		}


		/// <summary>
		/// Tag
		/// </summary>
		public const string Tag = "hero";


		/// <summary>
		/// Xml tag of the asset in bank
		/// </summary>
		public string XmlTag
		{
			get
			{
				return Tag;
			}
		}


		/// <summary>
		/// Returns true if dead
		/// </summary>
		public override bool IsDead
		{
			get
			{
				return HitPoint.Current <= -10;
			}
		}

		/// <summary>
		/// Returns if is unconscious
		/// </summary>
		public bool IsUnconscious
		{
			get
			{
				return HitPoint.Current > -10 && HitPoint.Current <= 0;
			}
		}



		#region Bonus

		/// <summary>
		/// Base save bonus
		/// </summary>
		public override int BaseSaveBonus
		{
			get
			{
				int value = 2;

				foreach (Profession prof in Professions)
				{
					if (prof == null)
						continue;
					value += prof.Level / 2;
				}
				return value;
			}
		}


		/// <summary>
		/// Base attack bonus
		/// </summary>
		public int BaseAttackBonus
		{
			get
			{
				int value = 0;

				foreach (Profession prof in Professions)
				{
					if (prof == null)
						continue;

					if (prof.Class == HeroClass.Fighter || prof.Class == HeroClass.Ranger || prof.Class == HeroClass.Paladin)
						value += prof.Level;

					if (prof.Class == HeroClass.Cleric || prof.Class == HeroClass.Mage || prof.Class == HeroClass.Thief)
						value += (prof.Level * 4) / 3;
				}

				return value;
			}
		}


		/// <summary>
		/// Armor bonus
		/// Provided by armor slot, head slot and bracers slot 
		/// </summary>
		public int ArmorBonus
		{
			get
			{
				byte value = 0;

				Item item = GetInventoryItem(InventoryPosition.Helmet);
				if (item != null)
					value += item.ArmorClass;

				item = GetInventoryItem(InventoryPosition.Armor);
				if (item != null)
					value += item.ArmorClass;

				item = GetInventoryItem(InventoryPosition.Wrist);
				if (item != null)
					value += item.ArmorClass;

				return value;
			}
		}


		/// <summary>
		/// Shield bonus
		/// Provided by shield slot
		/// </summary>
		public int ShieldBonus
		{
			get
			{
				Item item = GetInventoryItem(InventoryPosition.Secondary);
				if (item == null)
					return 0;

				return item.ArmorClass;
			}
		}


		/// <summary>
		/// Dodge bonus
		/// Provided by boots slot
		/// </summary>
		public int DodgeBonus
		{
			get
			{
				Item item = GetInventoryItem(InventoryPosition.Feet);
				if (item == null)
					return 0;

				return item.ArmorClass;
			}
		}


		/// <summary>
		/// Natural armor bonus
		/// provided by amulet slot
		/// </summary>
		public int NaturalArmorBonus
		{
			get
			{
				Item item = GetInventoryItem(InventoryPosition.Neck);
				if (item == null)
					return 0;

				return item.ArmorClass;
			}
		}


		#endregion


		/// <summary>
		/// Number of arrow in the quiver
		/// </summary>
		public int Quiver;


		/// <summary>
		/// Armor class
		/// </summary>
		public override int ArmorClass
		{
			get
			{
				return 10 + ArmorBonus + ShieldBonus + DodgeBonus + NaturalArmorBonus;
			}
			set
			{
			}
		}


		/// <summary>
		///  Name of the hero
		/// </summary>
		public string Name
		{
			get;
			set;
		}


		/// <summary>
		/// Hero race
		/// </summary>
		public HeroRace Race
		{
			get;
			set;
		}


		/// <summary>
		/// Hero gender
		/// </summary>
		public HeroGender Gender
		{
			get;
			set;
		}


		/// <summary>
		/// Items in the bag
		/// </summary>
		Item[] Inventory;


		/// <summary>
		/// Profressions of the Hero
		/// </summary>
		public List<Profession> Professions;


		/// <summary>
		/// Number of profession
		/// </summary>
		public int ProfessionCount
		{
			get
			{
				return Professions.Count;
			}
		}


		/// <summary>
		/// Classes of the hero
		/// </summary>
		public HeroClass Classes
		{
			get
			{
				HeroClass hclass = 0;

				foreach (Profession prof in Professions)
					hclass |= prof.Class;

				return hclass;
			}
		}


		/// <summary>
		/// ID of head tile
		/// </summary>
		public int Head;


		/// <summary>
		/// Back pack items
		/// </summary>
		public Item[] BackPack
		{
			get;
			private set;
		}


		/// <summary>
		/// Belt items
		/// </summary>
		public Item[] WaistPack
		{
			get;
			private set;
		}


		/// <summary>
		/// These value represent how hungry and thursty a champion is.
		/// Food value is decreased to regenerate Stamina and Health. 
		/// When these value reach zero, the hero is starving: his Stamina and health decrease until he eats, drinks or dies.
		/// </summary>
		/// <remarks>Max food Level is 100</remarks>
		public int Food
		{
			get;
			set;
		}


		/// <summary>
		/// Summary of last attacks for each hands
		/// </summary>
		Attack[] Attacks;


		/// <summary>
		/// Time penality on hands
		/// </summary>
		public DateTime[] HandPenality
		{
			get;
			private set;
		}

		/// <summary>
		/// Action result for each hands
		/// </summary>
		HandAction[] HandActions;


		#region Magic

		/// <summary>
		/// No spells available
		/// </summary>
		private static readonly List<Spell>[] NoSpells = new[] { new List<Spell>(0), new List<Spell>(0), new List<Spell>(0), new List<Spell>(0), new List<Spell>(0), new List<Spell>(0) };

		/// <summary>
		/// Cleric spells list
		/// </summary>
		List<Spell>[] ClericSpells;

		/// <summary>
		/// Mage spells list
		/// </summary>
		List<Spell>[] MageSpells;

		/// <summary>
		/// Known scrolls
		/// </summary>
		public List<string> LearnedSpells
		{
			get;
			private set;
		}



		#endregion

		#endregion

	}


	#region Enums & Structures


	/// <summary>
	/// Position in the inventory of a Hero
	/// </summary>
	public enum InventoryPosition
	{
		/// <summary>
		/// 
		/// </summary>
		Armor,

		/// <summary>
		/// 
		/// </summary>
		Wrist,

		/// <summary>
		/// 
		/// </summary>
		Secondary,

		/// <summary>
		/// 
		/// </summary>
		Ring_Left,

		/// <summary>
		/// 
		/// </summary>
		Ring_Right,

		/// <summary>
		/// 
		/// </summary>
		Feet,

		/// <summary>
		/// 
		/// </summary>
		Primary,

		/// <summary>
		/// 
		/// </summary>
		Neck,

		/// <summary>
		/// 
		/// </summary>
		Helmet,
	}


	/// <summary>
	/// Class of the Hero
	/// </summary>
	[Flags]
	public enum HeroClass
	{
		/// <summary>
		/// Fighter
		/// </summary>
		Fighter = 0x1,

		/// <summary>
		/// Ranger
		/// </summary>
		Ranger = 0x2,

		/// <summary>
		/// Paladin
		/// </summary>
		Paladin = 0x4,

		/// <summary>
		/// Mage
		/// </summary>
		Mage = 0x8,

		/// <summary>
		/// Cleric
		/// </summary>
		Cleric = 0x10,

		/// <summary>
		/// Thief
		/// </summary>
		Thief = 0x20,

	}


	/// <summary>
	/// Race of the Hero
	/// </summary>
	[Flags]
	public enum HeroRace
	{

		/// <summary>
		/// 
		/// </summary>
		Human = 0,

		/// <summary>
		/// 
		/// </summary>
		Elf = 1,

		/// <summary>
		/// 
		/// </summary>
		HalfElf = 2,

		/// <summary>
		/// 
		/// </summary>
		Dwarf = 4,

		/// <summary>
		/// 
		/// </summary>
		Gnome = 8,

		/// <summary>
		/// 
		/// </summary>
		Halfling = 16,
	}


	/// <summary>
	/// Hand of Hero
	/// </summary>
	public enum HeroHand
	{
		/// <summary>
		/// Right hand
		/// </summary>
		Primary = 0,

		/// <summary>
		/// Left hand
		/// </summary>
		Secondary = 1
	}


	/// <summary>
	/// Gender of a Hero
	/// </summary>
	public enum HeroGender
	{
		/// <summary>
		/// Male
		/// </summary>
		Male,

		/// <summary>
		/// Female
		/// </summary>
		Female,
	}


	#endregion

}
