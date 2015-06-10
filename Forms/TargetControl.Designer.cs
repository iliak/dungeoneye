namespace DungeonEye.Forms
{
	partial class TargetControl
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.CoordinateBox = new System.Windows.Forms.TextBox();
			this.MazeNameBox = new System.Windows.Forms.TextBox();
			this.FromMapBox = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.CoordinateBox);
			this.groupBox1.Controls.Add(this.MazeNameBox);
			this.groupBox1.Controls.Add(this.FromMapBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(175, 100);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Target :";
			// 
			// CoordinateBox
			// 
			this.CoordinateBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CoordinateBox.Location = new System.Drawing.Point(70, 45);
			this.CoordinateBox.Name = "CoordinateBox";
			this.CoordinateBox.ReadOnly = true;
			this.CoordinateBox.Size = new System.Drawing.Size(99, 20);
			this.CoordinateBox.TabIndex = 2;
			this.CoordinateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// MazeNameBox
			// 
			this.MazeNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MazeNameBox.Location = new System.Drawing.Point(70, 19);
			this.MazeNameBox.Name = "MazeNameBox";
			this.MazeNameBox.ReadOnly = true;
			this.MazeNameBox.Size = new System.Drawing.Size(99, 20);
			this.MazeNameBox.TabIndex = 2;
			this.MazeNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FromMapBox
			// 
			this.FromMapBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.FromMapBox.Location = new System.Drawing.Point(82, 71);
			this.FromMapBox.Name = "FromMapBox";
			this.FromMapBox.Size = new System.Drawing.Size(90, 23);
			this.FromMapBox.TabIndex = 1;
			this.FromMapBox.Text = "From map...";
			this.FromMapBox.UseVisualStyleBackColor = true;
			this.FromMapBox.Click += new System.EventHandler(this.FromMapBox_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Coordinate";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Maze";
			// 
			// TargetControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.MinimumSize = new System.Drawing.Size(175, 100);
			this.Name = "TargetControl";
			this.Size = new System.Drawing.Size(175, 100);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox CoordinateBox;
		private System.Windows.Forms.TextBox MazeNameBox;
		private System.Windows.Forms.Button FromMapBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
