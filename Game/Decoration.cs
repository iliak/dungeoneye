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
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Xml;
using ArcEngine;
using ArcEngine.Graphic;
using ArcEngine.Asset;
using ArcEngine.Interface;


namespace DungeonEye
{
	/// <summary>
	/// Information about a specific decoration
	/// </summary>
	public class Decoration
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public Decoration()
		{
			TileId= new int[16];
			Location = new Point[16]
			{
				new Point(-999, -999), new Point(-999, -999), new Point(-999, -999), new Point(-999, -999), new Point(-999, -999), 
				new Point(-999, -999), new Point(-999, -999), new Point(-999, -999), new Point(-999, -999), new Point(-999, -999), 
				new Point(-999, -999), new Point(-999, -999), new Point(-999, -999), 
				new Point(-999, -999), new Point(-999, -999), new Point(-999, -999), 
			};
			OnBashId = -1;
			OnHackId = -1;
			OnClickId = -1;

			for (int i = 0 ; i < TileId.Length ; i++)
				TileId[i] = -1;
			Swap = new bool[16];
		}




		/// <summary>
		/// Gets the tile id for a given view point
		/// </summary>
		/// <param name="position">View point position</param>
		/// <returns>Tile id or -1 if no tile</returns>
		public int GetTileId(ViewFieldPosition position)
		{
			return TileId[(int) position];
		}



		/// <summary>
		/// Sets the tile id for a given view point
		/// </summary>
		/// <param name="position">View point position</param>
		/// <param name="id">Id of the tile</param>
		public void SetTileId(ViewFieldPosition position, int id)
		{
			TileId[(int) position] = id;
		}


		/// <summary>
		/// Gets the on screen location for a given view point
		/// </summary>
		/// <param name="position">View point position</param>
		/// <returns>Screen location</returns>
		public Point GetLocation(ViewFieldPosition position)
		{
			return Location[(int)position];
		}


		/// <summary>
		/// Gets the on screen location for a given view point
		/// </summary>
		/// <param name="position">View point position</param>
		/// <param name="location">Screen location</param>
		public void SetLocation(ViewFieldPosition position, Point location)
		{
			Location[(int) position] = location;
		}


		/// <summary>
		/// Gets if the tile need to be swapped
		/// </summary>
		/// <param name="position">View field position</param>
		/// <returns>True on horizontal swap</returns>
		public bool GetSwap(ViewFieldPosition position)
		{
			return Swap[(int)position];
		}


		/// <summary>
		/// Sets if the tile need to be swapped
		/// </summary>
		/// <param name="position">View field position</param>
		public void SetSwap(ViewFieldPosition position, bool swap)
		{
			Swap[(int)position] = swap;
		}


		/// <summary>
		/// Clear definition
		/// </summary>
		public void Clear()
		{
			foreach (ViewFieldPosition pos in Enum.GetValues(typeof(ViewFieldPosition)))
			{
				SetTileId(pos, -1);
				SetLocation(pos, Point.Empty);
				SetSwap(pos, false);
			}

			IsBlocking = false;
		}


		/// <summary>
		/// Draws a single decoration
		/// </summary>
		/// <param name="batch">Spritebatch handle</param>
		/// <param name="decoration">DecorationSet handle</param>
		/// <param name="position">Position of the square in the view</param>
		/// <param name="view">Viewing direction</param>
		/// <param name="alignview">True if the side is facing south (horizontaly span the decoration)</param>
		public void DrawDecoration(SpriteBatch batch, DecorationSet set, ViewFieldPosition position, bool alignview)
		{
			if (batch == null || set == null)
				return;

			// Location of the decoration on the screen
			Point location = GetLocation(position);

			// Tile id
			int tileid = GetTileId(position);


			// Offset the decoration if facing to the view point
			if (alignview)
			{
				location = PrepareLocation(position);
				tileid = PrepareTile(position);
			}


			// Draws the decoration
			batch.DrawTile(set.Tileset,
			tileid,
			location, Color.White,
			0.0f,
			GetSwap(position) ? SpriteEffects.FlipHorizontally : SpriteEffects.None,
			0.0f);
		}




		#region Helpers

		/// <summary>
		/// Gets the screen location of a decoration if a decoration is facing the view point
		/// </summary>
		/// <param name="position">Viewfield position</param>
		/// <returns>On screen location</returns>
		public Point PrepareLocation(ViewFieldPosition position)
		{
			Point location = Point.Empty;

			switch (position)
			{
				case ViewFieldPosition.A:
				location = GetLocation(ViewFieldPosition.C);
				location.X += -96 * 2;
				break;
				case ViewFieldPosition.B:
				location = GetLocation(ViewFieldPosition.C);
				location.X += -96;
				break;
				case ViewFieldPosition.D:
				location = GetLocation(ViewFieldPosition.C);
				location.X += 96;
				break;
				case ViewFieldPosition.E:
				location = GetLocation(ViewFieldPosition.C);
				location.X += 96 * 2;
				break;

				case ViewFieldPosition.G:
				location = GetLocation(ViewFieldPosition.H);
				location.X += -160;
				break;
				case ViewFieldPosition.I:
				location = GetLocation(ViewFieldPosition.H);
				location.X += 160;
				break;

				case ViewFieldPosition.K:
				location = GetLocation(ViewFieldPosition.L);
				location.X -= 256;
				break;
				case ViewFieldPosition.M:
				location = GetLocation(ViewFieldPosition.L);
				location.X += 256;
				break;

				default:
				{
					location = GetLocation(position);
				}
				break;
			}
			
			return location;
		}


		/// <summary>
		/// Gets the tile id if the decoration is facing the view point
		/// </summary>
		/// <param name="position">Viewfield position</param>
		/// <returns>Tile id</returns>
		public int PrepareTile(ViewFieldPosition position)
		{
			ViewFieldPosition[] pos = new ViewFieldPosition[]
			{
				ViewFieldPosition.C,	// A
				ViewFieldPosition.C,	// B
				ViewFieldPosition.C,	// C
				ViewFieldPosition.C,	// D
				ViewFieldPosition.C,	// E

				ViewFieldPosition.H,	// F
				ViewFieldPosition.H,	// G
				ViewFieldPosition.H,	// H
				ViewFieldPosition.H,	// I
				ViewFieldPosition.H,	// J

				ViewFieldPosition.L,	// K
				ViewFieldPosition.L,	// L
				ViewFieldPosition.L,	// M

				ViewFieldPosition.N,	// N
				ViewFieldPosition.Team,	// Team
				ViewFieldPosition.O,	// O
			};

			return GetTileId(pos[(int)position]);
		}

		#endregion


		#region IO

		/// <summary>
		/// 
		/// </summary>
		/// <param name="xml"></param>
		/// <returns></returns>
		public bool Load(XmlNode xml)
		{

			if (xml == null || xml.Name != Tag)
				return false;

			IsBlocking = bool.Parse(xml.Attributes["isblocking"].Value);
			ForceDisplay = bool.Parse(xml.Attributes["forcedisplay"].Value);
			OnHackId = int.Parse(xml.Attributes["onhack"].Value);
			OnBashId = int.Parse(xml.Attributes["onbash"].Value);
			OnClickId = int.Parse(xml.Attributes["onclick"].Value);
			HideItems= bool.Parse(xml.Attributes["hideitems"].Value);

			foreach (XmlNode node in xml)
			{
				if (node.NodeType == XmlNodeType.Comment)
					continue;

				if (node.Name == "item")
				{
					ItemLocation = new Point(int.Parse(node.Attributes["x"].Value),
						 int.Parse(node.Attributes["y"].Value));
				}

				else
				{
					try
					{
						ViewFieldPosition pos = (ViewFieldPosition) Enum.Parse(typeof(ViewFieldPosition), node.Name);
						TileId[(int) pos] = int.Parse(node.Attributes["id"].Value);

						if (TileId[(int)pos] != -1)
						{
							Location[(int)pos].X = int.Parse(node.Attributes["x"].Value);
							Location[(int)pos].Y = int.Parse(node.Attributes["y"].Value);
							Swap[(int)pos] = bool.Parse(node.Attributes["swap"].Value);
						}
					}
					catch (Exception e)
					{
						Trace.WriteLine("[Decoration]Load : Error while loading : " + e.Message);
					}
				}
			}



			return true;
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="writer">XmlWriter handle</param>
		/// <param name="id">Decoration Id</param>
		/// <returns></returns>
		public bool Save(XmlWriter writer, int id)
		{
			if (writer == null)
				return false;


			writer.WriteStartElement("decoration");
			writer.WriteAttributeString("id", id.ToString());
			writer.WriteAttributeString("isblocking", IsBlocking.ToString());
			writer.WriteAttributeString("forcedisplay", ForceDisplay.ToString());
			writer.WriteAttributeString("onhack", OnHackId.ToString());
			writer.WriteAttributeString("onbash", OnBashId.ToString());
			writer.WriteAttributeString("onclick", OnClickId.ToString());
			writer.WriteAttributeString("hideitems", HideItems.ToString());

			writer.WriteStartElement("item");
			writer.WriteAttributeString("x", ItemLocation.X.ToString());
			writer.WriteAttributeString("y", ItemLocation.Y.ToString());
			writer.WriteEndElement();

			foreach (ViewFieldPosition vfp in Enum.GetValues(typeof(ViewFieldPosition)))
			{
				writer.WriteStartElement(vfp.ToString());
				writer.WriteAttributeString("id", TileId[(int) vfp].ToString());
				writer.WriteAttributeString("x", Location[(int) vfp].X.ToString());
				writer.WriteAttributeString("y", Location[(int)vfp].Y.ToString());
				writer.WriteAttributeString("swap", Swap[(int)vfp].ToString());
				writer.WriteEndElement();
			}

			writer.WriteEndElement();

			return true;
		}


		#endregion


		#region Properties


		/// <summary>
		/// XML Tag
		/// </summary>
		public const string Tag = "decoration";


		/// <summary>
		/// Tile Id
		/// </summary>
		int[] TileId;


		/// <summary>
		/// Display location on the screen
		/// </summary>
		Point[] Location;


		/// <summary>
		/// Horizontal swap
		/// </summary>
		bool[] Swap;


		/// <summary>
		/// Does the decoration is blocking
		/// </summary>
		public bool IsBlocking
		{
			get;
			set;
		}

		/// <summary>
		/// Does the decoration is visible from all sides
		/// </summary>
		public bool ForceDisplay
		{
			get;
			set;
		}


		/// <summary>
		/// Items location on the screen
		/// </summary>
		public Point ItemLocation
		{
			get;
			set;
		}


		/// <summary>
		/// If true, don't display items on the ground
		/// </summary>
		public bool HideItems
		{
			get;
			set;
		}


		/// <summary>
		/// Id of the decoration to use when hacked
		/// </summary>
		public int OnHackId
		{
			get;
			set;
		}


		/// <summary>
		/// Id of the decoration to use when bashed
		/// </summary>
		public int OnBashId
		{
			get;
			set;
		}


		/// <summary>
		/// Id of the decoration to use when clicked
		/// </summary>
		public int OnClickId
		{
			get;
			set;
		}

		#endregion

	}
}
