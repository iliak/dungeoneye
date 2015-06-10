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
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DungeonEye.Script.Actions;
using DungeonEye.Script;


namespace DungeonEye.Forms
{
	/// <summary>
	/// Script action control base
	/// </summary>
	public partial class ActionBaseControl : UserControl
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ActionBaseControl()
		{
			InitializeComponent();
		}




		#region Properties


		/// <summary>
		/// Action to execute
		/// </summary>
		public ActionBase Action
		{
			get;
			protected set;
		}



		#endregion
	}
}
