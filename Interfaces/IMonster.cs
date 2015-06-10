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


namespace DungeonEye.Interfaces
{

	/// <summary>
	/// Interface for monsters
	/// </summary>
	public interface IMonster
	{

		/// <summary>
		/// Updates monster state
		/// </summary>
		/// <param name="monster">Monster handle</param>
		void OnUpdate(Monster monster);


		/// <summary>
		/// Draws the monster
		/// </summary>
		/// <param name="monster">Monster handle</param>
		void OnDraw(Monster monster);


		/// <summary>
		/// Fired when the monster is killed
		/// </summary>
		/// <param name="monster">Monster handle</param>
		void OnDeath(Monster monster);
	}
}
