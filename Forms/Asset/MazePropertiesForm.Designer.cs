namespace DungeonEye.Forms
{
	partial class MazePropertiesForm
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
			this.MazeControl = new DungeonEye.Forms.MazePropertiesControl();
			this.SuspendLayout();
			// 
			// mazePropertiesControl1
			// 
			this.MazeControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MazeControl.Location = new System.Drawing.Point(0, 0);
			this.MazeControl.Name = "mazePropertiesControl1";
			this.MazeControl.Size = new System.Drawing.Size(444, 466);
			this.MazeControl.TabIndex = 0;
			// 
			// MazePropertiesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 462);
			this.Controls.Add(this.MazeControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(400, 500);
			this.Name = "MazePropertiesForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Maze properties";
			this.ResumeLayout(false);

		}

		#endregion

		private MazePropertiesControl MazeControl;
	}
}