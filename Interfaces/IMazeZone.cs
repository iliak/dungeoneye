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
using ArcEngine;


namespace DungeonEye.Interfaces
{
	public interface IMazeZone
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="zone"></param>
		/// <param name="team"></param>
		void OnTeamEnter(MazeZone zone, GameScreen team);


		/// <summary>
		/// 
		/// </summary>
		/// <param name="zone"></param>
		/// <param name="team"></param>
		void OnTeamLeave(MazeZone zone, GameScreen team);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="zone"></param>
		/// <param name="team"></param>
		void OnMonsterEnter(MazeZone zone, Monster monster);


		/// <summary>
		/// 
		/// </summary>
		/// <param name="zone"></param>
		/// <param name="team"></param>
		void OnMonsterLeave(MazeZone zone, Monster monster);


		/// <summary>
		/// 
		/// </summary>
		/// <param name="zone"></param>
		/// <param name="time"></param>
		void Update(MazeZone zone, GameTime time);


		/// <summary>
		/// 
		/// </summary>
		/// <param name="zone"></param>
		void Draw(MazeZone zone);
	}
}
