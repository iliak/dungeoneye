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
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ArcEngine;
using ArcEngine.Graphic;

namespace DungeonEye
{

	/// <summary>
	/// Actor containing alcoves
	/// </summary>
	public class AlcoveActor : SquareActor
	{

		/// <summary>
		/// Cosntructor
		/// </summary>
		/// <param name="square">Parent square handle</param>
		public AlcoveActor(Square square) : base(square)
		{
			Alcoves = new Alcove[4]
			{
				new Alcove(),
				new Alcove(),
				new Alcove(),
				new Alcove(),
			};
			IsBlocking = true;
		}


		/// <summary>
		/// Draws all alcoves according to the view point
		/// </summary>
		/// <param name="batch">Spritebatch handle</param>
		/// <param name="field">Field of view handle</param>
		/// <param name="position">Position in the field of view</param>
		/// <param name="direction">Looking direction</param>
		public override void Draw(SpriteBatch batch, ViewField field, ViewFieldPosition position, CardinalPoint direction)
		{
			if (field.Maze.Decoration == null)
				return;

			// For each wall side, draws the decoration
			foreach (CardinalPoint side in DisplayCoordinates.DrawingWallSides[(int) position])
			{
				Alcove alcove = GetAlcove(Compass.GetDirectionFromView(direction, side));

				// Get the decoration
				Decoration deco = field.Maze.Decoration.GetDecoration(alcove.Decoration);
				if (deco == null)
					continue;

				// Draw the decoration
				deco.DrawDecoration(batch, field.Maze.Decoration, position, side == CardinalPoint.South);


				// Hide items
				if (alcove.HideItems || side != CardinalPoint.South)
					continue;

				

				// Offset the item locations according to the distance
				Vector2 vect = DisplayCoordinates.GetMonsterScaleFactor(position);
				Point loc = deco.PrepareLocation(position);
				loc.Offset((int) (deco.ItemLocation.X * vect.X), (int) (deco.ItemLocation.Y * vect.Y));
				

				// Draw items in the alcove in front of the team
				foreach (Item item in Square.GetItemsFromSide(direction, side))
				{
					batch.DrawTile(Square.Maze.Dungeon.ItemTileSet, item.GroundTileID, loc,
						DisplayCoordinates.GetDistantColor(position), 0.0f,
						DisplayCoordinates.GetItemScaleFactor(position), SpriteEffects.None, 0.0f);
				}
			}

		}


		/// <summary>
		/// Gets an alcove
		/// </summary>
		/// <param name="side">Wall side</param>
		/// <returns>Alcove handle</returns>
		public Alcove GetAlcove(CardinalPoint side)
		{
			return Alcoves[(int) side];
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("Alcoves (x)");

			return sb.ToString();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override DungeonLocation[] GetTargets()
		{
			List<DungeonLocation> list = new List<DungeonLocation>();

			foreach (Alcove alcove in Alcoves)
				list.AddRange(alcove.GetTargets());


			return list.ToArray();

		}


		#region Events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="location"></param>
		/// <param name="side"></param>
		/// <param name="button"></param>
		/// <returns></returns>
		public override bool OnClick(Point location, CardinalPoint side, MouseButtons button)
		{
			// No decoration set
			if (Square.Maze.Decoration == null)
				return false;

			// No decoration for the alcove
			Alcove alcove = GetAlcove(side);
			if (alcove.Decoration == -1)
				return false;

			// Point not in decoration
			if (!Square.Maze.Decoration.IsPointInside(alcove.Decoration, location))
				return false;

			Team team = GameScreen.Team;

			// No item in hand
			if (team.ItemInHand != null)
			{
				if (!alcove.AcceptBigItems && team.ItemInHand.IsBig)
				{
					return false;
				}

				// Run scripts
				alcove.AddItem();

				Square.DropItemFromSide(side, team.ItemInHand);
				team.SetItemInHand(null);
			}
			else
			{
				// Run scripts
				alcove.RemoveItem();

				// Set item in hand
				if ((button | MouseButtons.Left) == MouseButtons.Left)
					team.SetItemInHand(Square.CollectItemFromSide(side));

				// Add to inventory
				else if ((button | MouseButtons.Right) == MouseButtons.Right && team.SelectedHero != null)
					team.SelectedHero.AddToInventory(Square.CollectItemFromSide(side));
			}


			return true;
		}

		#endregion


		#region I/O


		/// <summary>
		/// 
		/// </summary>
		/// <param name="xml"></param>
		/// <returns></returns>
		public override bool Load(XmlNode xml)
		{
			if (xml == null || xml.Name != Tag)
				return false;

			foreach (XmlNode node in xml)
			{
				switch (node.Name.ToLower())
				{
					case "side":
					{
						CardinalPoint dir = (CardinalPoint) Enum.Parse(typeof(CardinalPoint), node.Attributes["name"].Value);
						Alcoves[(int) dir].Load(node);
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

			base.Save(writer);

			for (int i = 0 ; i < 4 ; i++)
			{
				if (Alcoves[i].Decoration == -1)
					continue;

				writer.WriteStartElement("side");
				writer.WriteAttributeString("name", ((CardinalPoint) i).ToString());
				Alcoves[i].Save(writer);
				writer.WriteEndElement();
			}
			writer.WriteEndElement();

			return true;
		}



		#endregion


		#region Properties

		/// <summary>
		/// 
		/// </summary>
		public const string Tag = "alcove";


		/// <summary>
		/// 4 alcoves
		/// </summary>
		Alcove[] Alcoves;

		#endregion
	}

}
