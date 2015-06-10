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
using System.Xml;


namespace DungeonEye
{
	/// <summary>
	/// Profession information
	/// </summary>
	public class Profession
	{
		
		/// <summary>
		/// XmlNode constructor
		/// </summary>
		public Profession(XmlNode node)
		{
			Load(node);
		}


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="xp">XP points</param>
		/// <param name="classe">Class</param>
		public Profession(int xp, HeroClass classe)
		{
			Experience = Math.Max(1, xp);
			Class = classe;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format("{0}, level {1} (XP={2})", Class, Level, Experience);
		}


		/// <summary>
		/// Add xp
		/// </summary>
		/// <param name="amount">Amount of points to add</param>
		/// <returns>True if level up</returns>
		public bool AddXP(int amount)
		{
			int level = Level;

			Experience += amount;

			return level != Level;
		}



		#region IO


		/// <summary>
		/// Loads properties
		/// </summary>
		/// <param name="node">Node</param>
		/// <returns></returns>
		public bool Load(XmlNode xml)
		{
			if (xml == null || xml.NodeType != XmlNodeType.Element)
				return false;



			foreach (XmlNode node in xml.ChildNodes)
			{
				switch (node.Name.ToLower())
				{
					case "class":
					{
						Class = (HeroClass)Enum.Parse(typeof(HeroClass), node.Attributes["name"].Value);
					}
					break;

					case "xp":
					{
						if (node.Attributes["points"] != null)
							Experience = int.Parse(node.Attributes["points"].Value);
					}
					break;
				}
			}

			return true;
		}



		/// <summary>
		/// Saves properties
		/// </summary>
		/// <param name="name">Name for the node</param>
		/// <param name="writer">XmlWriter</param>
		/// <returns>True if saved</returns>
		public bool Save(XmlWriter writer)
		{
			if (writer == null)
				return false;

			writer.WriteStartElement("profession");
			
			writer.WriteStartElement("class");
			writer.WriteAttributeString("name", Class.ToString());
			writer.WriteEndElement();

			writer.WriteStartElement("xp");
			writer.WriteAttributeString("points", Experience.ToString());
			writer.WriteEndElement();
	
			writer.WriteEndElement();

			return true;
		}

		#endregion


		#region Properties

		/// <summary>
		/// Profression
		/// </summary>
		public HeroClass Class
		{
			get;
			private set;
		}


		/// <summary>
		/// Experience points
		/// </summary>
		public int Experience
		{
			get;
			set;
		}


		/// <summary>
		/// Level
		/// </summary>
		public int Level
		{
			get
			{
				#region Fighter
				int[] Fighter = new int[]
				{
					0,
					2000,
					4000,
					8000,
					16000,
					32000,
					64000,
					125000,
					250000,
					500000,
					750000,
					1000000,
					1250000
				};
				#endregion

				#region Clerc
				int[] Cleric = new int[]
				{
					0,
					1500,
					3000,
					6000,
					13000,
					27500,
					55000,
					110000,
					225000,
					450000,
					675000,
					900000,
					1125000
				};
				#endregion

				#region Paladin
				int[] Paladin = new int[]
				{
					0,
					2250,
					4500,
					9000,
					18000,
					36000,
					75000,
					150000,
					300000,
					600000,
					900000,
					1200000,
					1500000,
				};
				#endregion

				#region Mage
				int[] Mage = new int[]
				{
					0,
					2500,
					5000,
					10000,
					20000,
					40000,
					60000,
					90000,
					135000,
					250000,
					375000,
					750000,
					1125000
				};
				#endregion

				#region Ranger
				int[] Ranger = new int[]
				{
					0,
					2250,
					4500,
					9000,
					18000,
					36000,
					75000,
					150000,
					300000,
					600000,
					900000,
					1200000,
					1500000
				};
				#endregion

				#region Thief
				int[] Thief = new int[]
				{
					0,
					1250,
					2500,
					5000,
					10000,
					20000,
					40000,
					70000,
					110000,
					160000,
					220000,
					440000,
					660000
				};
				#endregion


				int[] data = null;

				switch (Class)
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

				for (int i = data.Length; i > 0; i--)
				{
					if (Experience >= data[i - 1])
						return i;
				}

				return 0;
			}
		}

		#endregion
	}

}
