using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DungeonEye.Forms
{
	/// <summary>
	/// 
	/// </summary>
	public partial class GeneratorControl : UserControl
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="wallswitch"></param>
		/// <param name="maze"></param>
		public GeneratorControl(WallSwitch wallswitch, Maze maze)
		{
			InitializeComponent();
		}
	}
}
