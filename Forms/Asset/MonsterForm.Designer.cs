namespace DungeonEye.Forms
{
	partial class MonsterForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.MonsterBox = new DungeonEye.Forms.MonsterControl();
			this.SuspendLayout();
			// 
			// MonsterBox
			// 
			this.MonsterBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MonsterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MonsterBox.Location = new System.Drawing.Point(0, 0);
			this.MonsterBox.Name = "MonsterBox";
			this.MonsterBox.Size = new System.Drawing.Size(688, 528);
			this.MonsterBox.TabIndex = 0;
			// 
			// MonsterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(688, 528);
			this.Controls.Add(this.MonsterBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(500, 400);
			this.Name = "MonsterForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Monster wizard";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MonsterForm_FormClosing);
			this.Load += new System.EventHandler(this.MonsterForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MonsterForm_KeyDown);
			this.ResumeLayout(false);

		}

		#endregion

		private MonsterControl MonsterBox;

	}
}