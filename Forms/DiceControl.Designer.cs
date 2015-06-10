namespace DungeonEye.Forms
{
	partial class DiceControl
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.MaximumBox = new System.Windows.Forms.TextBox();
			this.MinimumBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ThrowBox = new System.Windows.Forms.NumericUpDown();
			this.BaseBox = new System.Windows.Forms.NumericUpDown();
			this.FacesBox = new System.Windows.Forms.NumericUpDown();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ThrowBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BaseBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FacesBox)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Modifier :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Throws :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Faces :";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.MaximumBox);
			this.groupBox1.Controls.Add(this.MinimumBox);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.ThrowBox);
			this.groupBox1.Controls.Add(this.BaseBox);
			this.groupBox1.Controls.Add(this.FacesBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(230, 100);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dice :";
			// 
			// MaximumBox
			// 
			this.MaximumBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.MaximumBox.Location = new System.Drawing.Point(177, 44);
			this.MaximumBox.Name = "MaximumBox";
			this.MaximumBox.ReadOnly = true;
			this.MaximumBox.Size = new System.Drawing.Size(41, 20);
			this.MaximumBox.TabIndex = 3;
			this.MaximumBox.TabStop = false;
			this.MaximumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// MinimumBox
			// 
			this.MinimumBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.MinimumBox.Location = new System.Drawing.Point(177, 18);
			this.MinimumBox.Name = "MinimumBox";
			this.MinimumBox.ReadOnly = true;
			this.MinimumBox.Size = new System.Drawing.Size(41, 20);
			this.MinimumBox.TabIndex = 3;
			this.MinimumBox.TabStop = false;
			this.MinimumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(117, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Maximum :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(117, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Minimum :";
			// 
			// ThrowBox
			// 
			this.ThrowBox.Location = new System.Drawing.Point(62, 71);
			this.ThrowBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.ThrowBox.Name = "ThrowBox";
			this.ThrowBox.Size = new System.Drawing.Size(49, 20);
			this.ThrowBox.TabIndex = 3;
			this.ThrowBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ThrowBox.ThousandsSeparator = true;
			this.ThrowBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.ThrowBox.ValueChanged += new System.EventHandler(this.OnValueChanged);
			// 
			// BaseBox
			// 
			this.BaseBox.Location = new System.Drawing.Point(62, 45);
			this.BaseBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.BaseBox.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
			this.BaseBox.Name = "BaseBox";
			this.BaseBox.Size = new System.Drawing.Size(49, 20);
			this.BaseBox.TabIndex = 2;
			this.BaseBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.BaseBox.ThousandsSeparator = true;
			this.BaseBox.ValueChanged += new System.EventHandler(this.OnValueChanged);
			// 
			// FacesBox
			// 
			this.FacesBox.Location = new System.Drawing.Point(62, 19);
			this.FacesBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.FacesBox.Name = "FacesBox";
			this.FacesBox.Size = new System.Drawing.Size(49, 20);
			this.FacesBox.TabIndex = 1;
			this.FacesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.FacesBox.ThousandsSeparator = true;
			this.FacesBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.FacesBox.ValueChanged += new System.EventHandler(this.OnValueChanged);
			// 
			// DiceControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.MinimumSize = new System.Drawing.Size(230, 100);
			this.Name = "DiceControl";
			this.Size = new System.Drawing.Size(230, 100);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ThrowBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BaseBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FacesBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox MaximumBox;
		private System.Windows.Forms.TextBox MinimumBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown ThrowBox;
		private System.Windows.Forms.NumericUpDown BaseBox;
		private System.Windows.Forms.NumericUpDown FacesBox;
	}
}
