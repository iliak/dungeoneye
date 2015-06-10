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
using ArcEngine;


namespace DungeonEye.Forms
{
	/// <summary>
	/// Alcove script form
	/// </summary>
	public partial class AlcoveScriptForm : Form
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="script">Script handle to edit</param>
		/// <param name="dungeon">Dungeon handle</param>
		public AlcoveScriptForm(AlcoveScript script, Dungeon dungeon)
		{
			InitializeComponent();

			if (script == null)
				Script = new AlcoveScript();
			else
				Script = script;

			Dungeon = dungeon;
			ActionBox.Dungeon = dungeon;
			ActionBox.Script = Script;
		}



		/// <summary>
		/// 
		/// </summary>
		void UpdateUI()
		{

			ItemNameBox.SelectedItem = Script.ItemName;
			ConsumeItemBox.Checked = Script.ConsumeItem;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AlcoveScriptForm_Load(object sender, EventArgs e)
		{
			ItemNameBox.Items.Add("");
			ItemNameBox.Items.AddRange(ResourceManager.GetAssets<Item>().ToArray());

			UpdateUI();
		}


		#region Form events


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ItemNameBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Script == null)
				return;

			Script.ItemName = (string)ItemNameBox.SelectedItem;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ConsumeItemBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Script == null)
				return;

			Script.ConsumeItem = ConsumeItemBox.Checked;
		}

		#endregion



		#region Properties


		/// <summary>
		/// 
		/// </summary>
		public AlcoveScript Script
		{
			get;
			private set;
		}
		

		/// <summary>
		/// Dungeon handle
		/// </summary>
		Dungeon Dungeon;

		#endregion


	}
}
