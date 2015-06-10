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
using System.Text;
using System.Windows.Forms;

namespace DungeonEye.Forms
{
	/// <summary>
	/// Dice control form
	/// </summary>
	public partial class DiceControl : UserControl
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public DiceControl()
		{
			InitializeComponent();


			CalculateMinMax();
		}



		/// <summary>
		/// 
		/// </summary>
		void CalculateMinMax()
		{
			MinimumBox.Text = Dice.Minimum.ToString();
			MaximumBox.Text = Dice.Maximum.ToString();
		}


		#region Events

		public event EventHandler ValueChanged;


		#endregion


		#region Form events


		/// <summary>
		/// On value changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnValueChanged(object sender, EventArgs e)
		{
			CalculateMinMax();

			if (ValueChanged != null)
				ValueChanged(this, null);
		}

		#endregion


		#region Properties

		/// <summary>
		/// Dice
		/// </summary>
		public Dice Dice
		{
			get
			{
				return new Dice((int)ThrowBox.Value, (int)FacesBox.Value, (int)BaseBox.Value);
			}
			set
			{
				if (value == null)
					return;
				BaseBox.Value = value.Modifier;
				FacesBox.Value = value.Faces;
				ThrowBox.Value = value.Throws;
			}
		}


		/// <summary>
		/// Text to display
		/// </summary>
		public string ControlText
		{
			get
			{
				return groupBox1.Text;
			}
			set
			{
				groupBox1.Text = value;
			}
		}

		#endregion

	}
}
