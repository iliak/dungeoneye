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
using System.Drawing;
using System.Collections.Generic;
using System.Xml;
using ArcEngine.Asset;
using ArcEngine;



namespace DungeonEye
{
	/// <summary>
	/// Defines a rectangular zone in a maze
	/// </summary>
	public class MazeZone
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public MazeZone()
		{
			Rectangle = Rectangle.Empty;
		}


		#region IO


		/// <summary>
		/// Loads properties
		/// </summary>
		/// <param name="node">Node</param>
		/// <returns></returns>
		public bool Load(XmlNode xml)
		{
			if (xml == null || xml.Name != Tag)
				return false;


			foreach (XmlNode node in xml)
			{
				switch (node.Name.ToLower())
				{

					case "script":
					{
						ScriptName = node.Attributes["name"].Value;
						//Script = Script.LoadFromBank(ScriptName);
					}
					break;

					case "onteamleave":
					{
						OnTeamLeaveScript = node.Attributes["name"].Value;
					}
					break;

					case "onteamenter":
					{
						OnTeamEnterScript = node.Attributes["name"].Value;
					}
					break;


					case "onmonsterleave":
					{
						OnMonsterLeaveScript = node.Attributes["name"].Value;
					}
					break;

					case "onmonsterenter":
					{
						OnMonsterEnterScript = node.Attributes["name"].Value;
					}
					break;

					case "onupdate":
					{
						OnUpdateScript = node.Attributes["name"].Value;
					}
					break;

					case "ondraw":
					{
						OnDrawScript = node.Attributes["name"].Value;
					}
					break;

				}

			}

			return true;
		}



		/// <summary>
		/// Saves properties
		/// </summary>
		/// <param name="writer">XmlWriter</param>
		/// <returns>True if saved</returns>
		public bool Save(XmlWriter writer)
		{
			if (writer == null)
				return false;

			writer.WriteStartElement(Tag);
			writer.WriteAttributeString("name", Name);

			writer.WriteStartElement("rectangle");
			writer.WriteAttributeString("x", Rectangle.X.ToString());
			writer.WriteAttributeString("y", Rectangle.Y.ToString());
			writer.WriteAttributeString("width", Rectangle.Width.ToString());
			writer.WriteAttributeString("height", Rectangle.Height.ToString());
			writer.WriteEndElement();


			writer.WriteStartElement("script");
			writer.WriteAttributeString("name", ScriptName);
			writer.WriteEndElement();


			writer.WriteStartElement("onteamenter");
			writer.WriteAttributeString("name", OnTeamEnterScript);
			writer.WriteEndElement();

			writer.WriteStartElement("onteamleave");
			writer.WriteAttributeString("name", OnTeamLeaveScript);
			writer.WriteEndElement();



			writer.WriteStartElement("onmonsterenter");
			writer.WriteAttributeString("name", OnMonsterEnterScript);
			writer.WriteEndElement();

			writer.WriteStartElement("onmonsterleave");
			writer.WriteAttributeString("name", OnMonsterLeaveScript);
			writer.WriteEndElement();


	
			writer.WriteStartElement("onupdate");
			writer.WriteAttributeString("name", OnUpdateScript);
			writer.WriteEndElement();

			writer.WriteStartElement("ondraw");
			writer.WriteAttributeString("name", OnDrawScript);
			writer.WriteEndElement();


			writer.WriteEndElement();

			return true;
		}

		#endregion




		#region Properties

		/// <summary>
		/// 
		/// </summary>
		public const string Tag = "zone";


		/// <summary>
		/// Name of the zone
		/// </summary>
		public string Name
		{
			get;
			set;
		}

		/// <summary>
		/// Rectangle of the zone
		/// </summary>
		public Rectangle Rectangle
		{
			get;
			set;
		}


		/// <summary>
		/// Script name
		/// </summary>
		public string ScriptName
		{
			get;
			set;
		}


		/// <summary>
		/// Script handle
		/// </summary>
		//Script Script;


		/// <summary>
		/// 
		/// </summary>
		public string OnTeamEnterScript
		{
			get;
			set;
		}

		/// <summary>
		/// 
		/// </summary>
		public string OnTeamLeaveScript
		{
			get;
			set;
		}

		/// <summary>
		/// 
		/// </summary>
		public string OnMonsterEnterScript
		{
			get;
			set;
		}

		/// <summary>
		/// 
		/// </summary>
		public string OnMonsterLeaveScript
		{
			get;
			set;
		}


		/// <summary>
		/// 
		/// </summary>
		public string OnUpdateScript
		{
			get;
			set;
		}


		/// <summary>
		/// 
		/// </summary>
		public string OnDrawScript
		{
			get;
			set;
		}



		/// <summary>
		/// Hides the zone in the editor
		/// </summary>
		public bool Hide;

		#endregion
	}
}
