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
using System.Xml;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Forms;
using ArcEngine.Graphic;
using DungeonEye.Interfaces;

namespace DungeonEye.Forms
{
	/// <summary>
	/// Monster control editor
	/// </summary>
	public partial class MonsterControl : UserControl
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public MonsterControl()
		{
			InitializeComponent();

			ItemsBox.Items.AddRange(ResourceManager.GetAssets<Item>().ToArray());
			TileSetBox.Items.AddRange(ResourceManager.GetAssets<TileSet>().ToArray());

			foreach(var name in Enum.GetValues(typeof(MonsterBehaviour)))
				DefaultBehaviourBox.Items.Add(name);

			foreach (var name in Enum.GetValues(typeof(MonsterBehaviour)))
				CurrentBehaviourBox.Items.Add(name);

			foreach (var name in Enum.GetValues(typeof(CardinalPoint)))
				DirectionBox.Items.Add(name);
		}


		/// <summary>
		/// Update controls
		/// </summary>
		void UpdateControls()
		{
			// Populate comboboxes
			if (WeaponNameBox.Items.Count == 0)
			{
				WeaponNameBox.BeginUpdate();
				foreach (string name in ResourceManager.GetAssets<Item>())
				{
					Item item = ResourceManager.CreateAsset<Item>(name);
					if (item.Type == ItemType.Weapon)
						WeaponNameBox.Items.Add(name);
				}
				WeaponNameBox.Items.Insert(0, "");
				WeaponNameBox.EndUpdate();
			}


			if (Monster != null)
			{
				EntityBox.Entity = Monster;
				TileSetBox.Text = Monster.TileSetName;
				TileIDBox.Value = Monster.Tile;
				PocketItemsBox.Items.AddRange(Monster.ItemsInPocket.ToArray());
				XPRewardBox.Value = Monster.Reward;
				ArmorClassBox.Value = Monster.ArmorClass;
				ScriptBox.SetValues<IMonster>(Monster.Script);
				DamageBox.Dice = Monster.DamageDice;
				FleesBox.Checked = Monster.FleesAfterAttack;
				FlyingBox.Checked = Monster.Flying;
				FillSquareBox.Checked = Monster.FillSquare;
				NonMaterialBox.Checked = Monster.NonMaterial;
				UseStairsBox.Checked = Monster.UseStairs;
				BackRowAttackBox.Checked = Monster.BackRowAttack;
				PoisonImmunityBox.Checked = Monster.PoisonImmunity;
				ThrowWeaponsBox.Checked = Monster.ThrowWeapons;
				SmartAIBox.Checked = Monster.SmartAI;
				CanSeeInvisibleBox.Checked = Monster.CanSeeInvisible;
				SightRangeBox.Value = Monster.SightRange;
				PickupBox.Value = (decimal)Monster.PickupRate * 100;
				StealBox.Value = (decimal)Monster.StealRate * 100;
				CanSeeInvisibleBox.Checked = Monster.CanSeeInvisible;
				TeleportsBox.Checked = Monster.Teleports;
				DefaultBehaviourBox.SelectedItem = Monster.DefaultBehaviour;
				CurrentBehaviourBox.SelectedItem = Monster.CurrentBehaviour;
				DirectionBox.SelectedItem = Monster.Direction;
				NameBox.Text = Monster.Name;
				AttackSpeedBox.Value = (int)Monster.AttackSpeed.TotalMilliseconds;
				WeaponNameBox.SelectedItem = Monster.WeaponName;
			}

			Draw();
		}


		/// <summary>
		/// Changes the monster
		/// </summary>
		/// <param name="handle">Monster handle</param>
		public void SetMonster(Monster handle)
		{
			// Dispose previous monster
			if (Monster != null)
				Monster.Dispose();
			Monster = handle;



			// Change tileset
			if (TileSet == null || TileSet.Name != Monster.TileSetName)
			{
				if (TileSet != null)
					TileSet.Dispose();
				TileSet = null;

				if (Monster != null)
					TileSet = ResourceManager.CreateAsset<TileSet>(Monster.TileSetName);
			}


			// Update visual
			UpdateControls();
		}


		/// <summary>
		/// Render the monster visual
		/// </summary>
		void Draw()
		{
			try
			{
				GlControl.MakeCurrent();
				Display.ClearBuffers();

				if (SpriteBatch != null)
				{
					SpriteBatch.Begin();

					// Background texture
					Rectangle dst = new Rectangle(Point.Empty, GlControl.Size);
					SpriteBatch.Draw(CheckerBoard, dst, dst, Color.White);

					if (Monster != null && TileSet != null)
					{
						Tile tile = TileSet.GetTile(Monster.Tile);
						if (tile != null)
						{
							Point pos = new Point((GlControl.Width - tile.Size.Width) / 2, (GlControl.Height - tile.Size.Height) / 2);
							pos.Offset(tile.Pivot);
							SpriteBatch.DrawTile(TileSet, Monster.Tile, pos);
						}
					}

					SpriteBatch.End();
				}


				GlControl.SwapBuffers();
			}
			catch (Exception e)
			{
			}


		}



		/// <summary> 
		/// Dispose resources
		/// </summary>
		/// <param name="disposing"></param>
		protected override void Dispose(bool disposing)
		{

			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);

	
			if (TileSet != null)
				TileSet.Dispose();
			TileSet = null;

			if (SpriteBatch != null)
				SpriteBatch.Dispose();
			SpriteBatch = null;

			if (CheckerBoard != null)
				CheckerBoard.Dispose();
			CheckerBoard = null;
		}



		#region Events



		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GlControl_Load(object sender, EventArgs e)
		{
			if (DesignMode)
				return;

			//HACK: this method is called twice... Strange...
			if (SpriteBatch != null)
				MessageBox.Show("[MonsterControl] : Double call to GlControlLoad(), Oops !");

			GlControl.MakeCurrent();
			Display.ViewPort = new Rectangle(new Point(), GlControl.Size);

			Display.Init();
			Display.ClearBuffers();





			// Preload background texture resource
			CheckerBoard = new Texture2D(ResourceManager.GetInternalResource("ArcEngine.Resources.checkerboard.png"));
			CheckerBoard.HorizontalWrap = TextureWrapFilter.Repeat;
			CheckerBoard.VerticalWrap = TextureWrapFilter.Repeat;


			SpriteBatch = new SpriteBatch();


			Draw();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TileSetBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			// No monster or same tileset
			if (Monster == null || Monster.TileSetName == (string)TileSetBox.SelectedItem)
				return;

			// Reload tileset
			if (TileSet != null)
				TileSet.Dispose();

			Monster.TileSetName = (string)TileSetBox.SelectedItem;
			TileSet = ResourceManager.CreateAsset<TileSet>(Monster.TileSetName);

			Draw();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GlControl_Paint(object sender, PaintEventArgs e)
		{
			Draw();
		}


		/// <summary>
		/// Change tileset ID
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TileIDBox_ValueChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.Tile = (int)TileIDBox.Value;
			Draw();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddPocketItemBox_Click(object sender, EventArgs e)
		{
			if (Monster == null || ItemsBox.SelectedItem == null)
				return;

			string name = ItemsBox.SelectedItem as string;
			Monster.ItemsInPocket.Add(name);
			PocketItemsBox.Items.Add(name);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RemovePocketItemBox_Click(object sender, EventArgs e)
		{
			if (Monster == null || PocketItemsBox.SelectedItem == null)
				return;


			PocketItemsBox.Items.RemoveAt(PocketItemsBox.SelectedIndex);

			Monster.ItemsInPocket.Clear();
			foreach (string name in PocketItemsBox.Items)
				Monster.ItemsInPocket.Add(name);


		}


		#endregion


		#region Visual Tab



		#endregion


		#region Magic Tab

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CastingLevelBox_ValueChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.MagicCastingLevel = (int)CastingLevelBox.Value;
		}

		/// <summary>
		/// Has Magic
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HasMagicBox_CheckedChanged(object sender, EventArgs e)
		{
			MagicGroupBox.Enabled = HasMagicBox.Checked;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MagicGroupBox_EnabledChanged(object sender, EventArgs e)
		{
			if (Monster == null)
			{
				HealMagicBox.Checked = false;
				HasDrainMagicBox.Checked = false;
				CastingLevelBox.Value = 0;
				KnownSpellsBox.Items.Clear();
			}
			else
			{
				HealMagicBox.Checked = Monster.HasHealMagic;
				HasDrainMagicBox.Checked = Monster.HasDrainMagic;
				CastingLevelBox.Value = Monster.MagicCastingLevel;
				KnownSpellsBox.Items.Clear();
			}
		}


		#endregion


		#region Properties Tab


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NameBox_TextChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.Name = NameBox.Text;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AttackSpeedBox_ValueChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.AttackSpeed = TimeSpan.FromMilliseconds((int)AttackSpeedBox.Value);
		}

		/// <summary>
		/// Damage value changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DamageBox_ValueChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.DamageDice.Clone(DamageBox.Dice);
		}


		/// <summary>
		/// Remove selected item from backpack
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PocketItemsBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (Monster == null)
				return;

			PocketItemsBox.Items.RemoveAt(PocketItemsBox.SelectedIndex);

			Monster.ItemsInPocket.Clear();
			foreach (string name in PocketItemsBox.Items)
				Monster.ItemsInPocket.Add(name);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExperienceBox_ValueChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;
			Monster.Reward = (int)XPRewardBox.Value;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DirectionBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.Direction = (CardinalPoint)DirectionBox.SelectedItem;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ArmorClassBox_ValueChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.ArmorClass = (int)ArmorClassBox.Value;
		}


		/// <summary>
		/// Flees after attack
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FleesBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.FleesAfterAttack = FleesBox.Checked;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FillSquareBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.FillSquare = FillSquareBox.Checked;

		}

		private void NonMaterialBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.NonMaterial = NonMaterialBox.Checked;

		}

		private void PoisonImmunityBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.PoisonImmunity = PoisonImmunityBox.Checked;

		}

		private void ThrowWeaponsBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.ThrowWeapons = ThrowWeaponsBox.Checked;

		}

		private void PickupBox_ValueChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.PickupRate = (float)PickupBox.Value / 100.0f;

		}

		private void StealBox_ValueChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.StealRate = (float)StealBox.Value / 100.0f;

		}

		private void UseStairsBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.UseStairs = UseStairsBox.Checked;

		}

		private void FlyingBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.Flying = FlyingBox.Checked;

		}

		private void SmartAIBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.SmartAI = SmartAIBox.Checked;

		}

		private void TeleportsBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.Teleports = TeleportsBox.Checked;

		}

		private void BackRowAttackBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.BackRowAttack = BackRowAttackBox.Checked;
		}

		private void CanSeeInvisibleBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.CanSeeInvisible = CanSeeInvisibleBox.Checked;
		}

		private void SightRangeBox_ValueChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.SightRange = (int)SightRangeBox.Value;

		}


		private void DefaultBehaviourBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.DefaultBehaviour = (MonsterBehaviour)DefaultBehaviourBox.SelectedItem;

		}

		private void CurrentBehaviourBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.CurrentBehaviour = (MonsterBehaviour)CurrentBehaviourBox.SelectedItem;
		}

		private void WeaponNameBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Monster == null)
				return;

			Monster.WeaponName = (string)WeaponNameBox.SelectedItem;
		}

		#endregion


		#region Audio

		private void LoadAttackSoundBox_Click(object sender, EventArgs e)
		{
			StorageBrowserForm form = new StorageBrowserForm();
			form.ShowDialog();
		}

		private void LoadMoveSoundBox_Click(object sender, EventArgs e)
		{

		}

		private void LoadDeathSoundBox_Click(object sender, EventArgs e)
		{

		}

		private void LoadHurtSoundBox_Click(object sender, EventArgs e)
		{

		}


		#endregion


		#region Properties

		/// <summary>
		/// Monster handle
		/// </summary>
		public Monster Monster
		{
			get;
			private set;
		}


		/// <summary>
		/// Tileset
		/// </summary>
		TileSet TileSet;


		/// <summary>
		/// Spritebatch
		/// </summary>
		SpriteBatch SpriteBatch;


		/// <summary>
		/// Background texture
		/// </summary>
		Texture2D CheckerBoard;


		#endregion


	}
}
