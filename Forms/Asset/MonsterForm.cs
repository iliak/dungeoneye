#region Licence
//
//This file is part of ArcEngine.
//Copyright (C)2008-2011 Adrien Hémery ( iliak@mimicprod.net )
//
//ArcEngine is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//any later version.
//
//ArcEngine is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//
//You should have received a copy of the GNU General Public License
//along with Foobar.  If not, see <http://www.gnu.org/licenses/>.
//
#endregion
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Forms;
using ArcEngine.Interface;

namespace DungeonEye.Forms
{
	/// <summary>
	/// Monster form editor
	/// </summary>
	public partial class MonsterForm : AssetEditorBase
	{

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="node">Xml node</param>
		public MonsterForm(XmlNode node)
		{
			InitializeComponent();

			Monster = new Monster();
			Monster.Load(node);
		//	MonsterBox.SetMonster(Monster);
		}



		/// <summary>
		/// save the asset to the manager
		/// </summary>
		public override void Save()
		{
			ResourceManager.AddAsset<Monster>(Monster.Name, ResourceManager.ConvertAsset(Monster));
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MonsterForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Monster != null)
				Monster.Dispose();
			Monster = null;
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MonsterForm_Load(object sender, System.EventArgs e)
		{
			MonsterBox.SetMonster(Monster);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MonsterForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				Close();
		}



		#region Properties

		/// <summary>
		/// 
		/// </summary>
		public override IAsset Asset
		{
			get
			{
				return Monster;
			}
		}


		/// <summary>
		/// Monster handle
		/// </summary>
		Monster Monster;

		#endregion

	}
}
