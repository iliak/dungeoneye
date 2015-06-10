using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DungeonEye;


namespace DungeonEye.Forms
{
	/// <summary>
	/// HitPoint control
	/// </summary>
	public partial class HitPointControl : UserControl
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public HitPointControl()
		{
			InitializeComponent();
		}


		#region Events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MaxBox_ValueChanged(object sender, EventArgs e)
		{
			if (HitPoint == null)
				return;

			if (HP.Current == HP.Max)
				CurrentBox.Value = (int)MaxBox.Value;

			HP.Max = (int)MaxBox.Value;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CurrentBox_ValueChanged(object sender, EventArgs e)
		{
			if (CurrentBox.Value > MaxBox.Value)
				CurrentBox.Value = MaxBox.Value;

			if (HitPoint != null)
				HP.Current = (int)CurrentBox.Value;
		}

		#endregion


		#region Properties

		/// <summary>
		/// HitPoint
		/// </summary>
		public HitPoint HitPoint
		{
			get
			{
				return HP;
			}
			set
			{
				HP = value;

				if (value == null)
				{
					MaxBox.Value = 0;
					CurrentBox.Value = 0;
				}
				else
				{
					MaxBox.Value = value.Max;
					CurrentBox.Value = value.Current;
				}
			}
		}
		HitPoint HP;

		#endregion


	}
}
