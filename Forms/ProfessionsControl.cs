using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DungeonEye.Forms
{
	/// <summary>
	/// Profession control
	/// </summary>
	public partial class ProfessionsControl : UserControl
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ProfessionsControl()
		{
			InitializeComponent();

		}



		/// <summary>
		/// Rebuild form
		/// </summary>
		void Rebuild()
		{
			if (Hero == null)
			{
				ClericXPBox.Value = 0;
				FighterXPBox.Value = 0;
				MageXPBox.Value = 0;
				PaladinXPBox.Value = 0;
				RangerXPBox.Value = 0;
				ThiefXPBox.Value = 0;

				ClericLevelBox.Text = "0";
				FighterLevelBox.Text = "0";
				MageLevelBox.Text = "0";
				PaladinLevelBox.Text = "0";
				RangerLevelBox.Text = "0";
				ThiefLevelBox.Text = "0";
			}
			else
			{

				Profession prof = null;

				#region Cleric
				prof = Hero.GetProfession(HeroClass.Cleric);
				if (prof != null)
				{
					ClericBox.Checked = true;
					ClericXPBox.Enabled = true;
					ClericLevelBox.Enabled = true;
					ClericXPBox.Value = prof.Experience;
				}
				else
				{
					ClericBox.Checked = false;
					ClericXPBox.Enabled = false;
					ClericLevelBox.Enabled = false;
					ClericXPBox.Value = 0;
				}
				#endregion

				#region Fighter
				prof = Hero.GetProfession(HeroClass.Fighter);
				if (prof != null)
				{
					FighterBox.Checked = true;
					FighterXPBox.Enabled = true;
					FighterLevelBox.Enabled = true;
					FighterXPBox.Value = prof.Experience;
				}
				else
				{
					FighterBox.Checked = false;
					FighterXPBox.Enabled = false;
					FighterLevelBox.Enabled = false;
					FighterXPBox.Value = 0;
				}
				#endregion

				#region Mage
				prof = Hero.GetProfession(HeroClass.Mage);
				if (prof != null)
				{
					MageBox.Checked = true;
					MageXPBox.Enabled = true;
					MageLevelBox.Enabled = true;
					MageXPBox.Value = prof.Experience;
				}
				else
				{
					MageBox.Checked = false;
					MageXPBox.Enabled = false;
					MageLevelBox.Enabled = false;
					MageXPBox.Value = 0;
				}
				#endregion

				#region Paladin
				prof = Hero.GetProfession(HeroClass.Paladin);
				if (prof != null)
				{
					PaladinBox.Checked = true;
					PaladinXPBox.Enabled = true;
					PaladinLevelBox.Enabled = true;
					PaladinXPBox.Value = prof.Experience;
				}
				else
				{
					PaladinBox.Checked = false;
					PaladinXPBox.Enabled = false;
					PaladinLevelBox.Enabled = false;
					PaladinXPBox.Value = 0;
				}
				#endregion

				#region Ranger
				prof = Hero.GetProfession(HeroClass.Ranger);
				if (prof != null)
				{
					RangerBox.Checked = true;
					RangerXPBox.Enabled = true;
					RangerLevelBox.Enabled = true;
					RangerXPBox.Value = prof.Experience;
				}
				else
				{
					RangerBox.Checked = false;
					RangerXPBox.Enabled = false;
					RangerLevelBox.Enabled = false;
					RangerXPBox.Value = 0;
				}
				#endregion

				#region Thief
				prof = Hero.GetProfession(HeroClass.Thief);
				if (prof != null)
				{
					ThiefBox.Checked = true;
					ThiefXPBox.Enabled = true;
					ThiefLevelBox.Enabled = true;
					ThiefXPBox.Value = prof.Experience;
				}
				else
				{
					ThiefBox.Checked = false;
					ThiefXPBox.Enabled = false;
					ThiefLevelBox.Enabled = false;
					ThiefXPBox.Value = 0;
				}
				#endregion

			}
		}


		/// <summary>
		/// Check for multi class validity
		/// </summary>
		void CheckValidity()
		{
			if (Hero.ProfessionCount == 0 || hero.ProfessionCount > 3)
			{
				MultiClassErrorBox.Visible = true;
			}
			else
			{
				MultiClassErrorBox.Visible = false;
			}
		}


		#region Form events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClericBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Profession prof = Hero.GetProfession(HeroClass.Cleric);
			if (ClericBox.Checked)
			{
				// Add profession
				if (prof == null)
					Hero.Professions.Add(new Profession(0, HeroClass.Cleric));

				ClericXPBox.Enabled = true;
				ClericXPBox.Focus();
			}
			else
			{
				// Remove profession
				if (prof != null)
					Hero.Professions.Remove(prof);

				ClericXPBox.Value = 0;
				ClericXPBox.Enabled = false;
			}
			
			CheckValidity();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FighterBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Profession prof = Hero.GetProfession(HeroClass.Fighter);
			if (FighterBox.Checked)
			{
				// Add profession
				if (prof == null)
					Hero.Professions.Add(new Profession(0, HeroClass.Fighter));

				FighterXPBox.Enabled = true;
				FighterXPBox.Focus();
			}
			else
			{
				// Remove profession
				if (prof != null)
					Hero.Professions.Remove(prof);

				FighterXPBox.Value = 0;
				FighterXPBox.Enabled = false;
			}

			CheckValidity();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MageBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Profession prof = Hero.GetProfession(HeroClass.Mage);
			if (MageBox.Checked)
			{
				// Add profession
				if (prof == null)
					Hero.Professions.Add(new Profession(0, HeroClass.Mage));

				MageXPBox.Enabled = true;
				MageXPBox.Focus();
			}
			else
			{
				// Remove profession
				if (prof != null)
					Hero.Professions.Remove(prof);

				MageXPBox.Value = 0;
				MageXPBox.Enabled = false;
			}

			CheckValidity();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PaladinBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Profession prof = Hero.GetProfession(HeroClass.Paladin);
			if (PaladinBox.Checked)
			{
				// Add profession
				if (prof == null)
					Hero.Professions.Add(new Profession(0, HeroClass.Paladin));

				PaladinXPBox.Enabled = true;
				PaladinXPBox.Focus();
			}
			else
			{
				// Remove profession
				if (prof != null)
					Hero.Professions.Remove(prof);

				PaladinXPBox.Value = 0;
				PaladinXPBox.Enabled = false;
			}

			CheckValidity();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RangerBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Profession prof = Hero.GetProfession(HeroClass.Ranger);
			if (RangerBox.Checked)
			{
				// Add profession
				if (prof == null)
					Hero.Professions.Add(new Profession(0, HeroClass.Ranger));

				RangerXPBox.Enabled = true;
				RangerXPBox.Focus();
			}
			else
			{
				// Remove profession
				if (prof != null)
					Hero.Professions.Remove(prof);

				RangerXPBox.Value = 0;
				RangerXPBox.Enabled = false;
			}

			CheckValidity();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ThiefBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Profession prof = Hero.GetProfession(HeroClass.Thief);
			if (ThiefBox.Checked)
			{
				// Add profession
				if (prof == null)
					Hero.Professions.Add(new Profession(0, HeroClass.Thief));

				ThiefXPBox.Enabled = true;
				ThiefXPBox.Focus();
			}
			else
			{
				// Remove profession
				if (prof != null)
					Hero.Professions.Remove(prof);

				ThiefXPBox.Value = 0;
				ThiefXPBox.Enabled = false;
			}

			CheckValidity();
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClericXPBox_ValueChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Profession prof = Hero.GetProfession(HeroClass.Cleric);
			if (prof != null)
			{
				ClericLevelBox.Text = prof.Level.ToString();
				prof.Experience = (int) ClericXPBox.Value;
			}
			else
				ClericLevelBox.Text = "0";
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FighterXPBox_ValueChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Profession prof = Hero.GetProfession(HeroClass.Fighter);
			if (prof != null)
			{
				FighterLevelBox.Text = prof.Level.ToString();
				prof.Experience = (int) FighterXPBox.Value;
			}
			else
				FighterLevelBox.Text = "0";
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MageXPBox_ValueChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Profession prof = Hero.GetProfession(HeroClass.Mage);
			if (prof != null)
			{
				MageLevelBox.Text = prof.Level.ToString();
				prof.Experience = (int) MageXPBox.Value;
			}
			else
				MageLevelBox.Text = "0";
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PaladinXPBox_ValueChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Profession prof = Hero.GetProfession(HeroClass.Paladin);
			if (prof != null)
			{
				PaladinLevelBox.Text = prof.Level.ToString();
				prof.Experience = (int) PaladinXPBox.Value;
			}
			else
				PaladinLevelBox.Text = "0";
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RangerXPBox_ValueChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Profession prof = Hero.GetProfession(HeroClass.Ranger);
			if (prof != null)
			{
				RangerLevelBox.Text = prof.Level.ToString();
				prof.Experience = (int) RangerXPBox.Value;
			}
			else
				RangerLevelBox.Text = "0";
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ThiefXPBox_ValueChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Profession prof = Hero.GetProfession(HeroClass.Thief);
			if (prof != null)
			{
				ThiefLevelBox.Text = prof.Level.ToString();
				prof.Experience = (int)ThiefXPBox.Value;
			}
			else
				ThiefLevelBox.Text = "0";
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
				return groupBox2.Text;
			}
			set
			{
				if (value == null)
					return;

				groupBox2.Text = value;
			}
		}


		/// <summary>
		/// Hero to manage
		/// </summary>
		public Hero Hero
		{
			get
			{
				return hero;
			}
			set
			{
				hero = value;
				Rebuild();
			}
		}
		Hero hero;



		#endregion


	}
}
