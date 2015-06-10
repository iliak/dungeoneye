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
	/// Switch count control
	/// </summary>
	public partial class SwitchCountControl : UserControl
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public SwitchCountControl()
		{
			InitializeComponent();

			SwitchCount = new SwitchCount();
		}


		/// <summary>
		/// 
		/// </summary>
		void UpdateUI()
		{
			TargetBox.Value = SwitchCount.Target;
			CountBox.Value = SwitchCount.Count;
			ResetBox.Checked = SwitchCount.ResetOnTrigger;
		}


		#region Control Events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ResetBox_CheckedChanged(object sender, EventArgs e)
		{
			if (SwitchCount == null)
				return;

			SwitchCount.ResetOnTrigger = ResetBox.Checked;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RemainingBox_ValueChanged(object sender, EventArgs e)
		{
			if (SwitchCount == null)
				return;

			SwitchCount.Count = (int)CountBox.Value;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NeededBox_ValueChanged(object sender, EventArgs e)
		{
			if (SwitchCount == null)
				return;

			SwitchCount.Target = (int) TargetBox.Value;
		}

		#endregion


		#region Properties


		/// <summary>
		/// 
		/// </summary>
		public SwitchCount SwitchCount
		{
			get
			{
				return switchcount;
			}
			set
			{
				if (value == null)
					return;

				switchcount = value;
				UpdateUI();
			}
		}
		SwitchCount switchcount;

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

		#endregion

	}
}
