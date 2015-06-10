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
using System.Drawing;
using System.Windows.Forms;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Graphic;


namespace DungeonEye.Forms
{
	/// <summary>
	/// Control to edit Hero's parameters
	/// </summary>
	public partial class HeroControl : UserControl, IDisposable
	{

		/// <summary>
		/// Constructor
		/// </summary>
		public HeroControl()
		{
			InitializeComponent();

			Spells = new List<Spell>();
			SpellLevel = 1;

			// Alignments
			AlignmentBox.BeginUpdate();
			AlignmentBox.DataSource = Enum.GetValues(typeof(EntityAlignment));
			AlignmentBox.EndUpdate();

			// Races
			RaceBox.BeginUpdate();
			RaceBox.DataSource = Enum.GetValues(typeof(HeroRace));
			RaceBox.EndUpdate();

			// Back pack
			// Put slot id in the Tag element of the Button
			BackPack1Box.Tag = 0;
			BackPack2Box.Tag = 1;
			BackPack3Box.Tag = 2;
			BackPack4Box.Tag = 3;
			BackPack5Box.Tag = 4;
			BackPack6Box.Tag = 5;
			BackPack7Box.Tag = 6;
			BackPack8Box.Tag = 7;
			BackPack9Box.Tag = 8;
			BackPack10Box.Tag = 9;
			BackPack11Box.Tag = 10;
			BackPack12Box.Tag = 11;
			BackPack13Box.Tag = 12;
			BackPack14Box.Tag = 13;

			HelmetBox.Tag = InventoryPosition.Helmet;
			PrimaryBox.Tag = InventoryPosition.Primary;
			SecondaryBox.Tag =InventoryPosition.Secondary;
			ArmorBox.Tag =InventoryPosition.Armor;
			WristBox.Tag = InventoryPosition.Wrist;
			LeftRingBox.Tag = InventoryPosition.Ring_Left;
			RightRingBox.Tag = InventoryPosition.Ring_Right;
			FeetBox.Tag = InventoryPosition.Feet;
			NeckBox.Tag = InventoryPosition.Neck;

			Waist1Box.Tag = -1;
			Waist2Box.Tag = -2;
			Waist3Box.Tag = -3;
		}


		/// <summary>
		/// Dispose
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);


			if (Batch != null)
				Batch.Dispose();
			Batch = null;

			if (Heads != null)
				Heads.Dispose();
			Heads = null;
		}


		/// <summary>
		/// Rebuild data
		/// </summary>
		void RebuildPanels()
		{
			RebuildProperties();
			RebuildEquipment();
			RebuildSpellPanel();
		}


		/// <summary>
		/// Rebuild properties panel
		/// </summary>
		void RebuildProperties()
		{
			if (this.DesignMode)
				return;

			ProfessionsBox.Hero = Hero;

			if (Hero == null)
			{
				StrengthBox.Ability = null;
				IntelligenceBox.Ability = null;
				WisdomBox.Ability = null;
				DexterityBox.Ability = null;
				ConstitutionBox.Ability = null;
				CharismaBox.Ability = null;

				ArmorClassBox.Text = "0";

				HPBox.HitPoint = null;

				NameBox.Text = "";
				FoodBox.Value = 0;

			}
			else
			{
				QuiverBox.Value = Hero.Quiver;
				StrengthBox.Ability = Hero.Strength;
				IntelligenceBox.Ability = Hero.Intelligence;
				WisdomBox.Ability = Hero.Wisdom;
				DexterityBox.Ability = Hero.Dexterity;
				ConstitutionBox.Ability = Hero.Constitution;
				CharismaBox.Ability = Hero.Charisma;

				RaceBox.SelectedItem = Hero.Race;
				AlignmentBox.SelectedItem = Hero.Alignment;

				ArmorClassBox.Text = Hero.ArmorClass.ToString();

				HPBox.HitPoint = Hero.HitPoint;
				FoodBox.Value = Hero.Food;
				NameBox.Text = Hero.Name;
			}

			// Repaint
			OpenGLBox.Invalidate();
		}


		/// <summary>
		/// Rebuild equipment panel
		/// </summary>
		void RebuildEquipment()
		{
			if (!DesignMode)
			{
				List<string> list = ResourceManager.GetAssets<Item>();
				list.Insert(0, "");
				ItemsBox.DataSource = list;
			}

			if (Hero == null)
			{
				QuiverBox.Value = 0;
				HelmetBox.Text = string.Empty;
				PrimaryBox.Text = string.Empty;
				SecondaryBox.Text = string.Empty;
				ArmorBox.Text = string.Empty;
				WristBox.Text = string.Empty;
				LeftRingBox.Text = string.Empty;
				RightRingBox.Text = string.Empty;
				FeetBox.Text = string.Empty;
				NeckBox.Text = string.Empty;
				
				BackPack1Box.Text = string.Empty;
				BackPack2Box.Text = string.Empty;
				BackPack3Box.Text = string.Empty;
				BackPack4Box.Text = string.Empty;
				BackPack5Box.Text = string.Empty;
				BackPack6Box.Text = string.Empty;
				BackPack7Box.Text = string.Empty;
				BackPack8Box.Text = string.Empty;
				BackPack9Box.Text = string.Empty;
				BackPack10Box.Text = string.Empty;
				BackPack11Box.Text = string.Empty;
				BackPack12Box.Text = string.Empty;
				BackPack13Box.Text = string.Empty;
				BackPack14Box.Text = string.Empty;

				Waist1Box.Text = string.Empty;
				Waist2Box.Text = string.Empty;
				Waist3Box.Text = string.Empty;
			}
			else
			{
				Item item = Hero.GetInventoryItem(InventoryPosition.Helmet);
				HelmetBox.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetInventoryItem(InventoryPosition.Primary);
				PrimaryBox.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetInventoryItem(InventoryPosition.Secondary);
				SecondaryBox.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetInventoryItem(InventoryPosition.Armor);
				ArmorBox.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetInventoryItem(InventoryPosition.Wrist);
				WristBox.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetInventoryItem(InventoryPosition.Ring_Left);
				LeftRingBox.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetInventoryItem(InventoryPosition.Ring_Right);
				RightRingBox.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetInventoryItem(InventoryPosition.Feet);
				FeetBox.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetInventoryItem(InventoryPosition.Neck);
				NeckBox.Text = item != null ? item.Name : string.Empty;

				item = Hero.GetBackPackItem(0);
				BackPack1Box.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetBackPackItem(1);
				BackPack2Box.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetBackPackItem(2);
				BackPack3Box.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetBackPackItem(3);
				BackPack4Box.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetBackPackItem(4);
				BackPack5Box.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetBackPackItem(5);
				BackPack6Box.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetBackPackItem(6);
				BackPack7Box.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetBackPackItem(7);
				BackPack8Box.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetBackPackItem(8);
				BackPack9Box.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetBackPackItem(9);
				BackPack10Box.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetBackPackItem(10);
				BackPack11Box.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetBackPackItem(11);
				BackPack12Box.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetBackPackItem(12);
				BackPack13Box.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetBackPackItem(13);
				BackPack14Box.Text = item != null ? item.Name : string.Empty;


				item = Hero.GetWaistPackItem(0);
				Waist1Box.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetWaistPackItem(1);
				Waist2Box.Text = item != null ? item.Name : string.Empty;
				item = Hero.GetWaistPackItem(2);
				Waist3Box.Text = item != null ? item.Name : string.Empty;

			}
		}


		/// <summary>
		/// Rebuild spell list
		/// </summary>
		void RebuildSpellPanel()
		{
			if (DesignMode)
				return;

			if (Hero != null)
			{



				RebuildAvailableSpellsPanel();


				// Available & learned spells
				AvailableSpellBox.BeginUpdate();
				AvailableSpellBox.Items.Clear();
				LearnedSpellBox.BeginUpdate();
				LearnedSpellBox.Items.Clear();
				foreach (Spell spell in Spells)
				{
					// Learned spells
					if (spell.Class == HeroClass.Mage && spell.Level == SpellLevel)
					{
						bool check = false;

						if (Hero.LearnedSpells.Contains(spell.Name))
							check = true;

						LearnedSpellBox.Items.Add(spell.Name, check);
					}

					// Available spells
					if (spell.Level == SpellLevel && spell.Class == CurrentClass)
						AvailableSpellBox.Items.Add(spell.Name);

				}
				LearnedSpellBox.EndUpdate();
				AvailableSpellBox.EndUpdate();
			}
			else
			{
			}

		}


		/// <summary>
		/// 
		/// </summary>
		void RebuildAvailableSpellsPanel()
		{
			if (DesignMode)
				return;

			if (Hero != null)
			{
				// All spell in the desired level
				List<Spell> spells = Hero.GetSpells(CurrentClass, SpellLevel);

				// Spells ready
				SpellReadyBox.BeginUpdate();
				SpellReadyBox.Items.Clear();
				foreach (Spell spell in spells)
				{
					SpellReadyBox.Items.Add(spell.Name);
				}
				SpellReadyBox.EndUpdate();
			}
			else
			{
			}
		}




		#region Main control events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HeroControl_Load(object sender, EventArgs e)
		{
			if (DesignMode)
				return;


			Spells.Clear();
			List<string> spells = ResourceManager.GetAssets<Spell>();
			foreach (string name in spells)
				Spells.Add(ResourceManager.CreateAsset<Spell>(name));

			SpellLevel = 1;
			SpellClassBox.SelectedIndex = 0;

			RebuildPanels();
			RebuildProperties();
			RebuildSpellPanel();
		}

		#endregion


		#region Spells events


		/// <summary>
		/// check all known spells
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckAllLearnedBox_Click(object sender, EventArgs e)
		{
			for (int i = 0 ; i < LearnedSpellBox.Items.Count ; i++)
			{
				if (!LearnedSpellBox.GetItemChecked(i))
					LearnedSpellBox.SetItemChecked(i, true);
			}
		}


		/// <summary>
		/// Uncheck all known spells
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void UncheckAllLearnedBox_Click(object sender, EventArgs e)
		{
			for (int i = 0 ; i < LearnedSpellBox.Items.Count ; i++)
			{
				if (LearnedSpellBox.GetItemChecked(i))
					LearnedSpellBox.SetItemChecked(i, false);
			}
		}



		/// <summary>
		/// Change spell's level
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SpellLevelBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			RebuildSpellPanel();
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LearnedSpellBox_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (Hero == null)
				return;

			CheckedListBox clb = sender as CheckedListBox;

			if (e.NewValue == CheckState.Checked)
			{
				if (!Hero.LearnedSpells.Contains((string) clb.Items[e.Index]))
					hero.LearnedSpells.Add((string) clb.Items[e.Index]);
			}
			else if (e.NewValue == CheckState.Unchecked)
			{
				if (Hero.LearnedSpells.Contains((string) clb.Items[e.Index]))
					hero.LearnedSpells.Remove((string) clb.Items[e.Index]);
			}

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AvailableSpellBox_DoubleClick(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			string name = AvailableSpellBox.SelectedItem as string;

			Spell spell = ResourceManager.CreateAsset<Spell>(name);
			Hero.PushSpell(spell);

			RebuildAvailableSpellsPanel();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click(object sender, EventArgs e)
		{

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SpellReadyBox_DoubleClick(object sender, EventArgs e)
		{
			if (SpellReadyBox.SelectedIndex == -1 || Hero == null)
				return;

			Hero.PopSpell(CurrentClass, SpellLevel, SpellReadyBox.SelectedIndex + 1);

			RebuildAvailableSpellsPanel();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		#endregion


		#region Properties events

		/// <summary>
		/// NPC Hero
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void IsNPCBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			//Hero.IsNPC = IsNPCBox.Checked;
		}


		/// <summary>
		/// Change Hero's name
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NameBox_TextChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Hero.Name = NameBox.Text;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OpenGLBox_Load(object sender, EventArgs e)
		{
			if (DesignMode)
				return;

			OpenGLBox.MakeCurrent();
			Display.Init();
			Display.RenderState.ClearColor = Color.Black;

			Heads = ResourceManager.CreateAsset<TileSet>("Heads");

			Batch = new SpriteBatch();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OpenGLBox_Resize(object sender, EventArgs e)
		{
			if (Batch == null || Heads == null)
				return;

			OpenGLBox.MakeCurrent();
			Display.ViewPort = new Rectangle(Point.Empty, OpenGLBox.Size);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OpenGLBox_Paint(object sender, PaintEventArgs e)
		{
			if (Batch == null || Heads == null)
				return;

			OpenGLBox.MakeCurrent();
			Display.ClearBuffers();

			if (Heads != null && Batch != null && Hero != null)
			{

				Batch.Begin();
				Batch.DrawTile(Heads, Hero.Head, Point.Empty);
				Batch.End();
			}


			OpenGLBox.SwapBuffers();
		}



		/// <summary>
		/// Next hero face
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NextFaceBox_Click(object sender, EventArgs e)
		{
			if (Hero == null || Heads == null)
				return;

			int id = Hero.Head + 1;
			if (id >= Heads.Count)
				id = 0;

			Hero.Head = id;
			OpenGLBox.Invalidate();
		}


		/// <summary>
		/// Previous Hero face
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PreviousFaceBox_Click(object sender, EventArgs e)
		{
			if (Hero == null || Heads == null)
				return;

			int id = Hero.Head - 1;
			if (id <= 0)
				id = Heads.Count - 1;

			Hero.Head = id;
			OpenGLBox.Invalidate();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FoodBox_ValueChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Hero.Food = (int) FoodBox.Value;
		}
		
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Hero.Quiver = (int) QuiverBox.Value;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ArmorBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Hero.SetInventoryItem(InventoryPosition.Armor, ResourceManager.CreateAsset<Item>((string)ArmorBox.Text));
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WristBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Hero.SetInventoryItem(InventoryPosition.Wrist, ResourceManager.CreateAsset<Item>((string)WristBox.Text));

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LeftRingBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Hero.SetInventoryItem(InventoryPosition.Ring_Left, ResourceManager.CreateAsset<Item>((string)LeftRingBox.Text));

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RightRingBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Hero.SetInventoryItem(InventoryPosition.Ring_Right, ResourceManager.CreateAsset<Item>((string)RightRingBox.Text));

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PrimaryBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Hero.SetInventoryItem(InventoryPosition.Primary, ResourceManager.CreateAsset<Item>((string)PrimaryBox.Text));
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SecondaryBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Hero.SetInventoryItem(InventoryPosition.Secondary, ResourceManager.CreateAsset<Item>((string)SecondaryBox.Text));
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FeetBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Hero.SetInventoryItem(InventoryPosition.Feet, ResourceManager.CreateAsset<Item>((string)FeetBox.Text));
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NeckBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Hero.SetInventoryItem(InventoryPosition.Neck, ResourceManager.CreateAsset<Item>((string)NeckBox.Text));

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HelmetBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Hero.SetInventoryItem(InventoryPosition.Helmet, ResourceManager.CreateAsset<Item>((string)HelmetBox.Text));

		}


		/// <summary>
		/// Change alignment
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AlignmentBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Hero.Alignment = (EntityAlignment)AlignmentBox.SelectedItem;
		}


		/// <summary>
		/// Change race
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RaceBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			Hero.Race = (HeroRace) RaceBox.SelectedItem;
		}

		#endregion


		#region Equipments


		/// <summary>
		/// Affect an item in the backpack
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Equipment_Click(object sender, EventArgs e)
		{
			if (Hero == null)
				return;

			// Target
			Button button = sender as Button;

			// Item
			string name = ItemsBox.SelectedItem as string;
			Item item = ResourceManager.CreateAsset<Item>(name);

			// Backpack
			if (button.Tag is int)
			{
				int id = (int)button.Tag;
				if (id >= 0)
				{
					Hero.SetBackPackItem((int)button.Tag, item);
					button.Text = ItemsBox.SelectedItem as string;
				}
				else
				{
					if (Hero.SetWaistPackItem(Math.Abs(id) - 1, item) || !CheckValidityBox.Checked)
						button.Text = ItemsBox.SelectedItem as string;
				}
			}

			// Inventory
			else if (button.Tag is InventoryPosition)
			{
				if (Hero.SetInventoryItem((InventoryPosition)button.Tag, item) || !CheckValidityBox.Checked)
					button.Text = ItemsBox.SelectedItem as string;
			}
			
		}


		/// <summary>
		/// Clear back pack
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearBackPackBox_Click(object sender, EventArgs e)
		{
			if (Hero == null)
				return;
			for (int i = 0; i < 14; i++)
				Hero.SetBackPackItem(i, null);

			RebuildEquipment();
		}

		#endregion


		#region Properties

		/// <summary>
		/// Hero to edit
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
				RebuildPanels();
			}
		}
		Hero hero;


		/// <summary>
		/// All available spells
		/// </summary>
		List<Spell> Spells;


		/// <summary>
		/// Current spell level
		/// </summary>
		int SpellLevel
		{
			get
			{
				return SpellLevelBox.SelectedIndex + 1;
			}
			set
			{
				if (value < 1 | value > 6)
					return;
				SpellLevelBox.SelectedIndex = value - 1;
			}
		}


		/// <summary>
		/// Current selected class
		/// </summary>
		HeroClass CurrentClass
		{
			get
			{
				HeroClass hclass = HeroClass.Cleric;
				if ((string)SpellClassBox.SelectedItem == "Mage")
					hclass = HeroClass.Mage;

				return hclass;
			}
			set
			{
			}
		}


		/// <summary>
		/// Heroe's heads
		/// </summary>
		TileSet Heads;


		/// <summary>
		/// SpriteBatch
		/// </summary>
		SpriteBatch Batch;

		#endregion


	}
}
