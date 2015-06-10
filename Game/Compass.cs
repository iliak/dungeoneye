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
using System.Drawing;

namespace DungeonEye
{
	/// <summary>
	/// TurnLeft
	/// </summary>
	public class Compass
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public Compass()
		{
			Direction = CardinalPoint.North;
		}


		/// <summary>
		/// Copy constructor
		/// </summary>
		/// <param name="compass"></param>
		public Compass(Compass compass)
		{
			Direction = compass.Direction;
		}


		#region Statics

		/// <summary>
		/// Rotate the team
		/// </summary>
		/// <param name="direction">Initial direction</param>
		/// <param name="rot">Rotation needed</param>
		/// <returns>Final direction</returns>
		static public CardinalPoint Rotate(CardinalPoint direction, CompassRotation rot)
		{
			CardinalPoint[][] points = new CardinalPoint[][]
			{
				// North
				new CardinalPoint[] 
				{
					CardinalPoint.East,
					CardinalPoint.South,
					CardinalPoint.West,
					CardinalPoint.North,
				},

				// South
				new CardinalPoint[] 
				{
					CardinalPoint.West,
					CardinalPoint.North,
					CardinalPoint.East,
					CardinalPoint.South,
				},

				// West
				new CardinalPoint[] 
				{
					CardinalPoint.North,
					CardinalPoint.East,
					CardinalPoint.South,
					CardinalPoint.West,
				},

				// East
				new CardinalPoint[] 
				{
					CardinalPoint.South,
					CardinalPoint.West,
					CardinalPoint.North,
					CardinalPoint.East,
				},
			};

			return points[(int)direction][(int)rot];
		}


		/// <summary>
		/// Returns the direction in which an entity should face to look at.
		/// </summary>
		/// <param name="from">From location</param>
		/// <param name="target">Target direction</param>
		/// <returns>Direction to face to</returns>
		static public CardinalPoint SeekDirection(DungeonLocation from, DungeonLocation target)
		{
			Point delta = new Point(target.Coordinate.X - from.Coordinate.X, target.Coordinate.Y - from.Coordinate.Y);


			// Move west
			if (delta.X < 0)
			{
				if (delta.Y > 0)
					if (target.Direction == CardinalPoint.North)
						return CardinalPoint.South;
					else
						return CardinalPoint.West;
				else if (delta.Y < 0)
					if (target.Direction == CardinalPoint.South)
						return CardinalPoint.North;
					else
						return CardinalPoint.West;
				else
					return CardinalPoint.West;
			}

			// Move east
			else if (delta.X > 0)
			{
				if (delta.Y > 0)
					if (target.Direction == CardinalPoint.North)
						return CardinalPoint.South;
					else
						return CardinalPoint.East;
				else if (delta.Y < 0)
					if (target.Direction == CardinalPoint.South)
						return CardinalPoint.North;
					else
						return CardinalPoint.East;
				else
					return CardinalPoint.East;
			}

			if (delta.Y > 0)
				return CardinalPoint.South;
			else if (delta.Y < 0)
				return CardinalPoint.North;

			return CardinalPoint.North;
		}


		/// <summary>
		/// Returns if two locations are facing each others
		/// </summary>
		/// <param name="from">From location</param>
		/// <param name="target">Target direction</param>
		/// <returns>True if locations face each others</returns>
		static public bool IsFacing(DungeonLocation from, DungeonLocation target)
		{
			Point delta = new Point(target.Coordinate.X - from.Coordinate.X, target.Coordinate.Y - from.Coordinate.Y);
			
			switch (from.Direction)
			{
				case CardinalPoint.North:
					return target.Direction == CardinalPoint.South;

				case CardinalPoint.South:
					return target.Direction == CardinalPoint.North;
	
				case CardinalPoint.West:
					return target.Direction == CardinalPoint.East;
				
				case CardinalPoint.East:
					return target.Direction == CardinalPoint.West;
			}

			return false;
		}


		/// <summary>
		/// Returns if two sides are facing each others
		/// </summary>
		/// <param name="view">View</param>
		/// <param name="side">Side</param>
		/// <returns>True if sides face each others</returns>
		static public bool IsSideFacing(CardinalPoint view, CardinalPoint side)
		{
			if (view == CardinalPoint.North && side == CardinalPoint.South)
				return true;
			if (view == CardinalPoint.South && side == CardinalPoint.North)
				return true;
			if (view == CardinalPoint.West && side == CardinalPoint.East)
				return true;
			if (view == CardinalPoint.East && side == CardinalPoint.West)
				return true;

			return false;
		}

		/// <summary>
		/// Gets a direction from a view point
		/// </summary>
		/// <param name="from">Facing direction</param>
		/// <param name="side">Side</param>
		/// <returns>Direction</returns>
		static public CardinalPoint GetDirectionFromView(CardinalPoint from, CardinalPoint side)
		{
			CardinalPoint[,] tab = new CardinalPoint[,]
			{
				{CardinalPoint.North, CardinalPoint.South, CardinalPoint.West, CardinalPoint.East},
				{CardinalPoint.South, CardinalPoint.North, CardinalPoint.East, CardinalPoint.West},
				{CardinalPoint.West, CardinalPoint.East, CardinalPoint.South, CardinalPoint.North},
				{CardinalPoint.East, CardinalPoint.West, CardinalPoint.North, CardinalPoint.South},
			};


			return tab[(int)from, (int)side];
		}


		/// <summary>
		/// Gets the opposite direction
		/// </summary>
		/// <param name="direction">Direction</param>
		/// <returns>Opposite direction</returns>
		static public CardinalPoint GetOppositeDirection(CardinalPoint direction)
		{
			CardinalPoint[] val = new CardinalPoint[]
			{
				CardinalPoint.South,
				CardinalPoint.North,
				CardinalPoint.East,
				CardinalPoint.West
			};

			return val[(int)direction];
		}

		#endregion


		/// <summary>
		/// Is facing a specific direction
		/// </summary>
		/// <param name="dir">Direction</param>
		/// <returns>True if facing the same direction</returns>
		public bool IsFacing(CardinalPoint dir)
		{
			return Direction == dir;
		}


		#region Properties

		/// <summary>
		/// Gets or sets the direction
		/// </summary>
		public CardinalPoint Direction
		{
			get;
			set;
		}


		#endregion
	}


	/// <summary>
	/// TurnLeft direction
	/// </summary>
	//[Flags]
	public enum CardinalPoint
	{
		/// <summary>
		/// North
		/// </summary>
		North = 0,

		/// <summary>
		/// South
		/// </summary>
		South = 1,

		/// <summary>
		/// West
		/// </summary>
		West = 2,

		/// <summary>
		/// East
		/// </summary>
		East = 3,
	}


		/// <summary>
	/// Type of rotation
	/// </summary>
	public enum CompassRotation
	{
		/// <summary>
		/// Rotate 90°
		/// </summary>
		Rotate90,

		/// <summary>
		/// Rotate 180°
		/// </summary>
		Rotate180,

		/// <summary>
		/// Rotate 270°
		/// </summary>
		Rotate270,
	}


}
