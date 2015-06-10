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
using System.Drawing;
using System.Xml;
using ArcEngine.Graphic;
using ArcEngine;
using DungeonEye.Script;


namespace DungeonEye
{
	/// <summary>
	/// Control how many switches are necessary to trigger an event
	/// </summary>
	public class SwitchCount
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public SwitchCount() : this(1, 0)
		{
		}


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="target">Target value</param>
		/// <param name="count">Current count</param>
		public SwitchCount(int target, int count)
		{
			Count = count;
			Target = target;

		}



		/// <summary>
		/// Activate
		/// </summary>
		/// <returns>True if the count is equals to the target</returns>
		public bool Activate()
		{
			Count++;

			// Reset count
			if (Count >= Target && ResetOnTrigger)
			{
				Count = 0;
				return true;
			}

			return Count == Target;
		}



		/// <summary>
		/// Deactivate
		/// </summary>
		/// <returns>True if the count is equals to 0</returns>
		public bool Deactivate()
		{
			Count--;

			if (Count < 0)
				Count = 0;

			return Count == 0;
		}



		#region I/O


		/// <summary>
		/// 
		/// </summary>
		/// <param name="node">Xml node</param>
		/// <returns></returns>
		public bool Load(XmlNode xml)
		{
			if (xml == null)
				return false;

			Target = int.Parse(xml.Attributes["target"].Value);
			Count = int.Parse(xml.Attributes["count"].Value);
			ResetOnTrigger = bool.Parse(xml.Attributes["reset"].Value);


			return true;
		}


		/// <summary>
		/// Saves location
		/// </summary>
		/// <param name="name">Node's name</param>
		/// <param name="writer">XmlWriter handle</param>
		/// <returns></returns>
		public bool Save(string name, XmlWriter writer)
		{
			if (writer == null || string.IsNullOrEmpty(name))
				return false;



			writer.WriteStartElement(name);
			writer.WriteAttributeString("target", Target.ToString());
			writer.WriteAttributeString("count", Count.ToString());
			writer.WriteAttributeString("reset", ResetOnTrigger.ToString());
			writer.WriteEndElement();

			return true;
		}



		#endregion



		#region Properties


		/// <summary>
		/// Number to reach to fire an event
		/// </summary>
		public int Target
		{
			get;
			set;
		}


		/// <summary>
		/// The number of time the switch was activated
		/// </summary>
		public int Count
		{
			get;
			set;
		}


		/// <summary>
		/// If true, the switch count will be reset after triggering so that again 
		/// the specified number of switch activations will be necessary. 
		/// Otherwise, every further switch activation will again trigger.
		/// </summary>
		public bool ResetOnTrigger
		{
			get;
			set;
		}



		/// <summary>
		/// 
		/// </summary>
		public bool IsUsable
		{
			get
			{
				return Count >= Target;
			}
		}
		#endregion

	}
}
