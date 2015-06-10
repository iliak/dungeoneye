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
using System.Text;
using System.Xml;



namespace DungeonEye
{
	/// <summary>
	/// An ability partially describes an entity and affects some of his or her actions. 
	/// http://www.dandwiki.com/wiki/SRD:Ability_Scores
	/// </summary>
	public class Ability
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public Ability() : this(0)
		{

		}


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="value">Value</param>
		public Ability(int value)
		{
			Value = value;
		}


		#region IO


		/// <summary>
		/// Loads properties
		/// </summary>
		/// <param name="node">Node</param>
		/// <returns></returns>
		public bool Load(XmlNode node)
		{
			if (node == null || node.NodeType != XmlNodeType.Element)
				return false;


			if (node.Attributes["value"] != null)
				Value = int.Parse(node.Attributes["value"].Value);

			return true;
		}



		/// <summary>
		/// Saves properties
		/// </summary>
		/// <param name="name">Name for the node</param>
		/// <param name="writer">XmlWriter</param>
		/// <returns>True if saved</returns>
		public bool Save(string name, XmlWriter writer)
		{
			if (writer == null || string.IsNullOrEmpty(name))
				return false;

			writer.WriteStartElement(name);
			writer.WriteAttributeString("value", Value.ToString());
			writer.WriteEndElement();

			return true;
		}

		#endregion


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format("{0} (mod {1})", Value, Modifier);
		}


		#region Properties


		/// <summary>
		/// Value
		/// </summary>
		public int Value
		{
			get;
			set;
		}


		/// <summary>
		/// A positive modifier is called a bonus, and a negative modifier is called a penalty. 
		/// </summary>
		public int Modifier
		{
			get
			{
				return (Value - 10) / 2;
			}
		}


		#endregion
	}
}
