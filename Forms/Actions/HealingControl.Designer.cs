namespace DungeonEye.Forms
{
	partial class HealingControl
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
			this.HPBox = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.FoodBox = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.HPBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.FoodBox)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.FoodBox);
			this.groupBox1.Controls.Add(this.HPBox);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(623, 464);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Healing";
			// 
			// HPBox
			// 
			this.HPBox.Location = new System.Drawing.Point(51, 37);
			this.HPBox.Name = "HPBox";
			this.HPBox.Size = new System.Drawing.Size(120, 20);
			this.HPBox.TabIndex = 0;
			this.HPBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.HPBox.ThousandsSeparator = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "HP";
			// 
			// FoodBox
			// 
			this.FoodBox.Location = new System.Drawing.Point(51, 63);
			this.FoodBox.Name = "FoodBox";
			this.FoodBox.Size = new System.Drawing.Size(120, 20);
			this.FoodBox.TabIndex = 0;
			this.FoodBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.FoodBox.ThousandsSeparator = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Food";
			// 
			// ScriptHealingControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Name = "ScriptHealingControl";
			this.Size = new System.Drawing.Size(629, 470);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.HPBox)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.FoodBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown FoodBox;
		private System.Windows.Forms.NumericUpDown HPBox;
	}
}
