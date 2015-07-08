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
using System.Collections.Generic;
using System.Drawing;
using System.Xml;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Graphic;
using ArcEngine.Interface;


namespace DungeonEye
{

	/// <summary>
	/// Decoration collection
	/// </summary>
	public class DecorationSet : IAsset
	{

		/// <summary>
		/// Constructor
		/// </summary>
		public DecorationSet()
		{
			Decorations = new Dictionary<int, Decoration>();
			IsDisposed = false;
		}



		/// <summary>
		/// Initializes the asset
		/// </summary>
		/// <returns>True on success</returns>
		public bool Init()
		{
			LoadTileSet(TileSetName);

			return true;
		}



		/// <summary>
		/// Disposes resources
		/// </summary>
		public void Dispose()
		{
			if (Tileset != null)
				Tileset.Dispose();
			Tileset = null;

			Decorations = null;
			IsDisposed = true;
		}



		/// <summary>
		/// Checks if a point is inside the decoration
		/// </summary>
		/// <param name="id">Decoration id</param>
		/// <param name="location">Location to check</param>
		/// <returns>True if point is inside the alcove</returns>
		public bool IsPointInside(int id, Point location)
		{
			Decoration deco = GetDecoration(id);
			if (deco == null)
				return false;

			Tile tile = Tileset.GetTile(deco.GetTileId(ViewFieldPosition.L));
			if (tile == null)
				return false;

			Rectangle zone = new Rectangle(
				deco.GetLocation(ViewFieldPosition.L),
				tile.Size);

			return zone.Contains(location);
		}


		/// <summary>
		/// Gets a decoration description
		/// </summary>
		/// <param name="id">Decoration number</param>
		/// <returns>Decoration information or null</returns>
		public Decoration GetDecoration(int id)
		{
			if (Decorations == null || id == -1)
				return null;

			if (!Decorations.ContainsKey(id))
				return null;

			return Decorations[id];
		}


		/// <summary>
		/// Adds a new decoration
		/// </summary>
		/// <param name="id">Id of the decoration</param>
		/// <returns>Decoration handle</returns>
		public Decoration AddDecoration(int id)
		{
			Decoration deco = new Decoration();
			Decorations[id] = deco;

			return deco;
		}


		/// <summary>
		/// Loads a TileSet
		/// </summary>
		/// <param name="name">TileSet name</param>
		/// <returns>True on success</returns>
		public bool LoadTileSet(string name)
		{
			TileSetName = name;

			if (string.IsNullOrEmpty(name))
				return false;

			if (Tileset != null)
				Tileset.Dispose();
			Tileset = ResourceManager.CreateAsset<TileSet>(TileSetName);

			return Tileset != null;
		}


		/// <summary>
		/// Draws a decoration
		/// </summary>
		/// <param name="batch">Spritebatch handle</param>
		/// <param name="id">Decoration id</param>
		/// <param name="position">View position</param>
		public void Draw(SpriteBatch batch, int id, ViewFieldPosition position)
		{
			if (batch == null || id == -1)
				return;

			Decoration deco = GetDecoration(id);
			if (deco == null)
				return;

			batch.DrawTile(Tileset, deco.GetTileId(position), deco.GetLocation(position),
				Color.White, 0.0f,
				deco.GetSwap(position) ? SpriteEffects.FlipHorizontally : SpriteEffects.None,
				0.0f);
		}



		#region IO

		/// <summary>
		/// 
		/// </summary>
		/// <param name="xml"></param>
		/// <returns></returns>
		public bool Load(XmlNode xml)
		{
			if (xml == null || xml.Name != XmlTag)
				return false;

			Name = xml.Attributes["name"].Value;
			BackgroundTileset = xml.Attributes["background"] != null ? xml.Attributes["background"].Value : string.Empty;
			TileSetName = xml.Attributes["tileset"] != null ? xml.Attributes["tileset"].Value : string.Empty;
			foreach (XmlNode node in xml)
			{
				if (node.NodeType == XmlNodeType.Comment)
					continue;


				switch (node.Name.ToLower())
				{
					case "decoration":
					{
						Decoration deco = new Decoration();
						deco.Load(node);
						int id = int.Parse(node.Attributes["id"].Value);
						Decorations[id] = deco;
					}
					break;
				}
			}


			// Load tileset
			LoadTileSet(TileSetName);


			return true;
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="writer"></param>
		/// <returns></returns>
		public bool Save(XmlWriter writer)
		{
			if (writer == null)
				return false;


			writer.WriteStartElement(XmlTag);
			writer.WriteAttributeString("name", Name);
			writer.WriteAttributeString("tileset", TileSetName);
			writer.WriteAttributeString("background", BackgroundTileset);

			foreach (KeyValuePair<int, Decoration> val in Decorations)
				val.Value.Save(writer, val.Key);

			writer.WriteEndElement();

			return true;
		}


		#endregion


		#region Properties


		/// <summary>
		/// Name of the decoration
		/// </summary>
		public string Name
		{
			get;
			set;
		}


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
		public const string Tag = "decorationset";


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
		/// TileSet of the decoration
		/// </summary>
		public TileSet Tileset
		{
			get;
			protected set;
		}


		/// <summary>
		/// TileSet name to use for this decoration
		/// </summary>
		public string TileSetName
		{
			get;
			set;
		}



		/// <summary>
		/// List of decorations
		/// </summary>
		Dictionary<int, Decoration> Decorations;


		/// <summary>
		/// Name of the tileset to use for the editor
		/// </summary>
		internal string BackgroundTileset
		{
			get;
			set;
		}

		#endregion

	}


}
