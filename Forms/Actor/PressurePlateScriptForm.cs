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
	/// 
	/// </summary>
	public partial class PressurePlateScriptForm : Form
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="script"></param>
		/// <param name="dungeon"></param>
		public PressurePlateScriptForm(PressurePlateScript script, Dungeon dungeon)
		{
			InitializeComponent();

			if (script == null)
				Script = new PressurePlateScript();
			else
				Script = script;

			ActionBox.Dungeon = dungeon;
			ActionBox.Script = Script;


			SetCondition(Script.Condition);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="condition"></param>
		void SetCondition(PressurcePlateCondition condition)
		{
			switch (condition)
			{
				case PressurcePlateCondition.Always:
				AlwaysBox.Checked = true;
				break;
				case PressurcePlateCondition.OnEnter:
				OnEnterBox.Checked = true;
				break;
				case PressurcePlateCondition.OnLeave:
				OnLeaveBox.Checked = true;
				break;
				case PressurcePlateCondition.OnTeam:
				OnTeamBox.Checked = true;
				break;
				case PressurcePlateCondition.OnTeamEnter:
				OnTeamEnterBox.Checked = true;
				break;
				case PressurcePlateCondition.OnTeamLeave:
				OnTeamLeaveBox.Checked = true;
				break;
				case PressurcePlateCondition.OnMonster:
				OnMonsterBox.Checked = true;
				break;
				case PressurcePlateCondition.OnMonsterEnter:
				OnMonsterEnterBox.Checked = true;
				break;
				case PressurcePlateCondition.OnMonsterLeave:
				OnMonsterLeaveBox.Checked = true;
				break;
				case PressurcePlateCondition.OnItem:
				OnItemBox.Checked = true;
				break;
				case PressurcePlateCondition.OnItemAdded:
				OnItemAddedBox.Checked = true;
				break;
				case PressurcePlateCondition.OnItemRemoved:
				OnItemRemovedBox.Checked = true;
				break;
				case PressurcePlateCondition.OnEntity:
				OnEntityBox.Checked = true;
				break;
				case PressurcePlateCondition.OnEntityEnter:
				OnEntityEnterBox.Checked = true;
				break;
				case PressurcePlateCondition.OnEntityLeave:
				OnEntityLeaveBox.Checked = true;
				break;
			}
		}




		#region Condition events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AlwaysBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Script == null)
				return;

			Script.Condition = PressurcePlateCondition.Always;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEnterBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Script == null)
				return;

			Script.Condition = PressurcePlateCondition.OnEnter;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnLeaveBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Script == null)
				return;

			Script.Condition = PressurcePlateCondition.OnLeave;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnTeamBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Script == null)
				return;

			Script.Condition = PressurcePlateCondition.OnTeam;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnTeamEnterBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Script == null)
				return;

			Script.Condition = PressurcePlateCondition.OnTeamEnter;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnTeamLeaveBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Script == null)
				return;

			Script.Condition = PressurcePlateCondition.OnTeamLeave;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnMonsterBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Script == null)
				return;

			Script.Condition = PressurcePlateCondition.OnMonster;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnMonsterEnterBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Script == null)
				return;

			Script.Condition = PressurcePlateCondition.OnMonsterEnter;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnMonsterLeaveBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Script == null)
				return;

			Script.Condition = PressurcePlateCondition.OnMonsterLeave;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnItemBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Script == null)
				return;

			Script.Condition = PressurcePlateCondition.OnItem;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnItemAddedBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Script == null)
				return;

			Script.Condition = PressurcePlateCondition.OnItemAdded;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnItemRemovedBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Script == null)
				return;

			Script.Condition = PressurcePlateCondition.OnItemRemoved;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEntityBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Script == null)
				return;

			Script.Condition = PressurcePlateCondition.OnEntity;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEntityEnterBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Script == null)
				return;

			Script.Condition = PressurcePlateCondition.OnEntityEnter;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEntityLeaveBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Script == null)
				return;

			Script.Condition = PressurcePlateCondition.OnEntityLeave;
		}

		#endregion


		#region Properties

		/// <summary>
		/// 
		/// </summary>
		public PressurePlateScript Script
		{
			get;
			private set;
		}


		#endregion
	}
}
