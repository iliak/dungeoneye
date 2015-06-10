namespace DungeonEye.Forms
{
	partial class MazePropertiesControl
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
			this.WallTileSetNameBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.DecorationNameBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.TileSetTab = new System.Windows.Forms.TabPage();
			this.PitTab = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.FloorControl = new OpenTK.GLControl();
			this.FloorIdBox = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.CeilingIdBox = new System.Windows.Forms.NumericUpDown();
			this.CeilingControl = new OpenTK.GLControl();
			this.tabControl1.SuspendLayout();
			this.TileSetTab.SuspendLayout();
			this.PitTab.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FloorIdBox)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CeilingIdBox)).BeginInit();
			this.SuspendLayout();
			// 
			// WallTileSetNameBox
			// 
			this.WallTileSetNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.WallTileSetNameBox.FormattingEnabled = true;
			this.WallTileSetNameBox.Location = new System.Drawing.Point(79, 33);
			this.WallTileSetNameBox.Name = "WallTileSetNameBox";
			this.WallTileSetNameBox.Size = new System.Drawing.Size(169, 21);
			this.WallTileSetNameBox.Sorted = true;
			this.WallTileSetNameBox.TabIndex = 0;
			this.WallTileSetNameBox.SelectedIndexChanged += new System.EventHandler(this.WallTileSetNameBox_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Wall :";
			// 
			// DecorationNameBox
			// 
			this.DecorationNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DecorationNameBox.FormattingEnabled = true;
			this.DecorationNameBox.Location = new System.Drawing.Point(79, 6);
			this.DecorationNameBox.Name = "DecorationNameBox";
			this.DecorationNameBox.Size = new System.Drawing.Size(169, 21);
			this.DecorationNameBox.Sorted = true;
			this.DecorationNameBox.TabIndex = 0;
			this.DecorationNameBox.SelectedIndexChanged += new System.EventHandler(this.DecorationNameBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Decoration :";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.TileSetTab);
			this.tabControl1.Controls.Add(this.PitTab);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(477, 585);
			this.tabControl1.TabIndex = 4;
			// 
			// TileSetTab
			// 
			this.TileSetTab.Controls.Add(this.WallTileSetNameBox);
			this.TileSetTab.Controls.Add(this.DecorationNameBox);
			this.TileSetTab.Controls.Add(this.label3);
			this.TileSetTab.Controls.Add(this.label1);
			this.TileSetTab.Location = new System.Drawing.Point(4, 22);
			this.TileSetTab.Name = "TileSetTab";
			this.TileSetTab.Padding = new System.Windows.Forms.Padding(3);
			this.TileSetTab.Size = new System.Drawing.Size(469, 688);
			this.TileSetTab.TabIndex = 0;
			this.TileSetTab.Text = "Tileset";
			this.TileSetTab.UseVisualStyleBackColor = true;
			// 
			// PitTab
			// 
			this.PitTab.AutoScroll = true;
			this.PitTab.Controls.Add(this.groupBox2);
			this.PitTab.Controls.Add(this.groupBox1);
			this.PitTab.Location = new System.Drawing.Point(4, 22);
			this.PitTab.Name = "PitTab";
			this.PitTab.Padding = new System.Windows.Forms.Padding(3);
			this.PitTab.Size = new System.Drawing.Size(469, 559);
			this.PitTab.TabIndex = 1;
			this.PitTab.Text = "Pit";
			this.PitTab.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.FloorIdBox);
			this.groupBox1.Controls.Add(this.FloorControl);
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(457, 269);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Floor pit";
			// 
			// FloorControl
			// 
			this.FloorControl.BackColor = System.Drawing.Color.Black;
			this.FloorControl.Location = new System.Drawing.Point(6, 19);
			this.FloorControl.Name = "FloorControl";
			this.FloorControl.Size = new System.Drawing.Size(352, 240);
			this.FloorControl.TabIndex = 0;
			this.FloorControl.VSync = false;
			this.FloorControl.Load += new System.EventHandler(this.FloorControl_Load);
			this.FloorControl.Paint += new System.Windows.Forms.PaintEventHandler(this.FloorControl_Paint);
			// 
			// FloorIdBox
			// 
			this.FloorIdBox.Location = new System.Drawing.Point(364, 35);
			this.FloorIdBox.Name = "FloorIdBox";
			this.FloorIdBox.Size = new System.Drawing.Size(83, 20);
			this.FloorIdBox.TabIndex = 1;
			this.FloorIdBox.ValueChanged += new System.EventHandler(this.FloorIdBox_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(364, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Decoration ID";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.CeilingIdBox);
			this.groupBox2.Controls.Add(this.CeilingControl);
			this.groupBox2.Location = new System.Drawing.Point(6, 281);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(457, 269);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ceiling pit";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(364, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Decoration ID";
			// 
			// CeilingIdBox
			// 
			this.CeilingIdBox.Location = new System.Drawing.Point(364, 35);
			this.CeilingIdBox.Name = "CeilingIdBox";
			this.CeilingIdBox.Size = new System.Drawing.Size(83, 20);
			this.CeilingIdBox.TabIndex = 1;
			this.CeilingIdBox.ValueChanged += new System.EventHandler(this.CeilingIdBox_ValueChanged);
			// 
			// CeilingControl
			// 
			this.CeilingControl.BackColor = System.Drawing.Color.Black;
			this.CeilingControl.Location = new System.Drawing.Point(6, 19);
			this.CeilingControl.Name = "CeilingControl";
			this.CeilingControl.Size = new System.Drawing.Size(352, 240);
			this.CeilingControl.TabIndex = 0;
			this.CeilingControl.VSync = false;
			this.CeilingControl.Load += new System.EventHandler(this.CeilingControl_Load);
			this.CeilingControl.Paint += new System.Windows.Forms.PaintEventHandler(this.CeilingControl_Paint);
			// 
			// MazePropertiesControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl1);
			this.Name = "MazePropertiesControl";
			this.Size = new System.Drawing.Size(477, 585);
			this.tabControl1.ResumeLayout(false);
			this.TileSetTab.ResumeLayout(false);
			this.TileSetTab.PerformLayout();
			this.PitTab.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.FloorIdBox)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CeilingIdBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox WallTileSetNameBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox DecorationNameBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage TileSetTab;
		private System.Windows.Forms.TabPage PitTab;
		private System.Windows.Forms.GroupBox groupBox1;
		private OpenTK.GLControl FloorControl;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown FloorIdBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown CeilingIdBox;
		private OpenTK.GLControl CeilingControl;
	}
}
