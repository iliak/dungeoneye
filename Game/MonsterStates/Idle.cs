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
	/// Monster is idle
	/// </summary>
	public class IdleState : MonsterState
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="monster">Monster handle</param>
		public IdleState(Monster monster) : base(monster)
		{

		}


		/// <summary>
		/// Update
		/// </summary>
		/// <param name="time">Elapsed game time</param>
		public override void Update(GameTime time)
		{
			// Target range
			int range = Game.Random.Next(Monster.SightRange);

			// Direction to face to

			while (true)
			{
				CardinalPoint direction = RandomEnum.Get<CardinalPoint>();
				if (direction == Monster.Location.Direction)
					continue;

				//int dir = Dice.GetD20(1);
				Point vector = Monster.Location.Coordinate;

/*
				// Depending the current direction
				switch (Monster.Location.Direction)
				{
					case CardinalPoint.North:
					{
						if (dir < 10)
						{
							direction = CardinalPoint.West;
							vector.X--;
						}
						else
						{
							direction = CardinalPoint.East;
							vector.X++;
						}
					}
					break;
					case CardinalPoint.South:
					{
						if (dir < 10)
						{
							direction = CardinalPoint.East;
							vector.X++;
						}
						else
						{
							direction = CardinalPoint.West;
							vector.X--;
						}

					}
					break;
					case CardinalPoint.West:
					{
						if (dir < 10)
						{
							direction = CardinalPoint.North;
							vector.Y--;
						}
						else
						{
							direction = CardinalPoint.South;
							vector.Y++;
						}

					}
					break;
					case CardinalPoint.East:
					{
						if (dir < 10)
						{
							direction = CardinalPoint.South;
							vector.Y++;
						}
						else
						{
							direction = CardinalPoint.North;
							vector.Y--;
						}

					}
					break;
				}
*/
				// Depending the current direction
				switch (direction)
				{
					case CardinalPoint.North:
					{
						vector.Y--;
					}
					break;
					case CardinalPoint.South:
					{
						vector.Y++;
					}
					break;
					case CardinalPoint.West:
					{
						vector.X--;
					}
					break;
					case CardinalPoint.East:
					{
						vector.X++;
					}
					break;
				}


				// Check the block
				Square block = Monster.Maze.GetSquare(vector);
				if (block != null)
				{
					// Automatic direction changing
					//Monster.Location.Direction = direction;

					//Monster.StateManager.PushState(new MoveState(Monster, range, direction));
					return;
				}
			}
		}



	}
}
