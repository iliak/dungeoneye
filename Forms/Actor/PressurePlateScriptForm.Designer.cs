namespace DungeonEye.Forms
{
	partial class PressurePlateScriptForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.OnEntityLeaveBox = new System.Windows.Forms.RadioButton();
			this.AlwaysBox = new System.Windows.Forms.RadioButton();
			this.OnItemRemovedBox = new System.Windows.Forms.RadioButton();
			this.OnEnterBox = new System.Windows.Forms.RadioButton();
			this.OnMonsterLeaveBox = new System.Windows.Forms.RadioButton();
			this.OnLeaveBox = new System.Windows.Forms.RadioButton();
			this.OnTeamLeaveBox = new System.Windows.Forms.RadioButton();
			this.OnTeamBox = new System.Windows.Forms.RadioButton();
			this.OnEntityEnterBox = new System.Windows.Forms.RadioButton();
			this.OnMonsterBox = new System.Windows.Forms.RadioButton();
			this.OnItemAddedBox = new System.Windows.Forms.RadioButton();
			this.OnItemBox = new System.Windows.Forms.RadioButton();
			this.OnMonsterEnterBox = new System.Windows.Forms.RadioButton();
			this.OnEntityBox = new System.Windows.Forms.RadioButton();
			this.OnTeamEnterBox = new System.Windows.Forms.RadioButton();
			this.CancelBox = new System.Windows.Forms.Button();
			this.AcceptBox = new System.Windows.Forms.Button();
			this.ActionBox = new DungeonEye.Forms.Script.ActionChooserControl();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(147, 472);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Condition";
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.OnEntityLeaveBox);
			this.panel1.Controls.Add(this.AlwaysBox);
			this.panel1.Controls.Add(this.OnItemRemovedBox);
			this.panel1.Controls.Add(this.OnEnterBox);
			this.panel1.Controls.Add(this.OnMonsterLeaveBox);
			this.panel1.Controls.Add(this.OnLeaveBox);
			this.panel1.Controls.Add(this.OnTeamLeaveBox);
			this.panel1.Controls.Add(this.OnTeamBox);
			this.panel1.Controls.Add(this.OnEntityEnterBox);
			this.panel1.Controls.Add(this.OnMonsterBox);
			this.panel1.Controls.Add(this.OnItemAddedBox);
			this.panel1.Controls.Add(this.OnItemBox);
			this.panel1.Controls.Add(this.OnMonsterEnterBox);
			this.panel1.Controls.Add(this.OnEntityBox);
			this.panel1.Controls.Add(this.OnTeamEnterBox);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(141, 453);
			this.panel1.TabIndex = 3;
			// 
			// OnEntityLeaveBox
			// 
			this.OnEntityLeaveBox.AutoSize = true;
			this.OnEntityLeaveBox.Location = new System.Drawing.Point(3, 417);
			this.OnEntityLeaveBox.Name = "OnEntityLeaveBox";
			this.OnEntityLeaveBox.Size = new System.Drawing.Size(101, 17);
			this.OnEntityLeaveBox.TabIndex = 0;
			this.OnEntityLeaveBox.TabStop = true;
			this.OnEntityLeaveBox.Text = "On Entity Leave";
			this.OnEntityLeaveBox.UseVisualStyleBackColor = true;
			this.OnEntityLeaveBox.CheckedChanged += new System.EventHandler(this.OnEntityLeaveBox_CheckedChanged);
			// 
			// AlwaysBox
			// 
			this.AlwaysBox.AutoSize = true;
			this.AlwaysBox.Location = new System.Drawing.Point(3, 3);
			this.AlwaysBox.Name = "AlwaysBox";
			this.AlwaysBox.Size = new System.Drawing.Size(58, 17);
			this.AlwaysBox.TabIndex = 0;
			this.AlwaysBox.TabStop = true;
			this.AlwaysBox.Text = "Always";
			this.AlwaysBox.UseVisualStyleBackColor = true;
			this.AlwaysBox.CheckedChanged += new System.EventHandler(this.AlwaysBox_CheckedChanged);
			// 
			// OnItemRemovedBox
			// 
			this.OnItemRemovedBox.AutoSize = true;
			this.OnItemRemovedBox.Location = new System.Drawing.Point(3, 325);
			this.OnItemRemovedBox.Name = "OnItemRemovedBox";
			this.OnItemRemovedBox.Size = new System.Drawing.Size(111, 17);
			this.OnItemRemovedBox.TabIndex = 0;
			this.OnItemRemovedBox.TabStop = true;
			this.OnItemRemovedBox.Text = "On Item Removed";
			this.OnItemRemovedBox.UseVisualStyleBackColor = true;
			this.OnItemRemovedBox.CheckedChanged += new System.EventHandler(this.OnItemRemovedBox_CheckedChanged);
			// 
			// OnEnterBox
			// 
			this.OnEnterBox.AutoSize = true;
			this.OnEnterBox.Location = new System.Drawing.Point(3, 26);
			this.OnEnterBox.Name = "OnEnterBox";
			this.OnEnterBox.Size = new System.Drawing.Size(67, 17);
			this.OnEnterBox.TabIndex = 0;
			this.OnEnterBox.TabStop = true;
			this.OnEnterBox.Text = "On Enter";
			this.OnEnterBox.UseVisualStyleBackColor = true;
			this.OnEnterBox.CheckedChanged += new System.EventHandler(this.OnEnterBox_CheckedChanged);
			// 
			// OnMonsterLeaveBox
			// 
			this.OnMonsterLeaveBox.AutoSize = true;
			this.OnMonsterLeaveBox.Location = new System.Drawing.Point(3, 233);
			this.OnMonsterLeaveBox.Name = "OnMonsterLeaveBox";
			this.OnMonsterLeaveBox.Size = new System.Drawing.Size(113, 17);
			this.OnMonsterLeaveBox.TabIndex = 0;
			this.OnMonsterLeaveBox.TabStop = true;
			this.OnMonsterLeaveBox.Text = "On Monster Leave";
			this.OnMonsterLeaveBox.UseVisualStyleBackColor = true;
			this.OnMonsterLeaveBox.CheckedChanged += new System.EventHandler(this.OnMonsterLeaveBox_CheckedChanged);
			// 
			// OnLeaveBox
			// 
			this.OnLeaveBox.AutoSize = true;
			this.OnLeaveBox.Location = new System.Drawing.Point(3, 49);
			this.OnLeaveBox.Name = "OnLeaveBox";
			this.OnLeaveBox.Size = new System.Drawing.Size(72, 17);
			this.OnLeaveBox.TabIndex = 0;
			this.OnLeaveBox.TabStop = true;
			this.OnLeaveBox.Text = "On Leave";
			this.OnLeaveBox.UseVisualStyleBackColor = true;
			this.OnLeaveBox.CheckedChanged += new System.EventHandler(this.OnLeaveBox_CheckedChanged);
			// 
			// OnTeamLeaveBox
			// 
			this.OnTeamLeaveBox.AutoSize = true;
			this.OnTeamLeaveBox.Location = new System.Drawing.Point(3, 141);
			this.OnTeamLeaveBox.Name = "OnTeamLeaveBox";
			this.OnTeamLeaveBox.Size = new System.Drawing.Size(102, 17);
			this.OnTeamLeaveBox.TabIndex = 0;
			this.OnTeamLeaveBox.TabStop = true;
			this.OnTeamLeaveBox.Text = "On Team Leave";
			this.OnTeamLeaveBox.UseVisualStyleBackColor = true;
			this.OnTeamLeaveBox.CheckedChanged += new System.EventHandler(this.OnTeamLeaveBox_CheckedChanged);
			// 
			// OnTeamBox
			// 
			this.OnTeamBox.AutoSize = true;
			this.OnTeamBox.Location = new System.Drawing.Point(3, 95);
			this.OnTeamBox.Name = "OnTeamBox";
			this.OnTeamBox.Size = new System.Drawing.Size(69, 17);
			this.OnTeamBox.TabIndex = 0;
			this.OnTeamBox.TabStop = true;
			this.OnTeamBox.Text = "On Team";
			this.OnTeamBox.UseVisualStyleBackColor = true;
			this.OnTeamBox.CheckedChanged += new System.EventHandler(this.OnTeamBox_CheckedChanged);
			// 
			// OnEntityEnterBox
			// 
			this.OnEntityEnterBox.AutoSize = true;
			this.OnEntityEnterBox.Location = new System.Drawing.Point(3, 394);
			this.OnEntityEnterBox.Name = "OnEntityEnterBox";
			this.OnEntityEnterBox.Size = new System.Drawing.Size(96, 17);
			this.OnEntityEnterBox.TabIndex = 0;
			this.OnEntityEnterBox.TabStop = true;
			this.OnEntityEnterBox.Text = "On Entity Enter";
			this.OnEntityEnterBox.UseVisualStyleBackColor = true;
			this.OnEntityEnterBox.CheckedChanged += new System.EventHandler(this.OnEntityEnterBox_CheckedChanged);
			// 
			// OnMonsterBox
			// 
			this.OnMonsterBox.AutoSize = true;
			this.OnMonsterBox.Location = new System.Drawing.Point(3, 187);
			this.OnMonsterBox.Name = "OnMonsterBox";
			this.OnMonsterBox.Size = new System.Drawing.Size(80, 17);
			this.OnMonsterBox.TabIndex = 0;
			this.OnMonsterBox.TabStop = true;
			this.OnMonsterBox.Text = "On Monster";
			this.OnMonsterBox.UseVisualStyleBackColor = true;
			this.OnMonsterBox.CheckedChanged += new System.EventHandler(this.OnMonsterBox_CheckedChanged);
			// 
			// OnItemAddedBox
			// 
			this.OnItemAddedBox.AutoSize = true;
			this.OnItemAddedBox.Location = new System.Drawing.Point(3, 302);
			this.OnItemAddedBox.Name = "OnItemAddedBox";
			this.OnItemAddedBox.Size = new System.Drawing.Size(96, 17);
			this.OnItemAddedBox.TabIndex = 0;
			this.OnItemAddedBox.TabStop = true;
			this.OnItemAddedBox.Text = "On Item Added";
			this.OnItemAddedBox.UseVisualStyleBackColor = true;
			this.OnItemAddedBox.CheckedChanged += new System.EventHandler(this.OnItemAddedBox_CheckedChanged);
			// 
			// OnItemBox
			// 
			this.OnItemBox.AutoSize = true;
			this.OnItemBox.Location = new System.Drawing.Point(3, 279);
			this.OnItemBox.Name = "OnItemBox";
			this.OnItemBox.Size = new System.Drawing.Size(62, 17);
			this.OnItemBox.TabIndex = 0;
			this.OnItemBox.TabStop = true;
			this.OnItemBox.Text = "On Item";
			this.OnItemBox.UseVisualStyleBackColor = true;
			this.OnItemBox.CheckedChanged += new System.EventHandler(this.OnItemBox_CheckedChanged);
			// 
			// OnMonsterEnterBox
			// 
			this.OnMonsterEnterBox.AutoSize = true;
			this.OnMonsterEnterBox.Location = new System.Drawing.Point(3, 210);
			this.OnMonsterEnterBox.Name = "OnMonsterEnterBox";
			this.OnMonsterEnterBox.Size = new System.Drawing.Size(108, 17);
			this.OnMonsterEnterBox.TabIndex = 0;
			this.OnMonsterEnterBox.TabStop = true;
			this.OnMonsterEnterBox.Text = "On Monster Enter";
			this.OnMonsterEnterBox.UseVisualStyleBackColor = true;
			this.OnMonsterEnterBox.CheckedChanged += new System.EventHandler(this.OnMonsterEnterBox_CheckedChanged);
			// 
			// OnEntityBox
			// 
			this.OnEntityBox.AutoSize = true;
			this.OnEntityBox.Location = new System.Drawing.Point(3, 371);
			this.OnEntityBox.Name = "OnEntityBox";
			this.OnEntityBox.Size = new System.Drawing.Size(68, 17);
			this.OnEntityBox.TabIndex = 0;
			this.OnEntityBox.TabStop = true;
			this.OnEntityBox.Text = "On Entity";
			this.OnEntityBox.UseVisualStyleBackColor = true;
			this.OnEntityBox.CheckedChanged += new System.EventHandler(this.OnEntityBox_CheckedChanged);
			// 
			// OnTeamEnterBox
			// 
			this.OnTeamEnterBox.AutoSize = true;
			this.OnTeamEnterBox.Location = new System.Drawing.Point(3, 118);
			this.OnTeamEnterBox.Name = "OnTeamEnterBox";
			this.OnTeamEnterBox.Size = new System.Drawing.Size(97, 17);
			this.OnTeamEnterBox.TabIndex = 0;
			this.OnTeamEnterBox.TabStop = true;
			this.OnTeamEnterBox.Text = "On Team Enter";
			this.OnTeamEnterBox.UseVisualStyleBackColor = true;
			this.OnTeamEnterBox.CheckedChanged += new System.EventHandler(this.OnTeamEnterBox_CheckedChanged);
			// 
			// CancelBox
			// 
			this.CancelBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelBox.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelBox.Location = new System.Drawing.Point(788, 490);
			this.CancelBox.Name = "CancelBox";
			this.CancelBox.Size = new System.Drawing.Size(75, 23);
			this.CancelBox.TabIndex = 2;
			this.CancelBox.Text = "Cancel";
			this.CancelBox.UseVisualStyleBackColor = true;
			// 
			// AcceptBox
			// 
			this.AcceptBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AcceptBox.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.AcceptBox.Location = new System.Drawing.Point(707, 490);
			this.AcceptBox.Name = "AcceptBox";
			this.AcceptBox.Size = new System.Drawing.Size(75, 23);
			this.AcceptBox.TabIndex = 2;
			this.AcceptBox.Text = "Ok";
			this.AcceptBox.UseVisualStyleBackColor = true;
			// 
			// ActionBox
			// 
			this.ActionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ActionBox.Dungeon = null;
			this.ActionBox.Location = new System.Drawing.Point(165, 12);
			this.ActionBox.Name = "ActionBox";
			this.ActionBox.Script = null;
			this.ActionBox.Size = new System.Drawing.Size(698, 472);
			this.ActionBox.TabIndex = 1;
			// 
			// PressurePlateScriptForm
			// 
			this.AcceptButton = this.AcceptBox;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelBox;
			this.ClientSize = new System.Drawing.Size(875, 525);
			this.Controls.Add(this.AcceptBox);
			this.Controls.Add(this.CancelBox);
			this.Controls.Add(this.ActionBox);
			this.Controls.Add(this.groupBox1);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(700, 400);
			this.Name = "PressurePlateScriptForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Pressure Plate Script Form";
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private Script.ActionChooserControl ActionBox;
		private System.Windows.Forms.Button CancelBox;
		private System.Windows.Forms.Button AcceptBox;
		private System.Windows.Forms.RadioButton OnEntityLeaveBox;
		private System.Windows.Forms.RadioButton OnItemRemovedBox;
		private System.Windows.Forms.RadioButton OnMonsterLeaveBox;
		private System.Windows.Forms.RadioButton OnTeamLeaveBox;
		private System.Windows.Forms.RadioButton OnEntityEnterBox;
		private System.Windows.Forms.RadioButton OnItemAddedBox;
		private System.Windows.Forms.RadioButton OnMonsterEnterBox;
		private System.Windows.Forms.RadioButton OnTeamEnterBox;
		private System.Windows.Forms.RadioButton OnEntityBox;
		private System.Windows.Forms.RadioButton OnItemBox;
		private System.Windows.Forms.RadioButton OnMonsterBox;
		private System.Windows.Forms.RadioButton OnTeamBox;
		private System.Windows.Forms.RadioButton AlwaysBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton OnEnterBox;
		private System.Windows.Forms.RadioButton OnLeaveBox;
	}
}