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
using ArcEngine.Utility.GameState;
using System.Text;
using ArcEngine;


namespace DungeonEye.MonsterStates
{

	/// <summary>
	/// Monster is attacking the team
	/// </summary>
	public class AttackState : MonsterState
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="monster">Handle to the monster</param>
		public AttackState(Monster monster) : base(monster)
		{
		}



		/// <summary>
		/// Update
		/// </summary>
		/// <param name="time">Elapsed game time</param>
		public override void Update(GameTime time)
		{
			Team team = GameScreen.Team;

			// Can see the team anymore
			if (!Monster.CanSee(team.Location) || !Monster.CanDetect(team.Location))
			{
				Exit = true;
				return;
			}

			// Facing the team ?
			if (!Monster.Location.IsFacing(team.Location))
			{
				Monster.TurnTo(team.Location);
				return;
			}

	
			// Can attack ?
			if (Monster.Attack(team.Location))
				return;

			// Move to the team
		}


	}
}
