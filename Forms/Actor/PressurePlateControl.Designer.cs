namespace DungeonEye.Forms
{
	partial class PressurePlateControl
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ReusableBox = new System.Windows.Forms.CheckBox();
			this.WasUsedBox = new System.Windows.Forms.CheckBox();
			this.IsHiddenBox = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.VisualTab = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.VisualBox = new OpenTK.GLControl();
			this.DecorationIdBox = new System.Windows.Forms.NumericUpDown();
			this.PropertiesTab = new System.Windows.Forms.TabPage();
			this.ActorPropertiesBox = new DungeonEye.Forms.Actor.SquareActorControl();
			this.ActionBox = new DungeonEye.Forms.PressurePlateScriptListControl();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.VisualTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DecorationIdBox)).BeginInit();
			this.PropertiesTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ReusableBox);
			this.groupBox1.Controls.Add(this.WasUsedBox);
			this.groupBox1.Controls.Add(this.IsHiddenBox);
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(214, 120);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Properties :";
			// 
			// ReusableBox
			// 
			this.ReusableBox.AutoSize = true;
			this.ReusableBox.Location = new System.Drawing.Point(6, 65);
			this.ReusableBox.Name = "ReusableBox";
			this.ReusableBox.Size = new System.Drawing.Size(71, 17);
			this.ReusableBox.TabIndex = 2;
			this.ReusableBox.Text = "Reusable";
			this.ReusableBox.UseVisualStyleBackColor = true;
			this.ReusableBox.CheckedChanged += new System.EventHandler(this.ReusableBox_CheckedChanged);
			// 
			// WasUsedBox
			// 
			this.WasUsedBox.AutoSize = true;
			this.WasUsedBox.Location = new System.Drawing.Point(6, 42);
			this.WasUsedBox.Name = "WasUsedBox";
			this.WasUsedBox.Size = new System.Drawing.Size(76, 17);
			this.WasUsedBox.TabIndex = 1;
			this.WasUsedBox.Text = "Was Used";
			this.WasUsedBox.UseVisualStyleBackColor = true;
			this.WasUsedBox.CheckedChanged += new System.EventHandler(this.WasUsedBox_CheckedChanged);
			// 
			// IsHiddenBox
			// 
			this.IsHiddenBox.AutoSize = true;
			this.IsHiddenBox.Location = new System.Drawing.Point(6, 19);
			this.IsHiddenBox.Name = "IsHiddenBox";
			this.IsHiddenBox.Size = new System.Drawing.Size(71, 17);
			this.IsHiddenBox.TabIndex = 0;
			this.IsHiddenBox.Text = "Is Hidden";
			this.IsHiddenBox.UseVisualStyleBackColor = true;
			this.IsHiddenBox.CheckedChanged += new System.EventHandler(this.HiddenBox_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tabControl1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(706, 507);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Pressure plate";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.VisualTab);
			this.tabControl1.Controls.Add(this.PropertiesTab);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(3, 16);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(700, 488);
			this.tabControl1.TabIndex = 2;
			// 
			// VisualTab
			// 
			this.VisualTab.Controls.Add(this.label1);
			this.VisualTab.Controls.Add(this.VisualBox);
			this.VisualTab.Controls.Add(this.DecorationIdBox);
			this.VisualTab.Location = new System.Drawing.Point(4, 22);
			this.VisualTab.Name = "VisualTab";
			this.VisualTab.Padding = new System.Windows.Forms.Padding(3);
			this.VisualTab.Size = new System.Drawing.Size(692, 462);
			this.VisualTab.TabIndex = 0;
			this.VisualTab.Text = "Visual";
			this.VisualTab.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Decoration id :";
			// 
			// VisualBox
			// 
			this.VisualBox.BackColor = System.Drawing.Color.Black;
			this.VisualBox.Location = new System.Drawing.Point(6, 32);
			this.VisualBox.Name = "VisualBox";
			this.VisualBox.Size = new System.Drawing.Size(352, 240);
			this.VisualBox.TabIndex = 3;
			this.VisualBox.VSync = false;
			this.VisualBox.Load += new System.EventHandler(this.VisualBox_Load);
			this.VisualBox.Paint += new System.Windows.Forms.PaintEventHandler(this.ActivatedGLBox_Paint);
			// 
			// DecorationIdBox
			// 
			this.DecorationIdBox.Location = new System.Drawing.Point(88, 6);
			this.DecorationIdBox.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.DecorationIdBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.DecorationIdBox.Name = "DecorationIdBox";
			this.DecorationIdBox.Size = new System.Drawing.Size(74, 20);
			this.DecorationIdBox.TabIndex = 4;
			this.DecorationIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.DecorationIdBox.ThousandsSeparator = true;
			this.DecorationIdBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.DecorationIdBox.ValueChanged += new System.EventHandler(this.DecorationIdBox_ValueChanged);
			// 
			// PropertiesTab
			// 
			this.PropertiesTab.Controls.Add(this.ActorPropertiesBox);
			this.PropertiesTab.Controls.Add(this.groupBox1);
			this.PropertiesTab.Controls.Add(this.ActionBox);
			this.PropertiesTab.Location = new System.Drawing.Point(4, 22);
			this.PropertiesTab.Name = "PropertiesTab";
			this.PropertiesTab.Padding = new System.Windows.Forms.Padding(3);
			this.PropertiesTab.Size = new System.Drawing.Size(692, 462);
			this.PropertiesTab.TabIndex = 1;
			this.PropertiesTab.Text = "Properties";
			this.PropertiesTab.UseVisualStyleBackColor = true;
			// 
			// ActorPropertiesBox
			// 
			this.ActorPropertiesBox.Location = new System.Drawing.Point(226, 6);
			this.ActorPropertiesBox.MinimumSize = new System.Drawing.Size(130, 120);
			this.ActorPropertiesBox.Name = "ActorPropertiesBox";
			this.ActorPropertiesBox.Size = new System.Drawing.Size(130, 120);
			this.ActorPropertiesBox.TabIndex = 2;
			// 
			// ActionBox
			// 
			this.ActionBox.Dungeon = null;
			this.ActionBox.Location = new System.Drawing.Point(6, 132);
			this.ActionBox.MinimumSize = new System.Drawing.Size(350, 150);
			this.ActionBox.Name = "ActionBox";
			this.ActionBox.Scripts = null;
			this.ActionBox.Size = new System.Drawing.Size(350, 150);
			this.ActionBox.TabIndex = 1;
			this.ActionBox.Title = "Scripts";
			// 
			// PressurePlateControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox2);
			this.Name = "PressurePlateControl";
			this.Size = new System.Drawing.Size(706, 507);
			this.Load += new System.EventHandler(this.PressurePlateControl_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.VisualTab.ResumeLayout(false);
			this.VisualTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DecorationIdBox)).EndInit();
			this.PropertiesTab.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox IsHiddenBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private PressurePlateScriptListControl ActionBox;
		private System.Windows.Forms.CheckBox WasUsedBox;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage VisualTab;
		private System.Windows.Forms.TabPage PropertiesTab;
		private System.Windows.Forms.Label label1;
		private OpenTK.GLControl VisualBox;
		private System.Windows.Forms.NumericUpDown DecorationIdBox;
		private System.Windows.Forms.CheckBox ReusableBox;
		private Actor.SquareActorControl ActorPropertiesBox;
	}
}