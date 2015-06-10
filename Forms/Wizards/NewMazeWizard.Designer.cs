namespace DungeonEye.Forms.Wizards
{
	partial class NewMazeWizard
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

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.MazeName = new System.Windows.Forms.TextBox();
			this.CreateButton = new System.Windows.Forms.Button();
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.MazeHeightBox = new System.Windows.Forms.NumericUpDown();
			this.MazeWidthBox = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.OverlayTileSetBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.WallTilSetBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MazeHeightBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MazeWidthBox)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name :";
			// 
			// MazeName
			// 
			this.MazeName.Location = new System.Drawing.Point(54, 19);
			this.MazeName.Name = "MazeName";
			this.MazeName.Size = new System.Drawing.Size(223, 20);
			this.MazeName.TabIndex = 1;
			// 
			// CreateButton
			// 
			this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CreateButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.CreateButton.Location = new System.Drawing.Point(135, 191);
			this.CreateButton.Name = "CreateButton";
			this.CreateButton.Size = new System.Drawing.Size(75, 23);
			this.CreateButton.TabIndex = 7;
			this.CreateButton.Text = "Create";
			this.CreateButton.UseVisualStyleBackColor = true;
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ButtonCancel.Location = new System.Drawing.Point(217, 190);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
			this.ButtonCancel.TabIndex = 8;
			this.ButtonCancel.Text = "Cancel";
			this.ButtonCancel.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.MazeHeightBox);
			this.groupBox1.Controls.Add(this.MazeName);
			this.groupBox1.Controls.Add(this.MazeWidthBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(283, 89);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Maze properties :";
			// 
			// MazeHeightBox
			// 
			this.MazeHeightBox.Location = new System.Drawing.Point(222, 54);
			this.MazeHeightBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.MazeHeightBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.MazeHeightBox.Name = "MazeHeightBox";
			this.MazeHeightBox.Size = new System.Drawing.Size(55, 20);
			this.MazeHeightBox.TabIndex = 4;
			this.MazeHeightBox.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// MazeWidthBox
			// 
			this.MazeWidthBox.Location = new System.Drawing.Point(54, 54);
			this.MazeWidthBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.MazeWidthBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.MazeWidthBox.Name = "MazeWidthBox";
			this.MazeWidthBox.Size = new System.Drawing.Size(55, 20);
			this.MazeWidthBox.TabIndex = 3;
			this.MazeWidthBox.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(169, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Height :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Width :";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.OverlayTileSetBox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.WallTilSetBox);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(12, 107);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(283, 77);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// OverlayTileSetBox
			// 
			this.OverlayTileSetBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.OverlayTileSetBox.FormattingEnabled = true;
			this.OverlayTileSetBox.Location = new System.Drawing.Point(94, 43);
			this.OverlayTileSetBox.Name = "OverlayTileSetBox";
			this.OverlayTileSetBox.Size = new System.Drawing.Size(183, 21);
			this.OverlayTileSetBox.Sorted = true;
			this.OverlayTileSetBox.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Overlay tileset :";
			// 
			// WallTilSetBox
			// 
			this.WallTilSetBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.WallTilSetBox.FormattingEnabled = true;
			this.WallTilSetBox.Location = new System.Drawing.Point(94, 16);
			this.WallTilSetBox.Name = "WallTilSetBox";
			this.WallTilSetBox.Size = new System.Drawing.Size(183, 21);
			this.WallTilSetBox.Sorted = true;
			this.WallTilSetBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Wall tileset :";
			// 
			// NewMazeWizard
			// 
			this.AcceptButton = this.CreateButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.ButtonCancel;
			this.ClientSize = new System.Drawing.Size(304, 225);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.ButtonCancel);
			this.Controls.Add(this.CreateButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.HelpButton = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewMazeWizard";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New maze wizard";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MazeHeightBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MazeWidthBox)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox MazeName;
		private System.Windows.Forms.Button CreateButton;
		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown MazeHeightBox;
		private System.Windows.Forms.NumericUpDown MazeWidthBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox OverlayTileSetBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox WallTilSetBox;
		private System.Windows.Forms.Label label2;
	}
}