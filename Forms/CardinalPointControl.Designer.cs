namespace DungeonEye.Forms
{
	partial class CardinalPointControl
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
			this.EastBox = new System.Windows.Forms.CheckBox();
			this.WestBox = new System.Windows.Forms.CheckBox();
			this.SouthBox = new System.Windows.Forms.CheckBox();
			this.NorthBox = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.EastBox);
			this.groupBox1.Controls.Add(this.WestBox);
			this.groupBox1.Controls.Add(this.SouthBox);
			this.groupBox1.Controls.Add(this.NorthBox);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(119, 109);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Direction";
			// 
			// EastBox
			// 
			this.EastBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.EastBox.Location = new System.Drawing.Point(63, 49);
			this.EastBox.Name = "EastBox";
			this.EastBox.Size = new System.Drawing.Size(50, 24);
			this.EastBox.TabIndex = 0;
			this.EastBox.Text = "East";
			this.EastBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.EastBox.UseVisualStyleBackColor = true;
			this.EastBox.CheckedChanged += new System.EventHandler(this.EastBox_CheckedChanged);
			// 
			// WestBox
			// 
			this.WestBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.WestBox.Location = new System.Drawing.Point(6, 49);
			this.WestBox.Name = "WestBox";
			this.WestBox.Size = new System.Drawing.Size(50, 24);
			this.WestBox.TabIndex = 0;
			this.WestBox.Text = "West";
			this.WestBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.WestBox.UseVisualStyleBackColor = true;
			this.WestBox.CheckedChanged += new System.EventHandler(this.WestBox_CheckedChanged);
			// 
			// SouthBox
			// 
			this.SouthBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.SouthBox.Location = new System.Drawing.Point(31, 79);
			this.SouthBox.Name = "SouthBox";
			this.SouthBox.Size = new System.Drawing.Size(50, 24);
			this.SouthBox.TabIndex = 0;
			this.SouthBox.Text = "South";
			this.SouthBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.SouthBox.UseVisualStyleBackColor = true;
			this.SouthBox.CheckedChanged += new System.EventHandler(this.SouthBox_CheckedChanged);
			// 
			// NorthBox
			// 
			this.NorthBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.NorthBox.Location = new System.Drawing.Point(31, 19);
			this.NorthBox.Name = "NorthBox";
			this.NorthBox.Size = new System.Drawing.Size(50, 24);
			this.NorthBox.TabIndex = 0;
			this.NorthBox.Text = "North";
			this.NorthBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.NorthBox.UseVisualStyleBackColor = true;
			this.NorthBox.CheckedChanged += new System.EventHandler(this.NorthBox_CheckedChanged);
			// 
			// CardinalPointControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.MinimumSize = new System.Drawing.Size(125, 115);
			this.Name = "CardinalPointControl";
			this.Size = new System.Drawing.Size(125, 115);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox EastBox;
		private System.Windows.Forms.CheckBox WestBox;
		private System.Windows.Forms.CheckBox SouthBox;
		private System.Windows.Forms.CheckBox NorthBox;
	}
}
