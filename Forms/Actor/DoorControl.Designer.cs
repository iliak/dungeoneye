namespace DungeonEye.Forms
{
	partial class DoorControl
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
			DungeonEye.SwitchCount switchCount1 = new DungeonEye.SwitchCount();
			this.PicklockBox = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.DoorTypeBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.SmallItemPassThroughBox = new System.Windows.Forms.CheckBox();
			this.HasButtonBox = new System.Windows.Forms.CheckBox();
			this.SpeedBox = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.BreakValueBox = new System.Windows.Forms.NumericUpDown();
			this.IsBreakableBox = new System.Windows.Forms.CheckBox();
			this.DoorStateBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.SwitchCountBox = new DungeonEye.Forms.SwitchCountControl();
			this.ActorPropertiesBox = new DungeonEye.Forms.Actor.SquareActorControl();
			((System.ComponentModel.ISupportInitialize)(this.PicklockBox)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SpeedBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BreakValueBox)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// PicklockBox
			// 
			this.PicklockBox.Location = new System.Drawing.Point(101, 72);
			this.PicklockBox.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.PicklockBox.Name = "PicklockBox";
			this.PicklockBox.Size = new System.Drawing.Size(54, 20);
			this.PicklockBox.TabIndex = 4;
			this.PicklockBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.PicklockBox.ThousandsSeparator = true;
			this.PicklockBox.ValueChanged += new System.EventHandler(this.PicklockBox_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Pick lock";
			// 
			// DoorTypeBox
			// 
			this.DoorTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DoorTypeBox.Location = new System.Drawing.Point(49, 13);
			this.DoorTypeBox.Name = "DoorTypeBox";
			this.DoorTypeBox.Size = new System.Drawing.Size(123, 21);
			this.DoorTypeBox.Sorted = true;
			this.DoorTypeBox.TabIndex = 2;
			this.DoorTypeBox.SelectedIndexChanged += new System.EventHandler(this.DoorTypeBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Type :";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.SmallItemPassThroughBox);
			this.groupBox2.Controls.Add(this.HasButtonBox);
			this.groupBox2.Controls.Add(this.PicklockBox);
			this.groupBox2.Controls.Add(this.SpeedBox);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.BreakValueBox);
			this.groupBox2.Controls.Add(this.IsBreakableBox);
			this.groupBox2.Location = new System.Drawing.Point(9, 123);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(166, 146);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Properties :";
			// 
			// SmallItemPassThroughBox
			// 
			this.SmallItemPassThroughBox.AutoSize = true;
			this.SmallItemPassThroughBox.Location = new System.Drawing.Point(11, 123);
			this.SmallItemPassThroughBox.Name = "SmallItemPassThroughBox";
			this.SmallItemPassThroughBox.Size = new System.Drawing.Size(142, 17);
			this.SmallItemPassThroughBox.TabIndex = 6;
			this.SmallItemPassThroughBox.Text = "Small items pass through";
			this.SmallItemPassThroughBox.UseVisualStyleBackColor = true;
			this.SmallItemPassThroughBox.CheckedChanged += new System.EventHandler(this.ItemPassThroughBox_CheckedChanged);
			// 
			// HasButtonBox
			// 
			this.HasButtonBox.AutoSize = true;
			this.HasButtonBox.Location = new System.Drawing.Point(11, 100);
			this.HasButtonBox.Name = "HasButtonBox";
			this.HasButtonBox.Size = new System.Drawing.Size(78, 17);
			this.HasButtonBox.TabIndex = 5;
			this.HasButtonBox.Text = "Has button";
			this.HasButtonBox.UseVisualStyleBackColor = true;
			this.HasButtonBox.CheckedChanged += new System.EventHandler(this.HasButtonBox_CheckedChanged);
			// 
			// SpeedBox
			// 
			this.SpeedBox.Location = new System.Drawing.Point(101, 46);
			this.SpeedBox.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.SpeedBox.Name = "SpeedBox";
			this.SpeedBox.Size = new System.Drawing.Size(54, 20);
			this.SpeedBox.TabIndex = 4;
			this.SpeedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.SpeedBox.ThousandsSeparator = true;
			this.SpeedBox.ValueChanged += new System.EventHandler(this.SpeedBox_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Speed in seconds";
			// 
			// BreakValueBox
			// 
			this.BreakValueBox.Location = new System.Drawing.Point(101, 20);
			this.BreakValueBox.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.BreakValueBox.Name = "BreakValueBox";
			this.BreakValueBox.Size = new System.Drawing.Size(54, 20);
			this.BreakValueBox.TabIndex = 4;
			this.BreakValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.BreakValueBox.ThousandsSeparator = true;
			this.BreakValueBox.ValueChanged += new System.EventHandler(this.BreakValueBox_ValueChanged);
			// 
			// IsBreakableBox
			// 
			this.IsBreakableBox.AutoSize = true;
			this.IsBreakableBox.Location = new System.Drawing.Point(11, 21);
			this.IsBreakableBox.Name = "IsBreakableBox";
			this.IsBreakableBox.Size = new System.Drawing.Size(84, 17);
			this.IsBreakableBox.TabIndex = 3;
			this.IsBreakableBox.Text = "Is breakable";
			this.IsBreakableBox.UseVisualStyleBackColor = true;
			this.IsBreakableBox.CheckedChanged += new System.EventHandler(this.IsBreakableBox_CheckedChanged);
			// 
			// DoorStateBox
			// 
			this.DoorStateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DoorStateBox.Location = new System.Drawing.Point(49, 40);
			this.DoorStateBox.Name = "DoorStateBox";
			this.DoorStateBox.Size = new System.Drawing.Size(122, 21);
			this.DoorStateBox.Sorted = true;
			this.DoorStateBox.TabIndex = 2;
			this.DoorStateBox.SelectedIndexChanged += new System.EventHandler(this.DoorStateBox_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(5, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "State :";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.ActorPropertiesBox);
			this.groupBox3.Controls.Add(this.SwitchCountBox);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.groupBox2);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.DoorTypeBox);
			this.groupBox3.Controls.Add(this.DoorStateBox);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(0, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(678, 516);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Door";
			// 
			// SwitchCountBox
			// 
			this.SwitchCountBox.Location = new System.Drawing.Point(178, 13);
			this.SwitchCountBox.MinimumSize = new System.Drawing.Size(140, 130);
			this.SwitchCountBox.Name = "SwitchCountBox";
			this.SwitchCountBox.Size = new System.Drawing.Size(140, 130);
			switchCount1.Count = 0;
			switchCount1.ResetOnTrigger = false;
			switchCount1.Target = 0;
			this.SwitchCountBox.SwitchCount = switchCount1;
			this.SwitchCountBox.TabIndex = 5;
			this.SwitchCountBox.Title = "Switch count";
			// 
			// ActorPropertiesBox
			// 
			this.ActorPropertiesBox.Actor = null;
			this.ActorPropertiesBox.Location = new System.Drawing.Point(178, 149);
			this.ActorPropertiesBox.MinimumSize = new System.Drawing.Size(130, 120);
			this.ActorPropertiesBox.Name = "ActorPropertiesBox";
			this.ActorPropertiesBox.Size = new System.Drawing.Size(140, 120);
			this.ActorPropertiesBox.TabIndex = 6;
			// 
			// DoorControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox3);
			this.Name = "DoorControl";
			this.Size = new System.Drawing.Size(678, 516);
			this.Load += new System.EventHandler(this.DoorControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.PicklockBox)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SpeedBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BreakValueBox)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox DoorTypeBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.NumericUpDown BreakValueBox;
		private System.Windows.Forms.CheckBox IsBreakableBox;
		private System.Windows.Forms.NumericUpDown PicklockBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox DoorStateBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown SpeedBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox HasButtonBox;
		private System.Windows.Forms.CheckBox SmallItemPassThroughBox;
		private SwitchCountControl SwitchCountBox;
		private Actor.SquareActorControl ActorPropertiesBox;
	}
}