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
	/// Hit Point
	/// </summary>
	public class HitPoint
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public HitPoint() : this(0,0)
		{
		}

		/// <summary>
		/// Default constructor
		/// </summary>
		public HitPoint(int max) : this(max, max)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="current">Current</param>
		/// <param name="max">Maximum</param>
		public HitPoint(int current, int max)
		{
			Max = max;
			Current = current;

			if (Current > Max)
				Current = Max;
		}


		/// <summary>
		/// Adds a value to the curent HP
		/// </summary>
		/// <param name="amount"></param>
		public void Add(int amount)
		{
			Current += amount;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format("{0} / {1}", Current, Max);
		}


		#region IO

		/// <summary>
		/// Saves definition
		/// </summary>
		/// <param name="writer">WmlWriter handle</param>
		public bool Save(XmlWriter writer)
		{
			if (writer == null)
				return false;


			writer.WriteStartElement("hitpoint");
			writer.WriteAttributeString("current", Current.ToString());
			writer.WriteAttributeString("max", Max.ToString());
			writer.WriteEndElement();

			return true;
		}


		/// <summary>
		/// Loads
		/// </summary>
		/// <param name="xml">XmlNode handle</param>
		public bool Load(XmlNode xml)
		{
			if (xml == null)
				return false;

			if (xml.Name != "hitpoint")
				return false;

			Max = int.Parse(xml.Attributes["max"].Value);
			Current = int.Parse(xml.Attributes["current"].Value);



			return true;
		}

		#endregion


		#region Properties

		/// <summary>
		/// Current HP
		/// </summary>
		public int Current
		{
			get
			{
				return current;
			}
			set
			{
				current = value;
				current = Math.Min(current, Max);
			}
		}
		int current;

		/// <summary>
		/// Maximum HP
		/// </summary>
		public int Max
		{
			get;
			set;
		}

		/// <summary>
		/// Peril
		/// </summary>
		public int Peril
		{
			get
			{
				return Max / 2;
			}
		}


		/// <summary>
		/// Health ratio
		/// </summary>
		public float Ratio
		{
			get
			{
				return ((float) Current / (float) Max);
			}
		}


		#endregion

	}
}
