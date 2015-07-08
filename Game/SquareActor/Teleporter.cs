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
using System.Xml;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Graphic;

namespace DungeonEye
{
	/// <summary>
	/// Teleporter actor
	/// </summary>
	public class Teleporter : SquareActor
	{

		/// <summary>
		/// Constructor
		/// </summary>
		public Teleporter(Square block) : base(block)
		{
			if (block == null)
				throw new ArgumentNullException("block");

			AcceptItems = true;
			CanPassThrough = true;
			IsBlocking = false;

			TeleportTeam = true;
			TeleportMonsters = true;
			TeleportItems = true;
			IsVisible = true;


			Anim = ResourceManager.CreateAsset<Animation>("Teleporter");
			Anim.Play();
		}


		/// <summary>
		/// 
		/// </summary>
		public override void Dispose()
		{
			if (Anim != null)
				Anim.Dispose();
			Anim = null;
		}

		/// <summary>
		/// Update the teleporter
		/// </summary>
		/// <param name="time">Elapsed game time</param>
		public override void Update(GameTime time)
		{
			// Update animation
			if (Anim != null)
				Anim.Update(time);
		}


		/// <summary>
		/// Draw the door
		/// </summary>
		/// <param name="batch">Spritebatch to use</param>
		/// <param name="field">View field</param>
		/// <param name="position">Position in the view filed</param>
		/// <param name="view">Looking direction of the team</param>
		public override void Draw(SpriteBatch batch, ViewField field, ViewFieldPosition position, CardinalPoint direction)
		{
			if (!IsVisible)
				return;

			TileDrawing td = DisplayCoordinates.GetTeleporter(position);
			if (td == null)
				return;

			Anim.Draw(batch, td.Location, 0.0f, SpriteEffects.None,
				DisplayCoordinates.GetDistantColor(position), 
				DisplayCoordinates.GetMonsterScaleFactor(position));

		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("Teleporter (target " + Target + ")");

			return sb.ToString();
		}


		/// <summary>
		/// Get teleporter target
		/// </summary>
		/// <returns></returns>
		public override DungeonLocation[] GetTargets()
		{
			return new DungeonLocation[] { Target };
		}


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

			IsVisible = xml.Attributes["visible"] != null ? bool.Parse(xml.Attributes["visible"].Value) : false;
			TeleportTeam = xml.Attributes["team"] != null ? bool.Parse(xml.Attributes["team"].Value) : false;
			TeleportItems = xml.Attributes["items"] != null ? bool.Parse(xml.Attributes["items"].Value) : false;
			TeleportMonsters = xml.Attributes["monster"] != null ? bool.Parse(xml.Attributes["monster"].Value) : false;
			Reusable = xml.Attributes["resuable"] != null ? bool.Parse(xml.Attributes["reusable"].Value) : false;

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
		/// <param name="writer"></param>
		/// <returns></returns>
		public override bool Save(XmlWriter writer)
		{
			if (writer == null)
				return false;


			writer.WriteStartElement(Tag);
			writer.WriteAttributeString("team", TeleportTeam.ToString());
			writer.WriteAttributeString("monsters", TeleportMonsters.ToString());
			writer.WriteAttributeString("items", TeleportItems.ToString());
			writer.WriteAttributeString("visible", IsVisible.ToString());
			writer.WriteAttributeString("reusable", Reusable.ToString());

			if(Target != null)
				Target.Save("target", writer);

			base.Save(writer);

			writer.WriteEndElement();

			return true;
		}



		#endregion


		#region Script

		/// <summary>
		/// On team enter action
		/// </summary>
		/// <returns>True if team teleported</returns>
		public override bool OnTeamEnter()
		{
			if (!TeleportTeam || Target == null || !IsActivated)
				return false;

			// One shot ?
			IsActivated = Reusable;

			return GameScreen.Team.Teleport(Target);
		}


		/// <summary>
		/// On monster enter action
		/// </summary>
		/// <param name="monster">Monster handle</param>
		/// <returns>True on monster teleported</returns>
		public override bool OnMonsterEnter(Monster monster)
		{
			if (!TeleportMonsters || monster == null || Target == null)
				return false;

			monster.Teleport(Target);

			return true;
		}


		#endregion


		#region Properties

		/// <summary>
		/// Tag name
		/// </summary>
		public const string Tag = "teleporter";


		/// <summary>
		/// Name of the sound to play
		/// </summary>
		public string SoundName
		{
			get;
			set;
		}


		/// <summary>
		/// Silent teleporter
		/// </summary>
		public bool UseSound
		{
			get;
			set;
		}


		/// <summary>
		/// Does the teleport can be used more than once
		/// </summary>
		public bool Reusable
		{
			get;
			set;
		}


		/// <summary>
		/// Does the teleporter visible
		/// </summary>
		public bool IsVisible
		{
			get;
			set;
		}


		/// <summary>
		/// Can teleport monsters
		/// </summary>
		public bool TeleportMonsters
		{
			get;
			set;
		}


		/// <summary>
		/// Can teleport the team
		/// </summary>
		public bool TeleportTeam
		{
			get;
			set;
		}


		/// <summary>
		/// Can teleport items
		/// </summary>
		public bool TeleportItems
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


		/// <summary>
		/// Animation
		/// </summary>
		Animation Anim;

		#endregion


	}

}
