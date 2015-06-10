namespace DungeonEye.Forms
{
	partial class WallSwitchScriptForm
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
			this.ActionBox = new DungeonEye.Forms.Script.ActionChooserControl();
			this.AcceptBox = new System.Windows.Forms.Button();
			this.CancelBox = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ActionBox
			// 
			this.ActionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ActionBox.Dungeon = null;
			this.ActionBox.Location = new System.Drawing.Point(12, 12);
			this.ActionBox.Name = "ActionBox";
			this.ActionBox.Script = null;
			this.ActionBox.Size = new System.Drawing.Size(690, 328);
			this.ActionBox.TabIndex = 0;
			// 
			// AcceptBox
			// 
			this.AcceptBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AcceptBox.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.AcceptBox.Location = new System.Drawing.Point(546, 346);
			this.AcceptBox.Name = "AcceptBox";
			this.AcceptBox.Size = new System.Drawing.Size(75, 23);
			this.AcceptBox.TabIndex = 2;
			this.AcceptBox.Text = "Ok";
			this.AcceptBox.UseVisualStyleBackColor = true;
			// 
			// CancelBox
			// 
			this.CancelBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelBox.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelBox.Location = new System.Drawing.Point(627, 346);
			this.CancelBox.Name = "CancelBox";
			this.CancelBox.Size = new System.Drawing.Size(75, 23);
			this.CancelBox.TabIndex = 1;
			this.CancelBox.Text = "Cancel";
			this.CancelBox.UseVisualStyleBackColor = true;
			// 
			// WallSwitchScriptForm
			// 
			this.AcceptButton = this.AcceptBox;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelBox;
			this.ClientSize = new System.Drawing.Size(714, 381);
			this.Controls.Add(this.AcceptBox);
			this.Controls.Add(this.CancelBox);
			this.Controls.Add(this.ActionBox);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "WallSwitchScriptForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "WallSwitch Script Form";
			this.ResumeLayout(false);

		}

		#endregion

		private Script.ActionChooserControl ActionBox;
		private System.Windows.Forms.Button AcceptBox;
		private System.Windows.Forms.Button CancelBox;

	}
}