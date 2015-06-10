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
using ArcEngine.Graphic;
using ArcEngine.Input;
using DungeonEye.Gui;

namespace DungeonEye.Script
{
	/// <summary>
	/// PressurePlate script
	/// </summary>
	public class PressurePlateScript : ScriptBase
	{

		/// <summary>
		/// 
		/// </summary>
		public PressurePlateScript()
		{
			Condition = PressurcePlateCondition.Always;
		}




		#region IO

		/// <summary>
		/// 
		/// </summary>
		/// <param name="xml"></param>
		/// <returns></returns>
		public override bool Load(XmlNode xml)
		{
			if (xml == null)
				return false;


			foreach (XmlNode node in xml)
			{
				switch (node.Name)
				{

					case "condition":
					{
						Condition = (PressurcePlateCondition) Enum.Parse(typeof(PressurcePlateCondition), node.InnerText);
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

			writer.WriteStartElement(XmlTag);

			writer.WriteElementString("condition", Condition.ToString());

			base.Save(writer);

			writer.WriteEndElement();
			return true;
		}

		#endregion



		#region Properties

		/// <summary>
		/// 
		/// </summary>
		public const string XmlTag = "PressurePlateScript";


		/// <summary>
		/// Condition of the script
		/// </summary>
		public PressurcePlateCondition Condition
		{
			get;
			set;
		}

		#endregion
	}


	/// <summary>
	/// PressurePlate activation conditions
	/// </summary>
	[Flags]
	public enum PressurcePlateCondition : byte
	{

		/// <summary>
		/// Everything triggers the switch.
		/// </summary>
		Always = OnTeam | OnMonster | OnItem,

		/// <summary>
		/// On team, monsters or items stepping on the switch will activate it
		/// </summary>
		OnEnter = OnTeamEnter | OnMonsterEnter | OnItemAdded,

		/// <summary>
		/// On team, monsters or items stepping off the switch will activate it
		/// </summary>
		OnLeave = OnTeamLeave | OnMonsterLeave | OnItemRemoved,


		/// <summary>
		/// On team stepping on or off the switch will activate it
		/// </summary>
		OnTeam = OnTeamEnter | OnTeamLeave,

		/// <summary>
		/// On team stepping on the switch will activate it
		/// </summary>
		OnTeamEnter = 0x01,

		/// <summary>
		/// On team stepping off the switch will activate it
		/// </summary>
		OnTeamLeave = 0x02,


		/// <summary>
		/// On monsters stepping on or off the switch will activate it
		/// </summary>
		OnMonster = OnMonsterEnter | OnMonsterLeave,

		/// <summary>
		/// On monsters stepping on the switch will activate it
		/// </summary>
		OnMonsterEnter = 0x04,

		/// <summary>
		/// On monsters stepping off the switch will activate it
		/// </summary>
		OnMonsterLeave = 0x08,


		/// <summary>
		/// On item adding or removing, the switch will activate it
		/// </summary>
		OnItem = OnItemAdded | OnItemRemoved,

		/// <summary>
		/// On item adding, the switch will activate it
		/// </summary>
		OnItemAdded = 0x10,

		/// <summary>
		/// On item removing, the switch will activate it
		/// </summary>
		OnItemRemoved = 0x20,



		/// <summary>
		/// On team or monsters stepping on or off the switch will activate it
		/// </summary>
		OnEntity = OnTeam | OnMonster,

		/// <summary>
		/// On team or monsters stepping on the switch will activate it
		/// </summary>
		OnEntityEnter = OnTeamEnter | OnMonsterEnter,

		/// <summary>
		/// On team or monsters stepping off the switch will activate it
		/// </summary>
		OnEntityLeave = OnTeamLeave | OnMonsterLeave,


	}

}
