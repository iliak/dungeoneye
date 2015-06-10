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
	/// Gives experience to the team
	/// </summary>
	public partial class GiveExperienceControl : ActionBaseControl
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="script"></param>
		public GiveExperienceControl(GiveExperience script)
		{
			InitializeComponent();


			if (script != null)
				Action = script;
			else
				Action = new GiveExperience();

			UpdateUI();
		}


		/// <summary>
		/// Updates user interface
		/// </summary>
		void UpdateUI()
		{
			GiveExperience script = Action as GiveExperience;
			if (script == null)
				return;

			AmountBox.Value = script.Amount;
		}


		#region Events


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AmountBox_ValueChanged(object sender, EventArgs e)
		{
			(Action as GiveExperience).Amount = (int)AmountBox.Value;
		}

		#endregion


		#region Properties


		#endregion
	}
}
