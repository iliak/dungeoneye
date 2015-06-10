namespace DungeonEye.Forms
{
	partial class AbilityControl
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
			this.TitleBox = new System.Windows.Forms.Label();
			this.AbilityBox = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.ModifierBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.AbilityBox)).BeginInit();
			this.SuspendLayout();
			// 
			// TitleBox
			// 
			this.TitleBox.AutoSize = true;
			this.TitleBox.Location = new System.Drawing.Point(2, 7);
			this.TitleBox.Name = "TitleBox";
			this.TitleBox.Size = new System.Drawing.Size(35, 13);
			this.TitleBox.TabIndex = 0;
			this.TitleBox.Text = "label1";
			// 
			// AbilityBox
			// 
			this.AbilityBox.Location = new System.Drawing.Point(80, 3);
			this.AbilityBox.Name = "AbilityBox";
			this.AbilityBox.Size = new System.Drawing.Size(64, 20);
			this.AbilityBox.TabIndex = 1;
			this.AbilityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.AbilityBox.ThousandsSeparator = true;
			this.AbilityBox.ValueChanged += new System.EventHandler(this.AbilityBox_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(151, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Modifier :";
			// 
			// ModifierBox
			// 
			this.ModifierBox.Location = new System.Drawing.Point(207, 3);
			this.ModifierBox.Name = "ModifierBox";
			this.ModifierBox.ReadOnly = true;
			this.ModifierBox.Size = new System.Drawing.Size(46, 20);
			this.ModifierBox.TabIndex = 3;
			// 
			// AbilityControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ModifierBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.AbilityBox);
			this.Controls.Add(this.TitleBox);
			this.Name = "AbilityControl";
			this.Size = new System.Drawing.Size(260, 25);
			((System.ComponentModel.ISupportInitialize)(this.AbilityBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TitleBox;
		private System.Windows.Forms.NumericUpDown AbilityBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ModifierBox;
	}
}
