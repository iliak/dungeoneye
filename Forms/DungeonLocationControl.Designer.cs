namespace DungeonEye.Forms
{
	partial class DungeonLocationControl
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
			this.components = new System.ComponentModel.Container();
			this.GlControlBox = new OpenTK.GLControl();
			this.DrawTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// GlControlBox
			// 
			this.GlControlBox.BackColor = System.Drawing.Color.Black;
			this.GlControlBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GlControlBox.Location = new System.Drawing.Point(0, 0);
			this.GlControlBox.Name = "GlControlBox";
			this.GlControlBox.Size = new System.Drawing.Size(633, 562);
			this.GlControlBox.TabIndex = 2;
			this.GlControlBox.VSync = false;
			this.GlControlBox.Load += new System.EventHandler(this.GlControlBox_Load);
			this.GlControlBox.DoubleClick += new System.EventHandler(this.GlControlBox_DoubleClick);
			this.GlControlBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GlControl_Paint);
			this.GlControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GlControlBox_MouseMove);
			this.GlControlBox.Resize += new System.EventHandler(this.GlControl_Resize);
			this.GlControlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GlControlBox_MouseUp);
			// 
			// DrawTimer
			// 
			this.DrawTimer.Tick += new System.EventHandler(this.DrawTimer_Tick);
			// 
			// DungeonLocationControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.GlControlBox);
			this.Name = "DungeonLocationControl";
			this.Size = new System.Drawing.Size(633, 562);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer DrawTimer;
		public OpenTK.GLControl GlControlBox;
	}
}