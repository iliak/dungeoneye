namespace DungeonEye.Forms.Actor
{
	partial class SquareActorControl
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
			this.CanPassTroughBox = new System.Windows.Forms.CheckBox();
			this.IsBlockingBox = new System.Windows.Forms.CheckBox();
			this.IsActivatedBox = new System.Windows.Forms.CheckBox();
			this.IsEnabledBox = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// CanPassTroughBox
			// 
			this.CanPassTroughBox.AutoSize = true;
			this.CanPassTroughBox.Location = new System.Drawing.Point(6, 19);
			this.CanPassTroughBox.Name = "CanPassTroughBox";
			this.CanPassTroughBox.Size = new System.Drawing.Size(109, 17);
			this.CanPassTroughBox.TabIndex = 0;
			this.CanPassTroughBox.Text = "Can pass through";
			this.CanPassTroughBox.UseVisualStyleBackColor = true;
			this.CanPassTroughBox.CheckedChanged += new System.EventHandler(this.CanPassTroughBox_CheckedChanged);
			// 
			// IsBlockingBox
			// 
			this.IsBlockingBox.AutoSize = true;
			this.IsBlockingBox.Location = new System.Drawing.Point(6, 42);
			this.IsBlockingBox.Name = "IsBlockingBox";
			this.IsBlockingBox.Size = new System.Drawing.Size(77, 17);
			this.IsBlockingBox.TabIndex = 0;
			this.IsBlockingBox.Text = "Is blocking";
			this.IsBlockingBox.UseVisualStyleBackColor = true;
			this.IsBlockingBox.CheckedChanged += new System.EventHandler(this.IsBlockingBox_CheckedChanged);
			// 
			// IsActivatedBox
			// 
			this.IsActivatedBox.AutoSize = true;
			this.IsActivatedBox.Location = new System.Drawing.Point(6, 65);
			this.IsActivatedBox.Name = "IsActivatedBox";
			this.IsActivatedBox.Size = new System.Drawing.Size(81, 17);
			this.IsActivatedBox.TabIndex = 0;
			this.IsActivatedBox.Text = "Is activated";
			this.IsActivatedBox.UseVisualStyleBackColor = true;
			this.IsActivatedBox.CheckedChanged += new System.EventHandler(this.IsActivatedBox_CheckedChanged);
			// 
			// IsEnabledBox
			// 
			this.IsEnabledBox.AutoSize = true;
			this.IsEnabledBox.Location = new System.Drawing.Point(6, 88);
			this.IsEnabledBox.Name = "IsEnabledBox";
			this.IsEnabledBox.Size = new System.Drawing.Size(75, 17);
			this.IsEnabledBox.TabIndex = 0;
			this.IsEnabledBox.Text = "Is enabled";
			this.IsEnabledBox.UseVisualStyleBackColor = true;
			this.IsEnabledBox.CheckedChanged += new System.EventHandler(this.IsEnabledBox_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.CanPassTroughBox);
			this.groupBox1.Controls.Add(this.IsEnabledBox);
			this.groupBox1.Controls.Add(this.IsBlockingBox);
			this.groupBox1.Controls.Add(this.IsActivatedBox);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.MinimumSize = new System.Drawing.Size(120, 115);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(130, 120);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Actor properties :";
			// 
			// SquareActorControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.MinimumSize = new System.Drawing.Size(130, 120);
			this.Name = "SquareActorControl";
			this.Size = new System.Drawing.Size(130, 120);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckBox CanPassTroughBox;
		private System.Windows.Forms.CheckBox IsBlockingBox;
		private System.Windows.Forms.CheckBox IsActivatedBox;
		private System.Windows.Forms.CheckBox IsEnabledBox;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
