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


namespace DungeonEye.Forms
{
	/// <summary>
	/// Event choice form editor
	/// </summary>
	public partial class EventChoiceForm : Form
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="choice">choice to edit</param>
		/// <param name="dungeon">Dungeon handle</param>
		public EventChoiceForm(ScriptChoice choice, Dungeon dungeon)
		{
			InitializeComponent();

			if (choice == null)
				throw new ArgumentNullException("choice");

			Dungeon = dungeon;
			NameBox.Text = choice.Name;
		//	ActionBox.Actions = choice.Actions;
			ActionBox.Dungeon = dungeon;
			Choice = choice;
		}




		#region Events


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EventChoiceForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				Close();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NameBox_TextChanged(object sender, EventArgs e)
		{
			if (Choice == null)
				return;

			Choice.Name = NameBox.Text;
		}



	
		private void AddItemBox_Click(object sender, EventArgs e)
		{

		}

		private void RemoveItemBox_Click(object sender, EventArgs e)
		{

		}

		private void KeepItemBox_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void VisibleBox_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void AutoTriggerBox_CheckedChanged(object sender, EventArgs e)
		{

		}




		#endregion


		#region Properties

		/// <summary>
		/// Choice handle
		/// </summary>
		ScriptChoice Choice;


		/// <summary>
		/// Dungeon handle
		/// </summary>
		Dungeon Dungeon;

		#endregion

	}
}
