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
using System.ComponentModel;
using System.Drawing;
using System.Xml;

namespace DungeonEye
{


	/// <summary>
	/// Location in the dungeon
	/// </summary>
//	[EditorAttribute(typeof(DungeonLocationEditor), typeof(UITypeEditor))]
	[TypeConverter(typeof(DungeonLocationConverter))]
	public class DungeonLocation
	{
		#region constructors

		/// <summary>
		/// Empty constructor
		/// </summary>
		public DungeonLocation()
		{

		}


		/// <summary>
		/// Copy constructor
		/// </summary>
		/// <param name="loc">Location</param>
		public DungeonLocation(DungeonLocation loc)
		{
			if (loc == null)
				return;

			Maze = loc.Maze;
			Coordinate = loc.Coordinate;
			Position = loc.Position;
			Direction = loc.Direction;
		}


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="maze">Name of the maze</param>
		/// <param name="coordinate">Location</param>
		public DungeonLocation(string maze, Point coordinate) : this(maze, coordinate, CardinalPoint.North, SquarePosition.NorthWest)
		{
		}


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="maze">Name of the maze</param>
		/// <param name="coordinate">Location</param>
		/// <param name="direction">Direction</param>
		/// <param name="position">Square position</param>
		public DungeonLocation(string maze, Point coordinate, CardinalPoint direction, SquarePosition position)
		{
			Maze = maze;
			Coordinate = coordinate;
			Direction = direction;
			Position = position;
		}


		/// <summary>
		/// XML constructor
		/// </summary>
		/// <param name="node">Xml node</param>
		public DungeonLocation(XmlNode node)
		{
			Load(node);
		}



		/// <summary>
		/// Gets the maze of the location
		/// </summary>
		/// <param name="dungeon">Dungeon handle</param>
		/// <returns>Maze handle or null</returns>
		public Maze GetMaze(Dungeon dungeon)
		{
			if (dungeon == null)
				return null;

			return dungeon.GetMaze(Maze);
		}



		/// <summary>
		/// Gets the square
		/// </summary>
		/// <param name="dungeon">Dungeon handle</param>
		/// <returns>Square handle or null</returns>
		public Square GetSquare(Dungeon dungeon)
		{
			if (dungeon == null)
				return null;

			Maze maze = dungeon.GetMaze(Maze);
			if (maze == null)
				return null;

			return maze.GetSquare(Coordinate);
		}

		#endregion



		/// <summary>
		/// Offset the location
		/// </summary>
		/// <param name="direction">Direction of the move</param>
		/// <param name="count">Number of block to move</param>
		public void Offset(CardinalPoint direction, int count)
		{
			switch (direction)
			{
				case CardinalPoint.North:
				Coordinate.Offset(0, -count);
				break;
				case CardinalPoint.South:
				Coordinate.Offset(0, count);
				break;
				case CardinalPoint.West:
				Coordinate.Offset(-count, 0);
				break;
				case CardinalPoint.East:
				Coordinate.Offset(count, 0);
				break;
			}

	
		}


		/// <summary>
		/// Facing a given location
		/// </summary>
		/// <param name="location">Location to check</param>
		/// <returns>True if facing, or false</returns>
		public bool IsFacing(DungeonLocation location)
		{
			Point offset = new Point(location.Coordinate.X - Coordinate.X, location.Coordinate.Y - Coordinate.Y);

			switch (Direction)
			{
				case CardinalPoint.North:
				{
					if (offset.X <= 0 && offset.Y <= 0)
					return true;
				}
				break;
				case CardinalPoint.South:
				{
					if (offset.X >= 0 && offset.Y >= 0)
						return true;
				}
				break;
				case CardinalPoint.West:
				{
					if (offset.X <= 0 && offset.Y >= 0)
						return true;
				}
				break;
				case CardinalPoint.East:
				{
					if (offset.X >= 0 && offset.Y <= 0)
						return true;
				}
				break;
			}

			return false;
		}


		/// <summary>
		/// FAce to a given location
		/// </summary>
		/// <param name="target"></param>
		public void FaceTo(DungeonLocation target)
		{
			if (target == null)
				throw new ArgumentNullException("target");

		}


		#region I/O


		/// <summary>
		/// 
		/// </summary>
		/// <param name="node">Xml node</param>
		/// <returns></returns>
		public bool Load(XmlNode xml)
		{
			if (xml == null)
				return false;

			if (xml.Attributes["maze"] != null)
				Maze = xml.Attributes["maze"].Value;

			if (xml.Attributes["x"] != null && xml.Attributes["y"] != null)
				Coordinate = new Point(int.Parse(xml.Attributes["x"].Value), int.Parse(xml.Attributes["y"].Value));

			if (xml.Attributes["direction"] != null)
				Direction = (CardinalPoint)Enum.Parse(typeof(CardinalPoint), xml.Attributes["direction"].Value, true);

			if (xml.Attributes["position"] != null)
				Position = (SquarePosition) Enum.Parse(typeof(SquarePosition), xml.Attributes["position"].Value, true);

			return true;
		}


		/// <summary>
		/// Saves location
		/// </summary>
		/// <param name="name">Node's name</param>
		/// <param name="writer">XmlWriter handle</param>
		/// <returns></returns>
		public bool Save(string name, XmlWriter writer)
		{
			if (writer == null || string.IsNullOrEmpty(name))
				return false;



			writer.WriteStartElement(name);
			writer.WriteAttributeString("maze", Maze);
			writer.WriteAttributeString("x", Coordinate.X.ToString());
			writer.WriteAttributeString("y", Coordinate.Y.ToString());
			writer.WriteAttributeString("direction", Direction.ToString());
			writer.WriteAttributeString("position", Position.ToString());
			writer.WriteEndElement();

			return true;
		}



		#endregion


		/// <summary>
		/// Returns a String that represents the current location
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format("{0}x{1} in {2}, looking {3}, sub {4}", Coordinate.X, Coordinate.Y, Maze, Direction, Position);
		}


		/// <summary>
		/// Returns a String that represents the current location
		/// </summary>
		/// <returns></returns>
		public string ToStringShort()
		{
			return string.Format("{0:00}x{1:00} in \"{2}\"", Coordinate.X, Coordinate.Y, Maze);
		}



		#region Properties

		/// <summary>
		/// Gets current maze name
		/// </summary>
		public string Maze
		{
			get;
			set;
		}


		/// <summary>
		/// Coordinate in the maze
		/// </summary>
		public Point Coordinate;


		/// <summary>
		/// Facing direction
		/// </summary>
		public CardinalPoint Direction
		{
			get;
			set;
		}


		/// <summary>
		/// Position on the ground
		/// </summary>
		public SquarePosition Position
		{
			get;
			set;
		}

		#endregion

	}




	/// <summary>
	/// Convert DungeonLocation to a human readable string
	/// </summary>
	internal class DungeonLocationConverter : ExpandableObjectConverter
	{

		public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destType)
		{
			if (destType == typeof(string) && value is DungeonLocation)
			{
				DungeonLocation loc = value as DungeonLocation;

				if (string.IsNullOrEmpty(loc.Maze))
					return string.Empty;

				return loc.Maze + " " + loc.Position.ToString() + "-" + loc.Direction.ToString();
			}

			return base.ConvertTo(context, culture, value, destType);
		}

	}

/*

	/// <summary>
	/// WinForm editor for the DungeonLocation
	/// </summary>
	internal class DungeonLocationEditor : UITypeEditor
	{
		public override UITypeEditorEditStyle GetEditStyle(
		  ITypeDescriptorContext context)
		{
			if (context != null)
			{
				return UITypeEditorEditStyle.Modal;
			}
			return base.GetEditStyle(context);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="context"></param>
		/// <param name="provider"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			if ((context != null) && (provider != null))
			{
				// Access the Property Browser's UI display service
				IWindowsFormsEditorService editorService = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
				if (editorService == null)
					return new DungeonLocation();


				// Create an instance of the UI editor form
				DungeonLocationForm modalEditor = new DungeonLocationForm(null, value as DungeonLocation);


				// Display the UI editor dialog
				if (editorService.ShowDialog(modalEditor) == DialogResult.OK)
				{
					return modalEditor.DungeonLocation;
				}

				return new DungeonLocation();
			}
			return base.EditValue(context, provider, value);
		}
	}

	*/
}
