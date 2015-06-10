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
	public partial class EventActionForm : Form
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dungeon">Dungeon handle</param>
		public EventActionForm(Dungeon dungeon)
		{
			InitializeComponent();

			Dungeon = dungeon;

			ActionListBox.BeginUpdate();
			ActionListBox.Items.Add("Activate");
			ActionListBox.Items.Add("Deactivate");
			ActionListBox.Items.Add("Disable Choice");
			ActionListBox.Items.Add("Enable Choice");
			ActionListBox.Items.Add("Toggle");
			ActionListBox.Items.Add("Change Picture");
			ActionListBox.Items.Add("Give Experience");
			ActionListBox.Items.Add("Give Item");
			ActionListBox.Items.Add("Healing");
			ActionListBox.Items.Add("Teleport");
			ActionListBox.Items.Add("Join Character");
			ActionListBox.Items.Add("End Choice");
			ActionListBox.Items.Add("End Dialog");
			ActionListBox.Items.Add("Change Text");
			ActionListBox.Items.Add("Play Sound");
			ActionListBox.Items.Add("Display Message");
			ActionListBox.EndUpdate();

		}



		/// <summary>
		/// Set the action
		/// </summary>
		/// <param name="script">Action handle</param>
		/// <returns>True on success</returns>
		public bool SetAction(ActionBase script)
		{
			ControlHandle = null;
			
			if (script is Teleport)
			{
				ActionListBox.SelectedItem = "Teleport";
				ControlHandle = new TeleportControl(script as Teleport, Dungeon);
			}

			else if (script is ActivateTarget)
			{
				ActionListBox.SelectedItem = "Activate";
				ControlHandle = new ActivateTargetControl(script as ActivateTarget, Dungeon);
			}

			else if (script is ChangePicture)
			{
				ActionListBox.SelectedItem = "Change Picture";
				ControlHandle = new ChangePictureControl(script as ChangePicture);
			}

			else if (script is PlaySound)
			{
				ActionListBox.SelectedItem = "Play Sound";
				ControlHandle = new PlaySoundControl(script as PlaySound);
			}

			else if (script is EndDialog)
			{
				ActionListBox.SelectedItem = "End Dialog";
				ControlHandle = new EndDialogControl(script as EndDialog);
			}

			else if (script is EndChoice)
			{
				ActionListBox.SelectedItem = "End Choice";
				ControlHandle = new EndChoiceControl(script as EndChoice);
			}

			else if (script is DeactivateTarget)
			{
				ActionListBox.SelectedItem = "Deactivate";
				ControlHandle = new DeactivateTargetControl(script as DeactivateTarget, Dungeon);
			}

			else if (script is EnableChoice)
			{
				ActionListBox.SelectedItem = "Enable Choice";
				ControlHandle = new EnableChoiceControl(script as EnableChoice);
			}

			else if (script is DisableChoice)
			{
				ActionListBox.SelectedItem = "Disable Choice";
				ControlHandle = new DisableChoiceControl(script as DisableChoice);
			}

			else if (script is ToggleTarget)
			{
				ActionListBox.SelectedItem = "Toggle";
				ControlHandle = new ToggleTargetControl(script as ToggleTarget, Dungeon);
			}

			else if (script is Healing)
			{
				ActionListBox.SelectedItem = "Healing";
				ControlHandle = new HealingControl(script as Healing);
			}

			else if (script is GiveExperience)
			{
				ActionListBox.SelectedItem = "Give Experience";
				ControlHandle = new GiveExperienceControl(script as GiveExperience);
			}

			else if (script is GiveItem)
			{
				ActionListBox.SelectedItem = "Give Item";
				ControlHandle = new GiveItemControl(script as GiveItem);
			}

			else if (script is ChangeText)
			{
				ActionListBox.SelectedItem = "Change Text";
				ControlHandle = new ChangeTextControl(script as ChangeText);
			}

			else if (script is JoinCharacter)
			{
				ActionListBox.SelectedItem = "Join Character";
				ControlHandle = new JoinCharacterControl(script as JoinCharacter);
			}


			if (ControlHandle == null)
				return false;


			ControlHandle.Dock = DockStyle.Fill;
			ActionControlBox.Controls.Clear();
			ActionControlBox.Controls.Add(ControlHandle);

			return true;
		}




		#region Events


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ActionListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ActionControlBox.Controls.Clear();
			ControlHandle = null;

			if (ActionListBox.SelectedIndex == -1)
				return;


			if ((string) ActionListBox.SelectedItem == "Teleport")
				ControlHandle = new TeleportControl(null, Dungeon);

			else if ((string) ActionListBox.SelectedItem == "Change Picture")
				ControlHandle = new ChangePictureControl(null);

			else if ((string) ActionListBox.SelectedItem == "Play Sound")
				ControlHandle = new PlaySoundControl(null);

			else if ((string) ActionListBox.SelectedItem == "Activate")
				ControlHandle = new ActivateTargetControl(null, Dungeon);

			else if ((string) ActionListBox.SelectedItem == "End Dialog")
				ControlHandle = new EndDialogControl(null);

			else if ((string) ActionListBox.SelectedItem == "End Choice")
				ControlHandle = new EndChoiceControl(null);

			else if ((string) ActionListBox.SelectedItem == "Deactivate")
				ControlHandle = new DeactivateTargetControl(null, Dungeon);

			else if ((string) ActionListBox.SelectedItem == "Enable Choice")
				ControlHandle = new EnableChoiceControl(null);

			else if ((string) ActionListBox.SelectedItem == "Disable Choice")
				ControlHandle = new DisableChoiceControl(null);

			else if ((string) ActionListBox.SelectedItem == "Toggle")
				ControlHandle = new ToggleTargetControl(null, Dungeon);

			else if ((string) ActionListBox.SelectedItem == "Healing")
				ControlHandle = new HealingControl(null);

			else if ((string) ActionListBox.SelectedItem == "Give Experience")
				ControlHandle = new GiveExperienceControl(null);

			else if ((string) ActionListBox.SelectedItem == "Give Item")
				ControlHandle = new GiveItemControl(null);

			else if ((string) ActionListBox.SelectedItem == "Change Text")
				ControlHandle = new ChangeTextControl(null);

			else if ((string) ActionListBox.SelectedItem == "Join Character")
				ControlHandle = new JoinCharacterControl(null);


			if (ControlHandle == null)
				return;

			ControlHandle.Dock = DockStyle.Fill;
			ActionControlBox.Controls.Add(ControlHandle);

		}



		#endregion




		#region Properties

		/// <summary>
		/// 
		/// </summary>
		ActionBaseControl ControlHandle = null;


		/// <summary>
		/// Dungeon handle
		/// </summary>
		Dungeon Dungeon;


		/// <summary>
		/// Script action
		/// </summary>
		public ActionBase Action
		{
			get
			{
				if (ControlHandle == null)
					return null;

				return ControlHandle.Action;
			}
		}
		#endregion

	}
}
