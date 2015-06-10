namespace DungeonEye.Forms
{
	partial class EventActionForm
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
			this.CloseBox = new System.Windows.Forms.Button();
			this.ActionListBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.RemainingCountBox = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.ActionControlBox = new System.Windows.Forms.Panel();
			this.OKBox = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.RemainingCountBox)).BeginInit();
			this.SuspendLayout();
			// 
			// CloseBox
			// 
			this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseBox.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CloseBox.Location = new System.Drawing.Point(728, 449);
			this.CloseBox.Name = "CloseBox";
			this.CloseBox.Size = new System.Drawing.Size(75, 23);
			this.CloseBox.TabIndex = 0;
			this.CloseBox.Text = "Cancel";
			this.CloseBox.UseVisualStyleBackColor = true;
			// 
			// ActionListBox
			// 
			this.ActionListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ActionListBox.FormattingEnabled = true;
			this.ActionListBox.Location = new System.Drawing.Point(112, 12);
			this.ActionListBox.Name = "ActionListBox";
			this.ActionListBox.Size = new System.Drawing.Size(166, 21);
			this.ActionListBox.Sorted = true;
			this.ActionListBox.TabIndex = 1;
			this.ActionListBox.SelectedIndexChanged += new System.EventHandler(this.ActionListBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(356, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Remaining :";
			// 
			// RemainingCountBox
			// 
			this.RemainingCountBox.Location = new System.Drawing.Point(425, 13);
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
			this.RemainingCountBox.TabIndex = 3;
			this.RemainingCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.RemainingCountBox.ThousandsSeparator = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(63, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Action :";
			// 
			// ActionControlBox
			// 
			this.ActionControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ActionControlBox.Location = new System.Drawing.Point(12, 39);
			this.ActionControlBox.Name = "ActionControlBox";
			this.ActionControlBox.Size = new System.Drawing.Size(791, 404);
			this.ActionControlBox.TabIndex = 4;
			// 
			// OKBox
			// 
			this.OKBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OKBox.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OKBox.Location = new System.Drawing.Point(647, 449);
			this.OKBox.Name = "OKBox";
			this.OKBox.Size = new System.Drawing.Size(75, 23);
			this.OKBox.TabIndex = 0;
			this.OKBox.Text = "Accept";
			this.OKBox.UseVisualStyleBackColor = true;
			// 
			// EventActionForm
			// 
			this.AcceptButton = this.OKBox;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CloseBox;
			this.ClientSize = new System.Drawing.Size(815, 484);
			this.Controls.Add(this.ActionControlBox);
			this.Controls.Add(this.RemainingCountBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ActionListBox);
			this.Controls.Add(this.OKBox);
			this.Controls.Add(this.CloseBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "EventActionForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Event action wizard";
			((System.ComponentModel.ISupportInitialize)(this.RemainingCountBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CloseBox;
		private System.Windows.Forms.ComboBox ActionListBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown RemainingCountBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel ActionControlBox;
		private System.Windows.Forms.Button OKBox;
	}
}