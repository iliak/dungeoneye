namespace DungeonEye.Forms
{
	partial class SpawnMonsterControl
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.MonsterNameBox = new System.Windows.Forms.ComboBox();
			this.TargetBox = new DungeonEye.Forms.TargetControl();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.TargetBox);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(527, 448);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Spawn monster";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.MonsterNameBox);
			this.groupBox2.Location = new System.Drawing.Point(6, 125);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 54);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Monster";
			// 
			// MonsterNameBox
			// 
			this.MonsterNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.MonsterNameBox.FormattingEnabled = true;
			this.MonsterNameBox.Location = new System.Drawing.Point(6, 19);
			this.MonsterNameBox.Name = "MonsterNameBox";
			this.MonsterNameBox.Size = new System.Drawing.Size(188, 21);
			this.MonsterNameBox.Sorted = true;
			this.MonsterNameBox.TabIndex = 0;
			this.MonsterNameBox.SelectedIndexChanged += new System.EventHandler(this.MonsterNameBox_SelectedIndexChanged);
			// 
			// TargetBox
			// 
			this.TargetBox.Dungeon = null;
			this.TargetBox.Location = new System.Drawing.Point(6, 19);
			this.TargetBox.MinimumSize = new System.Drawing.Size(175, 100);
			this.TargetBox.Name = "TargetBox";
			this.TargetBox.Size = new System.Drawing.Size(200, 100);
			this.TargetBox.TabIndex = 1;
			this.TargetBox.Title = "Target :";
			this.TargetBox.TargetChanged += new DungeonEye.Forms.TargetControl.TargetChangedEventHandler(this.TargetBox_TargetChanged);
			// 
			// SpawnMonsterControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Name = "SpawnMonsterControl";
			this.Size = new System.Drawing.Size(533, 454);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private TargetControl TargetBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox MonsterNameBox;
	}
}
