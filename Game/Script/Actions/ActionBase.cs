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
	/// Base class for actions in scripts
	/// </summary>
	public class ActionBase : IDisposable
	{
		/// <summary>
		/// 
		/// </summary>
		public ActionBase()
		{

		}


		/// <summary>
		/// 
		/// </summary>
		public virtual void Dispose()
		{
		}


		/// <summary>
		/// Run the script
		/// </summary>
		/// <returns>True on success</returns>
		public virtual bool Run()
		{
			return false;
		}


		#region IO


		/// <summary>
		/// Loads a party
		/// </summary>
		/// <param name="node">XmlNode handle</param>
		/// <returns>True if team successfuly loaded, otherwise false</returns>
		public virtual bool Load(XmlNode node)
		{
			if (node == null)
				return false;


			switch (node.Name)
			{
				case "target":
				{
					if (Target == null)
						Target = new DungeonLocation();

					Target.Load(node);
				}
				break;

				default:
				{
					Trace.WriteLine("[ActionBase] Load() : Unknown node \"" + node.Name + "\" found.");
				}
				break;
			}

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

			if (Target != null)
				Target.Save("target", writer);


			return true;
		}


		#endregion



		#region Properties

		/// <summary>
		/// Name of the action
		/// </summary>
		public string Name
		{
			get;
			protected set;
		}



		/// <summary>
		/// 
		/// </summary>
		public DungeonLocation Target
		{
			get;
			set;
		}

		#endregion
	}
}
