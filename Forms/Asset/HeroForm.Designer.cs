namespace DungeonEye.Forms
{
	partial class HeroForm
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
			this.HeroBox = new DungeonEye.Forms.HeroControl();
			this.SuspendLayout();
			// 
			// HeroBox
			// 
			this.HeroBox.AutoScroll = true;
			this.HeroBox.AutoSize = true;
			this.HeroBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.HeroBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HeroBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HeroBox.Hero = null;
			this.HeroBox.Location = new System.Drawing.Point(0, 0);
			this.HeroBox.Name = "HeroBox";
			this.HeroBox.Size = new System.Drawing.Size(551, 545);
			this.HeroBox.TabIndex = 0;
			// 
			// HeroForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(551, 545);
			this.Controls.Add(this.HeroBox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "HeroForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private HeroControl HeroBox;

	}
}


