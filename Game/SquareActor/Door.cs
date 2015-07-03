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
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Audio;
using ArcEngine.Graphic;

namespace DungeonEye
{

	/// <summary>
	/// Door in a square 
	/// </summary>
	public class Door : SquareActor
	{
		/// <summary>
		/// Initializes doors
		/// </summary>
		/// <param name="square">Parent square handle</param>
		public Door(Square square) : base(square)
		{
			// Zone of the button to open/close the door
			Button = new Rectangle(252, 90, 20, 28);

			Count = new SwitchCount();

			// Sounds
			OpenSound = ResourceManager.LockSharedAsset<AudioSample>("door open");
			CloseSound = ResourceManager.LockSharedAsset<AudioSample>("door close");


			AcceptItems = false;
			Speed = TimeSpan.FromSeconds(1);

			if (Square != null || Square.Maze != null)
				Type = Square.Maze.DefaultDoorType;

			//IsActivated = IsOpen;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(State + " " + Type + " door ");
			if (IsBreakable)
				sb.Append("(breakable) ");
			sb.Append("(key ....) ");



			return sb.ToString();
		}


		/// <summary>
		/// Draw the door
		/// </summary>
		/// <param name="batch">Spritebatch to use</param>
		/// <param name="field">View field</param>
		/// <param name="position">Position in the view filed</param>
		/// <param name="view">Looking direction of the team</param>
		public override void Draw(SpriteBatch batch, ViewField field, ViewFieldPosition position, CardinalPoint view)
		{
			if (TileSet == null)
				return;

			TileDrawing td = null;
			TileSet wall = Square.Maze.WallTileset;


			// TODO: Under the door, draw sides
			if (field.GetBlock(ViewFieldPosition.L).IsWall && position == ViewFieldPosition.Team)
			{
		//		td = DisplayCoordinates.GetDoor(ViewFieldPosition.Team);
		//		if (td != null)
		//			batch.DrawTile(overlay, td.ID, td.Location, Color.White, 0.0f, td.Effect, 0.0f);
				if (field.Maze.Decoration != null)
				{
					field.Maze.Decoration.Draw(batch, field.Maze.DoorDeco, position);
				}
			}

			// Draw the door
			else if (((field.Maze.IsDoorNorthSouth(Square.Location) && (view == CardinalPoint.North || view == CardinalPoint.South)) ||
					(!field.Maze.IsDoorNorthSouth(Square.Location) && (view == CardinalPoint.East || view == CardinalPoint.West))) &&
					position != ViewFieldPosition.Team)
			{
				td = DisplayCoordinates.GetDoor(position);
				if (td != null)
				{
					batch.DrawTile(wall, td.ID, td.Location, Color.White, 0.0f, td.Effect, 0.0f);
					//block.Door.Draw(batch, td.Location, position, view);


					switch (Type)
					{
						case DoorType.Grid:
						DrawSimpleDoor(batch, 1, td.Location, position);
						break;
						case DoorType.Forest:
						DrawSimpleDoor(batch, 6, td.Location, position);
						break;
						case DoorType.Iron:
						DrawSimpleDoor(batch, 0, td.Location, position);
						break;
						case DoorType.Monster:
						DrawUpDownDoor(batch, 2, td.Location, position);
						break;
						case DoorType.Azure:
						DrawSimpleDoor(batch, 8, td.Location, position);
						break;
						case DoorType.Crimson:
						DrawSimpleDoor(batch, 9, td.Location, position);
						break;
						case DoorType.Temple:
						DrawSimpleDoor(batch, 10, td.Location, position);
						break;
						case DoorType.Silver:
						DrawSimpleDoor(batch, 11, td.Location, position);
						break;
						case DoorType.Mantis:
						DrawSimpleDoor(batch, 12, td.Location, position);
						break;
					}
				}
			}


		}


		/// <summary>
		/// Update the door state
		/// </summary>
		/// <param name="time">Game time</param>
		public override void Update(GameTime time)
		{
			// Opening
			if (State == DoorState.Opening)
			{
				VPosition--;

				if (VPosition <= -30)
				{
					State = DoorState.Opened;
				}
			}


			// Closing
			else if (State == DoorState.Closing)
			{
				VPosition++;

				if (VPosition >= 0)
				{
					State = DoorState.Closed;
				}
			}

		}


		/// <summary>
		/// Mouse click on the door
		/// </summary>
		/// <param name="location">Location of the click</param>
		/// <param name="side">Wall side</param>
		/// <param name="button">Mouse button state</param>
		/// <returns>True if the event is handled</returns>
		public override bool OnClick(Point location, CardinalPoint side, MouseButtons button)
		{

			// Button
			if (HasButton && Button.Contains(location))
			{
				if (State == DoorState.Closed || State == DoorState.Closing)
					Open();
				else if (State == DoorState.Opened || State == DoorState.Opening)
					Close();

				return true;
			}
			else
			{
				// Try to force the door
				if (State != DoorState.Opened)
				{
					GameMessage.AddMessage("No one is able to pry this door open.");
					return true;
				}
			}


			return false;
		}


		/// <summary>
		/// Opens the door
		/// </summary>
		public void Open()
		{
			State = DoorState.Opening;
			//IsActivated = true;
			//	Audio.PlaySample(0, OpenSound);
		}


		/// <summary>
		/// Closes the door
		/// </summary>
		public void Close()
		{
			// Check if a monster or the team is under the door
			//if (Maze.GetMonsterAt(Location).Count > 0 || (DungeonEye.Team.Maze == Maze && DungeonEye.Team.Location == Location))
			//	return;

			State = DoorState.Closing;
			//IsActivated = false;
			//	Audio.PlaySample(0, CloseSound);
		}


		/// <summary>
		/// Thrown items can pass through
		/// </summary>
		public bool CanItemsPassThrough(Item item)
		{
			if (item == null)
				return false;

			if (State == DoorState.Opened)
				return true;

			if (!item.IsBig && SmallItemPassThrough)
				return true;

			return false;
		}


		#region Actions

		/// <summary>
		/// Closes the door
		/// </summary>
		public override void Activate()
		{
			if (!IsEnabled)
				return;

			if (Count.Deactivate())
				Close();
		}


		/// <summary>
		/// Opens the door
		/// </summary>
		public override void Deactivate()
		{
			if (!IsEnabled)
				return;


			if (Count.Activate())
				Open();
		}



		#endregion


		#region Door type


		/// <summary>
		/// Draw the door with a scissor test
		/// </summary>
		/// <param name="batch">Spritebatch to use</param>
		/// <param name="tileset">Tileset to use</param>
		/// <param name="id">ID of the tile</param>
		/// <param name="location">Location of the tile on the screen</param>
		/// <param name="scissor">Scissor zone</param>
		/// <param name="scale">Scaling factor</param>
		/// <param name="color">Color</param>
		void InternalDraw(SpriteBatch batch, TileSet tileset, int id, Point location, Rectangle scissor, Vector2 scale, Color color)
		{
			if (batch == null)
				return;

			batch.End();

			Display.PushScissor(scissor);

			batch.Begin();
			batch.DrawTile(TileSet, id, location, color, 0.0f, scale, SpriteEffects.None, 0.0f);
			batch.End();

			Display.PopScissor();

			batch.Begin();
		}


		/// <summary>
		/// Draws a simple sliding door
		/// </summary>
		/// <param name="batch">Spritebatch handle</param>
		/// <param name="tileid">Tile id</param>
		/// <param name="location">Location on the screen</param>
		/// <param name="distance">Distance between the view point and the door</param>
		void DrawSimpleDoor(SpriteBatch batch, int tileid, Point location, ViewFieldPosition distance)
		{
			Vector2 scale = new Vector2();
			Color color = Color.White;
			Point button = new Point();

			switch (distance)
			{
				case ViewFieldPosition.K:
				case ViewFieldPosition.L:
				case ViewFieldPosition.M:
				{
					location.Offset(56, 16);
					scale = Vector2.One;
					button = new Point(252, 90);
				}
				break;

				case ViewFieldPosition.F:
				case ViewFieldPosition.G:
				case ViewFieldPosition.H:
				case ViewFieldPosition.I:
				case ViewFieldPosition.J:
				{
					location.Offset(32, 10);
					scale = new Vector2(0.66f, 0.66f);
					color = Color.FromArgb(130, 130, 130);
					button = new Point(230, 86);
				}
				break;

				case ViewFieldPosition.A:
				case ViewFieldPosition.B:
				case ViewFieldPosition.C:
				case ViewFieldPosition.D:
				case ViewFieldPosition.E:
				{
					location.Offset(12, 6);
					scale = new Vector2(0.50f, 0.50f);
					color = Color.FromArgb(40, 40, 40);
					button = new Point(210, 84);
				}
				break;

			}


			InternalDraw(batch, TileSet, tileid,
				new Point(location.X, location.Y + VPosition * 5),
				new Rectangle(location, new Size(144, 150)),
				scale, color);

			if (HasButton)
				batch.DrawTile(TileSet, 15, button, color, 0.0f, scale, SpriteEffects.None, 0.0f);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="location"></param>
		/// <param name="distance"></param>
		void DrawUpDownDoor(SpriteBatch batch, int tileid, Point location, ViewFieldPosition distance)
		{
			Vector2 scale = new Vector2();
			Color color = Color.White;
			Rectangle clip = Rectangle.Empty;
			int[] offset = new int[2];
			Point button = new Point();

			switch (distance)
			{
				case ViewFieldPosition.K:
				case ViewFieldPosition.L:
				case ViewFieldPosition.M:
				{
					location.Offset(56, 14);
					scale = Vector2.One;
					clip = new Rectangle(location, new Size(144, 142));
					offset[0] = VPosition * 5;
					offset[1] = 86 + VPosition * -2;
					button = new Point(252, 90);
				}
				break;

				case ViewFieldPosition.F:
				case ViewFieldPosition.G:
				case ViewFieldPosition.H:
				case ViewFieldPosition.I:
				case ViewFieldPosition.J:
				{
					location.Offset(28, 8);
					scale = new Vector2(0.66f, 0.66f);
					color = Color.FromArgb(130, 130, 130);
					clip = new Rectangle(location, new Size(104, 96));
					offset[0] = VPosition * 3;
					offset[1] = 56 - VPosition;
					button = new Point(230, 86);
				}
				break;

				case ViewFieldPosition.A:
				case ViewFieldPosition.B:
				case ViewFieldPosition.C:
				case ViewFieldPosition.D:
				case ViewFieldPosition.E:
				{
					location.Offset(14, 4);
					scale = new Vector2(0.5f, 0.5f);
					color = Color.FromArgb(40, 40, 40);
					clip = new Rectangle(location, new Size(68, 60));
					offset[0] = VPosition * 2;
					offset[1] = 36 - VPosition;
					button = new Point(210, 84);
				}
				break;

			}


			// Upper part
			InternalDraw(batch, TileSet, tileid,
				new Point(location.X, location.Y + offset[0]),
				clip,
				scale, color);

			// Lower part
			InternalDraw(batch, TileSet, tileid + 1,
				new Point(location.X, location.Y + offset[1]),
				clip,
				scale, color);

			// Button
			if (HasButton)
				batch.DrawTile(TileSet, 13, button, color, 0.0f, scale, SpriteEffects.None, 0.0f);

		}


		#endregion


		#region IO

		/// <summary>
		/// Loads the door's definition from a bank
		/// </summary>
		/// <param name="xml">Xml handle</param>
		/// <returns>True on success</returns>
		public override bool Load(XmlNode xml)
		{
			if (xml == null || xml.Name != Tag)
				return false;


			foreach (XmlNode node in xml)
			{
				if (node.NodeType == XmlNodeType.Comment)
					continue;


				switch (node.Name.ToLower())
				{
					case "smallitempassthrough":
					{
						SmallItemPassThrough = bool.Parse(node.InnerText);
					}
					break;

					case "type":
					{
						Type = (DoorType)Enum.Parse(typeof(DoorType), node.Attributes["value"].Value, true);
					}
					break;

					case "state":
					{
						State = (DoorState)Enum.Parse(typeof(DoorState), node.Attributes["value"].Value, true);
						if (State == DoorState.Opened)
							VPosition = -30;
					}
					break;

					case "isbreakable":
					{
						IsBreakable = Boolean.Parse(node.Attributes["value"].Value);
					}
					break;


					case "hasbutton":
					{
						HasButton = bool.Parse(node.InnerText);
					}
					break;

					case "picklock":
					{
						PickLock = int.Parse(node.Attributes["value"].Value);
					}
					break;

					case "speed":
					{
						Speed = TimeSpan.FromSeconds(int.Parse(node.Attributes["value"].Value));
					}
					break;

					case "strength":
					{
						Strength = int.Parse(node.Attributes["value"].Value);
					}
					break;

					//case "switch":
					//{
					//    Count.Load(node);
					//}
					//break;

					default:
					{
						base.Load(node);
					}
					break;
				}
			}



			return true;
		}


		/// <summary>
		/// Saves the door definition
		/// </summary>
		/// <param name="writer">XML writer handle</param>
		/// <returns></returns>
		public override bool Save(XmlWriter writer)
		{
			if (writer == null)
				return false;

			// State
			writer.WriteStartElement(Tag);
			writer.WriteAttributeString("type", Type.ToString());
			writer.WriteAttributeString("state", State.ToString());
			writer.WriteAttributeString("isbreakable", IsBreakable.ToString());
			writer.WriteAttributeString("hasbutton", HasButton.ToString());
			writer.WriteAttributeString("picklock", PickLock.ToString());
			writer.WriteAttributeString("speed", Speed.TotalSeconds.ToString());
			writer.WriteAttributeString("strength", Strength.ToString());
			writer.WriteAttributeString("smallitempassthrough", SmallItemPassThrough.ToString());

			base.Save(writer);
			writer.WriteEndElement();

			return true;
		}

		#endregion


		#region Helpers


		/// <summary>
		/// Returns true if the door can be displayed in the maze
		/// </summary>
		/// <param name="point">Looking direction</param>
		/// <returns>True if drawable</returns>
		public bool IsDrawable(CardinalPoint point)
		{

			//switch (point)
			//{
			//   case CardinalPoint.North:
			//   return IsNorthSouth;
			//   case CardinalPoint.South:
			//   return IsNorthSouth;
			//   case CardinalPoint.West:
			//   return! IsNorthSouth;
			//   case CardinalPoint.East:
			//   return !IsNorthSouth;
			//}

			return true;
		}


		#endregion


		#region Properties

		/// <summary>
		/// Switch count
		/// </summary>
		public SwitchCount Count
		{
			get;
			set;
		}

		/// <summary>
		/// Door's Tag
		/// </summary>
		public const string Tag = "door";

		
		/// <summary>
		/// Tileset for the drawing
		/// </summary>
		TileSet TileSet
		{
			get
			{
				if (Square == null ||Square.Maze == null)
					return null;

				return Square.Maze.DoorTileset;
			}
		}

		/// <summary>
		/// Door state
		/// </summary>
		public DoorState State
		{
			get;
			set;
		}


		/// <summary>
		/// Type of door
		/// </summary>
		public DoorType Type
		{
			get;
			set;
		}


		/// <summary>
		/// Gets if the door blocking the path
		/// </summary>
		[Browsable(false)]
		public override bool IsBlocking
		{
			get
			{
				return State != DoorState.Opened;
			}
		}


		/// <summary>
		/// Picklock value
		/// </summary>
		public int PickLock
		{
			get;
			set;
		}


		/// <summary>
		/// Does items can pass though
		/// </summary>
		public override bool CanPassThrough
		{
			get
			{
				return !IsBlocking;
			}
		}


		/// <summary>
		/// Gets if the door is open
		/// </summary>
		public bool IsOpen
		{
			get
			{
				return State == DoorState.Opened;
			}
		}


		/// <summary>
		/// Has the door a button to open it
		/// </summary>
		public bool HasButton
		{
			get;
			set;
		}


		/// <summary>
		/// Bashable by chopping
		/// </summary>
		public bool IsBreakable
		{
			get;
			set;
		}


		/// <summary>
		/// Vertical position of the door in the animation
		/// </summary>
		int VPosition;


		/// <summary>
		/// Opening / closing speed
		/// </summary>
		public TimeSpan Speed
		{
			get;
			set;
		}


		/// <summary>
		/// Does small item can pass through the closed door
		/// </summary>
		public bool SmallItemPassThrough
		{
			get;
			set;
		}


		/// <summary>
		/// Can see through the door
		/// </summary>
		public bool CanSeeThrough
		{
			get
			{
				//if (CanItemsPassThrough)
				//	return true;

				if (State == DoorState.Opened)
					return true;

				if (Type == DoorType.Grid || Type == DoorType.Iron)
					return true;



				return false;
			}
		}


		/// <summary>
		/// Zone of the button
		/// </summary>
		Rectangle Button;

		/// <summary>
		/// Opening sound name
		/// </summary>
		AudioSample OpenSound;


		/// <summary>
		/// Closing sound name
		/// </summary>
		AudioSample CloseSound;


		/// <summary>
		/// Door strength. 
		/// This damage must be done in a single blow.
		/// Multiple weaker blows will have no effect.
		/// </summary>
		public int Strength
		{
			get;
			set;
		}


		/// <summary>
		/// Swithc counter
		/// </summary>
		//public SwitchCount Count
		//{
		//    get;
		//    set;
		//}


		#endregion
	}


	/// <summary>
	/// State of a door
	/// </summary>
	public enum DoorState
	{
		/// <summary>
		/// Door is closed
		/// </summary>
		Closed,

		/// <summary>
		/// Door is closing
		/// </summary>
		Closing,

		/// <summary>
		/// Door is opening
		/// </summary>
		Opening,

		/// <summary>
		/// Door is opened
		/// </summary>
		Opened,

		/// <summary>
		/// Door is broken
		/// </summary>
		Broken,

		/// <summary>
		/// Door got stucked
		/// </summary>
		Stuck,
	}


	/// <summary>
	/// Visual type of door
	/// </summary>
	public enum DoorType
	{
		/// <summary>
		/// 
		/// </summary>
		Grid,

		/// <summary>
		/// 
		/// </summary>
		Iron,

		/// <summary>
		/// 
		/// </summary>
		Monster,

		/// <summary>
		/// 
		/// </summary>
		Azure,

		/// <summary>
		/// 
		/// </summary>
		Crimson,

		/// <summary>
		/// 
		/// </summary>
		Temple,

		/// <summary>
		/// 
		/// </summary>
		Forest,

		/// <summary>
		/// 
		/// </summary>
		Silver,

		/// <summary>
		/// 
		/// </summary>
		Mantis
	}

}
