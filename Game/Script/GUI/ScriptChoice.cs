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
using System.Xml;
using System.Text;
using ArcEngine;
using System.Drawing;
using DungeonEye.Script.Actions;


namespace DungeonEye.Script
{
	/// <summary>
	/// Provides interaction in event dialogs
	/// </summary>
	public class ScriptChoice
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="name">Choice's name</param>
		public ScriptChoice(string name)
		{
			Actions = new List<ActionBase>();

			Name = name;
			Enabled = true;
		}


		/// <summary>
		/// Run each action
		/// </summary>
		/// <param name="team">Team handle</param>
		public void Run()
		{
			foreach (ActionBase action in Actions)
				action.Run();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return Name + " - " + Text + " <" + Actions.Count + "> action(s)";
		}


		#region IO


		/// <summary>
		/// Loads a party
		/// </summary>
		/// <param name="filename">Xml data</param>
		/// <returns>True if team successfuly loaded, otherwise false</returns>
		public bool Load(XmlNode xml)
		{
			if (xml == null || xml.Name.ToLower() != "choice")
				return false;

			Name = xml.Attributes["name"].Value;

			foreach (XmlNode node in xml)
			{
				if (node.NodeType == XmlNodeType.Comment)
					continue;


				switch (node.Name.ToLower())
				{
					case "actions":
					{
						LoadActions(node);
					}
					break;
				
					default:
					{
						Trace.WriteLine("[ScriptChoice] Load() : Unknown node \"{0}\"", node.Name);
					}
					break;
				}
			}


			return true;
		}


		/// <summary>
		/// Loads actions
		/// </summary>
		/// <param name="filename">Xml node</param>
		public void LoadActions(XmlNode xml)
		{
			if (xml == null || xml.Name.ToLower() != "actions")
				return;

			foreach (XmlNode node in xml)
			{
				if (node.NodeType == XmlNodeType.Comment)
					continue;


				switch (node.Name.ToLower())
				{
					case "teleport":
					{
						Teleport teleport = new Teleport();
						teleport.Load(node);
						Actions.Add(teleport);
					}
					break;

					case "giveexperience":
					{
						GiveExperience script = new GiveExperience();
						script.Load(node);
						Actions.Add(script);
					}
					break;

					case "activate":
					{
						ActivateTarget script = new ActivateTarget();
						script.Load(node);
						Actions.Add(script);
					}
					break;

					case "changepicture":
					{
						ChangePicture script = new ChangePicture();
						script.Load(node);
						Actions.Add(script);
					}
					break;

					case "changetext":
					{
						ChangeText script = new ChangeText();
						script.Load(node);
						Actions.Add(script);
					}
					break;

					case "deactivate":
					{
						DeactivateTarget script = new DeactivateTarget();
						script.Load(node);
						Actions.Add(script);
					}
					break;

					case "disablechoice":
					{
						DisableChoice script = new DisableChoice();
						script.Load(node);
						Actions.Add(script);
					}
					break;

					case "disable":
					{
						DisableTarget script = new DisableTarget();
						script.Load(node);
						Actions.Add(script);
					}
					break;

					case "enablechoice":
					{
						EnableChoice script = new EnableChoice();
						script.Load(node);
						Actions.Add(script);
					}
					break;

					case "endchoice":
					{
						EndChoice script = new EndChoice();
						script.Load(node);
						Actions.Add(script);
					}
					break;

					case "enddialog":
					{
						EndDialog script = new EndDialog();
						script.Load(node);
						Actions.Add(script);
					}
					break;

					case "giveitem":
					{
						GiveItem script = new GiveItem();
						script.Load(node);
						Actions.Add(script);
					}
					break;

					case "healing":
					{
						Healing script = new Healing();
						script.Load(node);
						Actions.Add(script);
					}
					break;

					case "joincharacter":
					{
						JoinCharacter script = new JoinCharacter();
						script.Load(node);
						Actions.Add(script);
					}
					break;

					case "playsound":
					{
						PlaySound script = new PlaySound();
						script.Load(node);
						Actions.Add(script);
					}
					break;

					case "toggle":
					{
						ToggleTarget script = new ToggleTarget();
						script.Load(node);
						Actions.Add(script);
					}
					break;

					default:
					{
						Trace.WriteLine("[ScriptChoice] LoadActions() : Unknown node \"{0}\"", node.Name);
					}
					break;
				}
			}

		}


		/// <summary>
		/// Saves the party
		/// </summary>
		/// <param name="filename">XmlWriter</param>
		/// <returns></returns>
		public bool Save(XmlWriter writer)
		{
			if (writer == null)
				return false;

			writer.WriteStartElement("choice");
			writer.WriteAttributeString("name", Name);

			writer.WriteStartElement("actions");
			foreach (ActionBase action in Actions)
			{
				action.Save(writer);
			}
			writer.WriteEndElement();

			writer.WriteEndElement();

			return false;
		}


		#endregion


		#region Properties

		/// <summary>
		/// List of actions
		/// </summary>
		public List<ActionBase> Actions
		{
			get;
			private set;
		}


		/// <summary>
		/// Choice enabled
		/// </summary>
		public bool Enabled
		{
			get;
			set;
		}


		/// <summary>
		/// Name of the choice
		/// </summary>
		public string Name
		{
			get;
			set;
		}

		/// <summary>
		/// Text of the choice
		/// </summary>
		public string Text
		{
			get;
			set;
		}

		#endregion
	}
}
