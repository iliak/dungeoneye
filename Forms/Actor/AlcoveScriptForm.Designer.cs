namespace DungeonEye.Forms
{
	partial class AlcoveScriptForm
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
			this.CancelBox = new System.Windows.Forms.Button();
			this.AcceptBox = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ConsumeItemBox = new System.Windows.Forms.CheckBox();
			this.ItemNameBox = new System.Windows.Forms.ComboBox();
			this.RemainingCountBox = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ActionBox = new DungeonEye.Forms.Script.ActionChooserControl();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RemainingCountBox)).BeginInit();
			this.SuspendLayout();
			// 
			// CancelBox
			// 
			this.CancelBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelBox.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelBox.Location = new System.Drawing.Point(624, 404);
			this.CancelBox.Name = "CancelBox";
			this.CancelBox.Size = new System.Drawing.Size(75, 23);
			this.CancelBox.TabIndex = 0;
			this.CancelBox.Text = "Cancel";
			this.CancelBox.UseVisualStyleBackColor = true;
			// 
			// AcceptBox
			// 
			this.AcceptBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AcceptBox.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.AcceptBox.Location = new System.Drawing.Point(543, 404);
			this.AcceptBox.Name = "AcceptBox";
			this.AcceptBox.Size = new System.Drawing.Size(75, 23);
			this.AcceptBox.TabIndex = 0;
			this.AcceptBox.Text = "Ok";
			this.AcceptBox.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.ConsumeItemBox);
			this.groupBox1.Controls.Add(this.ItemNameBox);
			this.groupBox1.Controls.Add(this.RemainingCountBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(189, 386);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Condition";
			// 
			// ConsumeItemBox
			// 
			this.ConsumeItemBox.AutoSize = true;
			this.ConsumeItemBox.Location = new System.Drawing.Point(91, 72);
			this.ConsumeItemBox.Name = "ConsumeItemBox";
			this.ConsumeItemBox.Size = new System.Drawing.Size(92, 17);
			this.ConsumeItemBox.TabIndex = 6;
			this.ConsumeItemBox.Text = "Consume item";
			this.ConsumeItemBox.UseVisualStyleBackColor = true;
			this.ConsumeItemBox.CheckedChanged += new System.EventHandler(this.ConsumeItemBox_CheckedChanged);
			// 
			// ItemNameBox
			// 
			this.ItemNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ItemNameBox.FormattingEnabled = true;
			this.ItemNameBox.Location = new System.Drawing.Point(75, 19);
			this.ItemNameBox.Name = "ItemNameBox";
			this.ItemNameBox.Size = new System.Drawing.Size(108, 21);
			this.ItemNameBox.TabIndex = 1;
			this.ItemNameBox.SelectedIndexChanged += new System.EventHandler(this.ItemNameBox_SelectedIndexChanged);
			// 
			// RemainingCountBox
			// 
			this.RemainingCountBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RemainingCountBox.Location = new System.Drawing.Point(126, 46);
			this.RemainingCountBox.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
			this.RemainingCountBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.RemainingCountBox.Name = "RemainingCountBox";
			this.RemainingCountBox.Size = new System.Drawing.Size(57, 20);
			this.RemainingCountBox.TabIndex = 5;
			this.RemainingCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.RemainingCountBox.ThousandsSeparator = true;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(57, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Remaining :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Item\'s name";
			// 
			// ActionBox
			// 
			this.ActionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ActionBox.Dungeon = null;
			this.ActionBox.Location = new System.Drawing.Point(207, 12);
			this.ActionBox.Name = "ActionBox";
			this.ActionBox.Script = null;
			this.ActionBox.Size = new System.Drawing.Size(492, 386);
			this.ActionBox.TabIndex = 2;
			// 
			// AlcoveScriptForm
			// 
			this.AcceptButton = this.AcceptBox;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelBox;
			this.ClientSize = new System.Drawing.Size(711, 439);
			this.Controls.Add(this.ActionBox);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.AcceptBox);
			this.Controls.Add(this.CancelBox);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(650, 400);
			this.Name = "AlcoveScriptForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Alcove script form";
			this.Load += new System.EventHandler(this.AlcoveScriptForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RemainingCountBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button CancelBox;
		private System.Windows.Forms.Button AcceptBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown RemainingCountBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox ItemNameBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox ConsumeItemBox;
		private Script.ActionChooserControl ActionBox;
	}
}