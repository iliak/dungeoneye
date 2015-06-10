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
using System.Text;
using System.Windows.Forms;
using ArcEngine;

namespace DungeonEye.Forms
{
	/// <summary>
	/// Entity editor control
	/// </summary>
	public partial class EntityControl : UserControl
	{
		public EntityControl()
		{
			InitializeComponent();

			AlignmentBox.DataSource = Enum.GetValues(typeof(EntityAlignment));
		}


		/// <summary>
		/// Rebuild data
		/// </summary>
		void Rebuild()
		{
			if (entity == null)
			{
				hitPointControl1.HitPoint = null;
				StrengthBox.Value = 0;
				DexterityBox.Value = 0;
				ConstitutionBox.Value = 0;
				IntelligenceBox.Value = 0;
				WisdomBox.Value = 0;
				CharismaBox.Value = 0;
				MoveSpeedBox.Value = 0;
			}
			else
			{
				hitPointControl1.HitPoint = entity.HitPoint;
				StrengthBox.Value = entity.Strength.Value;
				DexterityBox.Value = entity.Dexterity.Value;
				ConstitutionBox.Value = entity.Constitution.Value;
				IntelligenceBox.Value = entity.Intelligence.Value;
				WisdomBox.Value = entity.Wisdom.Value;
				CharismaBox.Value = entity.Charisma.Value;
				AlignmentBox.SelectedItem = entity.Alignment;
				MoveSpeedBox.Value = (int)entity.MoveSpeed.TotalMilliseconds;
			}
		}



		#region Events

		private void StrengthBox_ValueChanged(object sender, EventArgs e)
		{
			if (entity == null)
				return;

			entity.Strength.Value = (int)StrengthBox.Value;
		}

		private void DexterityBox_ValueChanged(object sender, EventArgs e)
		{
			if (entity == null)
				return;

			entity.Dexterity.Value = (int)DexterityBox.Value;
		}

		private void ConstitutionBox_ValueChanged(object sender, EventArgs e)
		{
			if (entity == null)
				return;

			entity.Constitution.Value = (int)ConstitutionBox.Value;
		}

		private void IntelligenceBox_ValueChanged(object sender, EventArgs e)
		{
			if (entity == null)
				return;

			entity.Intelligence.Value = (int)IntelligenceBox.Value;
		}

		private void WisdomBox_ValueChanged(object sender, EventArgs e)
		{
			if (entity == null)
				return;

			entity.Wisdom.Value = (int)WisdomBox.Value;
		}

		private void CharismaBox_ValueChanged(object sender, EventArgs e)
		{
			if (entity == null)
				return;

			entity.Charisma.Value = (int)CharismaBox.Value;
		}

		private void AlignmentBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (entity == null)
				return;

			entity.Alignment = (EntityAlignment)AlignmentBox.SelectedItem;
		}

		private void RollAbilitiesBox_Click(object sender, EventArgs e)
		{
			if (entity == null)
				return;

			entity.RollAbilities();
			Rebuild();
		}

		private void MoveSpeedBox_ValueChanged(object sender, EventArgs e)
		{
			if (entity == null)
				return;

			entity.MoveSpeed = TimeSpan.FromMilliseconds((int)MoveSpeedBox.Value);
		}



		#endregion


		#region Properties

		/// <summary>
		/// Entity to edit
		/// </summary>
		public Entity Entity
		{
			get
			{
				return entity;
			}

			set
			{
				entity = value;
				Rebuild();
			}
		}
		Entity entity;

		#endregion

	}
}
