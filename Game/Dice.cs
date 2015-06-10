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
using System.Xml;


namespace DungeonEye
{
	/// <summary>
	/// Dice class
	/// </summary>
	public class Dice : ICloneable
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Dice() : this(0, 1, 0)
		{
		}

	
		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="throws">Throw count</param>
		/// <param name="faces">Face count</param>
		/// <param name="mode">Modifier value</param>
		public Dice(int throws, int faces, int modifier)
		{
			Throws = throws;
			Faces = faces;
			Modifier = modifier;
		}


		/// <summary>
		/// Returns a dice roll
		/// </summary>
		/// <returns>The value</returns>
		public int Roll()
		{
			return Roll(Throws);
		}



		/// <summary>
		/// Returns a dice roll
		/// </summary>
		/// <param name="rolls">Number of roll</param>
		/// <returns>The value</returns>
		public int Roll(int rolls)
		{
			if (Faces == 0)
				return 0;

			int val = 0;

			for (int i = 0; i < rolls; i++)
				val += Random.Next(1, Faces);


			return val + Modifier;
		}


		/// <summary>
		/// Resets the dice
		/// </summary>
		public void Reset()
		{
			Modifier = 0;
			Throws = 1;
			Faces = 1;
		}


		/// <summary>
		/// Copy a dice
		/// </summary>
		/// <param name="dice">Dice to copy from</param>
		public void Clone(Dice dice)
		{
			if (dice == null)
				return;

			Faces = dice.Faces;
			Throws = dice.Throws;
			Modifier = dice.Modifier;
		}


		/// <summary>
		/// Clone the dice
		/// </summary>
		/// <returns></returns>
		public object Clone()
		{
			return MemberwiseClone();
		}


		#region Statics


		/// <summary>
		/// Gets the result of a 20 faces dice
		/// </summary>
		/// <param name="count">Number of throws</param>
		/// <returns></returns>
		static public int GetD20(int count)
		{
			int res = 0;

			for (int i = 0; i < count; i++)
			{
				res += Random.Next(1, 20);
			}

			return res;
		}



		/// <summary>
		/// Gets a Saving Throw result
		/// </summary>
		/// <param name="type">Type of saving throw</param>
		/// <returns></returns>
		static public int SavingThrow(SavingThrowType type)
		{
			return 0;
		}

		#endregion



		#region IO


		/// <summary>
		/// Loads properties
		/// </summary>
		/// <param name="node">Node</param>
		/// <returns></returns>
		public bool Load(XmlNode node)
		{
			if (node == null)
				return false;

			if (node.NodeType != XmlNodeType.Element)
				return false;


			if (node.Attributes["faces"] != null)
				Faces = int.Parse(node.Attributes["faces"].Value);

			if (node.Attributes["throws"] != null)
				Throws = int.Parse(node.Attributes["throws"].Value);

			if (node.Attributes["modifier"] != null)
				Modifier = int.Parse(node.Attributes["modifier"].Value);

			return true;
		}



		/// <summary>
		/// Saves properties
		/// </summary>
		/// <param name="name">Name for the node</param>
		/// <param name="writer">XmlWriter</param>
		/// <returns>True if saved</returns>
		public bool Save(string name, XmlWriter writer)
		{
			if (writer == null || string.IsNullOrEmpty(name))
				return false;

			writer.WriteStartElement(name);
			writer.WriteAttributeString("throws", Throws.ToString());
			writer.WriteAttributeString("faces", Faces.ToString());
			writer.WriteAttributeString("modifier", Modifier.ToString());
			writer.WriteEndElement();

			return true;
		}

		#endregion


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format("{0}d{1} + {2} ({3}~{4})", Throws, Faces, Modifier, Minimum, Maximum);
		}



		#region Properties


		/// <summary>
		/// Random generator
		/// </summary>
		static Random Random = new Random((int)DateTime.Now.Ticks);


		/// <summary>
		/// Number of throw
		/// </summary>
		public int Throws
		{
			get;
			set;
		}

		/// <summary>
		/// Number of sides
		/// </summary>
		public int Faces
		{
			get;
			set;
		}

		/// <summary>
		/// Modifier value
		/// </summary>
		public int Modifier
		{
			get;
			set;
		}


		/// <summary>
		/// Minimum value
		/// </summary>
		public int Minimum
		{
			get
			{
				return Modifier + Throws;
			}
		}

		/// <summary>
		/// Maximum value
		/// </summary>
		public int Maximum
		{
			get
			{
				return Modifier + (Faces * Throws);
			}
		}


		#endregion
	}




	/// <summary>
	/// Difficulty Class
	/// </summary>
	/// <remarks>Some checks are made against a Difficulty Class (DC). 
	/// The DC is a number (set using the skill rules as a guideline)
	/// that you must score as a result on your skill check in order to succeed. </remarks>
	public enum DCType
	{
		/// <summary>
		/// Notice something large in plain sight 
		/// </summary>
		VeryEasy = 0,

		/// <summary>
		/// Climb a knotted rope 
		/// </summary>
		Easy = 10,

		/// <summary>
		/// Hear an approaching guard 
		/// </summary>
		Average = 15,
		
		/// <summary>
		/// Rig a wagon wheel to fall off (
		/// </summary>
		Tough = 15,
		
		/// <summary>
		/// Swim in stormy water 
		/// </summary>
		Challenging = 20,
		
		/// <summary>
		/// Open an average lock 
		/// </summary>
		Formidable = 25,
		
		/// <summary>
		/// Leap across a 30-foot chasm 
		/// </summary>
		Heroic = 30,

		/// <summary>
		/// Track a squad of orcs across hard ground after 24 hours of rainfall 
		/// </summary>
		NearlyImpossible = 40,
	}

}
