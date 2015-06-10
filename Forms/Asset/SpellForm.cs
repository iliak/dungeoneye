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
using System.Windows.Forms;
using System.Xml;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Forms;
using DungeonEye.Interfaces;
using ArcEngine.Interface;

namespace DungeonEye.Forms
{
	public partial class SpellForm : AssetEditorBase
	{
		public SpellForm(XmlNode node)
		{
			InitializeComponent();



			#region 

			RangeBox.BeginUpdate();
			RangeBox.Items.Clear();
			foreach (string name in Enum.GetNames(typeof(SpellRange)))
				RangeBox.Items.Add(name);
			RangeBox.EndUpdate();
			#endregion




			Spell spell = new Spell();
			spell.Load(node);

			RangeBox.SelectedItem = spell.Range.ToString();
			DescriptionBox.Text = spell.Description;
			DurationBox.Value = (int) spell.Duration.TotalSeconds;
			CastingTimeBox.Value = (int) spell.CastingTime.TotalSeconds;
			LevelBox.Value = (int) spell.Level;
			ScriptBox.SetValues<ISpell>(spell.Script);
			ClassBox.SelectedItem = spell.Class.ToString();

			Spell = spell;
		}




		/// <summary>
		/// Saves the asset to the manager
		/// </summary>
		public override void Save()
		{
			ResourceManager.AddAsset<Spell>(Spell.Name, ResourceManager.ConvertAsset(Spell));
		}





		#region Events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClassBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Spell == null)
				return;

			Spell.Class = (HeroClass)Enum.Parse(typeof(HeroClass), (string)ClassBox.SelectedItem);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DescriptionBox_TextChanged(object sender, EventArgs e)
		{
			if (Spell == null)
				return;

			Spell.Description = DescriptionBox.Text;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LevelBox_ValueChanged(object sender, EventArgs e)
		{
			if (Spell == null)
				return;

			Spell.Level = (int)LevelBox.Value;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CastingTimeBox_ValueChanged(object sender, EventArgs e)
		{
			if (Spell == null)
				return;

			Spell.CastingTime = TimeSpan.FromSeconds((int)CastingTimeBox.Value);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DurationBox_ValueChanged(object sender, EventArgs e)
		{
			if (Spell == null)
				return;

			Spell.Duration = TimeSpan.FromSeconds((int) DurationBox.Value);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RangeBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Spell == null)
				return;

			Spell.Range = (SpellRange) Enum.Parse(typeof(SpellRange), RangeBox.SelectedItem.ToString());
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void scriptControl1_ScriptChanged(object sender, EventArgs e)
		{
			if (Spell == null)
				return;

			Spell.Script.ScriptName = ScriptBox.ScriptName;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void scriptControl1_InterfaceChanged(object sender, EventArgs e)
		{
			if (Spell == null)
				return;

			Spell.Script.InterfaceName = ScriptBox.InterfaceName;
		}
		#endregion


		#region Properties


		/// <summary>
		/// 
		/// </summary>
		public override IAsset Asset
		{
			get
			{
				return Spell;
			}
		}




		/// <summary>
		/// Spell to edit
		/// </summary>
		Spell Spell;

		#endregion

	}
}
