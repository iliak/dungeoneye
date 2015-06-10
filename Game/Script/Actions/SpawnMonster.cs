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
using ArcEngine.Graphic;
using ArcEngine.Input;
using DungeonEye.Gui;


namespace DungeonEye.Script.Actions
{
	/// <summary>
	/// Spawn a monster
	/// </summary>
	public class SpawnMonster : ActionBase
	{

		/// <summary>
		/// Constructor
		/// </summary>
		public SpawnMonster()
		{
			Name = Tag;
		}


		/// <summary>
		/// Runs the script
		/// </summary>
		/// <returns>True on success</returns>
		public override bool Run()
		{
			if (Target == null || string.IsNullOrEmpty(MonsterName))
				return false;

			// Spawn the monster
			Monster monster = ResourceManager.CreateAsset<Monster>(MonsterName);
			if (monster == null)
				return false;

			monster.Teleport(Target);
			monster.OnSpawn();

			return true;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string str = "Spawn monster \"" + MonsterName + "\" at ";

			if (Target != null)
				str += Target.ToStringShort();

			return str;
		}


		#region IO

		/// <summary>
		/// 
		/// </summary>
		/// <param name="xml"></param>
		/// <returns></returns>
		public override bool Load(XmlNode xml)
		{
			if (xml == null || xml.Name != Tag)
				return false;

			if (xml.Attributes["name"] != null)
				MonsterName = xml.Attributes["name"].Value;

			base.Load(xml.FirstChild);

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

			writer.WriteAttributeString("name", MonsterName);


			base.Save(writer);

			writer.WriteEndElement();

			return true;
		}


		#endregion



		#region Properties


		/// <summary>
		/// Xml Tag
		/// </summary>
		public const string Tag = "SpawnMonster";


		/// <summary>
		/// Monster name
		/// </summary>
		public string MonsterName
		{
			get;
			set;
		}


		#endregion
	}
}
