namespace DungeonEye.Forms
{
	partial class MonsterEditorControl
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;


		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.MonsterModelsBox = new System.Windows.Forms.ListBox();
			this.ApplyModelBox = new System.Windows.Forms.Button();
			this.MonsterBox = new DungeonEye.Forms.MonsterControl();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.MonsterModelsBox);
			this.groupBox1.Controls.Add(this.ApplyModelBox);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(126, 533);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Apply a model :";
			// 
			// MonsterModelsBox
			// 
			this.MonsterModelsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MonsterModelsBox.FormattingEnabled = true;
			this.MonsterModelsBox.Location = new System.Drawing.Point(6, 19);
			this.MonsterModelsBox.Name = "MonsterModelsBox";
			this.MonsterModelsBox.Size = new System.Drawing.Size(114, 472);
			this.MonsterModelsBox.Sorted = true;
			this.MonsterModelsBox.TabIndex = 2;
			this.MonsterModelsBox.DoubleClick += new System.EventHandler(this.MonsterModelsBox_DoubleClick);
			// 
			// ApplyModelBox
			// 
			this.ApplyModelBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ApplyModelBox.Location = new System.Drawing.Point(6, 504);
			this.ApplyModelBox.Name = "ApplyModelBox";
			this.ApplyModelBox.Size = new System.Drawing.Size(114, 23);
			this.ApplyModelBox.TabIndex = 1;
			this.ApplyModelBox.Text = "Apply";
			this.ApplyModelBox.UseVisualStyleBackColor = true;
			this.ApplyModelBox.Click += new System.EventHandler(this.ApplyModelBox_Click);
			// 
			// MonsterBox
			// 
			this.MonsterBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MonsterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MonsterBox.Location = new System.Drawing.Point(144, 12);
			this.MonsterBox.Name = "MonsterBox";
			this.MonsterBox.Size = new System.Drawing.Size(687, 533);
			this.MonsterBox.TabIndex = 4;
			// 
			// MonsterEditorControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.MonsterBox);
			this.Controls.Add(this.groupBox1);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "MonsterEditorControl";
			this.Size = new System.Drawing.Size(834, 548);
			this.Load += new System.EventHandler(this.MonsterEditorControl_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox MonsterModelsBox;
		private System.Windows.Forms.Button ApplyModelBox;
		private MonsterControl MonsterBox;
	}
}