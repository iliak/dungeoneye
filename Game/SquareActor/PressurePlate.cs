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
using System.Drawing;
using System.Text;
using System.Xml;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Graphic;
using DungeonEye.Script;
using DungeonEye.Script.Actions;

namespace DungeonEye
{
	/// <summary>
	/// Floor switch
	/// </summary>
	public class PressurePlate : SquareActor
	{

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="square">Square handle</param>
		public PressurePlate(Square square) : base(square)
		{
			Scripts = new List<PressurePlateScript>();
			AcceptItems = true;
			CanPassThrough = true;
			IsBlocking = false;
			Reusable = true;
			WasUsed = false;
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

			TileDrawing td = DisplayCoordinates.GetFloorPlate(position);
			if (td == null)
				return;

			Decoration.Draw(batch, DecorationPrimary, position);
		}




		/// <summary>
		/// Runs scripts
		/// </summary>
		/// <param name="condition">Condtion</param>
		void RunScript(PressurcePlateCondition condition)
		{
			// Not activated
			if (!IsEnabled)
				return;

			// Already used
			if (!Reusable && WasUsed)
				return;

			foreach (PressurePlateScript script in Scripts)
			{
				if ((script.Condition & condition) == condition)
					script.Run();
			}

			WasUsed = true;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("Pressure plate (");


			if (IsHidden)
				sb.Append("Hidden. ");


			sb.Append(")");
			return sb.ToString();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override DungeonLocation[] GetTargets()
		{
			List<DungeonLocation> list = new List<DungeonLocation>();

			foreach (PressurePlateScript script in Scripts)
				if (script.Action != null && script.Action.Target != null)
					list.Add(script.Action.Target);

			return list.ToArray();
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
			Reusable = xml.Attributes["reusable"] != null ? bool.Parse(xml.Attributes["reusable"].Value) : false;
			WasUsed = xml.Attributes["used"] != null ? bool.Parse(xml.Attributes["used"].Value) : false;
			DecorationPrimary = xml.Attributes["primary"] != null ? int.Parse(xml.Attributes["primary"].Value) : -1;
			DecorationSecondary = xml.Attributes["secondary"] != null ? int.Parse(xml.Attributes["secondary"].Value) : -1;

			foreach (XmlNode node in xml)
			{
				switch (node.Name.ToLower())
				{
					case "scripts":
					{
						foreach (XmlNode sub in node)
						{
							PressurePlateScript script = new PressurePlateScript();
							script.Load(sub);
							Scripts.Add(script);
						}
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


			writer.WriteAttributeString("hidden", IsHidden.ToString());
			writer.WriteAttributeString("reusable", Reusable.ToString());
			writer.WriteAttributeString("used", WasUsed.ToString());
			writer.WriteAttributeString("primary", DecorationPrimary.ToString());
			writer.WriteAttributeString("secondary", DecorationSecondary.ToString());

			if (Scripts.Count > 0)
			{
				writer.WriteStartElement("scripts");
				foreach (PressurePlateScript script in Scripts)
					script.Save(writer);
				writer.WriteEndElement();
			}

			base.Save(writer);
			writer.WriteEndElement();

			return true;
		}



		#endregion


		#region Triggers

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override bool OnTeamEnter()
		{
			RunScript(PressurcePlateCondition.OnTeamEnter);

			return false;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="monster"></param>
		/// <returns></returns>
		public override bool OnMonsterEnter(Monster monster)
		{
			RunScript(PressurcePlateCondition.OnMonsterEnter);
			return false;
		}


		/// <summary>
		/// Team is leaving the pressure plate
		/// </summary>
		public override bool OnTeamLeave()
		{
			RunScript(PressurcePlateCondition.OnTeamLeave);
			return false;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="monster"></param>
		public override bool OnMonsterLeave(Monster monster)
		{
			RunScript(PressurcePlateCondition.OnMonsterLeave);
			return false;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		public override bool OnItemCollected(Item item)
		{
			RunScript(PressurcePlateCondition.OnItemRemoved);
			return false;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		public override bool OnItemDropped(Item item)
		{
			RunScript(PressurcePlateCondition.OnItemAdded);

			return false;
		}


		#endregion


		#region Properties

		/// <summary>
		/// 
		/// </summary>
		public const string Tag = "pressureplate";


		/// <summary>
		/// Defines if the switch can be used repeatedly. 
		/// Otherwise, after one use, the switch will no longer function.
		/// </summary>
		public bool Reusable
		{
			get;
			set;
		}


		/// <summary>
		/// Switch is already used
		/// </summary>
		public bool WasUsed
		{
			get;
			set;
		}


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
		/// Decoration ID for primary state
		/// </summary>
		public int DecorationPrimary
		{
			get;
			set;
		}

		/// <summary>
		/// Decoration ID for secondary state
		/// </summary>
		public int DecorationSecondary
		{
			get;
			set;
		}

		/// <summary>
		/// Is the floor plate visible
		/// </summary>
		public bool IsHidden
		{
			get;
			set;
		}


		/// <summary>
		/// Scripts
		/// </summary>
		public List<PressurePlateScript> Scripts
		{
			get;
			private set;
		}
		#endregion

	}
}
