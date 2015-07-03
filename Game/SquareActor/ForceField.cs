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
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using ArcEngine.Graphic;

namespace DungeonEye
{
	/// <summary>
	/// Invisible force moving the team
	/// </summary>
	public class ForceField : SquareActor
	{

		/// <summary>
		/// Constructor
		/// </summary>
		public ForceField(Square square) : base(square)
		{
			Type = ForceFieldType.Spin;
			Spin = CompassRotation.Rotate180;
			Direction = CardinalPoint.North;

			AffectTeam = true;
			AffectMonsters = true;
			AffectItems = true;

			AcceptItems = true;
			CanPassThrough = true;
			IsBlocking = false;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("ForceField (");

			switch (Type)
			{
				case ForceFieldType.Spin:
					sb.Append("Spin " + Spin);
				break;
				case ForceFieldType.Move:
					sb.Append("Move " + Direction);
				break;
				case ForceFieldType.Block:
					sb.Append("Block");
				break;
				case ForceFieldType.FaceTo:
					sb.Append("Face To " + Direction);
				break;
			}

			sb.Append(". Affect :");
			if (AffectTeam)
				sb.Append("Team ");
			if (AffectMonsters)
				sb.Append("monsters ");
			if (AffectItems)
				sb.Append("items ");

			sb.Append(")");
			return sb.ToString();
		}


		#region I/O


		/// <summary>
		/// 
		/// </summary>
		/// <param name="node"></param>
		/// <returns></returns>
		public override bool Load(XmlNode xml)
		{
			if (xml == null || xml.Name != Tag)
				return false;

			foreach (XmlNode node in xml)
			{
				switch (node.Name.ToLower())
				{
					case "type":
					{
						Type = (ForceFieldType)Enum.Parse(typeof(ForceFieldType), node.Attributes["value"].Value);
					}
					break;

					case "spin":
					{
						Spin = (CompassRotation)Enum.Parse(typeof(CompassRotation), node.Attributes["value"].Value);
					}
					break;

					case "direction":
					{
						Direction = (CardinalPoint)Enum.Parse(typeof(CardinalPoint), node.Attributes["value"].Value);
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
		/// 
		/// </summary>
		/// <returns></returns>
		public override bool Save(XmlWriter writer)
		{
			if (writer == null)
				return false;


			writer.WriteStartElement(Tag);
			writer.WriteAttributeString("type", Type.ToString());
			writer.WriteAttributeString("spin", Spin.ToString());
			writer.WriteAttributeString("direction", Direction.ToString());

			base.Save(writer);

			writer.WriteEndElement();

			return true;
		}



		#endregion


		#region Script

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override bool OnTeamEnter()
		{
			if (!AffectTeam)
				return false;

			Team team = GameScreen.Team;

			switch (Type)
			{
				case ForceFieldType.Spin:
				{
					team.Location.Direction = Compass.Rotate(team.Location.Direction, Spin);
				}
				break;

				case ForceFieldType.Move:
				{
					team.Offset(Direction, 1);
				}
				break;

				case ForceFieldType.FaceTo:
				{
					team.Location.Direction = Direction;
				}
				break;
			}


			return true;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="monster"></param>
		/// <returns></returns>
		public override bool OnMonsterEnter(Monster monster)
		{
			if (!AffectMonsters || monster == null)
				return false;

			switch (Type)
			{
				case ForceFieldType.Spin:
				{
					monster.Location.Direction = Compass.Rotate(monster.Location.Direction, Spin);
				}
				break;

				case ForceFieldType.Move:
				{

					switch (Direction)
					{
						case CardinalPoint.North:
						monster.Location.Coordinate.Offset(0, -1);
						break;
						case CardinalPoint.South:
						monster.Location.Coordinate.Offset(0, 1);
						break;
						case CardinalPoint.West:
						monster.Location.Coordinate.Offset(-1, 0);
						break;
						case CardinalPoint.East:
						monster.Location.Coordinate.Offset(1, 0);
						break;
					}
				}
				break;
			
				
				case ForceFieldType.FaceTo:
				{
					monster.Location.Direction = Direction;
				}
				break;
			}

			return true;
		}
		#endregion


		#region Properties

		/// <summary>
		/// 
		/// </summary>
		public const string Tag = "forcefield";



		/// <summary>
		/// Type of force field
		/// </summary>
		public ForceFieldType Type
		{
			get;
			set;
		}

		/// <summary>
		/// Type of turn
		/// </summary>
		public CompassRotation Spin
		{
			get;
			set;
		}


		/// <summary>
		/// Moving value
		/// </summary>
		public CardinalPoint Direction
		{
			get;
			set;
		}


		/// <summary>
		/// Does affect monsters
		/// </summary>
		public bool AffectMonsters
		{
			get;
			set;
		}


		/// <summary>
		/// Does affect team
		/// </summary>
		public bool AffectTeam
		{
			get;
			set;
		}


		/// <summary>
		/// Does affect items
		/// </summary>
		public bool AffectItems
		{
			get;
			set;
		}

		#endregion
	}


	/// <summary>
	/// Type of force field
	/// </summary>
	public enum ForceFieldType
	{
		/// <summary>
		/// Turn
		/// </summary>
		Spin,

		/// <summary>
		/// Move to a direction
		/// </summary>
		Move,

		/// <summary>
		/// Can't go through
		/// </summary>
		Block,


		/// <summary>
		/// Face to a given direction
		/// </summary>
		FaceTo,
	}
}
