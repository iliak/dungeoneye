namespace DungeonEye.Forms
{
	partial class SquareForm
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
			this.SquareControlBox = new DungeonEye.Forms.SquareControl();
			this.SuspendLayout();
			// 
			// CloseBox
			// 
			this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseBox.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.CloseBox.Location = new System.Drawing.Point(597, 627);
			this.CloseBox.Name = "CloseBox";
			this.CloseBox.Size = new System.Drawing.Size(75, 23);
			this.CloseBox.TabIndex = 1;
			this.CloseBox.Text = "Close";
			this.CloseBox.UseVisualStyleBackColor = true;
			// 
			// SquareControlBox
			// 
			this.SquareControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SquareControlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SquareControlBox.Location = new System.Drawing.Point(12, 12);
			this.SquareControlBox.Maze = null;
			this.SquareControlBox.MinimumSize = new System.Drawing.Size(650, 600);
			this.SquareControlBox.Name = "SquareControlBox";
			this.SquareControlBox.Size = new System.Drawing.Size(660, 609);
			this.SquareControlBox.TabIndex = 0;
			// 
			// SquareForm
			// 
			this.AcceptButton = this.CloseBox;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 662);
			this.Controls.Add(this.CloseBox);
			this.Controls.Add(this.SquareControlBox);
			this.KeyPreview = true;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(700, 700);
			this.Name = "SquareForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Square Form";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SquareForm_KeyDown);
			this.ResumeLayout(false);

		}

		#endregion

		private SquareControl SquareControlBox;
		private System.Windows.Forms.Button CloseBox;

	}
}