namespace DungeonEye.Forms
{
	partial class EventSquareControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventSquareControl));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.MustFaceBox = new System.Windows.Forms.CheckBox();
			this.DirectionBox = new System.Windows.Forms.ComboBox();
			this.PreviewBox = new System.Windows.Forms.PictureBox();
			this.BrowsePictureBox = new System.Windows.Forms.Button();
			this.DisplayBorderBox = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.LoopSoundBox = new System.Windows.Forms.CheckBox();
			this.BrowseSoundBox = new System.Windows.Forms.Button();
			this.SoundNameBox = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.PropertiesTab = new System.Windows.Forms.TabPage();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.RemainingBox = new System.Windows.Forms.NumericUpDown();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.IntelligenceBox = new System.Windows.Forms.NumericUpDown();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ColorPanelBox = new System.Windows.Forms.Panel();
			this.MsgColorBox = new System.Windows.Forms.Button();
			this.MessageBox = new System.Windows.Forms.TextBox();
			this.PictureTab = new System.Windows.Forms.TabPage();
			this.PictureNameBox = new System.Windows.Forms.TextBox();
			this.ChoicesTab = new System.Windows.Forms.TabPage();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.DownChoiceBox = new System.Windows.Forms.Button();
			this.UpChoiceBox = new System.Windows.Forms.Button();
			this.DeleteChoiceBox = new System.Windows.Forms.Button();
			this.AddEditChoiceBox = new System.Windows.Forms.Button();
			this.ChoicesBox = new System.Windows.Forms.ListBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TextJustificationBox = new System.Windows.Forms.ComboBox();
			this.TextColorBox = new System.Windows.Forms.Button();
			this.TextBox = new System.Windows.Forms.TextBox();
			this.ActorControlBox = new DungeonEye.Forms.Actor.SquareActorControl();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.PropertiesTab.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RemainingBox)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.IntelligenceBox)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.PictureTab.SuspendLayout();
			this.ChoicesTab.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.MustFaceBox);
			this.groupBox1.Controls.Add(this.DirectionBox);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(132, 79);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Direction :";
			// 
			// MustFaceBox
			// 
			this.MustFaceBox.AutoSize = true;
			this.MustFaceBox.Location = new System.Drawing.Point(6, 23);
			this.MustFaceBox.Name = "MustFaceBox";
			this.MustFaceBox.Size = new System.Drawing.Size(120, 17);
			this.MustFaceBox.TabIndex = 1;
			this.MustFaceBox.Text = "Team must face to :";
			this.MustFaceBox.UseVisualStyleBackColor = true;
			this.MustFaceBox.CheckedChanged += new System.EventHandler(this.MustFaceBox_CheckedChanged);
			// 
			// DirectionBox
			// 
			this.DirectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DirectionBox.FormattingEnabled = true;
			this.DirectionBox.Location = new System.Drawing.Point(6, 48);
			this.DirectionBox.Name = "DirectionBox";
			this.DirectionBox.Size = new System.Drawing.Size(115, 21);
			this.DirectionBox.TabIndex = 0;
			this.DirectionBox.SelectedIndexChanged += new System.EventHandler(this.DirectionBox_SelectedIndexChanged);
			// 
			// PreviewBox
			// 
			this.PreviewBox.Location = new System.Drawing.Point(6, 6);
			this.PreviewBox.Name = "PreviewBox";
			this.PreviewBox.Size = new System.Drawing.Size(352, 240);
			this.PreviewBox.TabIndex = 0;
			this.PreviewBox.TabStop = false;
			// 
			// BrowsePictureBox
			// 
			this.BrowsePictureBox.AutoSize = true;
			this.BrowsePictureBox.Location = new System.Drawing.Point(6, 252);
			this.BrowsePictureBox.Name = "BrowsePictureBox";
			this.BrowsePictureBox.Size = new System.Drawing.Size(98, 23);
			this.BrowsePictureBox.TabIndex = 1;
			this.BrowsePictureBox.Text = "Browse...";
			this.BrowsePictureBox.UseVisualStyleBackColor = true;
			this.BrowsePictureBox.Click += new System.EventHandler(this.BrowsePictureBox_Click);
			// 
			// DisplayBorderBox
			// 
			this.DisplayBorderBox.AutoSize = true;
			this.DisplayBorderBox.Location = new System.Drawing.Point(11, 281);
			this.DisplayBorderBox.Name = "DisplayBorderBox";
			this.DisplayBorderBox.Size = new System.Drawing.Size(93, 17);
			this.DisplayBorderBox.TabIndex = 2;
			this.DisplayBorderBox.Text = "Display border";
			this.DisplayBorderBox.UseVisualStyleBackColor = true;
			this.DisplayBorderBox.CheckedChanged += new System.EventHandler(this.DisplayBackgroundBox_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.LoopSoundBox);
			this.groupBox3.Controls.Add(this.BrowseSoundBox);
			this.groupBox3.Controls.Add(this.SoundNameBox);
			this.groupBox3.Location = new System.Drawing.Point(141, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(149, 79);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Sound :";
			// 
			// LoopSoundBox
			// 
			this.LoopSoundBox.AutoSize = true;
			this.LoopSoundBox.Location = new System.Drawing.Point(87, 23);
			this.LoopSoundBox.Name = "LoopSoundBox";
			this.LoopSoundBox.Size = new System.Drawing.Size(50, 17);
			this.LoopSoundBox.TabIndex = 2;
			this.LoopSoundBox.Text = "Loop";
			this.LoopSoundBox.UseVisualStyleBackColor = true;
			this.LoopSoundBox.CheckedChanged += new System.EventHandler(this.LoopSoundBox_CheckedChanged);
			// 
			// BrowseSoundBox
			// 
			this.BrowseSoundBox.Location = new System.Drawing.Point(6, 19);
			this.BrowseSoundBox.Name = "BrowseSoundBox";
			this.BrowseSoundBox.Size = new System.Drawing.Size(75, 23);
			this.BrowseSoundBox.TabIndex = 1;
			this.BrowseSoundBox.Text = "Browse...";
			this.BrowseSoundBox.UseVisualStyleBackColor = true;
			this.BrowseSoundBox.Click += new System.EventHandler(this.BrowseSoundBox_Click);
			// 
			// SoundNameBox
			// 
			this.SoundNameBox.Location = new System.Drawing.Point(6, 49);
			this.SoundNameBox.Name = "SoundNameBox";
			this.SoundNameBox.Size = new System.Drawing.Size(131, 20);
			this.SoundNameBox.TabIndex = 0;
			this.SoundNameBox.TextChanged += new System.EventHandler(this.SoundNameBox_TextChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.PropertiesTab);
			this.tabControl1.Controls.Add(this.PictureTab);
			this.tabControl1.Controls.Add(this.ChoicesTab);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(550, 450);
			this.tabControl1.TabIndex = 3;
			// 
			// PropertiesTab
			// 
			this.PropertiesTab.Controls.Add(this.ActorControlBox);
			this.PropertiesTab.Controls.Add(this.groupBox5);
			this.PropertiesTab.Controls.Add(this.groupBox4);
			this.PropertiesTab.Controls.Add(this.groupBox2);
			this.PropertiesTab.Controls.Add(this.groupBox1);
			this.PropertiesTab.Controls.Add(this.groupBox3);
			this.PropertiesTab.Location = new System.Drawing.Point(4, 22);
			this.PropertiesTab.Name = "PropertiesTab";
			this.PropertiesTab.Size = new System.Drawing.Size(542, 424);
			this.PropertiesTab.TabIndex = 2;
			this.PropertiesTab.Text = "Properties";
			this.PropertiesTab.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.label2);
			this.groupBox5.Controls.Add(this.RemainingBox);
			this.groupBox5.Location = new System.Drawing.Point(141, 173);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(149, 52);
			this.groupBox5.TabIndex = 7;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Usage count :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Remaining :";
			// 
			// RemainingBox
			// 
			this.RemainingBox.Location = new System.Drawing.Point(81, 19);
			this.RemainingBox.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
			this.RemainingBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.RemainingBox.Name = "RemainingBox";
			this.RemainingBox.Size = new System.Drawing.Size(56, 20);
			this.RemainingBox.TabIndex = 0;
			this.RemainingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.RemainingBox.ThousandsSeparator = true;
			this.RemainingBox.ValueChanged += new System.EventHandler(this.RemainingBox_ValueChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Controls.Add(this.IntelligenceBox);
			this.groupBox4.Location = new System.Drawing.Point(3, 173);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(132, 52);
			this.groupBox4.TabIndex = 6;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Intelligence :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Minimum :";
			// 
			// IntelligenceBox
			// 
			this.IntelligenceBox.Location = new System.Drawing.Point(66, 19);
			this.IntelligenceBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.IntelligenceBox.Name = "IntelligenceBox";
			this.IntelligenceBox.Size = new System.Drawing.Size(55, 20);
			this.IntelligenceBox.TabIndex = 0;
			this.IntelligenceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.IntelligenceBox.ThousandsSeparator = true;
			this.IntelligenceBox.ValueChanged += new System.EventHandler(this.IntelligenceBox_ValueChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.ColorPanelBox);
			this.groupBox2.Controls.Add(this.MsgColorBox);
			this.groupBox2.Controls.Add(this.MessageBox);
			this.groupBox2.Location = new System.Drawing.Point(3, 88);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(287, 79);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Display message :";
			// 
			// ColorPanelBox
			// 
			this.ColorPanelBox.Location = new System.Drawing.Point(259, 46);
			this.ColorPanelBox.Name = "ColorPanelBox";
			this.ColorPanelBox.Size = new System.Drawing.Size(22, 22);
			this.ColorPanelBox.TabIndex = 2;
			// 
			// MsgColorBox
			// 
			this.MsgColorBox.AutoSize = true;
			this.MsgColorBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MsgColorBox.Image = ((System.Drawing.Image)(resources.GetObject("MsgColorBox.Image")));
			this.MsgColorBox.Location = new System.Drawing.Point(259, 17);
			this.MsgColorBox.Name = "MsgColorBox";
			this.MsgColorBox.Size = new System.Drawing.Size(22, 22);
			this.MsgColorBox.TabIndex = 1;
			this.MsgColorBox.UseVisualStyleBackColor = true;
			this.MsgColorBox.Click += new System.EventHandler(this.MsgColorBox_Click);
			// 
			// MessageBox
			// 
			this.MessageBox.AcceptsReturn = true;
			this.MessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MessageBox.Location = new System.Drawing.Point(6, 19);
			this.MessageBox.Multiline = true;
			this.MessageBox.Name = "MessageBox";
			this.MessageBox.Size = new System.Drawing.Size(247, 54);
			this.MessageBox.TabIndex = 0;
			this.MessageBox.TextChanged += new System.EventHandler(this.MessageBox_TextChanged);
			// 
			// PictureTab
			// 
			this.PictureTab.Controls.Add(this.PictureNameBox);
			this.PictureTab.Controls.Add(this.DisplayBorderBox);
			this.PictureTab.Controls.Add(this.BrowsePictureBox);
			this.PictureTab.Controls.Add(this.PreviewBox);
			this.PictureTab.Location = new System.Drawing.Point(4, 22);
			this.PictureTab.Name = "PictureTab";
			this.PictureTab.Padding = new System.Windows.Forms.Padding(3);
			this.PictureTab.Size = new System.Drawing.Size(542, 424);
			this.PictureTab.TabIndex = 0;
			this.PictureTab.Text = "Picture";
			this.PictureTab.UseVisualStyleBackColor = true;
			// 
			// PictureNameBox
			// 
			this.PictureNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PictureNameBox.Location = new System.Drawing.Point(110, 255);
			this.PictureNameBox.Name = "PictureNameBox";
			this.PictureNameBox.Size = new System.Drawing.Size(248, 20);
			this.PictureNameBox.TabIndex = 3;
			this.PictureNameBox.TextChanged += new System.EventHandler(this.PictureNameBox_TextChanged);
			// 
			// ChoicesTab
			// 
			this.ChoicesTab.Controls.Add(this.groupBox7);
			this.ChoicesTab.Controls.Add(this.groupBox6);
			this.ChoicesTab.Location = new System.Drawing.Point(4, 22);
			this.ChoicesTab.Name = "ChoicesTab";
			this.ChoicesTab.Padding = new System.Windows.Forms.Padding(3);
			this.ChoicesTab.Size = new System.Drawing.Size(542, 424);
			this.ChoicesTab.TabIndex = 1;
			this.ChoicesTab.Text = "Choices";
			this.ChoicesTab.UseVisualStyleBackColor = true;
			// 
			// groupBox7
			// 
			this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox7.Controls.Add(this.DownChoiceBox);
			this.groupBox7.Controls.Add(this.UpChoiceBox);
			this.groupBox7.Controls.Add(this.DeleteChoiceBox);
			this.groupBox7.Controls.Add(this.AddEditChoiceBox);
			this.groupBox7.Controls.Add(this.ChoicesBox);
			this.groupBox7.Location = new System.Drawing.Point(6, 172);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(425, 165);
			this.groupBox7.TabIndex = 2;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Choices :";
			// 
			// DownChoiceBox
			// 
			this.DownChoiceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DownChoiceBox.Location = new System.Drawing.Point(344, 130);
			this.DownChoiceBox.Name = "DownChoiceBox";
			this.DownChoiceBox.Size = new System.Drawing.Size(75, 23);
			this.DownChoiceBox.TabIndex = 1;
			this.DownChoiceBox.Text = "Down";
			this.DownChoiceBox.UseVisualStyleBackColor = true;
			this.DownChoiceBox.Click += new System.EventHandler(this.DownChoiceBox_Click);
			// 
			// UpChoiceBox
			// 
			this.UpChoiceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.UpChoiceBox.Location = new System.Drawing.Point(344, 101);
			this.UpChoiceBox.Name = "UpChoiceBox";
			this.UpChoiceBox.Size = new System.Drawing.Size(75, 23);
			this.UpChoiceBox.TabIndex = 1;
			this.UpChoiceBox.Text = "Up";
			this.UpChoiceBox.UseVisualStyleBackColor = true;
			this.UpChoiceBox.Click += new System.EventHandler(this.UpChoiceBox_Click);
			// 
			// DeleteChoiceBox
			// 
			this.DeleteChoiceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteChoiceBox.Location = new System.Drawing.Point(344, 48);
			this.DeleteChoiceBox.Name = "DeleteChoiceBox";
			this.DeleteChoiceBox.Size = new System.Drawing.Size(75, 23);
			this.DeleteChoiceBox.TabIndex = 1;
			this.DeleteChoiceBox.Text = "Delete";
			this.DeleteChoiceBox.UseVisualStyleBackColor = true;
			this.DeleteChoiceBox.Click += new System.EventHandler(this.DeleteChoiceBox_Click);
			// 
			// AddEditChoiceBox
			// 
			this.AddEditChoiceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddEditChoiceBox.Location = new System.Drawing.Point(344, 19);
			this.AddEditChoiceBox.Name = "AddEditChoiceBox";
			this.AddEditChoiceBox.Size = new System.Drawing.Size(75, 23);
			this.AddEditChoiceBox.TabIndex = 1;
			this.AddEditChoiceBox.Text = "Add";
			this.AddEditChoiceBox.UseVisualStyleBackColor = true;
			this.AddEditChoiceBox.Click += new System.EventHandler(this.AddEditChoiceBox_Click);
			// 
			// ChoicesBox
			// 
			this.ChoicesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ChoicesBox.FormattingEnabled = true;
			this.ChoicesBox.Location = new System.Drawing.Point(6, 19);
			this.ChoicesBox.Name = "ChoicesBox";
			this.ChoicesBox.Size = new System.Drawing.Size(332, 134);
			this.ChoicesBox.TabIndex = 0;
			this.ChoicesBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ChoicesBox_MouseDoubleClick);
			// 
			// groupBox6
			// 
			this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox6.Controls.Add(this.label3);
			this.groupBox6.Controls.Add(this.TextJustificationBox);
			this.groupBox6.Controls.Add(this.TextColorBox);
			this.groupBox6.Controls.Add(this.TextBox);
			this.groupBox6.Location = new System.Drawing.Point(6, 6);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(425, 160);
			this.groupBox6.TabIndex = 1;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Initial message :";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(233, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Text align :";
			// 
			// TextJustificationBox
			// 
			this.TextJustificationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TextJustificationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TextJustificationBox.FormattingEnabled = true;
			this.TextJustificationBox.Location = new System.Drawing.Point(298, 131);
			this.TextJustificationBox.Name = "TextJustificationBox";
			this.TextJustificationBox.Size = new System.Drawing.Size(121, 21);
			this.TextJustificationBox.TabIndex = 2;
			this.TextJustificationBox.SelectedIndexChanged += new System.EventHandler(this.TextJustificationBox_SelectedIndexChanged);
			// 
			// TextColorBox
			// 
			this.TextColorBox.AutoSize = true;
			this.TextColorBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TextColorBox.Image = ((System.Drawing.Image)(resources.GetObject("TextColorBox.Image")));
			this.TextColorBox.Location = new System.Drawing.Point(6, 131);
			this.TextColorBox.Name = "TextColorBox";
			this.TextColorBox.Size = new System.Drawing.Size(22, 22);
			this.TextColorBox.TabIndex = 1;
			this.TextColorBox.UseVisualStyleBackColor = true;
			// 
			// TextBox
			// 
			this.TextBox.AcceptsReturn = true;
			this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBox.Location = new System.Drawing.Point(6, 19);
			this.TextBox.Multiline = true;
			this.TextBox.Name = "TextBox";
			this.TextBox.Size = new System.Drawing.Size(413, 106);
			this.TextBox.TabIndex = 0;
			this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// ActorControlBox
			// 
			this.ActorControlBox.Actor = null;
			this.ActorControlBox.Location = new System.Drawing.Point(5, 231);
			this.ActorControlBox.MinimumSize = new System.Drawing.Size(130, 120);
			this.ActorControlBox.Name = "ActorControlBox";
			this.ActorControlBox.Size = new System.Drawing.Size(130, 120);
			this.ActorControlBox.TabIndex = 8;
			// 
			// EventSquareControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl1);
			this.MinimumSize = new System.Drawing.Size(550, 450);
			this.Name = "EventSquareControl";
			this.Size = new System.Drawing.Size(550, 450);
			this.Load += new System.EventHandler(this.EventSquareForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.PropertiesTab.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RemainingBox)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.IntelligenceBox)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.PictureTab.ResumeLayout(false);
			this.PictureTab.PerformLayout();
			this.ChoicesTab.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox MustFaceBox;
		private System.Windows.Forms.ComboBox DirectionBox;
		private System.Windows.Forms.CheckBox DisplayBorderBox;
		private System.Windows.Forms.Button BrowsePictureBox;
		private System.Windows.Forms.PictureBox PreviewBox;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button BrowseSoundBox;
		private System.Windows.Forms.TextBox SoundNameBox;
		private System.Windows.Forms.CheckBox LoopSoundBox;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage PictureTab;
		private System.Windows.Forms.TabPage ChoicesTab;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox MessageBox;
		private System.Windows.Forms.TextBox PictureNameBox;
		private System.Windows.Forms.TabPage PropertiesTab;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown IntelligenceBox;
		private System.Windows.Forms.Button MsgColorBox;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown RemainingBox;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Button DownChoiceBox;
		private System.Windows.Forms.Button UpChoiceBox;
		private System.Windows.Forms.Button DeleteChoiceBox;
		private System.Windows.Forms.Button AddEditChoiceBox;
		private System.Windows.Forms.ListBox ChoicesBox;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox TextJustificationBox;
		private System.Windows.Forms.Button TextColorBox;
		private System.Windows.Forms.TextBox TextBox;
		private System.Windows.Forms.Panel ColorPanelBox;
		private Actor.SquareActorControl ActorControlBox;
	}
}