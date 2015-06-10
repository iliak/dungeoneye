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
using System.Drawing;


namespace DungeonEye.MonsterStates
{

	/// <summary>
	/// Monster is walking
	/// </summary>
	public class MoveState : MonsterState
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="monster">Monster handle</param>
		/// <param name="range">Range of the target</param>
		/// <param name="direction">Direction of the target</param>
		public MoveState(Monster monster, int range, CardinalPoint direction) : base(monster)
		{
			TargetRange = range;
			TargetDirection = direction;
			TargetLocation = new DungeonLocation(Monster.Location);
			TargetLocation.Offset(direction, range);
		}


		/// <summary>
		/// 
		/// </summary>
		public override void OnEnter()
		{
			// Change direction first
			Monster.TurnTo(TargetDirection);

		}


		/// <summary>
		/// Update
		/// </summary>
		/// <param name="time">Elapsed game time</param>
		public override void Update(GameTime time)
		{
			if (!Monster.CanMove)
				return;

			Team team = GameScreen.Team;

			// Is the monster facing the good direction ?
			if (Monster.Location.Direction != TargetDirection)
				Monster.Location.Direction = TargetDirection;


			//Team team = Monster.Location.Dungeon.Team;


			// Can see the team ?
			//if (Monster.CanSee(Team.Location))
			//	Monster.StateManager.PushState(new AttackState(Monster));


			// Can detect the team
			if (Monster.CanDetect(team.Location))
			{
				Monster.TurnTo(team.Location);
				return;
			}


			// Then move to the target
			Point vector = Point.Empty;
			switch (TargetDirection)
			{
				case CardinalPoint.North:
				vector.Y = -1;
				break;
				case CardinalPoint.South:
				vector.Y = 1;
				break;
				case CardinalPoint.West:
				vector.X = -1;
				break;
				case CardinalPoint.East:
				vector.X = 1;
				break;
			}
			TargetRange--;


			// Move the monster
			if (!Monster.Move(vector))
				Exit = true;


			// Time to move elsewhere
			if (TargetRange <= 0)
				Exit = true;

		}


		#region Properties

		/// <summary>
		/// Range remaining to reach the target
		/// </summary>
		public int TargetRange
		{
			get;
			private set;
		}


		/// <summary>
		/// Direction of the target
		/// </summary>
		public CardinalPoint TargetDirection
		{
			get;
			private set;
		}


		/// <summary>
		/// Target location
		/// </summary>
		public DungeonLocation TargetLocation
		{
			get;
			private set;
		}


		#endregion

	}
}
