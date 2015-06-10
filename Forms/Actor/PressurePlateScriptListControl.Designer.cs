namespace DungeonEye.Forms
{
	partial class PressurePlateScriptListControl
	{
		/// <summary> 
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WallSwitchScriptListControl));
			this.RemoveBox = new System.Windows.Forms.ToolStripButton();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.ScriptListBox = new System.Windows.Forms.ListBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.AddBox = new System.Windows.Forms.ToolStripButton();
			this.EditBox = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.MoveUpBox = new System.Windows.Forms.ToolStripButton();
			this.MoveDownBox = new System.Windows.Forms.ToolStripButton();
			this.groupBox5.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// RemoveBox
			// 
			this.RemoveBox.Image = ((System.Drawing.Image)(resources.GetObject("RemoveBox.Image")));
			this.RemoveBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.RemoveBox.Name = "RemoveBox";
			this.RemoveBox.Size = new System.Drawing.Size(70, 22);
			this.RemoveBox.Text = "Remove";
			this.RemoveBox.ToolTipText = "Remove action";
			this.RemoveBox.Click += new System.EventHandler(this.RemoveBox_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.ScriptListBox);
			this.groupBox5.Controls.Add(this.toolStrip1);
			this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox5.Location = new System.Drawing.Point(0, 0);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(350, 150);
			this.groupBox5.TabIndex = 10;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Script list";
			// 
			// ScriptListBox
			// 
			this.ScriptListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ScriptListBox.FormattingEnabled = true;
			this.ScriptListBox.Location = new System.Drawing.Point(6, 41);
			this.ScriptListBox.Name = "ScriptListBox";
			this.ScriptListBox.Size = new System.Drawing.Size(338, 95);
			this.ScriptListBox.TabIndex = 1;
			this.ScriptListBox.DoubleClick += new System.EventHandler(this.ScriptListBox_DoubleClick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBox,
            this.EditBox,
            this.toolStripSeparator1,
            this.RemoveBox,
            this.toolStripSeparator2,
            this.MoveUpBox,
            this.MoveDownBox});
			this.toolStrip1.Location = new System.Drawing.Point(6, 16);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new System.Drawing.Size(338, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// AddBox
			// 
			this.AddBox.Image = ((System.Drawing.Image)(resources.GetObject("AddBox.Image")));
			this.AddBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.AddBox.Name = "AddBox";
			this.AddBox.Size = new System.Drawing.Size(49, 22);
			this.AddBox.Text = "Add";
			this.AddBox.ToolTipText = "Add a new action";
			this.AddBox.Click += new System.EventHandler(this.AddBox_Click);
			// 
			// EditBox
			// 
			this.EditBox.Image = ((System.Drawing.Image)(resources.GetObject("EditBox.Image")));
			this.EditBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.EditBox.Name = "EditBox";
			this.EditBox.Size = new System.Drawing.Size(47, 22);
			this.EditBox.Text = "Edit";
			this.EditBox.ToolTipText = "Edit current action";
			this.EditBox.Click += new System.EventHandler(this.EditBox_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// MoveUpBox
			// 
			this.MoveUpBox.Image = ((System.Drawing.Image)(resources.GetObject("MoveUpBox.Image")));
			this.MoveUpBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.MoveUpBox.Name = "MoveUpBox";
			this.MoveUpBox.Size = new System.Drawing.Size(42, 22);
			this.MoveUpBox.Text = "Up";
			this.MoveUpBox.Click += new System.EventHandler(this.MoveUpBox_Click);
			// 
			// MoveDownBox
			// 
			this.MoveDownBox.Image = ((System.Drawing.Image)(resources.GetObject("MoveDownBox.Image")));
			this.MoveDownBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.MoveDownBox.Name = "MoveDownBox";
			this.MoveDownBox.Size = new System.Drawing.Size(58, 22);
			this.MoveDownBox.Text = "Down";
			this.MoveDownBox.Click += new System.EventHandler(this.MoveDownBox_Click);
			// 
			// WallSwitchScriptListControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox5);
			this.MinimumSize = new System.Drawing.Size(350, 150);
			this.Name = "WallSwitchScriptListControl";
			this.Size = new System.Drawing.Size(350, 150);
			this.EnabledChanged += new System.EventHandler(this.OnEnabledChanged);
			this.groupBox5.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripButton RemoveBox;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.ListBox ScriptListBox;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton AddBox;
		private System.Windows.Forms.ToolStripButton EditBox;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton MoveUpBox;
		private System.Windows.Forms.ToolStripButton MoveDownBox;

	}
}
