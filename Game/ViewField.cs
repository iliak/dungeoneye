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
using System.ComponentModel;
using System.Drawing;
using System.Xml;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Graphic;
using DungeonEye.MonsterStates;

namespace DungeonEye
{

	/// <summary>
	/// Get all the blocks viewed from a given point of view
	/// </summary>
	public class ViewField
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="maze">Maze handle</param>
		/// <param name="location">View's location</param>
		public ViewField(Maze maze, DungeonLocation location)
		{
			Maze = maze;
			Blocks = new Square[16];


			// Cone of vision : 15 blocks + 1 block for the Point of View
			//
			//    ABCDE
			//    FGHIJ
			//     KLM
			//     N^O
			//
			// ^ => Point of view
			switch (location.Direction)
			{
				#region North
				case CardinalPoint.North:
				{
					Blocks[0] = maze.GetSquare(new Point(location.Coordinate.X - 2, location.Coordinate.Y - 3));
					Blocks[1] = maze.GetSquare(new Point(location.Coordinate.X - 1, location.Coordinate.Y - 3));
					Blocks[2] = maze.GetSquare(new Point(location.Coordinate.X, location.Coordinate.Y - 3));
					Blocks[3] = maze.GetSquare(new Point(location.Coordinate.X + 1, location.Coordinate.Y - 3));
					Blocks[4] = maze.GetSquare(new Point(location.Coordinate.X + 2, location.Coordinate.Y - 3));

					Blocks[5] = maze.GetSquare(new Point(location.Coordinate.X - 2, location.Coordinate.Y - 2));
					Blocks[6] = maze.GetSquare(new Point(location.Coordinate.X - 1, location.Coordinate.Y - 2));
					Blocks[7] = maze.GetSquare(new Point(location.Coordinate.X, location.Coordinate.Y - 2));
					Blocks[8] = maze.GetSquare(new Point(location.Coordinate.X + 1, location.Coordinate.Y - 2));
					Blocks[9] = maze.GetSquare(new Point(location.Coordinate.X + 2, location.Coordinate.Y - 2));

					Blocks[10] = maze.GetSquare(new Point(location.Coordinate.X - 1, location.Coordinate.Y - 1));
					Blocks[11] = maze.GetSquare(new Point(location.Coordinate.X, location.Coordinate.Y - 1));
					Blocks[12] = maze.GetSquare(new Point(location.Coordinate.X + 1, location.Coordinate.Y - 1));

					Blocks[13] = maze.GetSquare(new Point(location.Coordinate.X - 1, location.Coordinate.Y));
					Blocks[15] = maze.GetSquare(new Point(location.Coordinate.X + 1, location.Coordinate.Y));

				}
				break;
				#endregion

				#region South
				case CardinalPoint.South:
				{
					Blocks[0] = maze.GetSquare(new Point(location.Coordinate.X + 2, location.Coordinate.Y + 3));
					Blocks[1] = maze.GetSquare(new Point(location.Coordinate.X + 1, location.Coordinate.Y + 3));
					Blocks[2] = maze.GetSquare(new Point(location.Coordinate.X, location.Coordinate.Y + 3));
					Blocks[3] = maze.GetSquare(new Point(location.Coordinate.X - 1, location.Coordinate.Y + 3));
					Blocks[4] = maze.GetSquare(new Point(location.Coordinate.X - 2, location.Coordinate.Y + 3));

					Blocks[5] = maze.GetSquare(new Point(location.Coordinate.X + 2, location.Coordinate.Y + 2));
					Blocks[6] = maze.GetSquare(new Point(location.Coordinate.X + 1, location.Coordinate.Y + 2));
					Blocks[7] = maze.GetSquare(new Point(location.Coordinate.X, location.Coordinate.Y + 2));
					Blocks[8] = maze.GetSquare(new Point(location.Coordinate.X - 1, location.Coordinate.Y + 2));
					Blocks[9] = maze.GetSquare(new Point(location.Coordinate.X - 2, location.Coordinate.Y + 2));

					Blocks[10] = maze.GetSquare(new Point(location.Coordinate.X + 1, location.Coordinate.Y + 1));
					Blocks[11] = maze.GetSquare(new Point(location.Coordinate.X, location.Coordinate.Y + 1));
					Blocks[12] = maze.GetSquare(new Point(location.Coordinate.X - 1, location.Coordinate.Y + 1));

					Blocks[13] = maze.GetSquare(new Point(location.Coordinate.X + 1, location.Coordinate.Y));
					Blocks[15] = maze.GetSquare(new Point(location.Coordinate.X - 1, location.Coordinate.Y));
				}
				break;
				#endregion

				#region East
				case CardinalPoint.East:
				{
					Blocks[0] = maze.GetSquare(new Point(location.Coordinate.X + 3, location.Coordinate.Y - 2));
					Blocks[1] = maze.GetSquare(new Point(location.Coordinate.X + 3, location.Coordinate.Y - 1));
					Blocks[2] = maze.GetSquare(new Point(location.Coordinate.X + 3, location.Coordinate.Y));
					Blocks[3] = maze.GetSquare(new Point(location.Coordinate.X + 3, location.Coordinate.Y + 1));
					Blocks[4] = maze.GetSquare(new Point(location.Coordinate.X + 3, location.Coordinate.Y + 2));

					Blocks[5] = maze.GetSquare(new Point(location.Coordinate.X + 2, location.Coordinate.Y - 2));
					Blocks[6] = maze.GetSquare(new Point(location.Coordinate.X + 2, location.Coordinate.Y - 1));
					Blocks[7] = maze.GetSquare(new Point(location.Coordinate.X + 2, location.Coordinate.Y));
					Blocks[8] = maze.GetSquare(new Point(location.Coordinate.X + 2, location.Coordinate.Y + 1));
					Blocks[9] = maze.GetSquare(new Point(location.Coordinate.X + 2, location.Coordinate.Y + 2));

					Blocks[10] = maze.GetSquare(new Point(location.Coordinate.X + 1, location.Coordinate.Y - 1));
					Blocks[11] = maze.GetSquare(new Point(location.Coordinate.X + 1, location.Coordinate.Y));
					Blocks[12] = maze.GetSquare(new Point(location.Coordinate.X + 1, location.Coordinate.Y + 1));

					Blocks[13] = maze.GetSquare(new Point(location.Coordinate.X, location.Coordinate.Y - 1));
					Blocks[15] = maze.GetSquare(new Point(location.Coordinate.X, location.Coordinate.Y + 1));
				}
				break;
				#endregion

				#region West
				case CardinalPoint.West:
				{
					Blocks[0] = maze.GetSquare(new Point(location.Coordinate.X - 3, location.Coordinate.Y + 2));
					Blocks[1] = maze.GetSquare(new Point(location.Coordinate.X - 3, location.Coordinate.Y + 1));
					Blocks[2] = maze.GetSquare(new Point(location.Coordinate.X - 3, location.Coordinate.Y));
					Blocks[3] = maze.GetSquare(new Point(location.Coordinate.X - 3, location.Coordinate.Y - 1));
					Blocks[4] = maze.GetSquare(new Point(location.Coordinate.X - 3, location.Coordinate.Y - 2));

					Blocks[5] = maze.GetSquare(new Point(location.Coordinate.X - 2, location.Coordinate.Y + 2));
					Blocks[6] = maze.GetSquare(new Point(location.Coordinate.X - 2, location.Coordinate.Y + 1));
					Blocks[7] = maze.GetSquare(new Point(location.Coordinate.X - 2, location.Coordinate.Y));
					Blocks[8] = maze.GetSquare(new Point(location.Coordinate.X - 2, location.Coordinate.Y - 1));
					Blocks[9] = maze.GetSquare(new Point(location.Coordinate.X - 2, location.Coordinate.Y - 2));

					Blocks[10] = maze.GetSquare(new Point(location.Coordinate.X - 1, location.Coordinate.Y + 1));
					Blocks[11] = maze.GetSquare(new Point(location.Coordinate.X - 1, location.Coordinate.Y));
					Blocks[12] = maze.GetSquare(new Point(location.Coordinate.X - 1, location.Coordinate.Y - 1));

					Blocks[13] = maze.GetSquare(new Point(location.Coordinate.X, location.Coordinate.Y + 1));
					Blocks[15] = maze.GetSquare(new Point(location.Coordinate.X, location.Coordinate.Y - 1));
				}
				break;
				#endregion
			}

			// Team's position
			Blocks[14] = maze.GetSquare(location.Coordinate);
		}


		/// <summary>
		/// Gets a block in the view field
		/// </summary>
		/// <param name="position">Block position</param>
		/// <returns>Block handle</returns>
		public Square GetBlock(ViewFieldPosition position)
		{
			return Blocks[(int) position];
		}


		#region Properties


		/// <summary>
		/// Blocks in the maze
		/// </summary>
		public Square[] Blocks
		{
			get;
			private set;
		}


		/// <summary>
		/// Is the team visible, no wall between the Team and the Point Of View 
		/// </summary>
		public bool IsTeamVisible
		{
			get;
			private set;
		}


		/// <summary>
		/// Current maze
		/// </summary>
		public Maze Maze
		{
			get;
			private set;
		}


		#endregion
	}



	/// <summary>
	/// Block position in the view field
	/// Cone of vision : 15 blocks + 1 block for the Point of View
	///
	///  ABCDE
	///  FGHIJ
	///   KLM
	///   N^O
	///
	/// ^ => Point of view of the team
	/// </summary>
	public enum ViewFieldPosition
	{
		A = 0,
		B = 1,
		C = 2,
		D = 3,
		E = 4,

		F = 5,
		G = 6,
		H = 7,
		I = 8,
		J = 9,

		K = 10,
		L = 11,
		M = 12,

		N = 13,
		Team = 14,
		O = 15
	}


}
