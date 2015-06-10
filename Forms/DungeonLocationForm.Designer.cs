namespace DungeonEye.Forms
{
	partial class DungeonLocationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DungeonLocationForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.MazeBox = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.DirectionBox = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
			this.GroundPositionBox = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.SelectBox = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.MouseLocationBox = new System.Windows.Forms.ToolStripStatusLabel();
			this.DungeonControl = new DungeonEye.Forms.DungeonLocationControl();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.MazeBox,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.DirectionBox,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.GroundPositionBox,
            this.toolStripSeparator3,
            this.SelectBox});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(773, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(41, 22);
			this.toolStripLabel1.Text = "Maze :";
			// 
			// MazeBox
			// 
			this.MazeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.MazeBox.Name = "MazeBox";
			this.MazeBox.Size = new System.Drawing.Size(121, 25);
			this.MazeBox.Sorted = true;
			this.MazeBox.SelectedIndexChanged += new System.EventHandler(this.MazeBox_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(61, 22);
			this.toolStripLabel2.Text = "Direction :";
			// 
			// DirectionBox
			// 
			this.DirectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DirectionBox.Name = "DirectionBox";
			this.DirectionBox.Size = new System.Drawing.Size(121, 25);
			this.DirectionBox.SelectedIndexChanged += new System.EventHandler(this.DirectionBox_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(53, 22);
			this.toolStripLabel3.Text = "Ground :";
			// 
			// GroundPositionBox
			// 
			this.GroundPositionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.GroundPositionBox.Name = "GroundPositionBox";
			this.GroundPositionBox.Size = new System.Drawing.Size(121, 25);
			this.GroundPositionBox.SelectedIndexChanged += new System.EventHandler(this.GroundPositionBox_SelectedIndexChanged);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// SelectBox
			// 
			this.SelectBox.Image = ((System.Drawing.Image) (resources.GetObject("SelectBox.Image")));
			this.SelectBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SelectBox.Name = "SelectBox";
			this.SelectBox.Size = new System.Drawing.Size(58, 22);
			this.SelectBox.Text = "Select";
			this.SelectBox.Click += new System.EventHandler(this.SelectBox_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.MouseLocationBox});
			this.statusStrip1.Location = new System.Drawing.Point(0, 529);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(773, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
			this.toolStripStatusLabel1.Text = "Position :";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
			// 
			// MouseLocationBox
			// 
			this.MouseLocationBox.Name = "MouseLocationBox";
			this.MouseLocationBox.Size = new System.Drawing.Size(37, 17);
			this.MouseLocationBox.Text = "..........";
			// 
			// DungeonControl
			// 
			this.DungeonControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DungeonControl.Dungeon = null;
			this.DungeonControl.Location = new System.Drawing.Point(0, 25);
			this.DungeonControl.Maze = null;
			this.DungeonControl.Name = "DungeonControl";
			this.DungeonControl.Size = new System.Drawing.Size(773, 504);
			this.DungeonControl.TabIndex = 0;
			this.DungeonControl.Target = null;
			this.DungeonControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DungeonControl_MouseMove);
			// 
			// DungeonLocationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(773, 551);
			this.Controls.Add(this.DungeonControl);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "DungeonLocationForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Dungeon Location";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DungeonLocationControl DungeonControl;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripComboBox MazeBox;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripComboBox DirectionBox;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton SelectBox;
		private System.Windows.Forms.ToolStripLabel toolStripLabel3;
		private System.Windows.Forms.ToolStripComboBox GroundPositionBox;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripStatusLabel MouseLocationBox;
	}
}