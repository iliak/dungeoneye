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
using System.Drawing;
using System.Xml;
using System.ComponentModel;
using ArcEngine.Asset;
using ArcEngine.Graphic;


namespace DungeonEye
{
	/// <summary>
	/// Pit class
	/// </summary>
	public class Pit : SquareActor
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Pit(Square block) : base(block)
		{
			if (block == null)
				throw new ArgumentNullException("block");

			Damage = new Dice();
			AcceptItems = true;
			CanPassThrough = true;
			IsBlocking = false;
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="batch"></param>
		/// <param name="field"></param>
		/// <param name="position"></param>
		/// <param name="direction"></param>
		public override void Draw(SpriteBatch batch, ViewField field, ViewFieldPosition position, CardinalPoint direction)
		{
			if (Decoration == null || IsHidden)
				return;

			TileDrawing td = DisplayCoordinates.GetPit(position);
			if (td == null)
				return;



			if (IsActivated)
				//batch.FillRectangle(new Rectangle(td.Location, new Size(50, 50)), Color.Red);
				Decoration.Draw(batch, field.Maze.FloorPitDeco, position);
			//TODO
			//if (td != null && !IsHidden)
			//    batch.DrawTile(TileSet, td.ID, td.Location, Color.White, 0.0f, td.Effect, 0.0f);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override DungeonLocation[] GetTargets()
		{
			DungeonLocation[] target = new DungeonLocation[] { Target };

			return target;
		}



		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("Pit (");
			if (Target != null)
				sb.Append(Target);

			if (Damage != null)
				sb.Append(". Difficulty : " + Damage);
			
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

			IsHidden = xml.Attributes["hidden"] != null ? bool.Parse(xml.Attributes["hidden"].Value) : false;
			Difficulty = xml.Attributes["difficulty"] != null ? int.Parse(xml.Attributes["difficulty"].Value) : 0;

			foreach (XmlNode node in xml)
			{
				switch (node.Name.ToLower())
				{
					case "target":
					{
						Target = new DungeonLocation(node);
					}
					break;

					case "damage":
					{
						Damage.Load(node);
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
		/// <param name="writer"></param>
		/// <returns></returns>
		public override bool Save(XmlWriter writer)
		{
			if (writer == null)
				return false;


			writer.WriteStartElement(Tag);
			writer.WriteAttributeString("hidden", IsHidden.ToString());
			writer.WriteAttributeString("difficulty", Difficulty.ToString());

			if (Target != null)
				Target.Save("target", writer);

			Damage.Save("damage", writer);

			base.Save(writer);
			writer.WriteEndElement();

			return true;
		}



		#endregion


		#region Script

		/// <summary>
		/// 
		/// </summary>
		/// <param name="team"></param>
		/// <returns></returns>
		public override bool OnTeamEnter()
		{
			if (Target == null || !IsActivated)
				return false;

			Team team = GameScreen.Team;
			CardinalPoint dir = team.Direction;

			if (team.Teleport(Target))
				team.Damage(Damage, SavingThrowType.Reflex, Difficulty);


			//Hack: Restore facing direction
			team.Direction = dir;

			return true;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="monster"></param>
		/// <returns></returns>
		public override bool OnMonsterEnter(Monster monster)
		{
			if (monster == null || IsActivated)
				return false;

			if (Target == null)
				return false;

			monster.Teleport(Target);
			monster.Damage(Damage, SavingThrowType.Reflex, Difficulty);

			return true;
		}
		#endregion


		#region Properties

		/// <summary>
		/// XML Tag
		/// </summary>
		public const string Tag = "pit";


		/// <summary>
		/// Decoration handle
		/// </summary>
		DecorationSet Decoration
		{
			get
			{
				if (Square == null)
					return null;

				return Square.Maze.Decoration;
			}
		}



		/// <summary>
		/// An illusion pit
		/// </summary>
		public bool IsIllusion
		{
			get;
			set;
		}


		/// <summary>
		/// Monster also trigger
		/// </summary>
		public bool MonsterTrigger
		{
			get;
			set;
		}


		/// <summary>
		/// A hidden pit
		/// </summary>
		public bool IsHidden
		{
			get;
			set;
		}


		/// <summary>
		/// Difficulty Class
		/// </summary>
		public int Difficulty
		{
			get;
			set;
		}


		/// <summary>
		/// Damage
		/// </summary>
		public Dice Damage
		{
			get;
			set;
		}

	
		/// <summary>
		/// Target
		/// </summary>
		public DungeonLocation Target
		{
			get;
			set;
		}

		#endregion


	}
}
