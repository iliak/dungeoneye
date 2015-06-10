namespace DungeonEye.Forms
{
	partial class HitPointControl
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
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.MaxBox = new System.Windows.Forms.NumericUpDown();
			this.CurrentBox = new System.Windows.Forms.NumericUpDown();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MaxBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentBox)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.label9);
			this.groupBox6.Controls.Add(this.label10);
			this.groupBox6.Controls.Add(this.MaxBox);
			this.groupBox6.Controls.Add(this.CurrentBox);
			this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox6.Location = new System.Drawing.Point(0, 0);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(156, 77);
			this.groupBox6.TabIndex = 9;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "HP :";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(7, 47);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(57, 13);
			this.label9.TabIndex = 1;
			this.label9.Text = "Maximum :";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(7, 25);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(43, 13);
			this.label10.TabIndex = 1;
			this.label10.Text = "Actual :";
			// 
			// MaxBox
			// 
			this.MaxBox.Location = new System.Drawing.Point(70, 45);
			this.MaxBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.MaxBox.Name = "MaxBox";
			this.MaxBox.Size = new System.Drawing.Size(80, 20);
			this.MaxBox.TabIndex = 0;
			this.MaxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.MaxBox.ThousandsSeparator = true;
			this.MaxBox.ValueChanged += new System.EventHandler(this.MaxBox_ValueChanged);
			// 
			// CurrentBox
			// 
			this.CurrentBox.Location = new System.Drawing.Point(70, 19);
			this.CurrentBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.CurrentBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
			this.CurrentBox.Name = "CurrentBox";
			this.CurrentBox.Size = new System.Drawing.Size(80, 20);
			this.CurrentBox.TabIndex = 0;
			this.CurrentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.CurrentBox.ThousandsSeparator = true;
			this.CurrentBox.ValueChanged += new System.EventHandler(this.CurrentBox_ValueChanged);
			// 
			// HitPointControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox6);
			this.Name = "HitPointControl";
			this.Size = new System.Drawing.Size(156, 77);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MaxBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown MaxBox;
		private System.Windows.Forms.NumericUpDown CurrentBox;
	}
}
