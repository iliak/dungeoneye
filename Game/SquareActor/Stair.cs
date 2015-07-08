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
using ArcEngine.Graphic;
using ArcEngine.Asset;


namespace DungeonEye
{
	/// <summary>
	/// Stair
	/// </summary>
	public class Stair : SquareActor
	{

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="block"></param>
		public Stair(Square block) : base(block)
		{
			if (block == null)
				throw new ArgumentNullException("block");

			block.Type = SquareType.Ground;
			AcceptItems = false;
			CanPassThrough = false;
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
			if (TileSet == null)
				return;

			// Upstair or downstair ?
			int delta = Type == StairType.Up ? 0 : 13;

			foreach (TileDrawing tmp in DisplayCoordinates.GetStairs(position))
				batch.DrawTile(TileSet, tmp.ID + delta, tmp.Location, Color.White, 0.0f, tmp.Effect, 0.0f);
		
		}



		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("Stairs going " + Type + " (target " + Target + ")");

			return sb.ToString();
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


		#region Script

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override bool OnTeamEnter()
		{
			Team team = GameScreen.Team;

			if (team.Teleport(Target))
				team.Direction = Target.Direction;

			return true;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="monster"></param>
		/// <returns></returns>
		public override bool OnMonsterEnter(Monster monster)
		{
			if (monster == null)
				return false;

			monster.Teleport(Target);
			monster.Location.Direction = Target.Direction;

			return true;
		}
		#endregion


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

			Type = xml.Attributes["type"] != null ? (StairType)Enum.Parse(typeof(StairType), xml.Attributes["type"].Value) : StairType.Up;

			foreach (XmlNode node in xml)
			{
				switch (node.Name.ToLower())
				{
					case "target":
					{
						Target = new DungeonLocation();
						Target.Load(node);
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


			if (Target != null)
				Target.Save("target", writer);

			base.Save(writer);
			writer.WriteEndElement();

			return true;
		}



		#endregion


		#region Properties

		/// <summary>
		/// 
		/// </summary>
		public const string Tag = "stair";

	

		/// <summary>
		/// Type of stair
		/// </summary>
		public StairType Type
		{
			get;
			set;
		}

		/// <summary>
		/// Tileset for the drawing
		/// </summary>
		TileSet TileSet
		{
			get
			{
				if (Square == null)
					return null;

				return Square.Maze.WallTileset;
			}
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


	/// <summary>
	/// Stair type
	/// </summary>
	public enum StairType
	{
		/// <summary>
		/// Going up
		/// </summary>
		Up,


		/// <summary>
		/// Going down
		/// </summary>
		Down
	}
}
