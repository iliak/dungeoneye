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
	public partial class LauncherControl : UserControl
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="wallswitch"></param>
		/// <param name="maze"></param>
		public LauncherControl(WallSwitch wallswitch, Maze maze)
		{
			InitializeComponent();
		}
	}
}
