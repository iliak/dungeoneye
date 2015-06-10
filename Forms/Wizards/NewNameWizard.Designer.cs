namespace DungeonEye.Forms.Wizards
{
	partial class NewNameWizard
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
			this.label1 = new System.Windows.Forms.Label();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.CancelBox = new System.Windows.Forms.Button();
			this.AcceptBox = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name :";
			// 
			// NameBox
			// 
			this.NameBox.Location = new System.Drawing.Point(59, 12);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(223, 20);
			this.NameBox.TabIndex = 1;
			// 
			// CancelBox
			// 
			this.CancelBox.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelBox.Location = new System.Drawing.Point(207, 38);
			this.CancelBox.Name = "CancelBox";
			this.CancelBox.Size = new System.Drawing.Size(75, 23);
			this.CancelBox.TabIndex = 3;
			this.CancelBox.Text = "Cancel";
			this.CancelBox.UseVisualStyleBackColor = true;
			// 
			// AcceptBox
			// 
			this.AcceptBox.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.AcceptBox.Location = new System.Drawing.Point(126, 38);
			this.AcceptBox.Name = "AcceptBox";
			this.AcceptBox.Size = new System.Drawing.Size(75, 23);
			this.AcceptBox.TabIndex = 2;
			this.AcceptBox.Text = "OK";
			this.AcceptBox.UseVisualStyleBackColor = true;
			// 
			// NewNameWizard
			// 
			this.AcceptButton = this.AcceptBox;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelBox;
			this.ClientSize = new System.Drawing.Size(293, 68);
			this.Controls.Add(this.AcceptBox);
			this.Controls.Add(this.CancelBox);
			this.Controls.Add(this.NameBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewNameWizard";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New Name Wizard";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.Button CancelBox;
		private System.Windows.Forms.Button AcceptBox;
	}
}