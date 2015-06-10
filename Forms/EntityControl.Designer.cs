namespace DungeonEye.Forms
{
	partial class EntityControl
	{
		/// <summary> 
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.MoveSpeedBox = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.AlignmentBox = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.RollAbilitiesBox = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.CharismaBox = new System.Windows.Forms.NumericUpDown();
			this.WisdomBox = new System.Windows.Forms.NumericUpDown();
			this.IntelligenceBox = new System.Windows.Forms.NumericUpDown();
			this.ConstitutionBox = new System.Windows.Forms.NumericUpDown();
			this.DexterityBox = new System.Windows.Forms.NumericUpDown();
			this.StrengthBox = new System.Windows.Forms.NumericUpDown();
			this.hitPointControl1 = new DungeonEye.Forms.HitPointControl();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MoveSpeedBox)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CharismaBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WisdomBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.IntelligenceBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConstitutionBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DexterityBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StrengthBox)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.MoveSpeedBox);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.AlignmentBox);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.hitPointControl1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(385, 322);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Entity :";
			// 
			// MoveSpeedBox
			// 
			this.MoveSpeedBox.Location = new System.Drawing.Point(291, 64);
			this.MoveSpeedBox.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.MoveSpeedBox.Name = "MoveSpeedBox";
			this.MoveSpeedBox.Size = new System.Drawing.Size(75, 20);
			this.MoveSpeedBox.TabIndex = 4;
			this.MoveSpeedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.MoveSpeedBox.ThousandsSeparator = true;
			this.MoveSpeedBox.ValueChanged += new System.EventHandler(this.MoveSpeedBox_ValueChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(180, 66);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(99, 13);
			this.label8.TabIndex = 3;
			this.label8.Text = "Move speed in ms :";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(180, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Alignment :";
			// 
			// AlignmentBox
			// 
			this.AlignmentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AlignmentBox.FormattingEnabled = true;
			this.AlignmentBox.Location = new System.Drawing.Point(245, 37);
			this.AlignmentBox.Name = "AlignmentBox";
			this.AlignmentBox.Size = new System.Drawing.Size(121, 21);
			this.AlignmentBox.TabIndex = 2;
			this.AlignmentBox.SelectedIndexChanged += new System.EventHandler(this.AlignmentBox_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.RollAbilitiesBox);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.CharismaBox);
			this.groupBox2.Controls.Add(this.WisdomBox);
			this.groupBox2.Controls.Add(this.IntelligenceBox);
			this.groupBox2.Controls.Add(this.ConstitutionBox);
			this.groupBox2.Controls.Add(this.DexterityBox);
			this.groupBox2.Controls.Add(this.StrengthBox);
			this.groupBox2.Location = new System.Drawing.Point(6, 102);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(168, 210);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Abilities :";
			// 
			// RollAbilitiesBox
			// 
			this.RollAbilitiesBox.Location = new System.Drawing.Point(71, 175);
			this.RollAbilitiesBox.Name = "RollAbilitiesBox";
			this.RollAbilitiesBox.Size = new System.Drawing.Size(75, 23);
			this.RollAbilitiesBox.TabIndex = 2;
			this.RollAbilitiesBox.Text = "Reroll";
			this.RollAbilitiesBox.UseVisualStyleBackColor = true;
			this.RollAbilitiesBox.Click += new System.EventHandler(this.RollAbilitiesBox_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 151);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Charisma :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Wisdom :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 99);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Intelligence :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Constitution :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Dexterity :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Strength :";
			// 
			// CharismaBox
			// 
			this.CharismaBox.Location = new System.Drawing.Point(80, 149);
			this.CharismaBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.CharismaBox.Name = "CharismaBox";
			this.CharismaBox.Size = new System.Drawing.Size(66, 20);
			this.CharismaBox.TabIndex = 0;
			this.CharismaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.CharismaBox.ValueChanged += new System.EventHandler(this.CharismaBox_ValueChanged);
			// 
			// WisdomBox
			// 
			this.WisdomBox.Location = new System.Drawing.Point(80, 123);
			this.WisdomBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.WisdomBox.Name = "WisdomBox";
			this.WisdomBox.Size = new System.Drawing.Size(66, 20);
			this.WisdomBox.TabIndex = 0;
			this.WisdomBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.WisdomBox.ValueChanged += new System.EventHandler(this.WisdomBox_ValueChanged);
			// 
			// IntelligenceBox
			// 
			this.IntelligenceBox.Location = new System.Drawing.Point(80, 97);
			this.IntelligenceBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.IntelligenceBox.Name = "IntelligenceBox";
			this.IntelligenceBox.Size = new System.Drawing.Size(66, 20);
			this.IntelligenceBox.TabIndex = 0;
			this.IntelligenceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.IntelligenceBox.ValueChanged += new System.EventHandler(this.IntelligenceBox_ValueChanged);
			// 
			// ConstitutionBox
			// 
			this.ConstitutionBox.Location = new System.Drawing.Point(80, 71);
			this.ConstitutionBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.ConstitutionBox.Name = "ConstitutionBox";
			this.ConstitutionBox.Size = new System.Drawing.Size(66, 20);
			this.ConstitutionBox.TabIndex = 0;
			this.ConstitutionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ConstitutionBox.ValueChanged += new System.EventHandler(this.ConstitutionBox_ValueChanged);
			// 
			// DexterityBox
			// 
			this.DexterityBox.Location = new System.Drawing.Point(80, 45);
			this.DexterityBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.DexterityBox.Name = "DexterityBox";
			this.DexterityBox.Size = new System.Drawing.Size(66, 20);
			this.DexterityBox.TabIndex = 0;
			this.DexterityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.DexterityBox.ValueChanged += new System.EventHandler(this.DexterityBox_ValueChanged);
			// 
			// StrengthBox
			// 
			this.StrengthBox.Location = new System.Drawing.Point(80, 19);
			this.StrengthBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.StrengthBox.Name = "StrengthBox";
			this.StrengthBox.Size = new System.Drawing.Size(66, 20);
			this.StrengthBox.TabIndex = 0;
			this.StrengthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.StrengthBox.ValueChanged += new System.EventHandler(this.StrengthBox_ValueChanged);
			// 
			// hitPointControl1
			// 
			this.hitPointControl1.HitPoint = null;
			this.hitPointControl1.Location = new System.Drawing.Point(6, 19);
			this.hitPointControl1.Name = "hitPointControl1";
			this.hitPointControl1.Size = new System.Drawing.Size(168, 77);
			this.hitPointControl1.TabIndex = 0;
			// 
			// EntityControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Name = "EntityControl";
			this.Size = new System.Drawing.Size(385, 322);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MoveSpeedBox)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CharismaBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WisdomBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.IntelligenceBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConstitutionBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DexterityBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StrengthBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private HitPointControl hitPointControl1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown CharismaBox;
		private System.Windows.Forms.NumericUpDown WisdomBox;
		private System.Windows.Forms.NumericUpDown IntelligenceBox;
		private System.Windows.Forms.NumericUpDown ConstitutionBox;
		private System.Windows.Forms.NumericUpDown DexterityBox;
		private System.Windows.Forms.NumericUpDown StrengthBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox AlignmentBox;
		private System.Windows.Forms.Button RollAbilitiesBox;
		private System.Windows.Forms.NumericUpDown MoveSpeedBox;
		private System.Windows.Forms.Label label8;
	}
}
