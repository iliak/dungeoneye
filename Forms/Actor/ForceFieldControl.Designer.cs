namespace DungeonEye.Forms
{
	partial class ForceFieldControl
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
			this.BlockRadioBox = new System.Windows.Forms.RadioButton();
			this.SpinDirectionBox = new System.Windows.Forms.ComboBox();
			this.MoveDirectionBox = new System.Windows.Forms.ComboBox();
			this.SpinRadioBox = new System.Windows.Forms.RadioButton();
			this.MoveRadioBox = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.AffectItemsBox = new System.Windows.Forms.CheckBox();
			this.AffectMonstersBox = new System.Windows.Forms.CheckBox();
			this.AffectTeamBox = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.FaceToBox = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.BlockRadioBox);
			this.groupBox1.Controls.Add(this.SpinDirectionBox);
			this.groupBox1.Controls.Add(this.MoveDirectionBox);
			this.groupBox1.Controls.Add(this.SpinRadioBox);
			this.groupBox1.Controls.Add(this.FaceToBox);
			this.groupBox1.Controls.Add(this.MoveRadioBox);
			this.groupBox1.Location = new System.Drawing.Point(6, 19);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(175, 142);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Action :";
			// 
			// BlockRadioBox
			// 
			this.BlockRadioBox.AutoSize = true;
			this.BlockRadioBox.Location = new System.Drawing.Point(6, 95);
			this.BlockRadioBox.Name = "BlockRadioBox";
			this.BlockRadioBox.Size = new System.Drawing.Size(52, 17);
			this.BlockRadioBox.TabIndex = 3;
			this.BlockRadioBox.TabStop = true;
			this.BlockRadioBox.Text = "Block";
			this.BlockRadioBox.UseVisualStyleBackColor = true;
			this.BlockRadioBox.CheckedChanged += new System.EventHandler(this.BlockBox_CheckedChanged);
			// 
			// SpinDirectionBox
			// 
			this.SpinDirectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SpinDirectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SpinDirectionBox.FormattingEnabled = true;
			this.SpinDirectionBox.Location = new System.Drawing.Point(77, 44);
			this.SpinDirectionBox.Name = "SpinDirectionBox";
			this.SpinDirectionBox.Size = new System.Drawing.Size(92, 21);
			this.SpinDirectionBox.TabIndex = 0;
			this.SpinDirectionBox.SelectedIndexChanged += new System.EventHandler(this.SpinDirectionBox_SelectedIndexChanged);
			// 
			// MoveDirectionBox
			// 
			this.MoveDirectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MoveDirectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.MoveDirectionBox.FormattingEnabled = true;
			this.MoveDirectionBox.Location = new System.Drawing.Point(77, 115);
			this.MoveDirectionBox.Name = "MoveDirectionBox";
			this.MoveDirectionBox.Size = new System.Drawing.Size(92, 21);
			this.MoveDirectionBox.TabIndex = 0;
			this.MoveDirectionBox.SelectedIndexChanged += new System.EventHandler(this.MoveDirectionBox_SelectedIndexChanged);
			// 
			// SpinRadioBox
			// 
			this.SpinRadioBox.AutoSize = true;
			this.SpinRadioBox.Location = new System.Drawing.Point(6, 45);
			this.SpinRadioBox.Name = "SpinRadioBox";
			this.SpinRadioBox.Size = new System.Drawing.Size(46, 17);
			this.SpinRadioBox.TabIndex = 3;
			this.SpinRadioBox.TabStop = true;
			this.SpinRadioBox.Text = "Spin";
			this.SpinRadioBox.UseVisualStyleBackColor = true;
			this.SpinRadioBox.CheckedChanged += new System.EventHandler(this.SpinRadioBox_CheckedChanged);
			// 
			// MoveRadioBox
			// 
			this.MoveRadioBox.AutoSize = true;
			this.MoveRadioBox.Location = new System.Drawing.Point(6, 18);
			this.MoveRadioBox.Name = "MoveRadioBox";
			this.MoveRadioBox.Size = new System.Drawing.Size(52, 17);
			this.MoveRadioBox.TabIndex = 3;
			this.MoveRadioBox.TabStop = true;
			this.MoveRadioBox.Text = "Move";
			this.MoveRadioBox.UseVisualStyleBackColor = true;
			this.MoveRadioBox.CheckedChanged += new System.EventHandler(this.MoveRadioBox_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.AffectItemsBox);
			this.groupBox2.Controls.Add(this.AffectMonstersBox);
			this.groupBox2.Controls.Add(this.AffectTeamBox);
			this.groupBox2.Location = new System.Drawing.Point(187, 19);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(120, 93);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Properties :";
			// 
			// AffectItemsBox
			// 
			this.AffectItemsBox.AutoSize = true;
			this.AffectItemsBox.Location = new System.Drawing.Point(6, 65);
			this.AffectItemsBox.Name = "AffectItemsBox";
			this.AffectItemsBox.Size = new System.Drawing.Size(81, 17);
			this.AffectItemsBox.TabIndex = 0;
			this.AffectItemsBox.Text = "Affect items";
			this.AffectItemsBox.UseVisualStyleBackColor = true;
			this.AffectItemsBox.CheckedChanged += new System.EventHandler(this.AffectItemsBox_CheckedChanged);
			// 
			// AffectMonstersBox
			// 
			this.AffectMonstersBox.AutoSize = true;
			this.AffectMonstersBox.Location = new System.Drawing.Point(6, 42);
			this.AffectMonstersBox.Name = "AffectMonstersBox";
			this.AffectMonstersBox.Size = new System.Drawing.Size(99, 17);
			this.AffectMonstersBox.TabIndex = 0;
			this.AffectMonstersBox.Text = "Affect monsters";
			this.AffectMonstersBox.UseVisualStyleBackColor = true;
			this.AffectMonstersBox.CheckedChanged += new System.EventHandler(this.AffectMonstersBox_CheckedChanged);
			// 
			// AffectTeamBox
			// 
			this.AffectTeamBox.AutoSize = true;
			this.AffectTeamBox.Location = new System.Drawing.Point(6, 19);
			this.AffectTeamBox.Name = "AffectTeamBox";
			this.AffectTeamBox.Size = new System.Drawing.Size(80, 17);
			this.AffectTeamBox.TabIndex = 0;
			this.AffectTeamBox.Text = "Affect team";
			this.AffectTeamBox.UseVisualStyleBackColor = true;
			this.AffectTeamBox.CheckedChanged += new System.EventHandler(this.AffectTeamBox_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.groupBox1);
			this.groupBox3.Controls.Add(this.groupBox2);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(0, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(739, 420);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Force field";
			// 
			// FaceToBox
			// 
			this.FaceToBox.AutoSize = true;
			this.FaceToBox.Location = new System.Drawing.Point(6, 72);
			this.FaceToBox.Name = "FaceToBox";
			this.FaceToBox.Size = new System.Drawing.Size(65, 17);
			this.FaceToBox.TabIndex = 3;
			this.FaceToBox.TabStop = true;
			this.FaceToBox.Text = "Face To";
			this.FaceToBox.UseVisualStyleBackColor = true;
			this.FaceToBox.CheckedChanged += new System.EventHandler(this.DirectionBox_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 118);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Direction";
			// 
			// ForceFieldControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox3);
			this.Name = "ForceFieldControl";
			this.Size = new System.Drawing.Size(739, 420);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox SpinDirectionBox;
		private System.Windows.Forms.ComboBox MoveDirectionBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox AffectItemsBox;
		private System.Windows.Forms.CheckBox AffectMonstersBox;
		private System.Windows.Forms.CheckBox AffectTeamBox;
		private System.Windows.Forms.RadioButton SpinRadioBox;
		private System.Windows.Forms.RadioButton MoveRadioBox;
		private System.Windows.Forms.RadioButton BlockRadioBox;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton FaceToBox;
		private System.Windows.Forms.Label label1;
	}
}