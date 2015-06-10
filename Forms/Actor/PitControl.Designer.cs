namespace DungeonEye.Forms
{
	partial class PitControl
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
			DungeonEye.Dice dice1 = new DungeonEye.Dice();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.DifficultyBox = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.MonsterTriggerBox = new System.Windows.Forms.CheckBox();
			this.IsHiddenBox = new System.Windows.Forms.CheckBox();
			this.IsIllusionBox = new System.Windows.Forms.CheckBox();
			this.TargetBox = new DungeonEye.Forms.TargetControl();
			this.DamageBox = new DungeonEye.Forms.DiceControl();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DifficultyBox)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.DifficultyBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.MonsterTriggerBox);
			this.groupBox1.Controls.Add(this.IsHiddenBox);
			this.groupBox1.Controls.Add(this.IsIllusionBox);
			this.groupBox1.Location = new System.Drawing.Point(6, 125);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(230, 72);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// DifficultyBox
			// 
			this.DifficultyBox.Location = new System.Drawing.Point(156, 18);
			this.DifficultyBox.Name = "DifficultyBox";
			this.DifficultyBox.Size = new System.Drawing.Size(53, 20);
			this.DifficultyBox.TabIndex = 2;
			this.DifficultyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.DifficultyBox.ThousandsSeparator = true;
			this.DifficultyBox.ValueChanged += new System.EventHandler(this.DifficultyBox_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(103, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Difficulty";
			// 
			// MonsterTriggerBox
			// 
			this.MonsterTriggerBox.AutoSize = true;
			this.MonsterTriggerBox.Location = new System.Drawing.Point(106, 42);
			this.MonsterTriggerBox.Name = "MonsterTriggerBox";
			this.MonsterTriggerBox.Size = new System.Drawing.Size(118, 17);
			this.MonsterTriggerBox.TabIndex = 0;
			this.MonsterTriggerBox.Text = "Monster also trigger";
			this.MonsterTriggerBox.UseVisualStyleBackColor = true;
			this.MonsterTriggerBox.CheckedChanged += new System.EventHandler(this.MonsterTriggerBox_CheckedChanged);
			// 
			// IsHiddenBox
			// 
			this.IsHiddenBox.AutoSize = true;
			this.IsHiddenBox.Location = new System.Drawing.Point(6, 42);
			this.IsHiddenBox.Name = "IsHiddenBox";
			this.IsHiddenBox.Size = new System.Drawing.Size(60, 17);
			this.IsHiddenBox.TabIndex = 0;
			this.IsHiddenBox.Text = "Hidden";
			this.IsHiddenBox.UseVisualStyleBackColor = true;
			this.IsHiddenBox.CheckedChanged += new System.EventHandler(this.IsHiddenBox_CheckedChanged);
			// 
			// IsIllusionBox
			// 
			this.IsIllusionBox.AutoSize = true;
			this.IsIllusionBox.Location = new System.Drawing.Point(6, 19);
			this.IsIllusionBox.Name = "IsIllusionBox";
			this.IsIllusionBox.Size = new System.Drawing.Size(58, 17);
			this.IsIllusionBox.TabIndex = 0;
			this.IsIllusionBox.Text = "Illusion";
			this.IsIllusionBox.UseVisualStyleBackColor = true;
			this.IsIllusionBox.CheckedChanged += new System.EventHandler(this.IsIllusionBox_CheckedChanged);
			// 
			// TargetBox
			// 
			this.TargetBox.Dungeon = null;
			this.TargetBox.Location = new System.Drawing.Point(242, 19);
			this.TargetBox.MinimumSize = new System.Drawing.Size(175, 100);
			this.TargetBox.Name = "TargetBox";
			this.TargetBox.Size = new System.Drawing.Size(175, 100);
			this.TargetBox.TabIndex = 2;
			this.TargetBox.Title = "Target :";
			this.TargetBox.TargetChanged += new DungeonEye.Forms.TargetControl.TargetChangedEventHandler(this.TargetBox_TargetChanged);
			// 
			// DamageBox
			// 
			this.DamageBox.ControlText = "Damage :";
			dice1.Faces = 1;
			dice1.Modifier = 0;
			dice1.Throws = 1;
			this.DamageBox.Dice = dice1;
			this.DamageBox.Location = new System.Drawing.Point(6, 19);
			this.DamageBox.MinimumSize = new System.Drawing.Size(230, 100);
			this.DamageBox.Name = "DamageBox";
			this.DamageBox.Size = new System.Drawing.Size(230, 100);
			this.DamageBox.TabIndex = 1;
			this.DamageBox.ValueChanged += new System.EventHandler(this.DamageBox_ValueChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.groupBox1);
			this.groupBox2.Controls.Add(this.DamageBox);
			this.groupBox2.Controls.Add(this.TargetBox);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1068, 693);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Pit";
			// 
			// PitControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox2);
			this.Name = "PitControl";
			this.Size = new System.Drawing.Size(1068, 693);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DifficultyBox)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DiceControl DamageBox;
		private TargetControl TargetBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown DifficultyBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox IsHiddenBox;
		private System.Windows.Forms.CheckBox IsIllusionBox;
		private System.Windows.Forms.CheckBox MonsterTriggerBox;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}