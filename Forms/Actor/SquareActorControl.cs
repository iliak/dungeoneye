using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DungeonEye.Forms.Actor
{
	/// <summary>
	/// 
	/// </summary>
	public partial class SquareActorControl : UserControl
	{

		/// <summary>
		/// 
		/// </summary>
		public SquareActorControl()
		{
			InitializeComponent();
		}


		/// <summary>
		/// 
		/// </summary>
		void UpdateUI()
		{
			if (Actor == null)
				return;

			CanPassTroughBox.Checked = Actor.CanPassThrough;
			IsBlockingBox.Checked = Actor.IsBlocking;
			IsEnabledBox.Checked = Actor.IsEnabled;
			IsActivatedBox.Checked = Actor.IsActivated;
		}


		#region Events


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CanPassTroughBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Actor == null)
				return;

			Actor.CanPassThrough = CanPassTroughBox.Checked;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void IsBlockingBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Actor == null)
				return;

			Actor.IsBlocking = IsBlockingBox.Checked;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void IsActivatedBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Actor == null)
				return;

			Actor.IsActivated = IsActivatedBox.Checked;
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void IsEnabledBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Actor == null)
				return;

			Actor.IsEnabled = IsEnabledBox.Checked;
		}


		#endregion



		#region Properties


		/// <summary>
		/// 
		/// </summary>
		public SquareActor Actor
		{
			get 
			{
				return actor;
			}
			set 
			{
				actor = value;
				UpdateUI();
			}
		}
		SquareActor actor;

		#endregion
	}
}
