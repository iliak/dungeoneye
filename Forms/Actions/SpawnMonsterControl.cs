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
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DungeonEye.Script.Actions;
using ArcEngine;

namespace DungeonEye.Forms
{
	/// <summary>
	/// Spawn a new monster control
	/// </summary>
	public partial class SpawnMonsterControl : ActionBaseControl
	{

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="script">Script handle</param>
		/// <param name="dungeon">Dungeon handle</param>
		public SpawnMonsterControl(SpawnMonster script, Dungeon dungeon)
		{
			InitializeComponent();


			Action = script ?? new SpawnMonster();

			TargetBox.Dungeon = dungeon;
			TargetBox.SetTarget(script.Target);

			MonsterNameBox.Items.AddRange(ResourceManager.GetAssets<Monster>().ToArray());
			if (!string.IsNullOrEmpty(SpawnScript.MonsterName))
				MonsterNameBox.SelectedItem = SpawnScript.MonsterName;
		}




		#region Events


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		void TargetBox_TargetChanged(object sender, DungeonLocation target)
		{
			Action.Target = target;
		}
		
		

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MonsterNameBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			((SpawnMonster)Action).MonsterName = (string) MonsterNameBox.SelectedItem;
		}

		#endregion



		#region Properties


		/// <summary>
		/// 
		/// </summary>
		SpawnMonster SpawnScript
		{
			get
			{
				return Action as SpawnMonster;
			}
		}

		#endregion

	}
}
