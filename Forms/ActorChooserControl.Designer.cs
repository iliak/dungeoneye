namespace DungeonEye.Forms
{
	partial class ActorChooserControl
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
			this.AlcoveBox = new System.Windows.Forms.Button();
			this.DoorBox = new System.Windows.Forms.Button();
			this.EventBox = new System.Windows.Forms.Button();
			this.ForceFieldBox = new System.Windows.Forms.Button();
			this.LauncherBox = new System.Windows.Forms.Button();
			this.PitBox = new System.Windows.Forms.Button();
			this.PressurePlateBox = new System.Windows.Forms.Button();
			this.StairBox = new System.Windows.Forms.Button();
			this.TeleporterBox = new System.Windows.Forms.Button();
			this.WallSwitchBox = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.WallSwitchBox);
			this.groupBox1.Controls.Add(this.TeleporterBox);
			this.groupBox1.Controls.Add(this.StairBox);
			this.groupBox1.Controls.Add(this.PressurePlateBox);
			this.groupBox1.Controls.Add(this.PitBox);
			this.groupBox1.Controls.Add(this.LauncherBox);
			this.groupBox1.Controls.Add(this.ForceFieldBox);
			this.groupBox1.Controls.Add(this.EventBox);
			this.groupBox1.Controls.Add(this.DoorBox);
			this.groupBox1.Controls.Add(this.AlcoveBox);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(325, 335);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Actor chooser";
			// 
			// AlcoveBox
			// 
			this.AlcoveBox.Location = new System.Drawing.Point(6, 19);
			this.AlcoveBox.Name = "AlcoveBox";
			this.AlcoveBox.Size = new System.Drawing.Size(75, 23);
			this.AlcoveBox.TabIndex = 0;
			this.AlcoveBox.Text = "Alcove";
			this.AlcoveBox.UseVisualStyleBackColor = true;
			this.AlcoveBox.Click += new System.EventHandler(this.AlcoveBox_Click);
			// 
			// DoorBox
			// 
			this.DoorBox.Location = new System.Drawing.Point(6, 48);
			this.DoorBox.Name = "DoorBox";
			this.DoorBox.Size = new System.Drawing.Size(75, 23);
			this.DoorBox.TabIndex = 0;
			this.DoorBox.Text = "Door";
			this.DoorBox.UseVisualStyleBackColor = true;
			this.DoorBox.Click += new System.EventHandler(this.DoorBox_Click);
			// 
			// EventBox
			// 
			this.EventBox.Location = new System.Drawing.Point(6, 77);
			this.EventBox.Name = "EventBox";
			this.EventBox.Size = new System.Drawing.Size(75, 23);
			this.EventBox.TabIndex = 0;
			this.EventBox.Text = "Event";
			this.EventBox.UseVisualStyleBackColor = true;
			this.EventBox.Click += new System.EventHandler(this.EventBox_Click);
			// 
			// ForceFieldBox
			// 
			this.ForceFieldBox.Location = new System.Drawing.Point(6, 106);
			this.ForceFieldBox.Name = "ForceFieldBox";
			this.ForceFieldBox.Size = new System.Drawing.Size(75, 23);
			this.ForceFieldBox.TabIndex = 0;
			this.ForceFieldBox.Text = "ForceField";
			this.ForceFieldBox.UseVisualStyleBackColor = true;
			this.ForceFieldBox.Click += new System.EventHandler(this.ForceFieldBox_Click);
			// 
			// LauncherBox
			// 
			this.LauncherBox.Location = new System.Drawing.Point(6, 135);
			this.LauncherBox.Name = "LauncherBox";
			this.LauncherBox.Size = new System.Drawing.Size(75, 23);
			this.LauncherBox.TabIndex = 0;
			this.LauncherBox.Text = "Launcher";
			this.LauncherBox.UseVisualStyleBackColor = true;
			this.LauncherBox.Click += new System.EventHandler(this.LauncherBox_Click);
			// 
			// PitBox
			// 
			this.PitBox.Location = new System.Drawing.Point(87, 19);
			this.PitBox.Name = "PitBox";
			this.PitBox.Size = new System.Drawing.Size(75, 23);
			this.PitBox.TabIndex = 0;
			this.PitBox.Text = "Pit";
			this.PitBox.UseVisualStyleBackColor = true;
			this.PitBox.Click += new System.EventHandler(this.PitBox_Click);
			// 
			// PressurePlateBox
			// 
			this.PressurePlateBox.Location = new System.Drawing.Point(87, 48);
			this.PressurePlateBox.Name = "PressurePlateBox";
			this.PressurePlateBox.Size = new System.Drawing.Size(75, 23);
			this.PressurePlateBox.TabIndex = 0;
			this.PressurePlateBox.Text = "Pressure Plate";
			this.PressurePlateBox.UseVisualStyleBackColor = true;
			this.PressurePlateBox.Click += new System.EventHandler(this.PressurePlateBox_Click);
			// 
			// StairBox
			// 
			this.StairBox.Location = new System.Drawing.Point(87, 77);
			this.StairBox.Name = "StairBox";
			this.StairBox.Size = new System.Drawing.Size(75, 23);
			this.StairBox.TabIndex = 0;
			this.StairBox.Text = "Stair";
			this.StairBox.UseVisualStyleBackColor = true;
			this.StairBox.Click += new System.EventHandler(this.StairBox_Click);
			// 
			// TeleporterBox
			// 
			this.TeleporterBox.Location = new System.Drawing.Point(87, 106);
			this.TeleporterBox.Name = "TeleporterBox";
			this.TeleporterBox.Size = new System.Drawing.Size(75, 23);
			this.TeleporterBox.TabIndex = 0;
			this.TeleporterBox.Text = "Teleporter";
			this.TeleporterBox.UseVisualStyleBackColor = true;
			this.TeleporterBox.Click += new System.EventHandler(this.TeleporterBox_Click);
			// 
			// WallSwitchBox
			// 
			this.WallSwitchBox.Location = new System.Drawing.Point(87, 135);
			this.WallSwitchBox.Name = "WallSwitchBox";
			this.WallSwitchBox.Size = new System.Drawing.Size(75, 23);
			this.WallSwitchBox.TabIndex = 0;
			this.WallSwitchBox.Text = "Wall Switch";
			this.WallSwitchBox.UseVisualStyleBackColor = true;
			this.WallSwitchBox.Click += new System.EventHandler(this.WallSwitchBox_Click);
			// 
			// ActorChooserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Name = "ActorChooserControl";
			this.Size = new System.Drawing.Size(325, 335);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button WallSwitchBox;
		private System.Windows.Forms.Button TeleporterBox;
		private System.Windows.Forms.Button StairBox;
		private System.Windows.Forms.Button PressurePlateBox;
		private System.Windows.Forms.Button PitBox;
		private System.Windows.Forms.Button LauncherBox;
		private System.Windows.Forms.Button ForceFieldBox;
		private System.Windows.Forms.Button EventBox;
		private System.Windows.Forms.Button DoorBox;
		private System.Windows.Forms.Button AlcoveBox;
	}
}
