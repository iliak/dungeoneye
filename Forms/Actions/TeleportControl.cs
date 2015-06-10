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

namespace DungeonEye.Forms
{
	/// <summary>
	/// 
	/// </summary>
	public partial class TeleportControl : ActionBaseControl
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="script"></param>
		/// <param name="dungeon"></param>
		public TeleportControl(Teleport script, Dungeon dungeon)
		{
			InitializeComponent();


			if (script != null)
				Action = script;
			else
				Action = new Teleport();

			TargetBox.Dungeon = dungeon;
			TargetBox.SetTarget(((Teleport)Action).Target);

			TargetBox.TargetChanged +=new TargetControl.TargetChangedEventHandler(TargetBox_TargetChanged);
			
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		void TargetBox_TargetChanged(object sender, DungeonLocation target)
		{
			((Teleport) Action).Target = target;
		}


		#region Events



		#endregion



		#region Properties

		/// <summary>
		/// Target location
		/// </summary>
		public DungeonLocation Target
		{
			get;
			private set;
		}

		#endregion

	}
}
