namespace DungeonEye.Forms
{
	partial class MonsterControl
	{
		/// <summary> 
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

	
		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			DungeonEye.Dice dice1 = new DungeonEye.Dice();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonsterControl));
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.GlControl = new OpenTK.GLControl();
			this.TileSetBox = new System.Windows.Forms.ComboBox();
			this.PocketGroupBox = new System.Windows.Forms.GroupBox();
			this.PocketItemsBox = new System.Windows.Forms.ListBox();
			this.AddPocketItemBox = new System.Windows.Forms.Button();
			this.ItemsBox = new System.Windows.Forms.ComboBox();
			this.RemovePocketItemBox = new System.Windows.Forms.Button();
			this.XPRewardBox = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.VisualTab = new System.Windows.Forms.TabPage();
			this.TileIDBox = new System.Windows.Forms.NumericUpDown();
			this.AttributesTab = new System.Windows.Forms.TabPage();
			this.EntityBox = new DungeonEye.Forms.EntityControl();
			this.PropertiesTab = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label19 = new System.Windows.Forms.Label();
			this.WeaponNameBox = new System.Windows.Forms.ComboBox();
			this.ScriptBox = new ArcEngine.Editor.ScriptControl();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.AttackSpeedBox = new System.Windows.Forms.NumericUpDown();
			this.label18 = new System.Windows.Forms.Label();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.DirectionBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.CurrentBehaviourBox = new System.Windows.Forms.ComboBox();
			this.DefaultBehaviourBox = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.SightRangeBox = new System.Windows.Forms.NumericUpDown();
			this.CanSeeInvisibleBox = new System.Windows.Forms.CheckBox();
			this.SmartAIBox = new System.Windows.Forms.CheckBox();
			this.TeleportsBox = new System.Windows.Forms.CheckBox();
			this.BackRowAttackBox = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.FlyingBox = new System.Windows.Forms.CheckBox();
			this.UseStairsBox = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.PickupBox = new System.Windows.Forms.NumericUpDown();
			this.ThrowWeaponsBox = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.PoisonImmunityBox = new System.Windows.Forms.CheckBox();
			this.ArmorClassBox = new System.Windows.Forms.NumericUpDown();
			this.NonMaterialBox = new System.Windows.Forms.CheckBox();
			this.StealBox = new System.Windows.Forms.NumericUpDown();
			this.FillSquareBox = new System.Windows.Forms.CheckBox();
			this.FleesBox = new System.Windows.Forms.CheckBox();
			this.DamageBox = new DungeonEye.Forms.DiceControl();
			this.MagicTab = new System.Windows.Forms.TabPage();
			this.HasMagicBox = new System.Windows.Forms.CheckBox();
			this.MagicGroupBox = new System.Windows.Forms.GroupBox();
			this.AvailableSpellsBox = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.ClearKnownSpellsBox = new System.Windows.Forms.Button();
			this.RemoveMagicSpellBox = new System.Windows.Forms.Button();
			this.AddMagicSpellBox = new System.Windows.Forms.Button();
			this.KnownSpellsBox = new System.Windows.Forms.ListBox();
			this.label8 = new System.Windows.Forms.Label();
			this.CastingLevelBox = new System.Windows.Forms.NumericUpDown();
			this.HasDrainMagicBox = new System.Windows.Forms.CheckBox();
			this.HealMagicBox = new System.Windows.Forms.CheckBox();
			this.AudioTab = new System.Windows.Forms.TabPage();
			this.PlayHurtSoundBox = new System.Windows.Forms.Button();
			this.PlayDeathSoundBox = new System.Windows.Forms.Button();
			this.PlayMoveSoundBox = new System.Windows.Forms.Button();
			this.PlayAttackSoundBox = new System.Windows.Forms.Button();
			this.LoadHurtSoundBox = new System.Windows.Forms.Button();
			this.LoadDeathSoundBox = new System.Windows.Forms.Button();
			this.LoadMoveSoundBox = new System.Windows.Forms.Button();
			this.LoadAttackSoundBox = new System.Windows.Forms.Button();
			this.HurtSoundBox = new System.Windows.Forms.TextBox();
			this.DeathSoundBox = new System.Windows.Forms.TextBox();
			this.MoveSoundBox = new System.Windows.Forms.TextBox();
			this.AttackSoundBox = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.PocketGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.XPRewardBox)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.VisualTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TileIDBox)).BeginInit();
			this.AttributesTab.SuspendLayout();
			this.PropertiesTab.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AttackSpeedBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SightRangeBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PickupBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ArmorClassBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StealBox)).BeginInit();
			this.MagicTab.SuspendLayout();
			this.MagicGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CastingLevelBox)).BeginInit();
			this.AudioTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(29, 35);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(30, 13);
			this.label11.TabIndex = 3;
			this.label11.Text = "Tile :";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(13, 9);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(46, 13);
			this.label12.TabIndex = 3;
			this.label12.Text = "TileSet :";
			// 
			// GlControl
			// 
			this.GlControl.BackColor = System.Drawing.Color.Black;
			this.GlControl.Location = new System.Drawing.Point(7, 62);
			this.GlControl.Name = "GlControl";
			this.GlControl.Size = new System.Drawing.Size(297, 259);
			this.GlControl.TabIndex = 1;
			this.GlControl.VSync = true;
			this.GlControl.Load += new System.EventHandler(this.GlControl_Load);
			this.GlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.GlControl_Paint);
			// 
			// TileSetBox
			// 
			this.TileSetBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TileSetBox.FormattingEnabled = true;
			this.TileSetBox.Location = new System.Drawing.Point(65, 6);
			this.TileSetBox.Name = "TileSetBox";
			this.TileSetBox.Size = new System.Drawing.Size(143, 21);
			this.TileSetBox.Sorted = true;
			this.TileSetBox.TabIndex = 2;
			this.TileSetBox.SelectedIndexChanged += new System.EventHandler(this.TileSetBox_SelectedIndexChanged);
			// 
			// PocketGroupBox
			// 
			this.PocketGroupBox.Controls.Add(this.PocketItemsBox);
			this.PocketGroupBox.Controls.Add(this.AddPocketItemBox);
			this.PocketGroupBox.Controls.Add(this.ItemsBox);
			this.PocketGroupBox.Controls.Add(this.RemovePocketItemBox);
			this.PocketGroupBox.Location = new System.Drawing.Point(257, 2);
			this.PocketGroupBox.Name = "PocketGroupBox";
			this.PocketGroupBox.Size = new System.Drawing.Size(227, 169);
			this.PocketGroupBox.TabIndex = 7;
			this.PocketGroupBox.TabStop = false;
			this.PocketGroupBox.Text = "Items in pocket :";
			// 
			// PocketItemsBox
			// 
			this.PocketItemsBox.FormattingEnabled = true;
			this.PocketItemsBox.Location = new System.Drawing.Point(6, 48);
			this.PocketItemsBox.Name = "PocketItemsBox";
			this.PocketItemsBox.Size = new System.Drawing.Size(215, 82);
			this.PocketItemsBox.Sorted = true;
			this.PocketItemsBox.TabIndex = 5;
			this.PocketItemsBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PocketItemsBox_MouseDoubleClick);
			// 
			// AddPocketItemBox
			// 
			this.AddPocketItemBox.AutoSize = true;
			this.AddPocketItemBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AddPocketItemBox.Location = new System.Drawing.Point(185, 19);
			this.AddPocketItemBox.Name = "AddPocketItemBox";
			this.AddPocketItemBox.Size = new System.Drawing.Size(36, 23);
			this.AddPocketItemBox.TabIndex = 4;
			this.AddPocketItemBox.Text = "Add";
			this.AddPocketItemBox.UseVisualStyleBackColor = true;
			this.AddPocketItemBox.Click += new System.EventHandler(this.AddPocketItemBox_Click);
			// 
			// ItemsBox
			// 
			this.ItemsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ItemsBox.FormattingEnabled = true;
			this.ItemsBox.Location = new System.Drawing.Point(6, 19);
			this.ItemsBox.Name = "ItemsBox";
			this.ItemsBox.Size = new System.Drawing.Size(173, 21);
			this.ItemsBox.Sorted = true;
			this.ItemsBox.TabIndex = 3;
			// 
			// RemovePocketItemBox
			// 
			this.RemovePocketItemBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RemovePocketItemBox.Location = new System.Drawing.Point(6, 140);
			this.RemovePocketItemBox.Name = "RemovePocketItemBox";
			this.RemovePocketItemBox.Size = new System.Drawing.Size(215, 23);
			this.RemovePocketItemBox.TabIndex = 2;
			this.RemovePocketItemBox.Text = "Remove";
			this.RemovePocketItemBox.UseVisualStyleBackColor = true;
			this.RemovePocketItemBox.Click += new System.EventHandler(this.RemovePocketItemBox_Click);
			// 
			// XPRewardBox
			// 
			this.XPRewardBox.Location = new System.Drawing.Point(113, 355);
			this.XPRewardBox.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
			this.XPRewardBox.Name = "XPRewardBox";
			this.XPRewardBox.Size = new System.Drawing.Size(73, 20);
			this.XPRewardBox.TabIndex = 11;
			this.XPRewardBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.XPRewardBox.ThousandsSeparator = true;
			this.XPRewardBox.ValueChanged += new System.EventHandler(this.ExperienceBox_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(45, 357);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "XP reward :";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.VisualTab);
			this.tabControl1.Controls.Add(this.AttributesTab);
			this.tabControl1.Controls.Add(this.PropertiesTab);
			this.tabControl1.Controls.Add(this.MagicTab);
			this.tabControl1.Controls.Add(this.AudioTab);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(500, 473);
			this.tabControl1.TabIndex = 13;
			// 
			// VisualTab
			// 
			this.VisualTab.Controls.Add(this.TileIDBox);
			this.VisualTab.Controls.Add(this.label11);
			this.VisualTab.Controls.Add(this.label12);
			this.VisualTab.Controls.Add(this.GlControl);
			this.VisualTab.Controls.Add(this.TileSetBox);
			this.VisualTab.Location = new System.Drawing.Point(4, 22);
			this.VisualTab.Name = "VisualTab";
			this.VisualTab.Padding = new System.Windows.Forms.Padding(3);
			this.VisualTab.Size = new System.Drawing.Size(492, 447);
			this.VisualTab.TabIndex = 0;
			this.VisualTab.Text = "Visual";
			this.VisualTab.UseVisualStyleBackColor = true;
			// 
			// TileIDBox
			// 
			this.TileIDBox.Location = new System.Drawing.Point(65, 33);
			this.TileIDBox.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
			this.TileIDBox.Name = "TileIDBox";
			this.TileIDBox.Size = new System.Drawing.Size(93, 20);
			this.TileIDBox.TabIndex = 4;
			this.TileIDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.TileIDBox.ThousandsSeparator = true;
			this.TileIDBox.ValueChanged += new System.EventHandler(this.TileIDBox_ValueChanged);
			// 
			// AttributesTab
			// 
			this.AttributesTab.Controls.Add(this.EntityBox);
			this.AttributesTab.Location = new System.Drawing.Point(4, 22);
			this.AttributesTab.Name = "AttributesTab";
			this.AttributesTab.Padding = new System.Windows.Forms.Padding(3);
			this.AttributesTab.Size = new System.Drawing.Size(492, 447);
			this.AttributesTab.TabIndex = 1;
			this.AttributesTab.Text = "Attributes";
			this.AttributesTab.UseVisualStyleBackColor = true;
			// 
			// EntityBox
			// 
			this.EntityBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.EntityBox.Entity = null;
			this.EntityBox.Location = new System.Drawing.Point(3, 3);
			this.EntityBox.Name = "EntityBox";
			this.EntityBox.Size = new System.Drawing.Size(486, 441);
			this.EntityBox.TabIndex = 0;
			// 
			// PropertiesTab
			// 
			this.PropertiesTab.Controls.Add(this.groupBox1);
			this.PropertiesTab.Controls.Add(this.ScriptBox);
			this.PropertiesTab.Controls.Add(this.groupBox2);
			this.PropertiesTab.Controls.Add(this.PocketGroupBox);
			this.PropertiesTab.Controls.Add(this.DamageBox);
			this.PropertiesTab.Location = new System.Drawing.Point(4, 22);
			this.PropertiesTab.Name = "PropertiesTab";
			this.PropertiesTab.Size = new System.Drawing.Size(492, 447);
			this.PropertiesTab.TabIndex = 2;
			this.PropertiesTab.Text = "Properties";
			this.PropertiesTab.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.WeaponNameBox);
			this.groupBox1.Location = new System.Drawing.Point(257, 363);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(227, 74);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Attack :";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(6, 22);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(54, 13);
			this.label19.TabIndex = 1;
			this.label19.Text = "Weapon :";
			// 
			// WeaponNameBox
			// 
			this.WeaponNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.WeaponNameBox.FormattingEnabled = true;
			this.WeaponNameBox.Location = new System.Drawing.Point(66, 19);
			this.WeaponNameBox.Name = "WeaponNameBox";
			this.WeaponNameBox.Size = new System.Drawing.Size(155, 21);
			this.WeaponNameBox.Sorted = true;
			this.WeaponNameBox.TabIndex = 0;
			this.WeaponNameBox.SelectedIndexChanged += new System.EventHandler(this.WeaponNameBox_SelectedIndexChanged);
			// 
			// ScriptBox
			// 
			this.ScriptBox.ControlText = "Script :";
			this.ScriptBox.Location = new System.Drawing.Point(257, 177);
			this.ScriptBox.MinimumSize = new System.Drawing.Size(200, 70);
			this.ScriptBox.Name = "ScriptBox";
			this.ScriptBox.Size = new System.Drawing.Size(225, 74);
			this.ScriptBox.TabIndex = 14;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.AttackSpeedBox);
			this.groupBox2.Controls.Add(this.label18);
			this.groupBox2.Controls.Add(this.NameBox);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.DirectionBox);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.CurrentBehaviourBox);
			this.groupBox2.Controls.Add(this.DefaultBehaviourBox);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.SightRangeBox);
			this.groupBox2.Controls.Add(this.CanSeeInvisibleBox);
			this.groupBox2.Controls.Add(this.SmartAIBox);
			this.groupBox2.Controls.Add(this.TeleportsBox);
			this.groupBox2.Controls.Add(this.BackRowAttackBox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.FlyingBox);
			this.groupBox2.Controls.Add(this.XPRewardBox);
			this.groupBox2.Controls.Add(this.UseStairsBox);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.PickupBox);
			this.groupBox2.Controls.Add(this.ThrowWeaponsBox);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.PoisonImmunityBox);
			this.groupBox2.Controls.Add(this.ArmorClassBox);
			this.groupBox2.Controls.Add(this.NonMaterialBox);
			this.groupBox2.Controls.Add(this.StealBox);
			this.groupBox2.Controls.Add(this.FillSquareBox);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.FleesBox);
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(248, 434);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Misc :";
			// 
			// AttackSpeedBox
			// 
			this.AttackSpeedBox.Location = new System.Drawing.Point(113, 407);
			this.AttackSpeedBox.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
			this.AttackSpeedBox.Name = "AttackSpeedBox";
			this.AttackSpeedBox.Size = new System.Drawing.Size(73, 20);
			this.AttackSpeedBox.TabIndex = 24;
			this.AttackSpeedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.AttackSpeedBox.ThousandsSeparator = true;
			this.AttackSpeedBox.ValueChanged += new System.EventHandler(this.AttackSpeedBox_ValueChanged);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(37, 409);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(70, 13);
			this.label18.TabIndex = 23;
			this.label18.Text = "Attack speed";
			// 
			// NameBox
			// 
			this.NameBox.Location = new System.Drawing.Point(57, 15);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(129, 20);
			this.NameBox.TabIndex = 22;
			this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 18);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 13);
			this.label7.TabIndex = 21;
			this.label7.Text = "Name :";
			// 
			// DirectionBox
			// 
			this.DirectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DirectionBox.FormattingEnabled = true;
			this.DirectionBox.Location = new System.Drawing.Point(113, 240);
			this.DirectionBox.Name = "DirectionBox";
			this.DirectionBox.Size = new System.Drawing.Size(129, 21);
			this.DirectionBox.TabIndex = 20;
			this.DirectionBox.SelectedIndexChanged += new System.EventHandler(this.DirectionBox_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(52, 243);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 19;
			this.label2.Text = "Direction :";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(10, 216);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(97, 13);
			this.label17.TabIndex = 18;
			this.label17.Text = "Current behaviour :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 189);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 13);
			this.label1.TabIndex = 18;
			this.label1.Text = "Default behaviour :";
			// 
			// CurrentBehaviourBox
			// 
			this.CurrentBehaviourBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CurrentBehaviourBox.FormattingEnabled = true;
			this.CurrentBehaviourBox.Location = new System.Drawing.Point(113, 213);
			this.CurrentBehaviourBox.Name = "CurrentBehaviourBox";
			this.CurrentBehaviourBox.Size = new System.Drawing.Size(129, 21);
			this.CurrentBehaviourBox.Sorted = true;
			this.CurrentBehaviourBox.TabIndex = 17;
			this.CurrentBehaviourBox.SelectedIndexChanged += new System.EventHandler(this.CurrentBehaviourBox_SelectedIndexChanged);
			// 
			// DefaultBehaviourBox
			// 
			this.DefaultBehaviourBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DefaultBehaviourBox.FormattingEnabled = true;
			this.DefaultBehaviourBox.Location = new System.Drawing.Point(113, 186);
			this.DefaultBehaviourBox.Name = "DefaultBehaviourBox";
			this.DefaultBehaviourBox.Size = new System.Drawing.Size(129, 21);
			this.DefaultBehaviourBox.Sorted = true;
			this.DefaultBehaviourBox.TabIndex = 17;
			this.DefaultBehaviourBox.SelectedIndexChanged += new System.EventHandler(this.DefaultBehaviourBox_SelectedIndexChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(40, 281);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(67, 13);
			this.label16.TabIndex = 16;
			this.label16.Text = "Sight range :";
			// 
			// SightRangeBox
			// 
			this.SightRangeBox.Location = new System.Drawing.Point(113, 279);
			this.SightRangeBox.Name = "SightRangeBox";
			this.SightRangeBox.Size = new System.Drawing.Size(73, 20);
			this.SightRangeBox.TabIndex = 15;
			this.SightRangeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.SightRangeBox.ValueChanged += new System.EventHandler(this.SightRangeBox_ValueChanged);
			// 
			// CanSeeInvisibleBox
			// 
			this.CanSeeInvisibleBox.AutoSize = true;
			this.CanSeeInvisibleBox.Location = new System.Drawing.Point(135, 133);
			this.CanSeeInvisibleBox.Name = "CanSeeInvisibleBox";
			this.CanSeeInvisibleBox.Size = new System.Drawing.Size(105, 17);
			this.CanSeeInvisibleBox.TabIndex = 14;
			this.CanSeeInvisibleBox.Text = "Can see invisible";
			this.CanSeeInvisibleBox.UseVisualStyleBackColor = true;
			this.CanSeeInvisibleBox.CheckedChanged += new System.EventHandler(this.CanSeeInvisibleBox_CheckedChanged);
			// 
			// SmartAIBox
			// 
			this.SmartAIBox.AutoSize = true;
			this.SmartAIBox.Location = new System.Drawing.Point(135, 87);
			this.SmartAIBox.Name = "SmartAIBox";
			this.SmartAIBox.Size = new System.Drawing.Size(66, 17);
			this.SmartAIBox.TabIndex = 14;
			this.SmartAIBox.Text = "Smart AI";
			this.SmartAIBox.UseVisualStyleBackColor = true;
			this.SmartAIBox.CheckedChanged += new System.EventHandler(this.SmartAIBox_CheckedChanged);
			// 
			// TeleportsBox
			// 
			this.TeleportsBox.AutoSize = true;
			this.TeleportsBox.Location = new System.Drawing.Point(135, 110);
			this.TeleportsBox.Name = "TeleportsBox";
			this.TeleportsBox.Size = new System.Drawing.Size(83, 17);
			this.TeleportsBox.TabIndex = 13;
			this.TeleportsBox.Text = "Can teleport";
			this.TeleportsBox.UseVisualStyleBackColor = true;
			this.TeleportsBox.CheckedChanged += new System.EventHandler(this.TeleportsBox_CheckedChanged);
			// 
			// BackRowAttackBox
			// 
			this.BackRowAttackBox.AutoSize = true;
			this.BackRowAttackBox.Location = new System.Drawing.Point(6, 151);
			this.BackRowAttackBox.Name = "BackRowAttackBox";
			this.BackRowAttackBox.Size = new System.Drawing.Size(104, 17);
			this.BackRowAttackBox.TabIndex = 13;
			this.BackRowAttackBox.Text = "Back row attack";
			this.BackRowAttackBox.UseVisualStyleBackColor = true;
			this.BackRowAttackBox.CheckedChanged += new System.EventHandler(this.BackRowAttackBox_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 307);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(101, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Pickups floor items :";
			// 
			// FlyingBox
			// 
			this.FlyingBox.AutoSize = true;
			this.FlyingBox.Location = new System.Drawing.Point(6, 129);
			this.FlyingBox.Name = "FlyingBox";
			this.FlyingBox.Size = new System.Drawing.Size(53, 17);
			this.FlyingBox.TabIndex = 13;
			this.FlyingBox.Text = "Flying";
			this.FlyingBox.UseVisualStyleBackColor = true;
			this.FlyingBox.CheckedChanged += new System.EventHandler(this.FlyingBox_CheckedChanged);
			// 
			// UseStairsBox
			// 
			this.UseStairsBox.AutoSize = true;
			this.UseStairsBox.Location = new System.Drawing.Point(6, 107);
			this.UseStairsBox.Name = "UseStairsBox";
			this.UseStairsBox.Size = new System.Drawing.Size(72, 17);
			this.UseStairsBox.TabIndex = 13;
			this.UseStairsBox.Text = "Use stairs";
			this.UseStairsBox.UseVisualStyleBackColor = true;
			this.UseStairsBox.CheckedChanged += new System.EventHandler(this.UseStairsBox_CheckedChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(38, 331);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Steals items :";
			// 
			// PickupBox
			// 
			this.PickupBox.Location = new System.Drawing.Point(113, 305);
			this.PickupBox.Name = "PickupBox";
			this.PickupBox.Size = new System.Drawing.Size(73, 20);
			this.PickupBox.TabIndex = 4;
			this.PickupBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.PickupBox.ValueChanged += new System.EventHandler(this.PickupBox_ValueChanged);
			// 
			// ThrowWeaponsBox
			// 
			this.ThrowWeaponsBox.AutoSize = true;
			this.ThrowWeaponsBox.Location = new System.Drawing.Point(135, 64);
			this.ThrowWeaponsBox.Name = "ThrowWeaponsBox";
			this.ThrowWeaponsBox.Size = new System.Drawing.Size(102, 17);
			this.ThrowWeaponsBox.TabIndex = 3;
			this.ThrowWeaponsBox.Text = "Throw weapons";
			this.ThrowWeaponsBox.UseVisualStyleBackColor = true;
			this.ThrowWeaponsBox.CheckedChanged += new System.EventHandler(this.ThrowWeaponsBox_CheckedChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(39, 383);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Armor Class :";
			// 
			// PoisonImmunityBox
			// 
			this.PoisonImmunityBox.AutoSize = true;
			this.PoisonImmunityBox.Location = new System.Drawing.Point(135, 41);
			this.PoisonImmunityBox.Name = "PoisonImmunityBox";
			this.PoisonImmunityBox.Size = new System.Drawing.Size(101, 17);
			this.PoisonImmunityBox.TabIndex = 3;
			this.PoisonImmunityBox.Text = "Poison immunity";
			this.PoisonImmunityBox.UseVisualStyleBackColor = true;
			this.PoisonImmunityBox.CheckedChanged += new System.EventHandler(this.PoisonImmunityBox_CheckedChanged);
			// 
			// ArmorClassBox
			// 
			this.ArmorClassBox.Location = new System.Drawing.Point(113, 381);
			this.ArmorClassBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.ArmorClassBox.Name = "ArmorClassBox";
			this.ArmorClassBox.Size = new System.Drawing.Size(73, 20);
			this.ArmorClassBox.TabIndex = 11;
			this.ArmorClassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ArmorClassBox.ThousandsSeparator = true;
			this.ArmorClassBox.ValueChanged += new System.EventHandler(this.ArmorClassBox_ValueChanged);
			// 
			// NonMaterialBox
			// 
			this.NonMaterialBox.AutoSize = true;
			this.NonMaterialBox.Location = new System.Drawing.Point(6, 85);
			this.NonMaterialBox.Name = "NonMaterialBox";
			this.NonMaterialBox.Size = new System.Drawing.Size(85, 17);
			this.NonMaterialBox.TabIndex = 2;
			this.NonMaterialBox.Text = "Non-material";
			this.NonMaterialBox.UseVisualStyleBackColor = true;
			this.NonMaterialBox.CheckedChanged += new System.EventHandler(this.NonMaterialBox_CheckedChanged);
			// 
			// StealBox
			// 
			this.StealBox.Location = new System.Drawing.Point(113, 329);
			this.StealBox.Name = "StealBox";
			this.StealBox.Size = new System.Drawing.Size(73, 20);
			this.StealBox.TabIndex = 4;
			this.StealBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.StealBox.ValueChanged += new System.EventHandler(this.StealBox_ValueChanged);
			// 
			// FillSquareBox
			// 
			this.FillSquareBox.AutoSize = true;
			this.FillSquareBox.Location = new System.Drawing.Point(6, 63);
			this.FillSquareBox.Name = "FillSquareBox";
			this.FillSquareBox.Size = new System.Drawing.Size(73, 17);
			this.FillSquareBox.TabIndex = 1;
			this.FillSquareBox.Text = "Fill square";
			this.FillSquareBox.UseVisualStyleBackColor = true;
			this.FillSquareBox.CheckedChanged += new System.EventHandler(this.FillSquareBox_CheckedChanged);
			// 
			// FleesBox
			// 
			this.FleesBox.AutoSize = true;
			this.FleesBox.Location = new System.Drawing.Point(6, 41);
			this.FleesBox.Name = "FleesBox";
			this.FleesBox.Size = new System.Drawing.Size(123, 17);
			this.FleesBox.TabIndex = 0;
			this.FleesBox.Text = "Flees after an attack";
			this.FleesBox.UseVisualStyleBackColor = true;
			this.FleesBox.CheckedChanged += new System.EventHandler(this.FleesBox_CheckedChanged);
			// 
			// DamageBox
			// 
			this.DamageBox.ControlText = "Damage :";
			dice1.Faces = 1;
			dice1.Modifier = 0;
			dice1.Throws = 1;
			this.DamageBox.Dice = dice1;
			this.DamageBox.Location = new System.Drawing.Point(257, 257);
			this.DamageBox.MinimumSize = new System.Drawing.Size(225, 100);
			this.DamageBox.Name = "DamageBox";
			this.DamageBox.Size = new System.Drawing.Size(225, 100);
			this.DamageBox.TabIndex = 10;
			this.DamageBox.ValueChanged += new System.EventHandler(this.DamageBox_ValueChanged);
			// 
			// MagicTab
			// 
			this.MagicTab.Controls.Add(this.HasMagicBox);
			this.MagicTab.Controls.Add(this.MagicGroupBox);
			this.MagicTab.Location = new System.Drawing.Point(4, 22);
			this.MagicTab.Name = "MagicTab";
			this.MagicTab.Size = new System.Drawing.Size(492, 447);
			this.MagicTab.TabIndex = 4;
			this.MagicTab.Text = "Magic";
			this.MagicTab.UseVisualStyleBackColor = true;
			// 
			// HasMagicBox
			// 
			this.HasMagicBox.AutoSize = true;
			this.HasMagicBox.Location = new System.Drawing.Point(9, 3);
			this.HasMagicBox.Name = "HasMagicBox";
			this.HasMagicBox.Size = new System.Drawing.Size(77, 17);
			this.HasMagicBox.TabIndex = 4;
			this.HasMagicBox.Text = "Has Magic";
			this.HasMagicBox.UseVisualStyleBackColor = true;
			this.HasMagicBox.CheckedChanged += new System.EventHandler(this.HasMagicBox_CheckedChanged);
			// 
			// MagicGroupBox
			// 
			this.MagicGroupBox.Controls.Add(this.AvailableSpellsBox);
			this.MagicGroupBox.Controls.Add(this.label9);
			this.MagicGroupBox.Controls.Add(this.ClearKnownSpellsBox);
			this.MagicGroupBox.Controls.Add(this.RemoveMagicSpellBox);
			this.MagicGroupBox.Controls.Add(this.AddMagicSpellBox);
			this.MagicGroupBox.Controls.Add(this.KnownSpellsBox);
			this.MagicGroupBox.Controls.Add(this.label8);
			this.MagicGroupBox.Controls.Add(this.CastingLevelBox);
			this.MagicGroupBox.Controls.Add(this.HasDrainMagicBox);
			this.MagicGroupBox.Controls.Add(this.HealMagicBox);
			this.MagicGroupBox.Location = new System.Drawing.Point(3, 23);
			this.MagicGroupBox.Name = "MagicGroupBox";
			this.MagicGroupBox.Size = new System.Drawing.Size(316, 212);
			this.MagicGroupBox.TabIndex = 5;
			this.MagicGroupBox.TabStop = false;
			this.MagicGroupBox.Text = "Magic properties :";
			this.MagicGroupBox.EnabledChanged += new System.EventHandler(this.MagicGroupBox_EnabledChanged);
			// 
			// AvailableSpellsBox
			// 
			this.AvailableSpellsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AvailableSpellsBox.FormattingEnabled = true;
			this.AvailableSpellsBox.Location = new System.Drawing.Point(8, 99);
			this.AvailableSpellsBox.Name = "AvailableSpellsBox";
			this.AvailableSpellsBox.Size = new System.Drawing.Size(215, 21);
			this.AvailableSpellsBox.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(5, 83);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(75, 13);
			this.label9.TabIndex = 12;
			this.label9.Text = "Known spells :";
			// 
			// ClearKnownSpellsBox
			// 
			this.ClearKnownSpellsBox.Location = new System.Drawing.Point(234, 172);
			this.ClearKnownSpellsBox.Name = "ClearKnownSpellsBox";
			this.ClearKnownSpellsBox.Size = new System.Drawing.Size(75, 23);
			this.ClearKnownSpellsBox.TabIndex = 11;
			this.ClearKnownSpellsBox.Text = "Clear";
			this.ClearKnownSpellsBox.UseVisualStyleBackColor = true;
			// 
			// RemoveMagicSpellBox
			// 
			this.RemoveMagicSpellBox.Location = new System.Drawing.Point(234, 128);
			this.RemoveMagicSpellBox.Name = "RemoveMagicSpellBox";
			this.RemoveMagicSpellBox.Size = new System.Drawing.Size(75, 23);
			this.RemoveMagicSpellBox.TabIndex = 11;
			this.RemoveMagicSpellBox.Text = "Remove";
			this.RemoveMagicSpellBox.UseVisualStyleBackColor = true;
			// 
			// AddMagicSpellBox
			// 
			this.AddMagicSpellBox.Location = new System.Drawing.Point(234, 97);
			this.AddMagicSpellBox.Name = "AddMagicSpellBox";
			this.AddMagicSpellBox.Size = new System.Drawing.Size(75, 23);
			this.AddMagicSpellBox.TabIndex = 11;
			this.AddMagicSpellBox.Text = "Add";
			this.AddMagicSpellBox.UseVisualStyleBackColor = true;
			// 
			// KnownSpellsBox
			// 
			this.KnownSpellsBox.FormattingEnabled = true;
			this.KnownSpellsBox.Location = new System.Drawing.Point(8, 126);
			this.KnownSpellsBox.Name = "KnownSpellsBox";
			this.KnownSpellsBox.Size = new System.Drawing.Size(216, 69);
			this.KnownSpellsBox.TabIndex = 10;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(163, 25);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(73, 13);
			this.label8.TabIndex = 9;
			this.label8.Text = "Casting level :";
			// 
			// CastingLevelBox
			// 
			this.CastingLevelBox.Location = new System.Drawing.Point(249, 23);
			this.CastingLevelBox.Name = "CastingLevelBox";
			this.CastingLevelBox.Size = new System.Drawing.Size(61, 20);
			this.CastingLevelBox.TabIndex = 8;
			this.CastingLevelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.CastingLevelBox.ValueChanged += new System.EventHandler(this.CastingLevelBox_ValueChanged);
			// 
			// HasDrainMagicBox
			// 
			this.HasDrainMagicBox.AutoSize = true;
			this.HasDrainMagicBox.Location = new System.Drawing.Point(8, 48);
			this.HasDrainMagicBox.Name = "HasDrainMagicBox";
			this.HasDrainMagicBox.Size = new System.Drawing.Size(102, 17);
			this.HasDrainMagicBox.TabIndex = 6;
			this.HasDrainMagicBox.Text = "Has drain magic";
			this.HasDrainMagicBox.UseVisualStyleBackColor = true;
			// 
			// HealMagicBox
			// 
			this.HealMagicBox.AutoSize = true;
			this.HealMagicBox.Location = new System.Drawing.Point(8, 24);
			this.HealMagicBox.Name = "HealMagicBox";
			this.HealMagicBox.Size = new System.Drawing.Size(99, 17);
			this.HealMagicBox.TabIndex = 5;
			this.HealMagicBox.Text = "Has heal magic";
			this.HealMagicBox.UseVisualStyleBackColor = true;
			// 
			// AudioTab
			// 
			this.AudioTab.Controls.Add(this.PlayHurtSoundBox);
			this.AudioTab.Controls.Add(this.PlayDeathSoundBox);
			this.AudioTab.Controls.Add(this.PlayMoveSoundBox);
			this.AudioTab.Controls.Add(this.PlayAttackSoundBox);
			this.AudioTab.Controls.Add(this.LoadHurtSoundBox);
			this.AudioTab.Controls.Add(this.LoadDeathSoundBox);
			this.AudioTab.Controls.Add(this.LoadMoveSoundBox);
			this.AudioTab.Controls.Add(this.LoadAttackSoundBox);
			this.AudioTab.Controls.Add(this.HurtSoundBox);
			this.AudioTab.Controls.Add(this.DeathSoundBox);
			this.AudioTab.Controls.Add(this.MoveSoundBox);
			this.AudioTab.Controls.Add(this.AttackSoundBox);
			this.AudioTab.Controls.Add(this.label15);
			this.AudioTab.Controls.Add(this.label14);
			this.AudioTab.Controls.Add(this.label13);
			this.AudioTab.Controls.Add(this.label10);
			this.AudioTab.Location = new System.Drawing.Point(4, 22);
			this.AudioTab.Name = "AudioTab";
			this.AudioTab.Size = new System.Drawing.Size(492, 447);
			this.AudioTab.TabIndex = 3;
			this.AudioTab.Text = "Audio";
			this.AudioTab.UseVisualStyleBackColor = true;
			// 
			// PlayHurtSoundBox
			// 
			this.PlayHurtSoundBox.Image = ((System.Drawing.Image)(resources.GetObject("PlayHurtSoundBox.Image")));
			this.PlayHurtSoundBox.Location = new System.Drawing.Point(343, 101);
			this.PlayHurtSoundBox.Name = "PlayHurtSoundBox";
			this.PlayHurtSoundBox.Size = new System.Drawing.Size(23, 23);
			this.PlayHurtSoundBox.TabIndex = 3;
			this.PlayHurtSoundBox.UseVisualStyleBackColor = true;
			// 
			// PlayDeathSoundBox
			// 
			this.PlayDeathSoundBox.Image = ((System.Drawing.Image)(resources.GetObject("PlayDeathSoundBox.Image")));
			this.PlayDeathSoundBox.Location = new System.Drawing.Point(343, 75);
			this.PlayDeathSoundBox.Name = "PlayDeathSoundBox";
			this.PlayDeathSoundBox.Size = new System.Drawing.Size(23, 23);
			this.PlayDeathSoundBox.TabIndex = 3;
			this.PlayDeathSoundBox.UseVisualStyleBackColor = true;
			// 
			// PlayMoveSoundBox
			// 
			this.PlayMoveSoundBox.Image = ((System.Drawing.Image)(resources.GetObject("PlayMoveSoundBox.Image")));
			this.PlayMoveSoundBox.Location = new System.Drawing.Point(343, 49);
			this.PlayMoveSoundBox.Name = "PlayMoveSoundBox";
			this.PlayMoveSoundBox.Size = new System.Drawing.Size(23, 23);
			this.PlayMoveSoundBox.TabIndex = 3;
			this.PlayMoveSoundBox.UseVisualStyleBackColor = true;
			// 
			// PlayAttackSoundBox
			// 
			this.PlayAttackSoundBox.Image = ((System.Drawing.Image)(resources.GetObject("PlayAttackSoundBox.Image")));
			this.PlayAttackSoundBox.Location = new System.Drawing.Point(343, 23);
			this.PlayAttackSoundBox.Name = "PlayAttackSoundBox";
			this.PlayAttackSoundBox.Size = new System.Drawing.Size(23, 23);
			this.PlayAttackSoundBox.TabIndex = 3;
			this.PlayAttackSoundBox.UseVisualStyleBackColor = true;
			// 
			// LoadHurtSoundBox
			// 
			this.LoadHurtSoundBox.Location = new System.Drawing.Point(269, 102);
			this.LoadHurtSoundBox.Name = "LoadHurtSoundBox";
			this.LoadHurtSoundBox.Size = new System.Drawing.Size(68, 23);
			this.LoadHurtSoundBox.TabIndex = 2;
			this.LoadHurtSoundBox.Text = "Browse...";
			this.LoadHurtSoundBox.UseVisualStyleBackColor = true;
			this.LoadHurtSoundBox.Click += new System.EventHandler(this.LoadHurtSoundBox_Click);
			// 
			// LoadDeathSoundBox
			// 
			this.LoadDeathSoundBox.Location = new System.Drawing.Point(269, 76);
			this.LoadDeathSoundBox.Name = "LoadDeathSoundBox";
			this.LoadDeathSoundBox.Size = new System.Drawing.Size(68, 23);
			this.LoadDeathSoundBox.TabIndex = 2;
			this.LoadDeathSoundBox.Text = "Browse...";
			this.LoadDeathSoundBox.UseVisualStyleBackColor = true;
			this.LoadDeathSoundBox.Click += new System.EventHandler(this.LoadDeathSoundBox_Click);
			// 
			// LoadMoveSoundBox
			// 
			this.LoadMoveSoundBox.Location = new System.Drawing.Point(269, 50);
			this.LoadMoveSoundBox.Name = "LoadMoveSoundBox";
			this.LoadMoveSoundBox.Size = new System.Drawing.Size(68, 23);
			this.LoadMoveSoundBox.TabIndex = 2;
			this.LoadMoveSoundBox.Text = "Browse...";
			this.LoadMoveSoundBox.UseVisualStyleBackColor = true;
			this.LoadMoveSoundBox.Click += new System.EventHandler(this.LoadMoveSoundBox_Click);
			// 
			// LoadAttackSoundBox
			// 
			this.LoadAttackSoundBox.Location = new System.Drawing.Point(269, 24);
			this.LoadAttackSoundBox.Name = "LoadAttackSoundBox";
			this.LoadAttackSoundBox.Size = new System.Drawing.Size(68, 23);
			this.LoadAttackSoundBox.TabIndex = 2;
			this.LoadAttackSoundBox.Text = "Browse...";
			this.LoadAttackSoundBox.UseVisualStyleBackColor = true;
			this.LoadAttackSoundBox.Click += new System.EventHandler(this.LoadAttackSoundBox_Click);
			// 
			// HurtSoundBox
			// 
			this.HurtSoundBox.Location = new System.Drawing.Point(53, 104);
			this.HurtSoundBox.Name = "HurtSoundBox";
			this.HurtSoundBox.Size = new System.Drawing.Size(210, 20);
			this.HurtSoundBox.TabIndex = 1;
			// 
			// DeathSoundBox
			// 
			this.DeathSoundBox.Location = new System.Drawing.Point(53, 78);
			this.DeathSoundBox.Name = "DeathSoundBox";
			this.DeathSoundBox.Size = new System.Drawing.Size(210, 20);
			this.DeathSoundBox.TabIndex = 1;
			// 
			// MoveSoundBox
			// 
			this.MoveSoundBox.Location = new System.Drawing.Point(53, 52);
			this.MoveSoundBox.Name = "MoveSoundBox";
			this.MoveSoundBox.Size = new System.Drawing.Size(210, 20);
			this.MoveSoundBox.TabIndex = 1;
			// 
			// AttackSoundBox
			// 
			this.AttackSoundBox.Location = new System.Drawing.Point(53, 26);
			this.AttackSoundBox.Name = "AttackSoundBox";
			this.AttackSoundBox.Size = new System.Drawing.Size(210, 20);
			this.AttackSoundBox.TabIndex = 1;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(5, 81);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(42, 13);
			this.label15.TabIndex = 0;
			this.label15.Text = "Death :";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(14, 107);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(33, 13);
			this.label14.TabIndex = 0;
			this.label14.Text = "Hurt :";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(3, 29);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(44, 13);
			this.label13.TabIndex = 0;
			this.label13.Text = "Attack :";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(7, 55);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 13);
			this.label10.TabIndex = 0;
			this.label10.Text = "Move :";
			// 
			// MonsterControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MonsterControl";
			this.Size = new System.Drawing.Size(500, 473);
			this.PocketGroupBox.ResumeLayout(false);
			this.PocketGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.XPRewardBox)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.VisualTab.ResumeLayout(false);
			this.VisualTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TileIDBox)).EndInit();
			this.AttributesTab.ResumeLayout(false);
			this.PropertiesTab.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.AttackSpeedBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SightRangeBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PickupBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ArmorClassBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StealBox)).EndInit();
			this.MagicTab.ResumeLayout(false);
			this.MagicTab.PerformLayout();
			this.MagicGroupBox.ResumeLayout(false);
			this.MagicGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CastingLevelBox)).EndInit();
			this.AudioTab.ResumeLayout(false);
			this.AudioTab.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private OpenTK.GLControl GlControl;
		private System.Windows.Forms.ComboBox TileSetBox;
		private System.Windows.Forms.GroupBox PocketGroupBox;
		private System.Windows.Forms.ListBox PocketItemsBox;
		private System.Windows.Forms.Button AddPocketItemBox;
		private System.Windows.Forms.ComboBox ItemsBox;
		private System.Windows.Forms.Button RemovePocketItemBox;
		private DiceControl DamageBox;
		private System.Windows.Forms.NumericUpDown XPRewardBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage VisualTab;
		private System.Windows.Forms.TabPage AttributesTab;
		private System.Windows.Forms.TabPage PropertiesTab;
		private EntityControl EntityBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown ArmorClassBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown StealBox;
		private System.Windows.Forms.NumericUpDown PickupBox;
		private System.Windows.Forms.CheckBox ThrowWeaponsBox;
		private System.Windows.Forms.CheckBox PoisonImmunityBox;
		private System.Windows.Forms.CheckBox NonMaterialBox;
		private System.Windows.Forms.CheckBox FillSquareBox;
		private System.Windows.Forms.CheckBox FleesBox;
		private System.Windows.Forms.TabPage AudioTab;
		private System.Windows.Forms.CheckBox SmartAIBox;
		private System.Windows.Forms.CheckBox TeleportsBox;
		private System.Windows.Forms.CheckBox FlyingBox;
		private System.Windows.Forms.CheckBox UseStairsBox;
		private System.Windows.Forms.TabPage MagicTab;
		private System.Windows.Forms.GroupBox MagicGroupBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown CastingLevelBox;
		private System.Windows.Forms.CheckBox HasDrainMagicBox;
		private System.Windows.Forms.CheckBox HealMagicBox;
		private System.Windows.Forms.CheckBox HasMagicBox;
		private System.Windows.Forms.ComboBox AvailableSpellsBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button ClearKnownSpellsBox;
		private System.Windows.Forms.Button RemoveMagicSpellBox;
		private System.Windows.Forms.Button AddMagicSpellBox;
		private System.Windows.Forms.ListBox KnownSpellsBox;
		private System.Windows.Forms.TextBox HurtSoundBox;
		private System.Windows.Forms.TextBox DeathSoundBox;
		private System.Windows.Forms.TextBox MoveSoundBox;
		private System.Windows.Forms.TextBox AttackSoundBox;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button PlayHurtSoundBox;
		private System.Windows.Forms.Button PlayDeathSoundBox;
		private System.Windows.Forms.Button PlayMoveSoundBox;
		private System.Windows.Forms.Button PlayAttackSoundBox;
		private System.Windows.Forms.Button LoadHurtSoundBox;
		private System.Windows.Forms.Button LoadDeathSoundBox;
		private System.Windows.Forms.Button LoadMoveSoundBox;
		private System.Windows.Forms.Button LoadAttackSoundBox;
		private System.Windows.Forms.CheckBox CanSeeInvisibleBox;
		private System.Windows.Forms.CheckBox BackRowAttackBox;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.NumericUpDown SightRangeBox;
		private ArcEngine.Editor.ScriptControl ScriptBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox DefaultBehaviourBox;
		private System.Windows.Forms.ComboBox DirectionBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.ComboBox CurrentBehaviourBox;
		private System.Windows.Forms.NumericUpDown AttackSpeedBox;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ComboBox WeaponNameBox;
		private System.Windows.Forms.NumericUpDown TileIDBox;
	}
}
