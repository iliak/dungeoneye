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
using ArcEngine;
using System.Xml;


namespace DungeonEye.Script.Actions
{
	/// <summary>
	/// Changes the picture of the dialog
	/// </summary>
	public class ChangePicture : ActionBase
	{

		/// <summary>
		/// 
		/// </summary>
		public ChangePicture()
		{
			Name = Tag;
		}

		/// <summary>
		/// Run actions
		/// </summary>
		/// <returns></returns>
		public override bool Run()
		{

			return false;
		}


		#region IO


		/// <summary>
		/// Loads a party
		/// </summary>
		/// <param name="filename">Xml data</param>
		/// <returns>True if team successfuly loaded, otherwise false</returns>
		public override bool Load(XmlNode xml)
		{
			return true;
		}



		/// <summary>
		/// Saves the party
		/// </summary>
		/// <param name="filename">XmlWriter</param>
		/// <returns></returns>
		public override bool Save(XmlWriter writer)
		{
			return true;
		}


		#endregion



		#region Properties


		/// <summary>
		/// 
		/// </summary>
		public const string Tag = "ChangePicture";


		#endregion
	}
}
