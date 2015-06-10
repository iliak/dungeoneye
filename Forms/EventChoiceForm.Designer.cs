namespace DungeonEye.Forms
{
	partial class EventChoiceForm
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
			this.CloseBox = new System.Windows.Forms.Button();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.VisibleBox = new System.Windows.Forms.CheckBox();
			this.AutoTriggerBox = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.KeepItemBox = new System.Windows.Forms.CheckBox();
			this.RemoveItemBox = new System.Windows.Forms.Button();
			this.AddItemBox = new System.Windows.Forms.Button();
			this.ItemsBox = new System.Windows.Forms.ListBox();
			this.ActionBox = new DungeonEye.Forms.WallSwitchScriptListControl();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// CloseBox
			// 
			this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseBox.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.CloseBox.Location = new System.Drawing.Point(422, 357);
			this.CloseBox.Name = "CloseBox";
			this.CloseBox.Size = new System.Drawing.Size(75, 23);
			this.CloseBox.TabIndex = 0;
			this.CloseBox.Text = "Close";
			this.CloseBox.UseVisualStyleBackColor = true;
			// 
			// NameBox
			// 
			this.NameBox.Location = new System.Drawing.Point(132, 12);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(269, 20);
			this.NameBox.TabIndex = 4;
			this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Choice name :";
			// 
			// VisibleBox
			// 
			this.VisibleBox.AutoSize = true;
			this.VisibleBox.Location = new System.Drawing.Point(6, 19);
			this.VisibleBox.Name = "VisibleBox";
			this.VisibleBox.Size = new System.Drawing.Size(56, 17);
			this.VisibleBox.TabIndex = 6;
			this.VisibleBox.Text = "Visible";
			this.VisibleBox.UseVisualStyleBackColor = true;
			this.VisibleBox.CheckedChanged += new System.EventHandler(this.VisibleBox_CheckedChanged);
			// 
			// AutoTriggerBox
			// 
			this.AutoTriggerBox.AutoSize = true;
			this.AutoTriggerBox.Location = new System.Drawing.Point(6, 42);
			this.AutoTriggerBox.Name = "AutoTriggerBox";
			this.AutoTriggerBox.Size = new System.Drawing.Size(177, 17);
			this.AutoTriggerBox.TabIndex = 6;
			this.AutoTriggerBox.Text = "Choice is automatically triggered";
			this.AutoTriggerBox.UseVisualStyleBackColor = true;
			this.AutoTriggerBox.CheckedChanged += new System.EventHandler(this.AutoTriggerBox_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.VisibleBox);
			this.groupBox2.Controls.Add(this.AutoTriggerBox);
			this.groupBox2.Location = new System.Drawing.Point(12, 38);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(234, 157);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Properties :";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.KeepItemBox);
			this.groupBox3.Controls.Add(this.RemoveItemBox);
			this.groupBox3.Controls.Add(this.AddItemBox);
			this.groupBox3.Controls.Add(this.ItemsBox);
			this.groupBox3.Location = new System.Drawing.Point(252, 38);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(245, 157);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Required items :";
			// 
			// KeepItemBox
			// 
			this.KeepItemBox.AutoSize = true;
			this.KeepItemBox.Location = new System.Drawing.Point(132, 78);
			this.KeepItemBox.Name = "KeepItemBox";
			this.KeepItemBox.Size = new System.Drawing.Size(99, 17);
			this.KeepItemBox.TabIndex = 3;
			this.KeepItemBox.Text = "Remove item(s)";
			this.KeepItemBox.UseVisualStyleBackColor = true;
			this.KeepItemBox.CheckedChanged += new System.EventHandler(this.KeepItemBox_CheckedChanged);
			// 
			// RemoveItemBox
			// 
			this.RemoveItemBox.Location = new System.Drawing.Point(132, 49);
			this.RemoveItemBox.Name = "RemoveItemBox";
			this.RemoveItemBox.Size = new System.Drawing.Size(75, 23);
			this.RemoveItemBox.TabIndex = 2;
			this.RemoveItemBox.Text = "Remove";
			this.RemoveItemBox.UseVisualStyleBackColor = true;
			this.RemoveItemBox.Click += new System.EventHandler(this.RemoveItemBox_Click);
			// 
			// AddItemBox
			// 
			this.AddItemBox.Location = new System.Drawing.Point(132, 19);
			this.AddItemBox.Name = "AddItemBox";
			this.AddItemBox.Size = new System.Drawing.Size(75, 23);
			this.AddItemBox.TabIndex = 1;
			this.AddItemBox.Text = "Add";
			this.AddItemBox.UseVisualStyleBackColor = true;
			this.AddItemBox.Click += new System.EventHandler(this.AddItemBox_Click);
			// 
			// ItemsBox
			// 
			this.ItemsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ItemsBox.FormattingEnabled = true;
			this.ItemsBox.Location = new System.Drawing.Point(6, 19);
			this.ItemsBox.Name = "ItemsBox";
			this.ItemsBox.Size = new System.Drawing.Size(121, 121);
			this.ItemsBox.Sorted = true;
			this.ItemsBox.TabIndex = 0;
			// 
			// ActionBox
			// 
			this.ActionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ActionBox.Location = new System.Drawing.Point(12, 201);
			this.ActionBox.MinimumSize = new System.Drawing.Size(350, 150);
			this.ActionBox.Name = "ActionBox";
			this.ActionBox.Size = new System.Drawing.Size(485, 150);
			this.ActionBox.TabIndex = 9;
			// 
			// EventChoiceForm
			// 
			this.AcceptButton = this.CloseBox;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 391);
			this.Controls.Add(this.ActionBox);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NameBox);
			this.Controls.Add(this.CloseBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EventChoiceForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Event choice wizard";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EventChoiceForm_KeyDown);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CloseBox;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox VisibleBox;
		private System.Windows.Forms.CheckBox AutoTriggerBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox KeepItemBox;
		private System.Windows.Forms.Button RemoveItemBox;
		private System.Windows.Forms.Button AddItemBox;
		private System.Windows.Forms.ListBox ItemsBox;
		private WallSwitchScriptListControl ActionBox;
	}
}