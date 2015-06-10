namespace DungeonEye.Forms
{
	partial class TeleportControl
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
			this.TargetBox = new DungeonEye.Forms.TargetControl();
			this.ChangeDirBox = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.ChangeDirBox);
			this.groupBox1.Controls.Add(this.TargetBox);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(490, 317);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Teleport";
			// 
			// TargetBox
			// 
			this.TargetBox.Dungeon = null;
			this.TargetBox.Location = new System.Drawing.Point(6, 19);
			this.TargetBox.MinimumSize = new System.Drawing.Size(175, 125);
			this.TargetBox.Name = "TargetBox";
			this.TargetBox.Size = new System.Drawing.Size(175, 125);
			this.TargetBox.TabIndex = 0;
			// 
			// ChangeDirBox
			// 
			this.ChangeDirBox.AutoSize = true;
			this.ChangeDirBox.Location = new System.Drawing.Point(187, 19);
			this.ChangeDirBox.Name = "ChangeDirBox";
			this.ChangeDirBox.Size = new System.Drawing.Size(106, 17);
			this.ChangeDirBox.TabIndex = 1;
			this.ChangeDirBox.Text = "Change direction";
			this.ChangeDirBox.UseVisualStyleBackColor = true;
			// 
			// ScriptTeleportControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Name = "ScriptTeleportControl";
			this.Size = new System.Drawing.Size(496, 323);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private TargetControl TargetBox;
		private System.Windows.Forms.CheckBox ChangeDirBox;
	}
}
