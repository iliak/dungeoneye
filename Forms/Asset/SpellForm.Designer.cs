namespace DungeonEye.Forms
{
	partial class SpellForm
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
			this.DescriptionBox = new System.Windows.Forms.TextBox();
			this.LevelBox = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.CastingTimeBox = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.DurationBox = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.RangeBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.ScriptBox = new ArcEngine.Editor.ScriptControl();
			this.label5 = new System.Windows.Forms.Label();
			this.ClassBox = new System.Windows.Forms.ComboBox();
			this.stringTableControl1 = new DungeonEye.Forms.StringTableControl();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.LevelBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.CastingTimeBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.DurationBox)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.DescriptionBox);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(477, 74);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Description :";
			// 
			// DescriptionBox
			// 
			this.DescriptionBox.CausesValidation = false;
			this.DescriptionBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DescriptionBox.Location = new System.Drawing.Point(3, 16);
			this.DescriptionBox.Multiline = true;
			this.DescriptionBox.Name = "DescriptionBox";
			this.DescriptionBox.Size = new System.Drawing.Size(471, 55);
			this.DescriptionBox.TabIndex = 0;
			this.DescriptionBox.TextChanged += new System.EventHandler(this.DescriptionBox_TextChanged);
			// 
			// LevelBox
			// 
			this.LevelBox.Location = new System.Drawing.Point(88, 205);
			this.LevelBox.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.LevelBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.LevelBox.Name = "LevelBox";
			this.LevelBox.Size = new System.Drawing.Size(77, 20);
			this.LevelBox.TabIndex = 1;
			this.LevelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.LevelBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.LevelBox.ValueChanged += new System.EventHandler(this.LevelBox_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 207);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Level : ";
			// 
			// CastingTimeBox
			// 
			this.CastingTimeBox.Location = new System.Drawing.Point(88, 231);
			this.CastingTimeBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.CastingTimeBox.Name = "CastingTimeBox";
			this.CastingTimeBox.Size = new System.Drawing.Size(77, 20);
			this.CastingTimeBox.TabIndex = 1;
			this.CastingTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.CastingTimeBox.ThousandsSeparator = true;
			this.CastingTimeBox.ValueChanged += new System.EventHandler(this.CastingTimeBox_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 233);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Casting time :";
			// 
			// DurationBox
			// 
			this.DurationBox.Location = new System.Drawing.Point(88, 257);
			this.DurationBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.DurationBox.Name = "DurationBox";
			this.DurationBox.Size = new System.Drawing.Size(77, 20);
			this.DurationBox.TabIndex = 1;
			this.DurationBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.DurationBox.ThousandsSeparator = true;
			this.DurationBox.ValueChanged += new System.EventHandler(this.DurationBox_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 259);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Duration :";
			// 
			// RangeBox
			// 
			this.RangeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.RangeBox.FormattingEnabled = true;
			this.RangeBox.Location = new System.Drawing.Point(223, 204);
			this.RangeBox.Name = "RangeBox";
			this.RangeBox.Size = new System.Drawing.Size(121, 21);
			this.RangeBox.TabIndex = 3;
			this.RangeBox.SelectedIndexChanged += new System.EventHandler(this.RangeBox_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(172, 207);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Range :";
			// 
			// ScriptBox
			// 
			this.ScriptBox.ControlText = "Interface :";
			this.ScriptBox.Location = new System.Drawing.Point(11, 283);
			this.ScriptBox.Name = "ScriptBox";
			this.ScriptBox.Size = new System.Drawing.Size(274, 87);
			this.ScriptBox.TabIndex = 5;
			this.ScriptBox.InterfaceChanged += new System.EventHandler(this.scriptControl1_InterfaceChanged);
			this.ScriptBox.ScriptChanged += new System.EventHandler(this.scriptControl1_ScriptChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(172, 236);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Class :";
			// 
			// ClassBox
			// 
			this.ClassBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ClassBox.FormattingEnabled = true;
			this.ClassBox.Items.AddRange(new object[] {
            "Cleric",
            "Mage"});
			this.ClassBox.Location = new System.Drawing.Point(223, 233);
			this.ClassBox.Name = "ClassBox";
			this.ClassBox.Size = new System.Drawing.Size(121, 21);
			this.ClassBox.Sorted = true;
			this.ClassBox.TabIndex = 6;
			this.ClassBox.SelectedIndexChanged += new System.EventHandler(this.ClassBox_SelectedIndexChanged);
			// 
			// stringTableControl1
			// 
			this.stringTableControl1.Location = new System.Drawing.Point(12, 92);
			this.stringTableControl1.Name = "stringTableControl1";
			this.stringTableControl1.ShowPreview = true;
			this.stringTableControl1.Size = new System.Drawing.Size(477, 100);
			this.stringTableControl1.StringID = 0;
			this.stringTableControl1.TabIndex = 8;
			this.stringTableControl1.Title = "Ingame name :";
			// 
			// SpellForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(877, 554);
			this.Controls.Add(this.stringTableControl1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.ClassBox);
			this.Controls.Add(this.ScriptBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.RangeBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.DurationBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CastingTimeBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LevelBox);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.Name = "SpellForm";
			this.Text = "SpellForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.LevelBox)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.CastingTimeBox)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.DurationBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox DescriptionBox;
		private System.Windows.Forms.NumericUpDown LevelBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown CastingTimeBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown DurationBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox RangeBox;
		private System.Windows.Forms.Label label4;
		private ArcEngine.Editor.ScriptControl ScriptBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox ClassBox;
		private StringTableControl stringTableControl1;
	}
}