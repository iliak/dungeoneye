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

namespace DungeonEye.Forms
{
	/// <summary>
	/// Ability control
	/// </summary>
	public partial class AbilityControl : UserControl
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public AbilityControl()
		{
			InitializeComponent();
		}



		/// <summary>
		/// Rebuild interface
		/// </summary>
		void Rebuild()
		{
			if (Ability == null)
			{
				AbilityBox.Value = 0;
				ModifierBox.Text = "0";
			}
			else
			{
				AbilityBox.Value = Ability.Value;
			}
		}



		#region Events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AbilityBox_ValueChanged(object sender, EventArgs e)
		{
			if (Ability == null)
				return;

			Ability.Value = (int)AbilityBox.Value;
			ModifierBox.Text = Ability.Modifier.ToString();
		}

		#endregion


		#region Properties


		/// <summary>
		/// Ability title
		/// </summary>
		public string Title
		{
			get
			{
				return TitleBox.Text;
			}
			set
			{
				TitleBox.Text = value;
			}
		}


		/// <summary>
		/// Ability
		/// </summary>
		public Ability Ability
		{
			get
			{
				return ability;
			}
			set
			{
				ability = value;
				Rebuild();
			}
		}
		Ability ability;

		#endregion


	}

}
