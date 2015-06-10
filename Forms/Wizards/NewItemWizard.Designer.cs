namespace DungeonEye.Forms.Wizards
{
	partial class NewItemWizard
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
			this.ItemNameBox = new System.Windows.Forms.TextBox();
			this.CancelBox = new System.Windows.Forms.Button();
			this.CreateBox = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name :";
			// 
			// ItemNameBox
			// 
			this.ItemNameBox.Location = new System.Drawing.Point(52, 12);
			this.ItemNameBox.Name = "ItemNameBox";
			this.ItemNameBox.Size = new System.Drawing.Size(220, 20);
			this.ItemNameBox.TabIndex = 1;
			// 
			// CancelBox
			// 
			this.CancelBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelBox.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelBox.Location = new System.Drawing.Point(197, 40);
			this.CancelBox.Name = "CancelBox";
			this.CancelBox.Size = new System.Drawing.Size(75, 23);
			this.CancelBox.TabIndex = 11;
			this.CancelBox.Text = "Cancel";
			this.CancelBox.UseVisualStyleBackColor = true;
			// 
			// CreateBox
			// 
			this.CreateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CreateBox.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.CreateBox.Location = new System.Drawing.Point(115, 41);
			this.CreateBox.Name = "CreateBox";
			this.CreateBox.Size = new System.Drawing.Size(75, 23);
			this.CreateBox.TabIndex = 10;
			this.CreateBox.Text = "Create";
			this.CreateBox.UseVisualStyleBackColor = true;
			// 
			// NewItemWizard
			// 
			this.AcceptButton = this.CreateBox;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelBox;
			this.ClientSize = new System.Drawing.Size(284, 75);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ItemNameBox);
			this.Controls.Add(this.CancelBox);
			this.Controls.Add(this.CreateBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewItemWizard";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New Item Wizard";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ItemNameBox;
		private System.Windows.Forms.Button CancelBox;
		private System.Windows.Forms.Button CreateBox;
	}
}