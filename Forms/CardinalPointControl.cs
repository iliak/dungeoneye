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
	/// Cardinal Point control
	/// </summary>
	public partial class CardinalPointControl : UserControl
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public CardinalPointControl()
		{
			InitializeComponent();
		}



		/// <summary>
		/// Update user interface
		/// </summary>
		void UpdateUI()
		{
			switch (Direction)
			{
				case CardinalPoint.North:
				{
					NorthBox.Checked = true;
					SouthBox.Checked = false;
					WestBox.Checked = false;
					EastBox.Checked = false;
				}
				break;
				case CardinalPoint.South:
				{
					NorthBox.Checked = false;
					SouthBox.Checked = true;
					WestBox.Checked = false;
					EastBox.Checked = false;
				}
				break;
				case CardinalPoint.West:
				{
					NorthBox.Checked = false;
					SouthBox.Checked = false;
					WestBox.Checked = true;
					EastBox.Checked = false;
				}
				break;
				case CardinalPoint.East:
				{
					NorthBox.Checked = false;
					SouthBox.Checked = false;
					WestBox.Checked = false;
					EastBox.Checked = true;
				}
				break;
			}
		}


		/// <summary>
		/// Highlight a direction
		/// </summary>
		/// <param name="side">Side</param>
		/// <param name="state">Sets to true to highlight</param>
		public void Highlight(CardinalPoint side, bool state)
		{
			CheckBox[] boxes = new CheckBox[]
			{
				NorthBox,
				SouthBox,
				WestBox,
				EastBox,
			};

			boxes[(int)side].ForeColor = state ? Color.Red : Color.Black;
		}


		/// <summary>
		/// Removes all highlight
		/// </summary>
		public void Reset()
		{
			Highlight(CardinalPoint.North, false);
			Highlight(CardinalPoint.South, false);
			Highlight(CardinalPoint.West, false);
			Highlight(CardinalPoint.East, false);
		}


		#region Form events


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NorthBox_CheckedChanged(object sender, EventArgs e)
		{
			if (!NorthBox.Checked)
				return;

			direction = CardinalPoint.North;
			UpdateUI();

			OnDirectionChanged(EventArgs.Empty);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EastBox_CheckedChanged(object sender, EventArgs e)
		{
			if (!EastBox.Checked)
				return;

			direction = CardinalPoint.East;
			UpdateUI();

			OnDirectionChanged(EventArgs.Empty);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WestBox_CheckedChanged(object sender, EventArgs e)
		{
			if (!WestBox.Checked)
				return;

			direction = CardinalPoint.West;
			UpdateUI();

			OnDirectionChanged(EventArgs.Empty);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SouthBox_CheckedChanged(object sender, EventArgs e)
		{
			if (!SouthBox.Checked)
				return;

			direction = CardinalPoint.South;
			UpdateUI();

			OnDirectionChanged(EventArgs.Empty);
		}


		#endregion


		#region Events

		/// <summary>
		/// Selected view position changer
		/// </summary>
		/// <param name="sender">Controler handle</param>
		/// <param name="position">Selected position</param>
		public delegate void ChangedEventHandler(object sender, CardinalPoint direction);


		/// <summary>
		/// 
		/// </summary>
		public event ChangedEventHandler DirectionChanged;


		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected virtual void OnDirectionChanged(EventArgs e)
		{
			if (DirectionChanged != null)
				DirectionChanged(this, Direction);
		}

		#endregion



		#region Properties


		/// <summary>
		/// Title of the control
		/// </summary>
		public string Title
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


		/// <summary>
		/// Current direction
		/// </summary>
		public CardinalPoint Direction
		{
			get
			{
				return direction;
			}
			set
			{
				direction = value;
				UpdateUI();

				OnDirectionChanged(EventArgs.Empty);
			}
		}
		CardinalPoint direction;


		#endregion

	}
}
