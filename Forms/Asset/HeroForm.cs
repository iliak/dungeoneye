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
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Forms;
using ArcEngine.Interface;

namespace DungeonEye.Forms
{
	/// <summary>
	/// Control to edit Hero's parameters
	/// </summary>
	public partial class HeroForm : AssetEditorBase
	{

		/// <summary>
		/// Constructor
		/// </summary>
		public HeroForm(XmlNode node)
		{
			InitializeComponent();


			// Load hero
			Hero hero = new Hero();
			hero.Load(node);
			HeroBox.Hero = hero;
		}






		/// <summary>
		/// Saves the asset to the manager
		/// </summary>
		public override void Save()
		{
			ResourceManager.AddAsset<Hero>(HeroBox.Hero.Name, ResourceManager.ConvertAsset(HeroBox.Hero));
		}







		#region Properties

		/// <summary>
		/// Asset handle
		/// </summary>
		public override IAsset Asset
		{
			get
			{
				return HeroBox.Hero;
			}
		}


		#endregion

	}
}
