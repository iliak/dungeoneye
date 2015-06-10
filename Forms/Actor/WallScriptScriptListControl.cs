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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DungeonEye.Script;
using DungeonEye.Script.Actions;

namespace DungeonEye.Forms
{
	/// <summary>
	/// Control that handle actions
	/// </summary>
	public partial class WallSwitchScriptListControl : UserControl
	{

		/// <summary>
		/// 
		/// </summary>
		public WallSwitchScriptListControl()
		{
			InitializeComponent();

		}



		/// <summary>
		/// 
		/// </summary>
		void UpdateUI()
		{
			ScriptListBox.Items.Clear();
			if (Scripts == null)
				return;

			foreach (WallSwitchScript script in Scripts)
			{
				if (script.Action == null)
					continue;

				ScriptListBox.Items.Add(script.Action.ToString());
			}

		}


		#region Control events


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ScriptListBox_DoubleClick(object sender, EventArgs e)
		{
			if (ScriptListBox.SelectedIndex == -1)
				return;


			new WallSwitchScriptForm(Scripts[ScriptListBox.SelectedIndex], Dungeon).ShowDialog();

			UpdateUI();

		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MoveDownBox_Click(object sender, EventArgs e)
		{
			if (Scripts == null)
				return;

			int id = ScriptListBox.SelectedIndex;
			if (id >= Scripts.Count - 1)
				return;

			WallSwitchScript action = Scripts[id];
			Scripts.RemoveAt(id);
			Scripts.Insert(id + 1, action);

			UpdateUI();
			ScriptListBox.SelectedIndex = id + 1;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MoveUpBox_Click(object sender, EventArgs e)
		{
			if (Scripts == null)
				return;

			int id = ScriptListBox.SelectedIndex;
			if (id <= 0)
				return;
			WallSwitchScript script = Scripts[id];
			Scripts.RemoveAt(id);
			Scripts.Insert(id - 1, script);

			UpdateUI();
			ScriptListBox.SelectedIndex = id - 1;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RemoveBox_Click(object sender, EventArgs e)
		{
			if (Scripts == null)
				return;

			if (ScriptListBox.SelectedIndex == -1 || ScriptListBox.SelectedIndex > Scripts.Count)
				return;

			Scripts.RemoveAt(ScriptListBox.SelectedIndex);

			UpdateUI();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EditBox_Click(object sender, EventArgs e)
		{
			if (ScriptListBox.SelectedIndex == -1)
				return;


			new WallSwitchScriptForm(Scripts[ScriptListBox.SelectedIndex], Dungeon).ShowDialog();

			UpdateUI();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddBox_Click(object sender, EventArgs e)
		{
			// Empty form
			WallSwitchScriptForm form = new WallSwitchScriptForm(null, Dungeon);
			if (form.ShowDialog() != DialogResult.OK)
				return;

			// Add new action to the list
			if (form.Script != null && Scripts != null)
				Scripts.Add(form.Script);

			UpdateUI();
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEnabledChanged(object sender, EventArgs e)
		{
			if (!Enabled)
				ScriptListBox.Items.Clear();
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
				return groupBox5.Text;
			}
			set
			{
				groupBox5.Text = value;
			}
		}


		/// <summary>
		/// Dungeon handle
		/// </summary>
		public Dungeon Dungeon
		{
			get;
			set;
		}


		/// <summary>
		/// Scripts
		/// </summary>
		public IList<WallSwitchScript> Scripts
		{
			get
			{
				return scripts;
			}
			set
			{
				scripts = value;
				UpdateUI();
			}
		}
		IList<WallSwitchScript> scripts;

		#endregion


	}
}
