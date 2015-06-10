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
using System.Linq;
using System.Text;
using System.Xml;
using ArcEngine;
using DungeonEye.Script.Actions;

namespace DungeonEye.Script
{
	/// <summary>
	/// Abstract base class for event script actions
	/// </summary>
	public abstract class ScriptBase : IDisposable
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ScriptBase()
		{
		}


		/// <summary>
		/// 
		/// </summary>
		public virtual void Dispose()
		{
			if (Action != null)
				Action.Dispose();
			Action = null;
		}
	


		/// <summary>
		/// Run the script
		/// </summary>
		/// <returns>True on success</returns>
		public virtual bool Run()
		{
			if (Action != null)
				return Action.Run();
			
			return false;
		}


		#region IO


		/// <summary>
		/// Loads a party
		/// </summary>
		/// <param name="filename">Xml data</param>
		/// <returns>True if team successfuly loaded, otherwise false</returns>
		public virtual bool Load(XmlNode xml)
		{
			if (xml == null)
				return false;


			Action = null;

			switch (xml.Name)
			{
				case SpawnMonster.Tag:
				{
					Action = new SpawnMonster();
				}
				break;

				case EnableTarget.Tag:
				{
					Action = new EnableTarget();
				}
				break;

				case DisableTarget.Tag:
				{
					Action = new DisableTarget();
				}
				break;

				case ActivateTarget.Tag:
				{
					Action = new ActivateTarget();
				}
				break;

				case DeactivateTarget.Tag:
				{
					Action = new DeactivateTarget();
				}
				break;

				case ChangePicture.Tag:
				{
					Action = new ChangePicture();
				}
				break;

				case ChangeText.Tag:
				{
					Action = new ChangeText();
				}
				break;

				case DisableChoice.Tag:
				{
					Action = new DisableChoice();
				}
				break;

				case EnableChoice.Tag:
				{
					Action = new EnableChoice();
				}
				break;

				case EndChoice.Tag:
				{
					Action = new EndChoice();
				}
				break;

				case EndDialog.Tag:
				{
					Action = new EndDialog();
				}
				break;

				case GiveExperience.Tag:
				{
					Action = new GiveExperience();
				}
				break;

				case GiveItem.Tag:
				{
					Action = new GiveItem();
				}
				break;

				case Healing.Tag:
				{
					Action = new Healing();
				}
				break;

				case JoinCharacter.Tag:
				{
					Action = new JoinCharacter();
				}
				break;

				case PlaySound.Tag:
				{
					Action = new PlaySound();
				}
				break;

				case SetTo.Tag:
				{
					Action = new SetTo();
				}
				break;

				case Teleport.Tag:
				{
					Action = new Teleport();
				}
				break;

				case ToggleTarget.Tag:
				{
					Action = new ToggleTarget();
				}
				break;

				case DisplayMessage.Tag:
				{
					Action = new DisplayMessage();
				}
				break;

				default:
				{
					Trace.WriteLine("[ScriptBase] Load() : Unknown node \"" + xml.Name + "\" found.");
					return false;
				}
			}

			if (Action == null)
				return false;


			Action.Load(xml);

			return true;
		}


		/// <summary>
		/// Saves the party
		/// </summary>
		/// <param name="filename">XmlWriter</param>
		/// <returns></returns>
		public virtual bool Save(XmlWriter writer)
		{
			if (writer == null)
				return false;


			if (Action != null)
				Action.Save(writer);

			return true;
		}


		#endregion



		#region Properties

		/// <summary>
		/// Action to execute
		/// </summary>
		public ActionBase Action
		{
			get;
			set;
		}


		/// <summary>
		/// Dungeon handle
		/// </summary>
		public Dungeon Dungeon
		{
			get;
			private set;
		}

		#endregion

	}

}
