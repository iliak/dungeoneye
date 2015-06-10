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
	/// Pit form editor
	/// </summary>
	public partial class PitControl : UserControl
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="pit">Pit handle</param>
		/// <param name="dungeon">Dungeon handle</param>
		public PitControl(Pit pit, Dungeon dungeon)
		{
			InitializeComponent();

			Dungeon = dungeon;

			IsHiddenBox.Checked = pit.IsHidden;
			IsIllusionBox.Checked = pit.IsIllusion;
			TargetBox.SetTarget(dungeon, pit.Target);
			DamageBox.Dice = pit.Damage;
			DifficultyBox.Value = pit.Difficulty;

			Pit = pit;
		}


		#region Form events

		private void TargetBox_TargetChanged(object sender, DungeonLocation location)
		{
			if (Pit == null)
				return;

			Pit.Target = location;
		}

		private void IsIllusionBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Pit == null)
				return;

			Pit.IsIllusion = IsIllusionBox.Checked;
		}

		private void IsHiddenBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Pit == null)
				return;

			Pit.IsHidden = IsHiddenBox.Checked;
		}

		private void DifficultyBox_ValueChanged(object sender, EventArgs e)
		{
			if (Pit == null)
				return;
			Pit.Difficulty = (int) DifficultyBox.Value;
		}

		private void DamageBox_ValueChanged(object sender, EventArgs e)
		{
			if (Pit == null)
				return;

			Pit.Damage = DamageBox.Dice;
		}

		private void MonsterTriggerBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Pit == null)
				return;

			Pit.MonsterTrigger = MonsterTriggerBox.Checked;
		}


		#endregion


		#region Properties

		/// <summary>
		/// 
		/// </summary>
		Pit Pit;

		/// <summary>
		/// 
		/// </summary>
		Dungeon Dungeon;

		#endregion

	}
}
