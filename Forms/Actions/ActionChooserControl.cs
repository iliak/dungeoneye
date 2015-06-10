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
using ArcEngine;
using DungeonEye.Script;
using DungeonEye.Script.Actions;


namespace DungeonEye.Forms.Script
{
	/// <summary>
	/// Action selector control
	/// </summary>
	public partial class ActionChooserControl : UserControl
	{
		/// <summary>
		/// 
		/// </summary>
		public ActionChooserControl()
		{
			InitializeComponent();
		}


		/// <summary>
		/// Change the current action
		/// </summary>
		/// <param name="action">Action handle</param>
		void SetAction(ActionBase action)
		{
			// Dispose disposable controls
			foreach (var ctrl in ActionPropertiesBox.Controls)
			{
				if (ctrl is IDisposable)
					((IDisposable)ctrl).Dispose();
			}
			ActionPropertiesBox.Controls.Clear();



			if (Script == null)
				return;

			Script.Action = action;

			if (action == null)
				return;

			ActionBaseControl basectrl = null;

			if (action is EnableTarget)
			{
				basectrl = new EnableTargetControl(action as EnableTarget, Dungeon);
			}
			else if (action is DisableTarget)
			{
				basectrl = new DisableTargetControl(action as DisableTarget, Dungeon);
			}
			else if (action is ToggleTarget)
			{
				basectrl = new ToggleTargetControl(action as ToggleTarget, Dungeon);
			}
			else if (action is ActivateTarget)
			{
				basectrl = new ActivateTargetControl(action as ActivateTarget, Dungeon);
			}
			else if (action is DeactivateTarget)
			{
				basectrl = new DeactivateTargetControl(action as DeactivateTarget, Dungeon);
			}
			else if (action is Teleport)
			{
				basectrl = new TeleportControl(action as Teleport, Dungeon);
			}
			else if (action is ChangePicture)
			{
				basectrl = new ChangePictureControl(action as ChangePicture);
			}
			else if (action is ChangeText)
			{
				basectrl = new ChangeTextControl(action as ChangeText);
			}
			else if (action is DisableChoice)
			{
				basectrl = new DisableChoiceControl(action as DisableChoice);
			}
			else if (action is EnableChoice)
			{
				basectrl = new EnableChoiceControl(action as EnableChoice);
			}
			else if (action is EndChoice)
			{
				basectrl = new EndChoiceControl(action as EndChoice);
			}
			else if (action is EndDialog)
			{
				basectrl = new EndDialogControl(action as EndDialog);
			}
			else if (action is GiveExperience)
			{
				basectrl = new GiveExperienceControl(action as GiveExperience);
			}
			else if (action is GiveItem)
			{
				basectrl = new GiveItemControl(action as GiveItem);
			}
			else if (action is Healing)
			{
				basectrl = new HealingControl(action as Healing);
			}
			else if (action is JoinCharacter)
			{
				basectrl = new JoinCharacterControl(action as JoinCharacter);
			}
			else if (action is DisplayMessage)
			{
				basectrl = new DisplayMessageControl(action as DisplayMessage);
			}
			else if (action is SetTo)
			{
				basectrl = new SetToControl(action as SetTo, Dungeon);
			}
			else if (action is SpawnMonster)
			{
				basectrl = new SpawnMonsterControl(action as SpawnMonster, Dungeon);
			}
			else
			{
			}

			if (basectrl == null)
				return;

			basectrl.Dock = DockStyle.Fill;
			ActionPropertiesBox.Controls.Add(basectrl);


		}



		#region Control events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SpawnMonsterBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(new SpawnMonster());
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DisableBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(new DisableTarget());
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EnableBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(new EnableTarget());
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DisplayMessageBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(new DisplayMessage());
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TogglesBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(new ToggleTarget());
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ActivatesBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(new ActivateTarget());
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DeactivatesBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(new DeactivateTarget());
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ActDeactBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DeactActBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExchangesBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(null);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SetToBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(new SetTo());
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PlaySoundBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(null);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void StopSoundBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(null);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ChangePictureBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(new ChangePicture());
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ChangeTextBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(new ChangeText());
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DisableChoiceBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(new DisableChoice());
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EnableChoiceBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(new EnableChoice());
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EndChoiceBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(new EndChoice());
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EndDialogBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(new EndDialog());
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GiveExperienceBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(new GiveExperience());
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GiveItemBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(new GiveItem());
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HealingBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(new Healing());
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void JoinCharacterBox_CheckedChanged(object sender, EventArgs e)
		{
			SetAction(new JoinCharacter());
		}

		#endregion


		#region Properties


		/// <summary>
		/// Dungoen handle
		/// </summary>
		public Dungeon Dungeon
		{
			get;
			set;
		}


		/// <summary>
		/// Script handle
		/// </summary>
		public ScriptBase Script
		{
			get
			{
				return script;
			}
			set
			{
				script = value;

				if (script == null)
					SetAction(null);
				else
					SetAction(script.Action);
			}
		}
		ScriptBase script;

		#endregion
	}
}
