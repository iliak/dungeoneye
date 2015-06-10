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
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Xml;
using ArcEngine;

namespace DungeonEye
{
	/// <summary>
	/// Base class for every entity in the game
	/// </summary>
	public abstract class Entity
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public Entity()
		{
			Charisma = new Ability();
			Strength = new Ability();
			Constitution = new Ability();
			Dexterity = new Ability();
			HitPoint = new HitPoint();
			Intelligence = new Ability();
			Wisdom = new Ability();
			MoveSpeed = TimeSpan.FromSeconds(1.0f);
		}



		/// <summary>
		/// Reroll entity abilities
		/// </summary>
		public virtual void RollAbilities()
		{
			Charisma.Value = RollForAbility();
			Strength.Value = RollForAbility();
			Constitution.Value = RollForAbility();
			Dexterity.Value = RollForAbility();
			Intelligence.Value = RollForAbility();
			Wisdom.Value = RollForAbility();

			HitPoint = new HitPoint(GameBase.Random.Next(6, 37));
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		int RollForAbility()
		{
			Dice dice = new Dice(1, 6, 0);

			List<int> list = new List<int>();
			list.Add(dice.Roll());
			list.Add(dice.Roll());
			list.Add(dice.Roll());
			list.Add(dice.Roll());
			list.Sort();


			return list[1] + list[2] + list[3];
		}


		/// <summary>
		/// Attack the entity
		/// </summary>
		/// <param name="attack">Attack</param>
		public abstract void Hit(Attack attack);
		//{
		//    if (attack == null)
		//        return;

		//    LastAttack = attack;
		//    if (LastAttack.IsAMiss)
		//        return;

		//    HitPoint.Current -= LastAttack.Hit;

		//    // Reward the team for having killed the entity
		//    if (IsDead && attack.Striker is Hero)
		//    {
		//        (attack.Striker as Hero).Team.AddExperience(Reward);
		//    }
		//}


		/// <summary>
		/// Make damage to the hero
		/// </summary>
		/// <param name="damage">Attack roll</param>
		/// <param name="type">Type of saving throw</param>
		/// <param name="difficulty">Difficulty</param>
		public void Damage(Dice damage, SavingThrowType type, int difficulty)
		{
			if (damage == null)
				return;

			int save = Dice.GetD20(1);

			// No damage
			if (save == 20 || save + SavingThrow(type) > difficulty)
				return;

			HitPoint.Current -= damage.Roll();

		}


		/// <summary>
		/// Returns the result of a saving throw
		/// </summary>
		/// <param name="type">Type of throw</param>
		/// <returns>Saving throw value</returns>
		public int SavingThrow(SavingThrowType type)
		{
			int ret = BaseSaveBonus;

			switch (type)
			{
				case SavingThrowType.Fortitude:
				ret += Constitution.Modifier;
				break;
				case SavingThrowType.Reflex:
				ret += Dexterity.Modifier;
				break;
				case SavingThrowType.Will:
				ret += Wisdom.Modifier;
				break;
			}

			ret += Dice.GetD20(1);

			return ret;
		}


		#region IO



		/// <summary>
		/// Saves properties
		/// </summary>
		/// <param name="writer">XmlWriter</param>
		/// <returns>True if saved</returns>
		public virtual bool Save(XmlWriter writer)
		{
			if (writer == null || writer.WriteState != WriteState.Element)
				return false;

			HitPoint.Save(writer);
			Strength.Save("strength", writer);
			Intelligence.Save("intelligence", writer);
			Wisdom.Save("wisdom", writer);
			Dexterity.Save("dexterity", writer);
			Constitution.Save("constitution", writer);
			Charisma.Save("charisma", writer);

			writer.WriteStartElement("alignment");
			writer.WriteAttributeString("value", Alignment.ToString());
			writer.WriteEndElement();

			writer.WriteStartElement("movespeed");
			writer.WriteAttributeString("value", MoveSpeed.TotalMilliseconds.ToString());
			writer.WriteEndElement();


			return true;
		}


		/// <summary>
		/// Loads
		/// </summary>
		/// <param name="node">XmlNode handle</param>
		public virtual bool Load(XmlNode node)
		{
			if (node == null)
				return false;


			if (node.NodeType == XmlNodeType.Comment)
				return false;

			switch (node.Name.ToLower())
			{

				case "strength":
				{
					Strength.Load(node);
				}
				break;

				case "intelligence":
				{
					Intelligence.Load(node);
				}
				break;

				case "wisdom":
				{
					Wisdom.Load(node);
				}
				break;

				case "dexterity":
				{
					Dexterity.Load(node);
				}
				break;

				case "constitution":
				{
					Constitution.Load(node);
				}
				break;

				case "charisma":
				{
					Charisma.Load(node);
				}
				break;

				case "alignment":
				{
					Alignment = (EntityAlignment)Enum.Parse(typeof(EntityAlignment), node.Attributes["value"].Value, true);
				}
				break;

				case "hitpoint":
				{
					HitPoint.Load(node);
				}
				break;

				case "movespeed":
				{
					MoveSpeed = TimeSpan.FromMilliseconds(int.Parse(node.Attributes["value"].Value));
				}
				break;

				default:
				{
					Trace.WriteLine("[Entity] Load() : Unknown node : <{0}>", node.Name);
				}
				break;
			}


			return true;
		}


		#endregion



		#region Properties


		/// <summary>
		/// This value determines a hero's resistance to magic attacks.
		/// </summary>
		public byte AntiMagic
		{
			get;
			set;
		}

	
		/// <summary>
		/// This value determines a hero's resistance to fire damage.
		/// </summary>
		public byte AntiFire
		{
			get;
			set;
		}

		
		/// <summary>
		/// Represents an entity's ability to avoid being hit in combat. 
		/// An opponent's attack roll must equal or exceed the target entity's Armor Class to hit it. 
		/// </summary>
		public abstract int ArmorClass
		{
			get;
			set;
		}


		/// <summary>
		/// Base save bonus
		/// </summary>
		public abstract int BaseSaveBonus
		{
			get;
		}


		/// <summary>
		/// Gives the entity’s tactical speed.
		/// Lower is faster
		/// </summary>
		public TimeSpan MoveSpeed
		{
			get;
			set;
		}


		/// <summary>
		/// Last time the entity was updated
		/// </summary>
		protected DateTime LastUpdate;


		/// <summary>
		/// Hit Point
		/// </summary>
		public HitPoint HitPoint
		{
			get;
			set;
		}


		/// <summary>
		/// Last attack suffered
		/// </summary>
		public Attack LastAttack
		{
			get;
			protected set;
		}



		/// <summary>
		/// Returns true if dead
		/// </summary>
		public virtual bool IsDead
		{
			get
			{
				return HitPoint.Current <= 0;
			}
		}


		#region Abilities

		/// <summary>
		/// This value determines the load a hero can carry, how far items can be thrown 
		/// and how much damage is done by melee attacks. Strength also limits the amount 
		/// of equipment your character can carry. 
		/// </summary>
		public Ability Strength
		{
			get;
			private set;
		}


		/// <summary>
		/// A vital attribute for mages as they learn spells. 
		/// </summary>
		public Ability Intelligence
		{
			get;
			private set;
		}


		/// <summary>
		/// This value is important for spellcasters as it determines their ability to master Magic.
		/// It also determines the speed of Mana recovery.
		/// </summary>
		public Ability Wisdom
		{
			get;
			private set;
		}


		/// <summary>
		/// This value determines the accuracy of missiles and the odds of hitting opponents in combat. 
		/// It also helps the champion to avoid or reduce physical damage improving their AC (armor class).
		/// </summary>
		public Ability Dexterity
		{
			get;
			private set;
		}


		/// <summary>
		/// A character's health and toughness is determined by this. This has other effects outside of simply determining the HP
		/// amount gained after every level, such as a character's resistance to certain physical effects. 
		/// </summary>
		public Ability Constitution
		{
			get;
			private set;
		}


		/// <summary>
		/// This determines how attractive or repulsive a character is to everyone around them.
		/// </summary>
		public Ability Charisma
		{
			get;
			private set;
		}

		#endregion

		/// <summary>
		/// Hero alignement
		/// </summary>
		public EntityAlignment Alignment
		{
			get;
			set;
		}


		#endregion
	}




	/// <summary>
	/// Available hero alignements
	/// </summary>
	public enum EntityAlignment
	{
		[Description("Lawfull good")]
		LawfulGood,
		[Description("Neutral good")]
		NeutralGood,
		[Description("Chaotic good")]
		ChaoticGood,

		[Description("Lawful neutral")]
		LawfulNeutral,
		[Description("Neutral neutral")]
		TrueNeutral,
		[Description("Chaotic neutral")]
		ChaoticNeutral,

		[Description("Lawfull evil")]
		LawfulEvil,
		[Description("Neutral evil")]
		NeutralEvil,
		[Description("Chaotic evil")]
		ChaoticEvil
	}


/*
	/// <summary>
	/// define the height of the creature. It is used to check if missiles can fly over the creatures (for example Fireballs can fly over small creatures).
	/// This value is also used to define how to animate a door that is closed upon the creature: 
	/// </summary>
	/// <remarks>This value is ignored for non material creatures and the door always closes normally without causing any damage to such creatures</remarks>
	public enum EntityHeight
	{
		/// <summary>
		/// the door is animated from half of its size to 3/4th of its size. This applies to small creatures. 
		/// </summary>
		Small,

		/// <summary>
		/// the door is animated between 1/4th of its size to half of its size. This applies to medium sized creatures. 
		/// </summary>
		Medium,

		/// <summary>
		/// the door is animated from the top to 1/4th of its size. This applies to tall creatures.
		/// </summary>
		Tall,


		/// <summary>
		/// the door is not animated and stays fully open. The creature still takes damage.
		/// </summary>
		Giant
	}
*/

}
