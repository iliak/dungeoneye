namespace DungeonEye.Forms
{
	partial class RenameForm
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
			this.DesiredNameBox = new System.Windows.Forms.TextBox();
			this.CancelBox = new System.Windows.Forms.Button();
			this.OkBox = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// DesiredNameBox
			// 
			this.DesiredNameBox.Location = new System.Drawing.Point(102, 12);
			this.DesiredNameBox.Name = "DesiredNameBox";
			this.DesiredNameBox.Size = new System.Drawing.Size(186, 20);
			this.DesiredNameBox.TabIndex = 0;
			// 
			// CancelBox
			// 
			this.CancelBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelBox.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelBox.Location = new System.Drawing.Point(213, 38);
			this.CancelBox.Name = "CancelBox";
			this.CancelBox.Size = new System.Drawing.Size(75, 23);
			this.CancelBox.TabIndex = 1;
			this.CancelBox.Text = "Cancel";
			this.CancelBox.UseVisualStyleBackColor = true;
			// 
			// OkBox
			// 
			this.OkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OkBox.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OkBox.Location = new System.Drawing.Point(132, 38);
			this.OkBox.Name = "OkBox";
			this.OkBox.Size = new System.Drawing.Size(75, 23);
			this.OkBox.TabIndex = 2;
			this.OkBox.Text = "OK";
			this.OkBox.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Enter new name";
			// 
			// RenameForm
			// 
			this.AcceptButton = this.OkBox;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelBox;
			this.ClientSize = new System.Drawing.Size(300, 73);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.OkBox);
			this.Controls.Add(this.CancelBox);
			this.Controls.Add(this.DesiredNameBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RenameForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Rename";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CancelBox;
		private System.Windows.Forms.Button OkBox;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox DesiredNameBox;
	}
}