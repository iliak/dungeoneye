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

namespace DungeonEye.Forms
{
	/// <summary>
	/// Teleporter form editor
	/// </summary>
	public partial class TeleporterControl : UserControl
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="teleporter">Teleporter handle</param>
		/// <param name="dungeon">Dungeon handle</param>
		public TeleporterControl(Teleporter teleporter, Dungeon dungeon)
		{
			InitializeComponent();

			targetControl1.Dungeon = dungeon;

			TeamBox.Checked = teleporter.TeleportTeam;
			ItemsBox.Checked = teleporter.TeleportItems;
			MonsterBox.Checked = teleporter.TeleportMonsters;
			VisibleBox.Checked = teleporter.IsVisible;
			ReusableBox.Checked = teleporter.Reusable;
			ActiveBox.Checked = teleporter.IsActivated;
			UseSoundBox.Checked = teleporter.UseSound;
			SoundNameBox.Text = teleporter.SoundName;

			if (teleporter != null)
			{
				targetControl1.SetTarget(teleporter.Target);
				
			}

			Teleporter = teleporter;
		}


		#region Events


		private void TeamBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Teleporter == null)
				return;

			Teleporter.TeleportTeam = TeamBox.Checked;
		}

		private void MonsterBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Teleporter == null)
				return;

			Teleporter.TeleportMonsters = MonsterBox.Checked;
		}

		private void ItemsBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Teleporter == null)
				return;

			Teleporter.TeleportItems = ItemsBox.Checked;
		}

		private void VisibleBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Teleporter == null)
				return;

			Teleporter.IsVisible = VisibleBox.Checked;
		}

		private void ReusableBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Teleporter == null)
				return;

			Teleporter.Reusable = ReusableBox.Checked;
		}

		private void ActiveBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Teleporter == null)
				return;

			if (ActiveBox.Checked)
				Teleporter.Activate();
			else
				Teleporter.Deactivate();
		}

		private void PlaySoundBox_Click(object sender, EventArgs e)
		{
			if (Teleporter == null)
				return;

		}

		private void SoundNameBox_TextChanged(object sender, EventArgs e)
		{
			if (Teleporter == null)
				return;

			Teleporter.SoundName = SoundNameBox.Text;
		}

		private void LoadSoundBox_Click(object sender, EventArgs e)
		{
			if (Teleporter == null)
				return;

		}

		private void UseSoundBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Teleporter == null)
				return;

			Teleporter.UseSound = UseSoundBox.Checked;
		}


		private void targetControl1_TargetChanged(object sender, DungeonLocation location)
		{
			if (Teleporter == null)
				return;

			Teleporter.Target = location;
		}

		#endregion


		#region Properties

		/// <summary>
		/// Teleporter
		/// </summary>
		Teleporter Teleporter;


		#endregion



	}
}
