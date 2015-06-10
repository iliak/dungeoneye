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

	/// <summary>
	/// Interface for items
	/// </summary>
	public interface IItem
	{

		/// <summary>
		/// When the team collect an item
		/// </summary>
		/// <param name="item">Item</param>
		/// <param name="hero">Hero collecting the item</param>
		void OnCollect(Item item, Hero hero);


		/// <summary>
		/// When an item is dropped
		/// </summary>
		/// <param name="item">Item</param>
		/// <param name="hero">Hero dropping the item</param>
		/// <param name="block">Block where the item is</param>
		void OnDrop(Item item, Hero hero, Square block);


		/// <summary>
		/// When an item is used
		/// </summary>
		/// <param name="item">Item</param>
		/// <param name="hero">Hero using the item</param>
		void OnUse(Item item, Hero hero);


		/// <summary>
		/// When an item is equiped on a hero
		/// </summary>
		/// <param name="item">Item</param>
		/// <param name="hero">Hero equiping the item</param>
		void OnEquip(Item item, Hero hero);


		/// <summary>
		/// When an item is unequiped of a hero
		/// </summary>
		/// <param name="item">Item</param>
		/// <param name="hero">Hero unequiping the item</param>
		void OnUnequip(Item item, Hero hero);

	}
}
