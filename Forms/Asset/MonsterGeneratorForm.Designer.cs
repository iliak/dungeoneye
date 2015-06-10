namespace DungeonEye.Forms
{
	partial class MonsterGeneratorForm
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
			this.DoneBox = new System.Windows.Forms.Button();
			this.MonsterTypeBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SpawnCountBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SpawnRateBox = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.ActiveBox = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.switchCountControl1 = new DungeonEye.Forms.SwitchCountControl();
			((System.ComponentModel.ISupportInitialize) (this.SpawnRateBox)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// DoneBox
			// 
			this.DoneBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DoneBox.Location = new System.Drawing.Point(348, 171);
			this.DoneBox.Name = "DoneBox";
			this.DoneBox.Size = new System.Drawing.Size(75, 23);
			this.DoneBox.TabIndex = 0;
			this.DoneBox.Text = "Done";
			this.DoneBox.UseVisualStyleBackColor = true;
			// 
			// MonsterTypeBox
			// 
			this.MonsterTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.MonsterTypeBox.FormattingEnabled = true;
			this.MonsterTypeBox.Location = new System.Drawing.Point(111, 19);
			this.MonsterTypeBox.Name = "MonsterTypeBox";
			this.MonsterTypeBox.Size = new System.Drawing.Size(121, 21);
			this.MonsterTypeBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Type";
			// 
			// SpawnCountBox
			// 
			this.SpawnCountBox.FormattingEnabled = true;
			this.SpawnCountBox.Items.AddRange(new object[] {
            "Random",
            "1",
            "2",
            "3",
            "4"});
			this.SpawnCountBox.Location = new System.Drawing.Point(111, 46);
			this.SpawnCountBox.Name = "SpawnCountBox";
			this.SpawnCountBox.Size = new System.Drawing.Size(121, 21);
			this.SpawnCountBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Spawn count";
			// 
			// SpawnRateBox
			// 
			this.SpawnRateBox.Location = new System.Drawing.Point(123, 19);
			this.SpawnRateBox.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
			this.SpawnRateBox.Name = "SpawnRateBox";
			this.SpawnRateBox.Size = new System.Drawing.Size(109, 20);
			this.SpawnRateBox.TabIndex = 4;
			this.SpawnRateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.SpawnRateBox.ThousandsSeparator = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Rate in seconds";
			// 
			// ActiveBox
			// 
			this.ActiveBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.ActiveBox.AutoSize = true;
			this.ActiveBox.Location = new System.Drawing.Point(256, 117);
			this.ActiveBox.Name = "ActiveBox";
			this.ActiveBox.Size = new System.Drawing.Size(57, 23);
			this.ActiveBox.TabIndex = 5;
			this.ActiveBox.Text = "Is active";
			this.ActiveBox.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.SpawnRateBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(12, 117);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(238, 78);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Generation";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Left before deactivate";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(123, 45);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(109, 20);
			this.numericUpDown1.TabIndex = 4;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown1.ThousandsSeparator = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.MonsterTypeBox);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.SpawnCountBox);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(238, 99);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Monster";
			// 
			// switchCountControl1
			// 
			this.switchCountControl1.Location = new System.Drawing.Point(256, 12);
			this.switchCountControl1.Name = "switchCountControl1";
			this.switchCountControl1.Size = new System.Drawing.Size(176, 99);
			this.switchCountControl1.TabIndex = 8;
			// 
			// MonsterGeneratorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(435, 206);
			this.Controls.Add(this.switchCountControl1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.ActiveBox);
			this.Controls.Add(this.DoneBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MonsterGeneratorForm";
			this.ShowInTaskbar = false;
			this.Text = "Monster generator";
			((System.ComponentModel.ISupportInitialize) (this.SpawnRateBox)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button DoneBox;
		private System.Windows.Forms.ComboBox MonsterTypeBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox SpawnCountBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown SpawnRateBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox ActiveBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private SwitchCountControl switchCountControl1;
	}
}