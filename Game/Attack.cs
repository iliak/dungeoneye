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
using System.Text;
using ArcEngine;
using ArcEngine.Input;
using System.Drawing;
using ArcEngine.Graphic;
using ArcEngine.Asset;
using System.Xml;

namespace DungeonEye
{

	/// <summary>
	/// This class handle an attack between to entities.
	/// There is a difference between Attacking and damaging. If you attack a monster, it is an attempt to do damage to it.
	/// It is not guaranteed that the attack is successful. In case of damage the attack was successful. 
	/// </summary>
	public class Attack
	{

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="striker">Striker entity</param>
		/// <param name="Attacked">Attacked entity</param>
		/// <param name="item">Item used as a weapon. Use null for a hand attack</param>
		/// http://nwn2.wikia.com/wiki/Attack_sequence
		public Attack(Entity striker, Entity target, Item item)
		{
			Team team = GameScreen.Team;
			Time = DateTime.Now;
			Striker = striker;
			Target = target;
			Item = item;

			if (striker == null || target == null)
				return;

			// Ranged attack ?
			DungeonLocation from = null;
			DungeonLocation to = null;
			if (striker is Hero)
				from = team.Location;
			else
				from = ((Monster)striker).Location;

			if (target is Hero)
				to = team.Location;
			else
				to = ((Monster)target).Location;

			Range = (int)Math.Sqrt((from.Coordinate.Y - to.Coordinate.Y) * (from.Coordinate.Y - to.Coordinate.Y) +
						(from.Coordinate.X - to.Coordinate.X) * (from.Coordinate.X - to.Coordinate.X));

			// Attack roll
			int attackdie = Dice.GetD20(1);

			// Critical fail ?
			if (attackdie == 1)
				attackdie = -100000;

			// Critical Hit ?
			if (attackdie == 20)
				attackdie = 100000;


			// Base attack bonus
			int baseattackbonus = 0;
			int modifier = 0;				// modifier
			int sizemodifier = 0;			// Size modifier
			int rangepenality = 0;			// Range penality


			if (striker is Hero)
			{
				baseattackbonus = ((Hero)striker).BaseAttackBonus;
			}
			else if (striker is Monster)
			{
				Monster monster = striker as Monster;
				//sizemodifier = (int)monster.Size;
			}


			// Range penality
			if (RangedAttack)
			{
				modifier = striker.Dexterity.Modifier;

				//TODO : Add range penality
			}
			else
				modifier = striker.Strength.Modifier;

			// Attack bonus
			int attackbonus = baseattackbonus + modifier + sizemodifier + rangepenality;
			if (target.ArmorClass > attackdie + attackbonus)
				return;


			if (item != null)
				Hit = item.Damage.Roll();
			else
			{
				Dice dice = new Dice(1, 4, 0);
				Hit = dice.Roll();
			}

			if (IsAHit)
				Target.Hit(this);

		}


		/// <summary>
		/// Gets whether the action is outdated
		/// </summary>
		/// <param name="time"></param>
		/// <param name="length"></param>
		/// <returns></returns>
		public bool IsOutdated(DateTime time, int length)
		{
			return Time + TimeSpan.FromMilliseconds(length) < time;
		}



		#region Properties

		/// <summary>
		/// Time of the attack
		/// </summary>
		public DateTime Time
		{
			get;
			private set;
		}

		/// <summary>
		/// Striker entity
		/// </summary>
		public Entity Striker
		{
			get;
			private set;
		}


		/// <summary>
		/// Target entity
		/// </summary>
		public Entity Target
		{
			get;
			private set;
		}


		/// <summary>
		/// Attacking item
		/// </summary>
		public Item Item
		{
			get;
			private set;
		}



		/// <summary>
		/// Is the attack a success
		/// </summary>
		public bool IsAHit
		{
			get
			{
				return Hit > 0;
			}
		}


		/// <summary>
		/// Is the attack a success
		/// </summary>
		public bool IsAMiss
		{
			get
			{
				return Hit == 0;
			}
		}


		/// <summary>
		/// Ranged attack
		/// </summary>
		public bool RangedAttack
		{
			get
			{
				return Range > 1;
			}
		}


		/// <summary>
		/// Distance of the attack
		/// </summary>
		public int Range
		{
			get;
			private set;
		}


		/// <summary>
		/// Damage inflicted
		/// </summary>
		public int Hit
		{
			get;
			private set;
		}

		#endregion
	}


}
