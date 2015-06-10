namespace DungeonEye.Forms
{
	partial class ScriptedDialogForm
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
			this.PreviewBox = new System.Windows.Forms.PictureBox();
			this.BrowsePictureBox = new System.Windows.Forms.Button();
			this.DisplayBorderBox = new System.Windows.Forms.CheckBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.PictureTab = new System.Windows.Forms.TabPage();
			this.PictureNameBox = new System.Windows.Forms.TextBox();
			this.ChoicesTab = new System.Windows.Forms.TabPage();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.DownChoiceBox = new System.Windows.Forms.Button();
			this.UpChoiceBox = new System.Windows.Forms.Button();
			this.DeleteChoiceBox = new System.Windows.Forms.Button();
			this.AddEditChoiceBox = new System.Windows.Forms.Button();
			this.ChoicesBox = new System.Windows.Forms.ListBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TextJustificationBox = new System.Windows.Forms.ComboBox();
			this.TextColorBox = new System.Windows.Forms.Button();
			this.MessageBox = new System.Windows.Forms.TextBox();
			this.CloseBox = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize) (this.PreviewBox)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.PictureTab.SuspendLayout();
			this.ChoicesTab.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// PreviewBox
			// 
			this.PreviewBox.Location = new System.Drawing.Point(6, 6);
			this.PreviewBox.Name = "PreviewBox";
			this.PreviewBox.Size = new System.Drawing.Size(352, 240);
			this.PreviewBox.TabIndex = 0;
			this.PreviewBox.TabStop = false;
			// 
			// BrowsePictureBox
			// 
			this.BrowsePictureBox.AutoSize = true;
			this.BrowsePictureBox.Location = new System.Drawing.Point(364, 6);
			this.BrowsePictureBox.Name = "BrowsePictureBox";
			this.BrowsePictureBox.Size = new System.Drawing.Size(98, 23);
			this.BrowsePictureBox.TabIndex = 1;
			this.BrowsePictureBox.Text = "Browse...";
			this.BrowsePictureBox.UseVisualStyleBackColor = true;
			// 
			// DisplayBorderBox
			// 
			this.DisplayBorderBox.AutoSize = true;
			this.DisplayBorderBox.Location = new System.Drawing.Point(364, 61);
			this.DisplayBorderBox.Name = "DisplayBorderBox";
			this.DisplayBorderBox.Size = new System.Drawing.Size(93, 17);
			this.DisplayBorderBox.TabIndex = 2;
			this.DisplayBorderBox.Text = "Display border";
			this.DisplayBorderBox.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.PictureTab);
			this.tabControl1.Controls.Add(this.ChoicesTab);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(520, 369);
			this.tabControl1.TabIndex = 3;
			// 
			// PictureTab
			// 
			this.PictureTab.Controls.Add(this.PictureNameBox);
			this.PictureTab.Controls.Add(this.DisplayBorderBox);
			this.PictureTab.Controls.Add(this.BrowsePictureBox);
			this.PictureTab.Controls.Add(this.PreviewBox);
			this.PictureTab.Location = new System.Drawing.Point(4, 22);
			this.PictureTab.Name = "PictureTab";
			this.PictureTab.Padding = new System.Windows.Forms.Padding(3);
			this.PictureTab.Size = new System.Drawing.Size(512, 343);
			this.PictureTab.TabIndex = 0;
			this.PictureTab.Text = "Picture";
			this.PictureTab.UseVisualStyleBackColor = true;
			// 
			// PictureNameBox
			// 
			this.PictureNameBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PictureNameBox.Location = new System.Drawing.Point(364, 35);
			this.PictureNameBox.Name = "PictureNameBox";
			this.PictureNameBox.Size = new System.Drawing.Size(142, 20);
			this.PictureNameBox.TabIndex = 3;
			// 
			// ChoicesTab
			// 
			this.ChoicesTab.Controls.Add(this.groupBox7);
			this.ChoicesTab.Controls.Add(this.groupBox6);
			this.ChoicesTab.Location = new System.Drawing.Point(4, 22);
			this.ChoicesTab.Name = "ChoicesTab";
			this.ChoicesTab.Padding = new System.Windows.Forms.Padding(3);
			this.ChoicesTab.Size = new System.Drawing.Size(512, 343);
			this.ChoicesTab.TabIndex = 1;
			this.ChoicesTab.Text = "Choices";
			this.ChoicesTab.UseVisualStyleBackColor = true;
			// 
			// groupBox7
			// 
			this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox7.Controls.Add(this.DownChoiceBox);
			this.groupBox7.Controls.Add(this.UpChoiceBox);
			this.groupBox7.Controls.Add(this.DeleteChoiceBox);
			this.groupBox7.Controls.Add(this.AddEditChoiceBox);
			this.groupBox7.Controls.Add(this.ChoicesBox);
			this.groupBox7.Location = new System.Drawing.Point(6, 172);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(500, 165);
			this.groupBox7.TabIndex = 2;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Choices :";
			// 
			// DownChoiceBox
			// 
			this.DownChoiceBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DownChoiceBox.Location = new System.Drawing.Point(419, 130);
			this.DownChoiceBox.Name = "DownChoiceBox";
			this.DownChoiceBox.Size = new System.Drawing.Size(75, 23);
			this.DownChoiceBox.TabIndex = 1;
			this.DownChoiceBox.Text = "Down";
			this.DownChoiceBox.UseVisualStyleBackColor = true;
			// 
			// UpChoiceBox
			// 
			this.UpChoiceBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.UpChoiceBox.Location = new System.Drawing.Point(419, 101);
			this.UpChoiceBox.Name = "UpChoiceBox";
			this.UpChoiceBox.Size = new System.Drawing.Size(75, 23);
			this.UpChoiceBox.TabIndex = 1;
			this.UpChoiceBox.Text = "Up";
			this.UpChoiceBox.UseVisualStyleBackColor = true;
			// 
			// DeleteChoiceBox
			// 
			this.DeleteChoiceBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteChoiceBox.Location = new System.Drawing.Point(419, 48);
			this.DeleteChoiceBox.Name = "DeleteChoiceBox";
			this.DeleteChoiceBox.Size = new System.Drawing.Size(75, 23);
			this.DeleteChoiceBox.TabIndex = 1;
			this.DeleteChoiceBox.Text = "Delete";
			this.DeleteChoiceBox.UseVisualStyleBackColor = true;
			// 
			// AddEditChoiceBox
			// 
			this.AddEditChoiceBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddEditChoiceBox.Location = new System.Drawing.Point(419, 19);
			this.AddEditChoiceBox.Name = "AddEditChoiceBox";
			this.AddEditChoiceBox.Size = new System.Drawing.Size(75, 23);
			this.AddEditChoiceBox.TabIndex = 1;
			this.AddEditChoiceBox.Text = "Add";
			this.AddEditChoiceBox.UseVisualStyleBackColor = true;
			// 
			// ChoicesBox
			// 
			this.ChoicesBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ChoicesBox.FormattingEnabled = true;
			this.ChoicesBox.Location = new System.Drawing.Point(6, 19);
			this.ChoicesBox.Name = "ChoicesBox";
			this.ChoicesBox.Size = new System.Drawing.Size(407, 134);
			this.ChoicesBox.TabIndex = 0;
			// 
			// groupBox6
			// 
			this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox6.Controls.Add(this.label3);
			this.groupBox6.Controls.Add(this.TextJustificationBox);
			this.groupBox6.Controls.Add(this.TextColorBox);
			this.groupBox6.Controls.Add(this.MessageBox);
			this.groupBox6.Location = new System.Drawing.Point(6, 6);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(500, 160);
			this.groupBox6.TabIndex = 1;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Message :";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(308, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Text align :";
			// 
			// TextJustificationBox
			// 
			this.TextJustificationBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TextJustificationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TextJustificationBox.FormattingEnabled = true;
			this.TextJustificationBox.Location = new System.Drawing.Point(373, 131);
			this.TextJustificationBox.Name = "TextJustificationBox";
			this.TextJustificationBox.Size = new System.Drawing.Size(121, 21);
			this.TextJustificationBox.TabIndex = 2;
			// 
			// TextColorBox
			// 
			this.TextColorBox.AutoSize = true;
			this.TextColorBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TextColorBox.Location = new System.Drawing.Point(6, 131);
			this.TextColorBox.Name = "TextColorBox";
			this.TextColorBox.Size = new System.Drawing.Size(6, 6);
			this.TextColorBox.TabIndex = 1;
			this.TextColorBox.UseVisualStyleBackColor = true;
			// 
			// MessageBox
			// 
			this.MessageBox.AcceptsReturn = true;
			this.MessageBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MessageBox.Location = new System.Drawing.Point(6, 19);
			this.MessageBox.Multiline = true;
			this.MessageBox.Name = "MessageBox";
			this.MessageBox.Size = new System.Drawing.Size(488, 106);
			this.MessageBox.TabIndex = 0;
			this.MessageBox.TextChanged += new System.EventHandler(this.MessageBox_TextChanged);
			// 
			// CloseBox
			// 
			this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseBox.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.CloseBox.Location = new System.Drawing.Point(457, 387);
			this.CloseBox.Name = "CloseBox";
			this.CloseBox.Size = new System.Drawing.Size(75, 23);
			this.CloseBox.TabIndex = 4;
			this.CloseBox.Text = "Close";
			this.CloseBox.UseVisualStyleBackColor = true;
			// 
			// ScriptedDialogForm
			// 
			this.AcceptButton = this.CloseBox;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 422);
			this.Controls.Add(this.CloseBox);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(550, 450);
			this.Name = "ScriptedDialogForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Scripted dialog wizard :";
			((System.ComponentModel.ISupportInitialize) (this.PreviewBox)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.PictureTab.ResumeLayout(false);
			this.PictureTab.PerformLayout();
			this.ChoicesTab.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckBox DisplayBorderBox;
		private System.Windows.Forms.Button BrowsePictureBox;
		private System.Windows.Forms.PictureBox PreviewBox;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage PictureTab;
		private System.Windows.Forms.TabPage ChoicesTab;
		private System.Windows.Forms.Button CloseBox;
		private System.Windows.Forms.TextBox PictureNameBox;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Button DownChoiceBox;
		private System.Windows.Forms.Button UpChoiceBox;
		private System.Windows.Forms.Button DeleteChoiceBox;
		private System.Windows.Forms.Button AddEditChoiceBox;
		private System.Windows.Forms.ListBox ChoicesBox;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox TextJustificationBox;
		private System.Windows.Forms.Button TextColorBox;
		private System.Windows.Forms.TextBox MessageBox;
	}
}