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
using System.Text;

namespace DungeonEye.Interfaces
{
	public interface IFloorPlate
	{
		/// <summary>
		/// 
		/// </summary>
		void OnTeamEnter();


		/// <summary>
		/// 
		/// </summary>
		void OnTeamLeave();


		/// <summary>
		/// When an item is droped
		/// </summary>
		/// <param name="item">Item handle</param>
		/// <param name="hero">Hero dropping the item</param>
		/// <param name="block">Block</param>
		void OnItemDrop(Item item, Hero hero, Square block);


		/// <summary>
		/// When an item is collected
		/// </summary>
		/// <param name="item">Item handle</param>
		/// <param name="hero">Hero dropping the item</param>
		/// <param name="block">Block</param>
		void OnItemCollect(Item item, Hero hero, Square block);

	}
}
