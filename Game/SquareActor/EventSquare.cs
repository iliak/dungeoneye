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
using DungeonEye.Script;

namespace DungeonEye
{
	/// <summary>
	/// Event Squares can be used for a variety of things such as displaying story information, npc dialog, quests...
	/// </summary>
	public class EventSquare : SquareActor
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="square">Square handle</param>
		public EventSquare(Square square) : base(square)
		{
			Choices = new List<ScriptChoice>();
			MessageColor = Color.White;
			Remaining = 1;
		}


		/// <summary>
		/// ToString
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return "Event";
		}


		/// <summary>
		/// Team enters the square
		/// </summary>
		/// <returns>True on success</returns>
		public override bool OnTeamEnter()
		{
			// No more usage possible
			if (Remaining == 0)
				return false;

			Hero hero = null;

			// Check if a hero detect the event
			foreach (Hero h in GameScreen.Team.Heroes)
			{
				//if (hero.SavingThrow(SavingThrowType.Will) > Dice.GetD20(1))
				if (h != null && h.SavingThrow(SavingThrowType.Will) > Intelligence)
				{
					hero = h;
					break;
				}
			}

			// No one is able to detect the event
			if (hero == null)
				return false;

			// Display message
			if (!string.IsNullOrEmpty(Message))
				GameMessage.AddMessage(hero.Name + ": " + Message, MessageColor);

			// Create the scripted dialog if there's a picture to show
			if (!string.IsNullOrEmpty(PictureName))
				GameScreen.Dialog = new ScriptedDialog(Square, this);


			// Decrement usage
			if (Remaining > 0)
				Remaining--;

			return true;
		}


		#region IO

		/// <summary>
		/// Loads the door's definition from a bank
		/// </summary>
		/// <param name="xml">Xml handle</param>
		/// <returns></returns>
		public override bool Load(XmlNode xml)
		{
			if (xml == null || xml.Name != Tag)
				return false;


			foreach (XmlNode node in xml)
			{
				if (node.NodeType == XmlNodeType.Comment)
					continue;


				switch (node.Name.ToLower())
				{
					case "choice":
					{
						ScriptChoice choice = new ScriptChoice("");
						choice.Load(node);
						Choices.Add(choice);
					}
					break;

					case "messagecolor":
					{
						MessageColor = Color.FromArgb(int.Parse(node.Attributes["value"].Value));
					}
					break;

					case "mustface":
					{
						MustFace = Boolean.Parse(node.Attributes["value"].Value);
					}
					break;

					case "direction":
					{
						Direction = (CardinalPoint) Enum.Parse(typeof(CardinalPoint), node.Attributes["value"].Value);
					}
					break;

					case "soundname":
					{
						SoundName = node.Attributes["value"].Value;
					}
					break;

					case "loopsound":
					{
						LoopSound = Boolean.Parse(node.Attributes["value"].Value);
					}
					break;

					case "displayborder":
					{
						DisplayBorder = Boolean.Parse(node.Attributes["value"].Value);
					}
					break;

					case "message":
					{
						Message = node.Attributes["value"].Value;
					}
					break;

					case "picturename":
					{
						PictureName = node.Attributes["value"].Value;
					}
					break;

					case "intelligence":
					{
						Intelligence = int.Parse(node.Attributes["value"].Value);
					}
					break;

					case "remaining":
					{
						Remaining = int.Parse(node.Attributes["value"].Value);
					}
					break;

					case "text":
					{
						Text = node.InnerText;
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
		/// Saves the door definition
		/// </summary>
		/// <param name="writer">XML writer handle</param>
		/// <returns></returns>
		public override bool Save(XmlWriter writer)
		{
			if (writer == null)
				return false;


			writer.WriteStartElement(Tag);

			
			writer.WriteAttributeString("color", MessageColor.ToArgb().ToString());
			writer.WriteAttributeString("mustface", MustFace.ToString());
			writer.WriteAttributeString("direction", Direction.ToString());
			writer.WriteAttributeString("remaining", Remaining.ToString());
			writer.WriteAttributeString("soundname", SoundName);
			writer.WriteAttributeString("loopsound", LoopSound.ToString());
			writer.WriteAttributeString("displayborder", DisplayBorder.ToString());
			writer.WriteAttributeString("intelligence", Intelligence.ToString());
			writer.WriteAttributeString("message", Message);
			writer.WriteAttributeString("picturename", PictureName);

			// 
			writer.WriteStartElement("text");
			writer.WriteString(Text);
			writer.WriteEndElement();



			foreach (ScriptChoice choice in Choices)
				choice.Save(writer);


			base.Save(writer);
			writer.WriteEndElement();

			return true;
		}

		#endregion


		#region Properties

		/// <summary>
		/// 
		/// </summary>
		public const string Tag = "eventsquare";


		/// <summary>
		/// Team must face a direction
		/// </summary>
		public bool MustFace
		{
			get;
			set;
		}


		/// <summary>
		/// Number of usage remaining
		/// </summary>
		/// <remarks>-1 means infinite usage</remarks>
		public int Remaining
		{
			get;
			set;
		}


		/// <summary>
		/// Message color
		/// </summary>
		public Color MessageColor
		{
			get;
			set;
		}


		/// <summary>
		/// Direction Team must face to trigger
		/// </summary>
		public CardinalPoint Direction
		{
			get;
			set;
		}


		/// <summary>
		/// Initial text to display
		/// </summary>
		public string Text
		{
			get;
			set;
		}


		/// <summary>
		/// Gets or sets the sound name
		/// </summary>
		public string SoundName
		{
			get;
			set;
		}


		/// <summary>
		/// Loop sound
		/// </summary>
		public bool LoopSound
		{
			get;
			set;
		}


		/// <summary>
		/// Gets or sets the background
		/// </summary>
		public bool DisplayBorder
		{
			get;
			set;
		}


		/// <summary>
		/// Gets or sets the minimum intelligence needed to trigger the event
		/// </summary>
		public int Intelligence
		{
			get;
			set;
		}


		/// <summary>
		/// Message to display
		/// </summary>
		public string Message
		{
			get;
			set;
		}


		/// <summary>
		/// Gets or sets the picture name
		/// </summary>
		public string PictureName
		{
			get;
			set;
		}


		/// <summary>
		/// Available choices
		/// </summary>
		public List<ScriptChoice> Choices
		{
			get;
			private set;
		}

		/*
				/// <summary>
				/// Current event
				/// </summary>
				public Event CurrentEvent
				{
					get;
					protected set;
				}


				/// <summary>
				/// Available events
				/// </summary>
				List<Event> Events;
		*/
		#endregion

	}
}
