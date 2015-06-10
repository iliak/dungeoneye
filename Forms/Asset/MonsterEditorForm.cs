using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArcEngine;


namespace DungeonEye.Forms
{
	/// <summary>
	/// Monster editor form
	/// </summary>
	public partial class MonsterEditorForm : Form
	{

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="monster">Monster's handle</param>
		public MonsterEditorForm(Monster monster)
		{
			InitializeComponent();
			Monster = monster;
		}




		#region Form events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MonsterEditorForm_Load(object sender, EventArgs e)
		{
			MonsterBox.SetMonster(Monster);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MonsterEditorForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				Close();
		}

		#endregion


		#region Properties


		/// <summary>
		/// 
		/// </summary>
		Monster Monster;

		#endregion
	}
}
