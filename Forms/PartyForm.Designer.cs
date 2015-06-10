namespace DungeonEye.Forms
{
	partial class PartyForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartyForm));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.RemoveHeroBox = new System.Windows.Forms.Button();
			this.CreateHeroBox = new System.Windows.Forms.Button();
			this.RearRightBox = new System.Windows.Forms.RadioButton();
			this.MiddleRightBox = new System.Windows.Forms.RadioButton();
			this.RearLeftBox = new System.Windows.Forms.RadioButton();
			this.FrontRightBox = new System.Windows.Forms.RadioButton();
			this.MiddleLeftBox = new System.Windows.Forms.RadioButton();
			this.FrontLeftBox = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.MessageColorBox = new System.Windows.Forms.Button();
			this.AddMessageBox = new System.Windows.Forms.Button();
			this.DeleteMessageBox = new System.Windows.Forms.Button();
			this.ClearMessageBox = new System.Windows.Forms.Button();
			this.MessageTxtBox = new System.Windows.Forms.TextBox();
			this.MessageListBox = new System.Windows.Forms.ListBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.LocationLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ChangeLocationBox = new System.Windows.Forms.Button();
			this.SaveBox = new System.Windows.Forms.Button();
			this.HeroBox = new DungeonEye.Forms.HeroControl();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.SlotIdBox = new System.Windows.Forms.TrackBar();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SlotIdBox)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.RemoveHeroBox);
			this.groupBox2.Controls.Add(this.CreateHeroBox);
			this.groupBox2.Controls.Add(this.RearRightBox);
			this.groupBox2.Controls.Add(this.MiddleRightBox);
			this.groupBox2.Controls.Add(this.RearLeftBox);
			this.groupBox2.Controls.Add(this.FrontRightBox);
			this.groupBox2.Controls.Add(this.MiddleLeftBox);
			this.groupBox2.Controls.Add(this.FrontLeftBox);
			this.groupBox2.Location = new System.Drawing.Point(12, 85);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(304, 106);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Heroes :";
			// 
			// RemoveHeroBox
			// 
			this.RemoveHeroBox.Location = new System.Drawing.Point(220, 56);
			this.RemoveHeroBox.Name = "RemoveHeroBox";
			this.RemoveHeroBox.Size = new System.Drawing.Size(75, 23);
			this.RemoveHeroBox.TabIndex = 2;
			this.RemoveHeroBox.Text = "Remove";
			this.RemoveHeroBox.UseVisualStyleBackColor = true;
			this.RemoveHeroBox.Click += new System.EventHandler(this.RemoveHeroBox_Click);
			// 
			// CreateHeroBox
			// 
			this.CreateHeroBox.Location = new System.Drawing.Point(220, 27);
			this.CreateHeroBox.Name = "CreateHeroBox";
			this.CreateHeroBox.Size = new System.Drawing.Size(75, 23);
			this.CreateHeroBox.TabIndex = 1;
			this.CreateHeroBox.Text = "Create";
			this.CreateHeroBox.UseVisualStyleBackColor = true;
			this.CreateHeroBox.Click += new System.EventHandler(this.CreateHeroBox_Click);
			// 
			// RearRightBox
			// 
			this.RearRightBox.AutoSize = true;
			this.RearRightBox.Location = new System.Drawing.Point(109, 76);
			this.RearRightBox.Name = "RearRightBox";
			this.RearRightBox.Size = new System.Drawing.Size(76, 17);
			this.RearRightBox.TabIndex = 0;
			this.RearRightBox.Text = "Rear Right";
			this.RearRightBox.UseVisualStyleBackColor = true;
			this.RearRightBox.CheckedChanged += new System.EventHandler(this.RearRightBox_CheckedChanged);
			// 
			// MiddleRightBox
			// 
			this.MiddleRightBox.AutoSize = true;
			this.MiddleRightBox.Location = new System.Drawing.Point(109, 53);
			this.MiddleRightBox.Name = "MiddleRightBox";
			this.MiddleRightBox.Size = new System.Drawing.Size(84, 17);
			this.MiddleRightBox.TabIndex = 0;
			this.MiddleRightBox.Text = "Middle Right";
			this.MiddleRightBox.UseVisualStyleBackColor = true;
			this.MiddleRightBox.CheckedChanged += new System.EventHandler(this.MiddleRightBox_CheckedChanged);
			// 
			// RearLeftBox
			// 
			this.RearLeftBox.AutoSize = true;
			this.RearLeftBox.Location = new System.Drawing.Point(7, 76);
			this.RearLeftBox.Name = "RearLeftBox";
			this.RearLeftBox.Size = new System.Drawing.Size(69, 17);
			this.RearLeftBox.TabIndex = 0;
			this.RearLeftBox.Text = "Rear Left";
			this.RearLeftBox.UseVisualStyleBackColor = true;
			this.RearLeftBox.CheckedChanged += new System.EventHandler(this.RearLeftBox_CheckedChanged);
			// 
			// FrontRightBox
			// 
			this.FrontRightBox.AutoSize = true;
			this.FrontRightBox.Location = new System.Drawing.Point(109, 30);
			this.FrontRightBox.Name = "FrontRightBox";
			this.FrontRightBox.Size = new System.Drawing.Size(77, 17);
			this.FrontRightBox.TabIndex = 0;
			this.FrontRightBox.Text = "Front Right";
			this.FrontRightBox.UseVisualStyleBackColor = true;
			this.FrontRightBox.CheckedChanged += new System.EventHandler(this.FrontRightBox_CheckedChanged);
			// 
			// MiddleLeftBox
			// 
			this.MiddleLeftBox.AutoSize = true;
			this.MiddleLeftBox.Location = new System.Drawing.Point(7, 53);
			this.MiddleLeftBox.Name = "MiddleLeftBox";
			this.MiddleLeftBox.Size = new System.Drawing.Size(77, 17);
			this.MiddleLeftBox.TabIndex = 0;
			this.MiddleLeftBox.Text = "Middle Left";
			this.MiddleLeftBox.UseVisualStyleBackColor = true;
			this.MiddleLeftBox.CheckedChanged += new System.EventHandler(this.MiddleLeftBox_CheckedChanged);
			// 
			// FrontLeftBox
			// 
			this.FrontLeftBox.AutoSize = true;
			this.FrontLeftBox.Checked = true;
			this.FrontLeftBox.Location = new System.Drawing.Point(7, 30);
			this.FrontLeftBox.Name = "FrontLeftBox";
			this.FrontLeftBox.Size = new System.Drawing.Size(70, 17);
			this.FrontLeftBox.TabIndex = 0;
			this.FrontLeftBox.TabStop = true;
			this.FrontLeftBox.Text = "Front Left";
			this.FrontLeftBox.UseVisualStyleBackColor = true;
			this.FrontLeftBox.CheckedChanged += new System.EventHandler(this.FrontLeftBox_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.MessageColorBox);
			this.groupBox1.Controls.Add(this.AddMessageBox);
			this.groupBox1.Controls.Add(this.DeleteMessageBox);
			this.groupBox1.Controls.Add(this.ClearMessageBox);
			this.groupBox1.Controls.Add(this.MessageTxtBox);
			this.groupBox1.Controls.Add(this.MessageListBox);
			this.groupBox1.Location = new System.Drawing.Point(12, 197);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(304, 110);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Messages :";
			// 
			// MessageColorBox
			// 
			this.MessageColorBox.AutoSize = true;
			this.MessageColorBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MessageColorBox.Image = ((System.Drawing.Image)(resources.GetObject("MessageColorBox.Image")));
			this.MessageColorBox.Location = new System.Drawing.Point(192, 80);
			this.MessageColorBox.Name = "MessageColorBox";
			this.MessageColorBox.Size = new System.Drawing.Size(22, 22);
			this.MessageColorBox.TabIndex = 4;
			this.MessageColorBox.UseVisualStyleBackColor = true;
			this.MessageColorBox.Click += new System.EventHandler(this.MessageColorBox_Click);
			// 
			// AddMessageBox
			// 
			this.AddMessageBox.Location = new System.Drawing.Point(220, 79);
			this.AddMessageBox.Name = "AddMessageBox";
			this.AddMessageBox.Size = new System.Drawing.Size(75, 23);
			this.AddMessageBox.TabIndex = 3;
			this.AddMessageBox.Text = "Add";
			this.AddMessageBox.UseVisualStyleBackColor = true;
			this.AddMessageBox.Click += new System.EventHandler(this.AddMessageBox_Click);
			// 
			// DeleteMessageBox
			// 
			this.DeleteMessageBox.Location = new System.Drawing.Point(220, 48);
			this.DeleteMessageBox.Name = "DeleteMessageBox";
			this.DeleteMessageBox.Size = new System.Drawing.Size(75, 23);
			this.DeleteMessageBox.TabIndex = 3;
			this.DeleteMessageBox.Text = "Delete";
			this.DeleteMessageBox.UseVisualStyleBackColor = true;
			this.DeleteMessageBox.Click += new System.EventHandler(this.DeleteMessageBox_Click);
			// 
			// ClearMessageBox
			// 
			this.ClearMessageBox.Location = new System.Drawing.Point(220, 19);
			this.ClearMessageBox.Name = "ClearMessageBox";
			this.ClearMessageBox.Size = new System.Drawing.Size(75, 23);
			this.ClearMessageBox.TabIndex = 3;
			this.ClearMessageBox.Text = "Clear All";
			this.ClearMessageBox.UseVisualStyleBackColor = true;
			this.ClearMessageBox.Click += new System.EventHandler(this.ClearMessageBox_Click);
			// 
			// MessageTxtBox
			// 
			this.MessageTxtBox.Location = new System.Drawing.Point(6, 81);
			this.MessageTxtBox.Name = "MessageTxtBox";
			this.MessageTxtBox.Size = new System.Drawing.Size(180, 20);
			this.MessageTxtBox.TabIndex = 2;
			// 
			// MessageListBox
			// 
			this.MessageListBox.FormattingEnabled = true;
			this.MessageListBox.Location = new System.Drawing.Point(6, 19);
			this.MessageListBox.Name = "MessageListBox";
			this.MessageListBox.Size = new System.Drawing.Size(208, 56);
			this.MessageListBox.TabIndex = 0;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "*.xml";
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Savegame|*.xml|All files|*.*";
			this.openFileDialog1.RestoreDirectory = true;
			this.openFileDialog1.Title = "Select savegame to edit...";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "xml";
			this.saveFileDialog1.Filter = "\"Save game|*.xml|All files|*.*\"";
			this.saveFileDialog1.RestoreDirectory = true;
			this.saveFileDialog1.Title = "Save party...";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.LocationLabel);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.ChangeLocationBox);
			this.groupBox3.Location = new System.Drawing.Point(12, 313);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(304, 70);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Location :";
			// 
			// LocationLabel
			// 
			this.LocationLabel.Location = new System.Drawing.Point(99, 19);
			this.LocationLabel.Name = "LocationLabel";
			this.LocationLabel.Size = new System.Drawing.Size(196, 13);
			this.LocationLabel.TabIndex = 2;
			this.LocationLabel.Text = ".......";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Current location :";
			// 
			// ChangeLocationBox
			// 
			this.ChangeLocationBox.Location = new System.Drawing.Point(6, 41);
			this.ChangeLocationBox.Name = "ChangeLocationBox";
			this.ChangeLocationBox.Size = new System.Drawing.Size(129, 23);
			this.ChangeLocationBox.TabIndex = 0;
			this.ChangeLocationBox.Text = "Change location...";
			this.ChangeLocationBox.UseVisualStyleBackColor = true;
			this.ChangeLocationBox.Click += new System.EventHandler(this.ChangeLocationBox_Click);
			// 
			// SaveBox
			// 
			this.SaveBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SaveBox.Image = ((System.Drawing.Image)(resources.GetObject("SaveBox.Image")));
			this.SaveBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.SaveBox.Location = new System.Drawing.Point(12, 487);
			this.SaveBox.Name = "SaveBox";
			this.SaveBox.Size = new System.Drawing.Size(75, 23);
			this.SaveBox.TabIndex = 3;
			this.SaveBox.Text = "Save...";
			this.SaveBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.SaveBox.UseVisualStyleBackColor = true;
			this.SaveBox.Click += new System.EventHandler(this.SaveBox_Click);
			// 
			// HeroBox
			// 
			this.HeroBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HeroBox.AutoScroll = true;
			this.HeroBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HeroBox.Hero = null;
			this.HeroBox.Location = new System.Drawing.Point(322, 12);
			this.HeroBox.MinimumSize = new System.Drawing.Size(635, 400);
			this.HeroBox.Name = "HeroBox";
			this.HeroBox.Size = new System.Drawing.Size(651, 498);
			this.HeroBox.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.SlotIdBox);
			this.groupBox4.Location = new System.Drawing.Point(12, 9);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(304, 70);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Slot position";
			// 
			// SlotIdBox
			// 
			this.SlotIdBox.Location = new System.Drawing.Point(6, 19);
			this.SlotIdBox.Maximum = 6;
			this.SlotIdBox.Name = "SlotIdBox";
			this.SlotIdBox.Size = new System.Drawing.Size(292, 45);
			this.SlotIdBox.TabIndex = 0;
			this.SlotIdBox.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// PartyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 522);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.SaveBox);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.HeroBox);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinimumSize = new System.Drawing.Size(1000, 560);
			this.Name = "PartyForm";
			this.Text = "PartyForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PartyForm_FormClosed);
			this.Load += new System.EventHandler(this.PartyForm_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SlotIdBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button AddMessageBox;
		private System.Windows.Forms.Button DeleteMessageBox;
		private System.Windows.Forms.Button ClearMessageBox;
		private System.Windows.Forms.TextBox MessageTxtBox;
		private System.Windows.Forms.ListBox MessageListBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton FrontRightBox;
		private System.Windows.Forms.RadioButton FrontLeftBox;
		private HeroControl HeroBox;
		private System.Windows.Forms.RadioButton RearRightBox;
		private System.Windows.Forms.RadioButton MiddleRightBox;
		private System.Windows.Forms.RadioButton RearLeftBox;
		private System.Windows.Forms.RadioButton MiddleLeftBox;
		private System.Windows.Forms.Button RemoveHeroBox;
		private System.Windows.Forms.Button CreateHeroBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button MessageColorBox;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label LocationLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ChangeLocationBox;
		private System.Windows.Forms.Button SaveBox;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TrackBar SlotIdBox;
	}
}