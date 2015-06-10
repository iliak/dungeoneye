using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DungeonEye.Forms.Wizards
{
	public partial class NewNameWizard : Form
	{
		public NewNameWizard(string name)
		{
			InitializeComponent();

			NameBox.Text = name;
		}



		/// <summary>
		/// Name
		/// </summary>
		public string NewName
		{
			get
			{
				return NameBox.Text;
			}

			set
			{
				NameBox.Text = value;
			}
		}
	}
}
