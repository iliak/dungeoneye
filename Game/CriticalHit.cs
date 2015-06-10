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
	/// A hit that strikes a vital area and therefore deals double damage or more.
	/// http://nwn.wikia.com/wiki/Critical_hit
	/// </summary>
	public class CriticalHit
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public CriticalHit()
		{
			Minimum = 20;
			Maximum = 20;
			Multiplier = 2;
		}


		/// <summary>
		/// Is a critical hit
		/// </summary>
		/// <param name="value">Attack roll value</param>
		/// <returns></returns>
		public bool IsCriticalHit(int value)
		{
			return value >= Minimum && value <= Maximum;
		}


		/// <summary>
		/// ToString
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format("{0}-{1}(x{2})", Minimum, Maximum, Multiplier); 
		}


		#region IO


		/// <summary>
		/// Loads properties
		/// </summary>
		/// <param name="node">Node</param>
		/// <returns></returns>
		public bool Load(XmlNode node)
		{
			if (node == null)
				return false;

			if (node.NodeType != XmlNodeType.Element)
				return false;


			if (node.Attributes["minimum"] != null)
				Minimum = int.Parse(node.Attributes["minimum"].Value);

			if (node.Attributes["maximum"] != null)
				Maximum = int.Parse(node.Attributes["maximum"].Value);

			if (node.Attributes["multiplier"] != null)
				Multiplier = int.Parse(node.Attributes["multiplier"].Value);

			return true;
		}



		/// <summary>
		/// Saves properties
		/// </summary>
		/// <param name="writer">XmlWriter</param>
		public void Save(XmlWriter writer)
		{
			if (writer == null)
				return;

			bool writeheader = false;
			if (writer.WriteState != WriteState.Element)
				writeheader = true;

			if (writeheader)
				writer.WriteStartElement("criticalhit");
			writer.WriteAttributeString("minimum", Minimum.ToString());
			writer.WriteAttributeString("maximum", Maximum.ToString());
			writer.WriteAttributeString("multiplier", Multiplier.ToString());
			if (writeheader)
				writer.WriteEndElement();
		}

		#endregion


		#region Properties

		/// <summary>
		/// Minimum threat
		/// </summary>
		public int Minimum
		{
			get;
			set;
		}

		/// <summary>
		/// Maximum threat
		/// </summary>
		public int Maximum
		{
			get;
			set;
		}


		/// <summary>
		/// Multiplier
		/// </summary>
		public int Multiplier
		{
			get;
			set;
		}

		#endregion

	}
}
