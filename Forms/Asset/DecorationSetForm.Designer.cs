namespace DungeonEye.Forms
{
	partial class DecorationSetForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecorationSetForm));
			this.OpenGLBox = new OpenTK.GLControl();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.DisplayWallBox = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BackgroundTileSetBox = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ForceDisplayBox = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.BlockBox = new System.Windows.Forms.CheckBox();
			this.DecorationIdBox = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.TilesetBox = new System.Windows.Forms.ComboBox();
			this.HorizontalSwapBox = new System.Windows.Forms.CheckBox();
			this.TileLocationBox = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.TileIdBox = new System.Windows.Forms.NumericUpDown();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.PasteBox = new System.Windows.Forms.Button();
			this.CopyBox = new System.Windows.Forms.Button();
			this.ClearAllBox = new System.Windows.Forms.Button();
			this.ViewPositionBox = new DungeonEye.Forms.ViewFieldControl();
			this.DrawTimer = new System.Windows.Forms.Timer(this.components);
			this.ItemTileSetBox = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.ItemPositionBox = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.ItemIdBox = new System.Windows.Forms.NumericUpDown();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.VisualTab = new System.Windows.Forms.TabPage();
			this.label10 = new System.Windows.Forms.Label();
			this.ItemsTab = new System.Windows.Forms.TabPage();
			this.label11 = new System.Windows.Forms.Label();
			this.OnHackTab = new System.Windows.Forms.TabPage();
			this.OnHackIdBox = new System.Windows.Forms.NumericUpDown();
			this.label15 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.OnClickTab = new System.Windows.Forms.TabPage();
			this.OnClickIdBox = new System.Windows.Forms.NumericUpDown();
			this.label16 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.OnBashTab = new System.Windows.Forms.TabPage();
			this.OnBashIdBox = new System.Windows.Forms.NumericUpDown();
			this.label17 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.HideItemsBox = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DecorationIdBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TileIdBox)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ItemIdBox)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.VisualTab.SuspendLayout();
			this.ItemsTab.SuspendLayout();
			this.OnHackTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.OnHackIdBox)).BeginInit();
			this.OnClickTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.OnClickIdBox)).BeginInit();
			this.OnBashTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.OnBashIdBox)).BeginInit();
			this.SuspendLayout();
			// 
			// OpenGLBox
			// 
			this.OpenGLBox.BackColor = System.Drawing.Color.Black;
			this.OpenGLBox.Location = new System.Drawing.Point(6, 98);
			this.OpenGLBox.Name = "OpenGLBox";
			this.OpenGLBox.Size = new System.Drawing.Size(352, 240);
			this.OpenGLBox.TabIndex = 0;
			this.OpenGLBox.VSync = false;
			this.OpenGLBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OpenGLBox_MouseMove);
			this.OpenGLBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OpenGLBox_PreviewKeyDown);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.DisplayWallBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.BackgroundTileSetBox);
			this.groupBox1.Controls.Add(this.OpenGLBox);
			this.groupBox1.Location = new System.Drawing.Point(284, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(369, 344);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Preview :";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(157, 54);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "label9";
			// 
			// DisplayWallBox
			// 
			this.DisplayWallBox.AutoSize = true;
			this.DisplayWallBox.Checked = true;
			this.DisplayWallBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.DisplayWallBox.Location = new System.Drawing.Point(9, 75);
			this.DisplayWallBox.Name = "DisplayWallBox";
			this.DisplayWallBox.Size = new System.Drawing.Size(86, 17);
			this.DisplayWallBox.TabIndex = 3;
			this.DisplayWallBox.Text = "Display walls";
			this.DisplayWallBox.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Background tileset :";
			// 
			// BackgroundTileSetBox
			// 
			this.BackgroundTileSetBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BackgroundTileSetBox.FormattingEnabled = true;
			this.BackgroundTileSetBox.Location = new System.Drawing.Point(113, 19);
			this.BackgroundTileSetBox.Name = "BackgroundTileSetBox";
			this.BackgroundTileSetBox.Size = new System.Drawing.Size(245, 21);
			this.BackgroundTileSetBox.Sorted = true;
			this.BackgroundTileSetBox.TabIndex = 1;
			this.BackgroundTileSetBox.SelectedIndexChanged += new System.EventHandler(this.BgTileSetBox_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.ForceDisplayBox);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.BlockBox);
			this.groupBox2.Controls.Add(this.DecorationIdBox);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.TilesetBox);
			this.groupBox2.Location = new System.Drawing.Point(12, 167);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(266, 98);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "General properties :";
			// 
			// ForceDisplayBox
			// 
			this.ForceDisplayBox.AutoSize = true;
			this.ForceDisplayBox.Location = new System.Drawing.Point(159, 49);
			this.ForceDisplayBox.Name = "ForceDisplayBox";
			this.ForceDisplayBox.Size = new System.Drawing.Size(88, 17);
			this.ForceDisplayBox.TabIndex = 6;
			this.ForceDisplayBox.Text = "Force display";
			this.ForceDisplayBox.UseVisualStyleBackColor = true;
			this.ForceDisplayBox.CheckedChanged += new System.EventHandler(this.AlwaysVisibleBox_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Decoration id :";
			// 
			// BlockBox
			// 
			this.BlockBox.AutoSize = true;
			this.BlockBox.Location = new System.Drawing.Point(159, 72);
			this.BlockBox.Name = "BlockBox";
			this.BlockBox.Size = new System.Drawing.Size(77, 17);
			this.BlockBox.TabIndex = 6;
			this.BlockBox.Text = "Is blocking";
			this.BlockBox.UseVisualStyleBackColor = true;
			this.BlockBox.CheckedChanged += new System.EventHandler(this.BlockBox_CheckedChanged);
			// 
			// DecorationIdBox
			// 
			this.DecorationIdBox.Location = new System.Drawing.Point(91, 46);
			this.DecorationIdBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.DecorationIdBox.Name = "DecorationIdBox";
			this.DecorationIdBox.Size = new System.Drawing.Size(62, 20);
			this.DecorationIdBox.TabIndex = 2;
			this.DecorationIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.DecorationIdBox.ThousandsSeparator = true;
			this.DecorationIdBox.ValueChanged += new System.EventHandler(this.DecorationIdBox_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tileset :";
			// 
			// TilesetBox
			// 
			this.TilesetBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TilesetBox.FormattingEnabled = true;
			this.TilesetBox.Location = new System.Drawing.Point(91, 19);
			this.TilesetBox.Name = "TilesetBox";
			this.TilesetBox.Size = new System.Drawing.Size(169, 21);
			this.TilesetBox.Sorted = true;
			this.TilesetBox.TabIndex = 0;
			this.TilesetBox.SelectedIndexChanged += new System.EventHandler(this.TilesetBox_SelectedIndexChanged);
			// 
			// HorizontalSwapBox
			// 
			this.HorizontalSwapBox.AutoSize = true;
			this.HorizontalSwapBox.Location = new System.Drawing.Point(150, 31);
			this.HorizontalSwapBox.Name = "HorizontalSwapBox";
			this.HorizontalSwapBox.Size = new System.Drawing.Size(101, 17);
			this.HorizontalSwapBox.TabIndex = 6;
			this.HorizontalSwapBox.Text = "Horizontal swap";
			this.HorizontalSwapBox.UseVisualStyleBackColor = true;
			this.HorizontalSwapBox.CheckedChanged += new System.EventHandler(this.HorizontalSwapBox_CheckedChanged);
			// 
			// TileLocationBox
			// 
			this.TileLocationBox.Location = new System.Drawing.Point(63, 60);
			this.TileLocationBox.Name = "TileLocationBox";
			this.TileLocationBox.Size = new System.Drawing.Size(90, 23);
			this.TileLocationBox.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Position :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Tile id :";
			// 
			// TileIdBox
			// 
			this.TileIdBox.Location = new System.Drawing.Point(57, 28);
			this.TileIdBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.TileIdBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.TileIdBox.Name = "TileIdBox";
			this.TileIdBox.Size = new System.Drawing.Size(67, 20);
			this.TileIdBox.TabIndex = 2;
			this.TileIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.TileIdBox.ThousandsSeparator = true;
			this.TileIdBox.ValueChanged += new System.EventHandler(this.TileIdBox_ValueChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.PasteBox);
			this.groupBox3.Controls.Add(this.CopyBox);
			this.groupBox3.Controls.Add(this.ClearAllBox);
			this.groupBox3.Controls.Add(this.ViewPositionBox);
			this.groupBox3.Location = new System.Drawing.Point(12, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(266, 149);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "View point :";
			// 
			// PasteBox
			// 
			this.PasteBox.Enabled = false;
			this.PasteBox.Image = ((System.Drawing.Image)(resources.GetObject("PasteBox.Image")));
			this.PasteBox.Location = new System.Drawing.Point(235, 19);
			this.PasteBox.Name = "PasteBox";
			this.PasteBox.Size = new System.Drawing.Size(25, 25);
			this.PasteBox.TabIndex = 2;
			this.PasteBox.UseVisualStyleBackColor = true;
			this.PasteBox.Click += new System.EventHandler(this.PasteBox_Click);
			// 
			// CopyBox
			// 
			this.CopyBox.AutoSize = true;
			this.CopyBox.Image = ((System.Drawing.Image)(resources.GetObject("CopyBox.Image")));
			this.CopyBox.Location = new System.Drawing.Point(204, 19);
			this.CopyBox.Name = "CopyBox";
			this.CopyBox.Size = new System.Drawing.Size(25, 25);
			this.CopyBox.TabIndex = 2;
			this.CopyBox.UseVisualStyleBackColor = true;
			this.CopyBox.Click += new System.EventHandler(this.CopyBox_Click);
			// 
			// ClearAllBox
			// 
			this.ClearAllBox.Location = new System.Drawing.Point(175, 120);
			this.ClearAllBox.Name = "ClearAllBox";
			this.ClearAllBox.Size = new System.Drawing.Size(75, 23);
			this.ClearAllBox.TabIndex = 1;
			this.ClearAllBox.Text = "Clear";
			this.ClearAllBox.UseVisualStyleBackColor = true;
			this.ClearAllBox.Click += new System.EventHandler(this.ClearAllBox_Click);
			// 
			// ViewPositionBox
			// 
			this.ViewPositionBox.Location = new System.Drawing.Point(9, 19);
			this.ViewPositionBox.MinimumSize = new System.Drawing.Size(160, 120);
			this.ViewPositionBox.Name = "ViewPositionBox";
			this.ViewPositionBox.Position = DungeonEye.ViewFieldPosition.L;
			this.ViewPositionBox.Size = new System.Drawing.Size(160, 120);
			this.ViewPositionBox.TabIndex = 0;
			this.ViewPositionBox.PositionChanged += new DungeonEye.Forms.ViewFieldControl.ChangedEventHandler(this.ViewPositionBox_PositionChanged);
			// 
			// DrawTimer
			// 
			this.DrawTimer.Interval = 66;
			this.DrawTimer.Tick += new System.EventHandler(this.DrawTimer_Tick);
			// 
			// ItemTileSetBox
			// 
			this.ItemTileSetBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ItemTileSetBox.FormattingEnabled = true;
			this.ItemTileSetBox.Location = new System.Drawing.Point(56, 46);
			this.ItemTileSetBox.Name = "ItemTileSetBox";
			this.ItemTileSetBox.Size = new System.Drawing.Size(196, 21);
			this.ItemTileSetBox.TabIndex = 0;
			this.ItemTileSetBox.SelectedIndexChanged += new System.EventHandler(this.ItemTileSetBox_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 49);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Tileset :";
			// 
			// ItemPositionBox
			// 
			this.ItemPositionBox.AutoSize = true;
			this.ItemPositionBox.Location = new System.Drawing.Point(175, 76);
			this.ItemPositionBox.Name = "ItemPositionBox";
			this.ItemPositionBox.Size = new System.Drawing.Size(58, 13);
			this.ItemPositionBox.TabIndex = 2;
			this.ItemPositionBox.Text = "XXX : XXX";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(119, 76);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 13);
			this.label8.TabIndex = 2;
			this.label8.Text = "Position :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 76);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Item id :";
			// 
			// ItemIdBox
			// 
			this.ItemIdBox.Location = new System.Drawing.Point(56, 74);
			this.ItemIdBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.ItemIdBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.ItemIdBox.Name = "ItemIdBox";
			this.ItemIdBox.Size = new System.Drawing.Size(57, 20);
			this.ItemIdBox.TabIndex = 2;
			this.ItemIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ItemIdBox.ThousandsSeparator = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.VisualTab);
			this.tabControl1.Controls.Add(this.ItemsTab);
			this.tabControl1.Controls.Add(this.OnHackTab);
			this.tabControl1.Controls.Add(this.OnClickTab);
			this.tabControl1.Controls.Add(this.OnBashTab);
			this.tabControl1.Location = new System.Drawing.Point(12, 271);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(266, 186);
			this.tabControl1.TabIndex = 7;
			// 
			// VisualTab
			// 
			this.VisualTab.Controls.Add(this.label10);
			this.VisualTab.Controls.Add(this.HorizontalSwapBox);
			this.VisualTab.Controls.Add(this.TileIdBox);
			this.VisualTab.Controls.Add(this.label4);
			this.VisualTab.Controls.Add(this.TileLocationBox);
			this.VisualTab.Controls.Add(this.label5);
			this.VisualTab.Location = new System.Drawing.Point(4, 22);
			this.VisualTab.Name = "VisualTab";
			this.VisualTab.Padding = new System.Windows.Forms.Padding(3);
			this.VisualTab.Size = new System.Drawing.Size(258, 160);
			this.VisualTab.TabIndex = 0;
			this.VisualTab.Text = "Visual";
			this.VisualTab.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(7, 7);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(209, 13);
			this.label10.TabIndex = 7;
			this.label10.Text = "Defines the visual aspect of the decoration";
			// 
			// ItemsTab
			// 
			this.ItemsTab.Controls.Add(this.HideItemsBox);
			this.ItemsTab.Controls.Add(this.label11);
			this.ItemsTab.Controls.Add(this.label8);
			this.ItemsTab.Controls.Add(this.ItemTileSetBox);
			this.ItemsTab.Controls.Add(this.ItemIdBox);
			this.ItemsTab.Controls.Add(this.label6);
			this.ItemsTab.Controls.Add(this.ItemPositionBox);
			this.ItemsTab.Controls.Add(this.label7);
			this.ItemsTab.Location = new System.Drawing.Point(4, 22);
			this.ItemsTab.Name = "ItemsTab";
			this.ItemsTab.Padding = new System.Windows.Forms.Padding(3);
			this.ItemsTab.Size = new System.Drawing.Size(258, 160);
			this.ItemsTab.TabIndex = 1;
			this.ItemsTab.Text = "Items";
			this.ItemsTab.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(7, 7);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(248, 36);
			this.label11.TabIndex = 8;
			this.label11.Text = "This panel helps you to define the on screen position of items";
			// 
			// OnHackTab
			// 
			this.OnHackTab.Controls.Add(this.OnHackIdBox);
			this.OnHackTab.Controls.Add(this.label15);
			this.OnHackTab.Controls.Add(this.label12);
			this.OnHackTab.Location = new System.Drawing.Point(4, 22);
			this.OnHackTab.Name = "OnHackTab";
			this.OnHackTab.Size = new System.Drawing.Size(258, 160);
			this.OnHackTab.TabIndex = 2;
			this.OnHackTab.Text = "OnHack";
			this.OnHackTab.UseVisualStyleBackColor = true;
			// 
			// OnHackIdBox
			// 
			this.OnHackIdBox.Location = new System.Drawing.Point(98, 47);
			this.OnHackIdBox.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
			this.OnHackIdBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.OnHackIdBox.Name = "OnHackIdBox";
			this.OnHackIdBox.Size = new System.Drawing.Size(83, 20);
			this.OnHackIdBox.TabIndex = 11;
			this.OnHackIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.OnHackIdBox.ThousandsSeparator = true;
			this.OnHackIdBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.OnHackIdBox.ValueChanged += new System.EventHandler(this.OnHackIdBox_ValueChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(8, 49);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(84, 13);
			this.label15.TabIndex = 10;
			this.label15.Text = "Exchange to id :";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(7, 7);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(248, 31);
			this.label12.TabIndex = 9;
			this.label12.Text = "This panel defines the decoration to use when hacked";
			// 
			// OnClickTab
			// 
			this.OnClickTab.Controls.Add(this.OnClickIdBox);
			this.OnClickTab.Controls.Add(this.label16);
			this.OnClickTab.Controls.Add(this.label13);
			this.OnClickTab.Location = new System.Drawing.Point(4, 22);
			this.OnClickTab.Name = "OnClickTab";
			this.OnClickTab.Size = new System.Drawing.Size(258, 160);
			this.OnClickTab.TabIndex = 3;
			this.OnClickTab.Text = "OnClick";
			this.OnClickTab.UseVisualStyleBackColor = true;
			// 
			// OnClickIdBox
			// 
			this.OnClickIdBox.Location = new System.Drawing.Point(99, 43);
			this.OnClickIdBox.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
			this.OnClickIdBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.OnClickIdBox.Name = "OnClickIdBox";
			this.OnClickIdBox.Size = new System.Drawing.Size(83, 20);
			this.OnClickIdBox.TabIndex = 13;
			this.OnClickIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.OnClickIdBox.ThousandsSeparator = true;
			this.OnClickIdBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.OnClickIdBox.ValueChanged += new System.EventHandler(this.OnClickIdBox_ValueChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(9, 45);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(84, 13);
			this.label16.TabIndex = 12;
			this.label16.Text = "Exchange to id :";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(7, 7);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(249, 36);
			this.label13.TabIndex = 10;
			this.label13.Text = "This panel defines the decoration to use when clicked";
			// 
			// OnBashTab
			// 
			this.OnBashTab.Controls.Add(this.OnBashIdBox);
			this.OnBashTab.Controls.Add(this.label17);
			this.OnBashTab.Controls.Add(this.label14);
			this.OnBashTab.Location = new System.Drawing.Point(4, 22);
			this.OnBashTab.Name = "OnBashTab";
			this.OnBashTab.Size = new System.Drawing.Size(258, 160);
			this.OnBashTab.TabIndex = 4;
			this.OnBashTab.Text = "OnBash";
			this.OnBashTab.UseVisualStyleBackColor = true;
			// 
			// OnBashIdBox
			// 
			this.OnBashIdBox.Location = new System.Drawing.Point(98, 43);
			this.OnBashIdBox.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
			this.OnBashIdBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.OnBashIdBox.Name = "OnBashIdBox";
			this.OnBashIdBox.Size = new System.Drawing.Size(83, 20);
			this.OnBashIdBox.TabIndex = 13;
			this.OnBashIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.OnBashIdBox.ThousandsSeparator = true;
			this.OnBashIdBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.OnBashIdBox.ValueChanged += new System.EventHandler(this.OnBashIdBox_ValueChanged);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(8, 45);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(84, 13);
			this.label17.TabIndex = 12;
			this.label17.Text = "Exchange to id :";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(7, 7);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(249, 36);
			this.label14.TabIndex = 11;
			this.label14.Text = "This panel defines the decoration to use when bashed";
			// 
			// HideItemsBox
			// 
			this.HideItemsBox.AutoSize = true;
			this.HideItemsBox.Location = new System.Drawing.Point(6, 110);
			this.HideItemsBox.Name = "HideItemsBox";
			this.HideItemsBox.Size = new System.Drawing.Size(75, 17);
			this.HideItemsBox.TabIndex = 9;
			this.HideItemsBox.Text = "Hide items";
			this.HideItemsBox.UseVisualStyleBackColor = true;
			this.HideItemsBox.CheckedChanged += new System.EventHandler(this.HideItemsBox_CheckedChanged);
			// 
			// DecorationSetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1129, 673);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "DecorationSetForm";
			this.Text = "DecorationSet Form";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DecorationForm_FormClosed);
			this.Load += new System.EventHandler(this.DecorationForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DecorationIdBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TileIdBox)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ItemIdBox)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.VisualTab.ResumeLayout(false);
			this.VisualTab.PerformLayout();
			this.ItemsTab.ResumeLayout(false);
			this.ItemsTab.PerformLayout();
			this.OnHackTab.ResumeLayout(false);
			this.OnHackTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.OnHackIdBox)).EndInit();
			this.OnClickTab.ResumeLayout(false);
			this.OnClickTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.OnClickIdBox)).EndInit();
			this.OnBashTab.ResumeLayout(false);
			this.OnBashTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.OnBashIdBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private OpenTK.GLControl OpenGLBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private ViewFieldControl ViewPositionBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox BackgroundTileSetBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox TilesetBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown DecorationIdBox;
		private System.Windows.Forms.Label TileLocationBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown TileIdBox;
		private System.Windows.Forms.CheckBox DisplayWallBox;
		private System.Windows.Forms.Timer DrawTimer;
		private System.Windows.Forms.CheckBox HorizontalSwapBox;
		private System.Windows.Forms.Button ClearAllBox;
		private System.Windows.Forms.CheckBox BlockBox;
		private System.Windows.Forms.CheckBox ForceDisplayBox;
		private System.Windows.Forms.Button PasteBox;
		private System.Windows.Forms.Button CopyBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown ItemIdBox;
		private System.Windows.Forms.Label ItemPositionBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox ItemTileSetBox;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage VisualTab;
		private System.Windows.Forms.TabPage ItemsTab;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TabPage OnHackTab;
		private System.Windows.Forms.TabPage OnClickTab;
		private System.Windows.Forms.TabPage OnBashTab;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.NumericUpDown OnHackIdBox;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.NumericUpDown OnClickIdBox;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.NumericUpDown OnBashIdBox;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.CheckBox HideItemsBox;
	}
}