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
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Forms;
using DungeonEye.Script;

namespace DungeonEye.Forms
{
	public partial class ScriptedDialogForm : Form
	{

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="eventsquare">EventSquare handle</param>
		/// <param name="dungeon">Dungeon handle</param>
		public ScriptedDialogForm(EventSquare eventsquare, Dungeon dungeon)
		{
			InitializeComponent();


			DisplayBorderBox.Checked = eventsquare.DisplayBorder;
			MessageBox.Text = eventsquare.Text;
			TextJustificationBox.DataSource = Enum.GetValues(typeof(TextJustification));

			Dungeon = dungeon;

			#region Choices

			ChoicesBox.DataSource = eventsquare.Choices;

			#endregion

			EventSquare = eventsquare;
		}



		#region Form events



		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EventSquareForm_Load(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;

			PictureNameBox.Text = EventSquare.PictureName;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PictureNameBox_TextChanged(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;

			EventSquare.PictureName = PictureNameBox.Text;

			Stream stream = ResourceManager.Load(EventSquare.PictureName);
			if (stream == null)
			{
				PreviewBox.Image.Dispose();
				PreviewBox.Image = null;
				return;
			}

			PreviewBox.Image = Image.FromStream(stream);
			stream.Close();
		}

	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BrowsePictureBox_Click(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;

			StorageBrowserForm form = new StorageBrowserForm();
			form.MultiSelect = false;
			if (form.ShowDialog() != DialogResult.OK)
				return;

			PictureNameBox.Text = form.FileName;

		}




		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EventSquareForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				Close();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DisplayBackgroundBox_CheckedChanged(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;

			EventSquare.DisplayBorder = DisplayBorderBox.Checked;

		}


		private void MessageBox_TextChanged(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;

			EventSquare.Text = MessageBox.Text;

		}


		#endregion


		/// <summary>
		/// 
		/// </summary>
		void RebuildChoices()
		{
			((CurrencyManager) ChoicesBox.BindingContext[ChoicesBox.DataSource]).Refresh();
		}


		#region Choices events

		private void AddEditChoiceBox_Click(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;


			ScriptChoice choice = new ScriptChoice("Choice " + (EventSquare.Choices.Count + 1));
			EventSquare.Choices.Add(choice);
			new EventChoiceForm(choice, Dungeon).ShowDialog();

			RebuildChoices();
		}

		private void DeleteChoiceBox_Click(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;

			EventSquare.Choices.Remove(EventSquare.Choices[ChoicesBox.SelectedIndex]);
			RebuildChoices();
		}

		private void UpChoiceBox_Click(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;


		}

		private void DownChoiceBox_Click(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;


		}

		private void TextJustificationBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;


		}


		private void ChoicesBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (EventSquare == null)
				return;

			new EventChoiceForm(EventSquare.Choices[ChoicesBox.SelectedIndex], Dungeon).ShowDialog();

			RebuildChoices();

		}

		#endregion


		#region Properties

		/// <summary>
		/// Square handle
		/// </summary>
		EventSquare EventSquare;


		/// <summary>
		/// Dungeon handle
		/// </summary>
		Dungeon Dungeon;

		#endregion


	}
}
