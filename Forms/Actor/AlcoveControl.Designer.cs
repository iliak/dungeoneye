namespace DungeonEye.Forms
{
	partial class AlcoveControl
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
			this.GLControl = new OpenTK.GLControl();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.VisualTab = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.AcceptBigItemsBox = new System.Windows.Forms.CheckBox();
			this.HideItemsBox = new System.Windows.Forms.CheckBox();
			this.ClearBox = new System.Windows.Forms.Button();
			this.DecorationBox = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.DirectionBox = new DungeonEye.Forms.CardinalPointControl();
			this.ScriptTab = new System.Windows.Forms.TabPage();
			this.ItemRemovedBox = new DungeonEye.Forms.AlcoveScriptListControl();
			this.ItemAddedBox = new DungeonEye.Forms.AlcoveScriptListControl();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.VisualTab.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DecorationBox)).BeginInit();
			this.ScriptTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// GLControl
			// 
			this.GLControl.BackColor = System.Drawing.Color.Black;
			this.GLControl.Location = new System.Drawing.Point(6, 19);
			this.GLControl.Name = "GLControl";
			this.GLControl.Size = new System.Drawing.Size(352, 240);
			this.GLControl.TabIndex = 1;
			this.GLControl.VSync = false;
			this.GLControl.Load += new System.EventHandler(this.GLControl_Load);
			this.GLControl.Paint += new System.Windows.Forms.PaintEventHandler(this.GLControl_Paint);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.GLControl);
			this.groupBox2.Location = new System.Drawing.Point(6, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(365, 270);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Visual properties";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.tabControl1);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Location = new System.Drawing.Point(0, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(788, 651);
			this.groupBox4.TabIndex = 7;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Alcove";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.VisualTab);
			this.tabControl1.Controls.Add(this.ScriptTab);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(3, 16);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(782, 632);
			this.tabControl1.TabIndex = 8;
			// 
			// VisualTab
			// 
			this.VisualTab.Controls.Add(this.groupBox1);
			this.VisualTab.Controls.Add(this.DirectionBox);
			this.VisualTab.Controls.Add(this.groupBox2);
			this.VisualTab.Location = new System.Drawing.Point(4, 22);
			this.VisualTab.Name = "VisualTab";
			this.VisualTab.Padding = new System.Windows.Forms.Padding(3);
			this.VisualTab.Size = new System.Drawing.Size(774, 606);
			this.VisualTab.TabIndex = 1;
			this.VisualTab.Text = "Visual";
			this.VisualTab.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.AcceptBigItemsBox);
			this.groupBox1.Controls.Add(this.HideItemsBox);
			this.groupBox1.Controls.Add(this.ClearBox);
			this.groupBox1.Controls.Add(this.DecorationBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(6, 282);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(234, 115);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Properties";
			// 
			// AcceptBigItemsBox
			// 
			this.AcceptBigItemsBox.AutoSize = true;
			this.AcceptBigItemsBox.Location = new System.Drawing.Point(6, 71);
			this.AcceptBigItemsBox.Name = "AcceptBigItemsBox";
			this.AcceptBigItemsBox.Size = new System.Drawing.Size(104, 17);
			this.AcceptBigItemsBox.TabIndex = 6;
			this.AcceptBigItemsBox.Text = "Accept big items";
			this.AcceptBigItemsBox.UseVisualStyleBackColor = true;
			// 
			// HideItemsBox
			// 
			this.HideItemsBox.AutoSize = true;
			this.HideItemsBox.Location = new System.Drawing.Point(6, 48);
			this.HideItemsBox.Name = "HideItemsBox";
			this.HideItemsBox.Size = new System.Drawing.Size(75, 17);
			this.HideItemsBox.TabIndex = 5;
			this.HideItemsBox.Text = "Hide items";
			this.HideItemsBox.UseVisualStyleBackColor = true;
			// 
			// ClearBox
			// 
			this.ClearBox.Location = new System.Drawing.Point(180, 19);
			this.ClearBox.Name = "ClearBox";
			this.ClearBox.Size = new System.Drawing.Size(48, 23);
			this.ClearBox.TabIndex = 4;
			this.ClearBox.Text = "Clear";
			this.ClearBox.UseVisualStyleBackColor = true;
			// 
			// DecorationBox
			// 
			this.DecorationBox.Location = new System.Drawing.Point(75, 22);
			this.DecorationBox.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
			this.DecorationBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.DecorationBox.Name = "DecorationBox";
			this.DecorationBox.Size = new System.Drawing.Size(67, 20);
			this.DecorationBox.TabIndex = 2;
			this.DecorationBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.DecorationBox.ThousandsSeparator = true;
			this.DecorationBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.DecorationBox.ValueChanged += new System.EventHandler(this.DecorationBox_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Decoration";
			// 
			// DirectionBox
			// 
			this.DirectionBox.Direction = DungeonEye.CardinalPoint.North;
			this.DirectionBox.Location = new System.Drawing.Point(377, 6);
			this.DirectionBox.MinimumSize = new System.Drawing.Size(125, 115);
			this.DirectionBox.Name = "DirectionBox";
			this.DirectionBox.Size = new System.Drawing.Size(125, 115);
			this.DirectionBox.TabIndex = 7;
			this.DirectionBox.Title = "Side";
			this.DirectionBox.DirectionChanged += new DungeonEye.Forms.CardinalPointControl.ChangedEventHandler(this.DirectionBox_DirectionChanged);
			// 
			// ScriptTab
			// 
			this.ScriptTab.Controls.Add(this.ItemRemovedBox);
			this.ScriptTab.Controls.Add(this.ItemAddedBox);
			this.ScriptTab.Location = new System.Drawing.Point(4, 22);
			this.ScriptTab.Name = "ScriptTab";
			this.ScriptTab.Padding = new System.Windows.Forms.Padding(3);
			this.ScriptTab.Size = new System.Drawing.Size(774, 606);
			this.ScriptTab.TabIndex = 0;
			this.ScriptTab.Text = "Scripting";
			this.ScriptTab.UseVisualStyleBackColor = true;
			// 
			// ItemRemovedBox
			// 
			this.ItemRemovedBox.Dungeon = null;
			this.ItemRemovedBox.Location = new System.Drawing.Point(6, 162);
			this.ItemRemovedBox.MinimumSize = new System.Drawing.Size(300, 150);
			this.ItemRemovedBox.Name = "ItemRemovedBox";
			this.ItemRemovedBox.Scripts = null;
			this.ItemRemovedBox.Size = new System.Drawing.Size(427, 150);
			this.ItemRemovedBox.TabIndex = 0;
			this.ItemRemovedBox.Title = "On item removed";
			// 
			// ItemAddedBox
			// 
			this.ItemAddedBox.Dungeon = null;
			this.ItemAddedBox.Location = new System.Drawing.Point(6, 6);
			this.ItemAddedBox.MinimumSize = new System.Drawing.Size(300, 150);
			this.ItemAddedBox.Name = "ItemAddedBox";
			this.ItemAddedBox.Scripts = null;
			this.ItemAddedBox.Size = new System.Drawing.Size(427, 150);
			this.ItemAddedBox.TabIndex = 0;
			this.ItemAddedBox.Title = "On item added";
			// 
			// AlcoveControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox4);
			this.Name = "AlcoveControl";
			this.Size = new System.Drawing.Size(788, 651);
			this.Load += new System.EventHandler(this.AlcoveControl_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.VisualTab.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DecorationBox)).EndInit();
			this.ScriptTab.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private OpenTK.GLControl GLControl;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage ScriptTab;
		private System.Windows.Forms.TabPage VisualTab;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox AcceptBigItemsBox;
		private System.Windows.Forms.CheckBox HideItemsBox;
		private System.Windows.Forms.Button ClearBox;
		private System.Windows.Forms.NumericUpDown DecorationBox;
		private System.Windows.Forms.Label label1;
		private CardinalPointControl DirectionBox;
		private AlcoveScriptListControl ItemAddedBox;
		private AlcoveScriptListControl ItemRemovedBox;
	}
}
