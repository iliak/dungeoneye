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
	///  A maze in a Dungeon
	/// 
	/// 
	/// 
	/// http://dmweb.free.fr/?q=node/217
	/// </summary>
	public class Maze : IDisposable
	{

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="dungeon">Dungeon handle</param>
		public Maze(Dungeon dungeon)
		{
			Name = "No name";
			Dungeon = dungeon;

			Squares = new List<List<Square>>();
			ThrownItems = new List<ThrownItem>();
			Zones = new List<MazeZone>();

			DoorDeco = -1;
			CeilingPitDeco = -1;
			FloorPitDeco = -1;

			IsDisposed = false;
		}



		/// <summary>
		/// Initialize the maze
		/// </summary>
		/// <returns>True on success</returns>
		public bool Init()
		{
			LoadWallTileSet();
			LoadDecoration();
			LoadDoorTileSet();


			foreach (List<Square> list in Squares)
				foreach (Square square in list)
				{
					square.Init();

					#region Pits
					// Find pit destination squares
					Pit pit = square.Actor as Pit;

					if (pit != null && pit.Target != null)
					{
						// Maze exists
						Maze maze = Dungeon.GetMaze(pit.Target.Maze);
						if (maze == null)
							continue;

						// Destination exists
						Square blk = maze.GetSquare(pit.Target.Coordinate);
						if (blk == null)
							continue;

						blk.IsPitTarget = true;
					}
					#endregion
				}

			return true;
		}


		/// <summary>
		/// Loads wall tilesets
		/// </summary>
		/// <returns>True on success</returns>
		public bool LoadWallTileSet()
		{
			ResourceManager.UnlockSharedAsset<TileSet>(WallTileset);

			WallTileset = ResourceManager.CreateSharedAsset<TileSet>(WallTilesetName, WallTilesetName);
			if (WallTileset == null)
			{
				Trace.WriteLine("[Maze] Failed to create wall tileset for the maze \"" + Name + "\".");
				return false;
			}

			return true;
		}


		/// <summary>
		/// Loads decoration
		/// </summary>
		/// <returns>True on success</returns>
		public bool LoadDecoration()
		{
			if (string.IsNullOrEmpty(DecorationName))
				return false;

			if (Decoration != null)
				Decoration.Dispose();

			Decoration = ResourceManager.CreateSharedAsset<DecorationSet>(DecorationName, DecorationName);
			if (Decoration == null)
			{
				Trace.WriteLine("[Maze] Failed to create decoration '" + DecorationName + "' for the maze '" + Name + "'.");
				return false;
			}

			return true;
		}


		/// <summary>
		/// Loads door tilesets
		/// </summary>
		/// <returns>True on success</returns>
		public bool LoadDoorTileSet()
		{
			if (DoorTileset != null)
				DoorTileset.Dispose();

			DoorTileset = ResourceManager.CreateSharedAsset<TileSet>("Doors", "Doors");
			if (DoorTileset == null)
			{
				Trace.WriteLine("[Maze] Failed to create door tileset.");
				return false;
			}

			return true;
		}


		/// <summary>
		/// Dispose
		/// </summary>
		public void Dispose()
		{

			// Dispose each sqaure
			foreach (List<Square> list in Squares)
				foreach (Square square in list)
					square.Dispose();


			ResourceManager.UnlockSharedAsset<TileSet>(DoorTileset);
			DoorTileset = null;

			ResourceManager.UnlockSharedAsset<DecorationSet>(Decoration);
			Decoration = null;

			ResourceManager.UnlockSharedAsset<TileSet>(WallTileset);
			WallTileset = null;

			Squares.Clear();
			Description = null;
			Dungeon = null;
			ThrownItems.Clear();
			DecorationName = null;
			WallTilesetName = null;
			size = Size.Empty;
			Zones.Clear();
			Name = "";

			IsDisposed = true;
		}


		/// <summary>
		/// Update all elements in the maze
		/// </summary>
		public void Update(GameTime time)
		{
			// TODO: URGENT TOP PRIORITY Update squares
			// Remove this lines (glouton cpu).
			foreach (List<Square> list in Squares)
				foreach (Square square in list)
				{
					square.Update(time);
				}

			/*
						// Remove dead monsters
						Monsters.RemoveAll(
							delegate(Monster monster)
							{
								// Monster alive
								if (!monster.IsDead)
									return false;

								// Drop the content of his pocket
								if (monster.ItemsInPocket.Count > 0)
								{
									Square block = GetBlock(monster.Location.Position);

									//ItemSet itemset = ResourceManager.CreateSharedAsset<ItemSet>("Main");
									foreach (string name in monster.ItemsInPocket)
										block.DropItem(monster.Location.Position, ResourceManager.CreateAsset<Item>(name));
								}

								return true;
							});


			*/

			#region Flying items

			// Update flying items
			foreach (ThrownItem item in ThrownItems)
				item.Update(time, this);

			// Remove all blocked flying items
			ThrownItems.RemoveAll(fi =>
				{
					// Item can fly
					if (fi.Distance > 0)
						return false;


					// Make the item falling on the ground
					SquarePosition pos = fi.Location.Position;
					/*
										switch (fi.Location.Direction)
										{
											case CardinalPoint.North:
											if (fi.Location.GroundPosition == GroundPosition.SouthWest)
												pos = GroundPosition.NorthWest;
											if (fi.Location.GroundPosition == GroundPosition.SouthEast)
												pos = GroundPosition.NorthEast;
											break;
											case CardinalPoint.East:
											if (fi.Location.GroundPosition == GroundPosition.NorthWest)
												pos = GroundPosition.NorthEast;
											if (fi.Location.GroundPosition == GroundPosition.SouthWest)
												pos = GroundPosition.SouthEast;
											break;
											case CardinalPoint.South:
											if (fi.Location.GroundPosition == GroundPosition.NorthEast)
												pos = GroundPosition.SouthEast;
											if (fi.Location.GroundPosition == GroundPosition.NorthWest)
												pos = GroundPosition.SouthWest;
											break;
											case CardinalPoint.West:
											if (fi.Location.GroundPosition == GroundPosition.SouthEast)
												pos = GroundPosition.SouthWest;
											if (fi.Location.GroundPosition == GroundPosition.NorthEast)
												pos = GroundPosition.NorthWest;
											break;
										}
					*/

					GetSquare(fi.Location.Coordinate).DropItem(pos, fi.Item);


					return true;
				});
			#endregion
		}



		/// <summary>
		/// Convert to string
		/// </summary>
		/// <returns>Maze name</returns>
		public override string ToString()
		{
			return Name;
		}


		#region Monsters

		/*

		/// <summary>
		/// Adds a monster in the maze
		/// </summary>
		/// <param name="monster">Monster handle</param>
		/// <param name="location">Location in the maze</param>
		/// <param name="position"></param>
		public void SetMonster(Monster monster, Point location, SquarePosition position)
		{
			Square square = GetBlock(location);
			if (square != null)
				square.SetMonster(monster, position);
		}


		/// <summary>
		/// Returns the number of monster in the block
		/// </summary>
		/// <param name="location">Block position</param>
		/// <returns>Number of monster in the block</returns>
		public int GetMonsterCount(Point location)
		{
			Monster[] monsters = GetMonsters(location);

			int count = 0;
			if (monsters[0] != null) count++;
			if (monsters[1] != null) count++;
			if (monsters[2] != null) count++;
			if (monsters[3] != null) count++;

			return count;
		}


		/// <summary>
		/// Returns monster at a given location
		/// </summary>
		/// <param name="location">Location to check</param>
		/// <param name="view">View point</param>
		/// <returns>An array containing monsters</returns>
		public Monster[] GetMonsters(Point location)//, CardinalPoint view)
		{
			Monster[] list = new Monster[4];

			// Out of the maze
			if (!Rectangle.Contains(location))
				return list;


			foreach (Monster monster in Monsters)
				if (monster.Location.Position == location)
					list[(int)monster.Location.Position] = monster;

			return list;
		}


		/// <summary>
		/// Returns the monster at a given location
		/// </summary>
		/// <param name="location">Location in the maze</param>
		/// <param name="position">Ground location</param>
		/// <returns>Monster handle or null</returns>
		public Monster GetMonster(DungeonLocation location, SquarePosition position)
		{
			// Out of the maze
			if (!Rectangle.Contains(location.Position))
				return null;

			// All monsters in the block
			Monster[] monsters = GetMonsters(location.Position);

			// Count monsters
			int count = 0;
			for (int i = 0; i < 4; i++)
				if (monsters[i] != null)
					count++;

			if (count == 0)
				return null;

			if (count == 1)
			{
				for (int i = 0; i < 4; i++)
					if (monsters[i] != null)
						return monsters[i];
			}

			return monsters[(int)position];
		}

*/

		#endregion


		#region Decoration

		/// <summary>
		/// Gets the decoration of a wall side
		/// </summary>
		/// <param name="location">Location of the square</param>
		/// <param name="side">Wall side</param>
		/// <returns>Decoration handle or null</returns>
		public Decoration GetDecoration(Point location, CardinalPoint side)
		{
			if (location == null || Decoration == null)
				return null;

			Square square = GetSquare(location);
			if (square == null)
				return null;

			// if a decoration is found on the desired side
			int id = square.GetDecorationId(side);
			if (id != -1)
				return Decoration.GetDecoration(id);

			// If there's a forced decoration
			for (int i = 0; i < 4; i++)
			{
				id = square.Decorations[i];
				if (id == -1)
					continue;

				Decoration deco = Decoration.GetDecoration(id);
				if (deco != null && deco.ForceDisplay)
					return deco;
			}


			return null;
		}

		#endregion


		#region  Helper



		/// <summary>
		/// Checks if a maze location is valid
		/// </summary>
		/// <param name="pos">Point in the maze</param>
		/// <returns>True if the point is in the maze, false if the point is outside the maze</returns>
		public bool Contains(Point pos)
		{
			return new Rectangle(Point.Empty, Size).Contains(pos);
		}


		/*
				/// <summary>
				/// Gets if a given location is free for a monster
				/// </summary>
				/// <param name="Location"></param>
				/// <param name="position"></param>
				/// <returns></returns>
				public bool IsLocationFree(DungeonLocation location, SquarePosition position)
				{
					if (location == null)
						return false;

					Square square = GetBlock(location.Position);
					if (square.IsBlocking)
						return true;
			

					return false;
				}
		*/

		/// <summary>
		/// Gets if a door is North-South aligned
		/// </summary>
		/// <param name="location">Door location in the maze</param>
		/// <returns>True if the door is pointing north or south</returns>
		public bool IsDoorNorthSouth(Point location)
		{
			if (location == null)
				throw new ArgumentNullException("location");

			Point left = new Point(location.X - 1, location.Y);
			if (!Contains(left))
				return false;

			Square block = GetSquare(left);
			return (block.IsWall);
		}


		/// <summary>
		/// Returns informations about a block in the maze
		/// </summary>
		/// <param name="location">Location of the block</param>
		/// <returns>Square handle</returns>
		public Square GetSquare(Point location)
		{
			if (!Rectangle.Contains(location))
				return new Square(this);

			return Squares[location.Y][location.X];

		}


		/// <summary>
		/// Sets a square at a given location
		/// </summary>
		/// <param name="location">Location in the maze</param>
		/// <param name="square">Square handle</param>
		/// <returns>True on success</returns>
		public bool SetSquare(Point location, Square square)
		{
			if (square == null || !Rectangle.Contains(location))
				return false;

			Squares[location.Y][location.X] = square;
			square.Location = location;
			square.Maze = this;

			return true;
		}


		/// <summary>
		/// Checks if a point is visible from another point
		/// ie: is a monster visible from the current point of view of the team ?
		/// </summary>
		/// <param name="from">The point of view</param>
		/// <param name="to">The destination point to check</param>
		/// <param name="dir">The direction to look</param>
		/// <param name="distance">See distance</param>
		/// <returns>true if visible, false if not visible</returns>
		public bool IsVisible(Point from, Point to, Compass dir, int distance)
		{

			return false;
		}

		#endregion


		#region Flying items

		/// <summary>
		/// Returns all objects flying depending the view point
		/// </summary>
		/// <param name="direction">Looking direction</param>
		/// <returns>Returns an array of flying items
		/// Position 0 : North West
		/// Position 1 : North East
		/// Position 2 : South West
		/// Position 3 : South East</returns>
		public List<ThrownItem>[] GetFlyingItems(Point location, CardinalPoint direction)
		{
			List<ThrownItem>[] tmp = new List<ThrownItem>[5];
			tmp[0] = new List<ThrownItem>();
			tmp[1] = new List<ThrownItem>();
			tmp[2] = new List<ThrownItem>();
			tmp[3] = new List<ThrownItem>();
			tmp[4] = new List<ThrownItem>();

			foreach (ThrownItem item in ThrownItems)
			{
				// Not in the same maze
	//			if (item.Location.Maze != location.Maze)
	//				continue;

				// Same coordinate
				if (item.Location.Coordinate == location)
					tmp[(int)item.Location.Position].Add(item);
			}


			// Swap according to view point direction
			List<ThrownItem>[] items = new List<ThrownItem>[5];
			switch (direction)
			{
				case CardinalPoint.North:
				{
					items[0] = tmp[0];
					items[1] = tmp[1];
					items[2] = tmp[2];
					items[3] = tmp[3];
				}
				break;
				case CardinalPoint.East:
				{
					items[0] = tmp[1];
					items[1] = tmp[3];
					items[2] = tmp[0];
					items[3] = tmp[2];
				}
				break;
				case CardinalPoint.South:
				{
					items[0] = tmp[3];
					items[1] = tmp[2];
					items[2] = tmp[1];
					items[3] = tmp[0];
				}
				break;
				case CardinalPoint.West:
				{
					items[0] = tmp[2];
					items[1] = tmp[0];
					items[2] = tmp[3];
					items[3] = tmp[1];
				}
				break;
			}

			items[4] = tmp[4];

			return items;
		}


		#endregion


		#region Draws

		/// <summary>
		/// Draw the maze
		/// </summary>
		/// <param name="batch">SpriteBatch to use</param>
		/// <param name="location">Location to display from</param>
		/// <see cref="http://eob.wikispaces.com/eob.vmp"/>
		public void Draw(SpriteBatch batch, DungeonLocation location)
		{
			if (WallTileset == null)
				return;

			// Clear the spritebatch
			batch.End();
			Display.PushScissor(new Rectangle(0, 0, 352, 240));
			batch.Begin();


			//
			// 
			//
			ViewField pov = new ViewField(this, location);


			// TODO Backdrop
			// The background is assumed to be x-flipped when party.x & party.y & party.direction = 1.
			// I.e. all kind of moves and rotations from the current position will result in the background being x-flipped.
			bool flipbackdrop = ((location.Coordinate.X + location.Coordinate.Y + (int)location.Direction) & 1) == 0;
			SpriteEffects effect = flipbackdrop ? SpriteEffects.FlipHorizontally : SpriteEffects.None;
			batch.DrawTile(WallTileset, 0, Point.Empty, Color.White, 0.0f, effect, 0.0f);

			// maze block draw order
			// A E B D C
			// F J G I H
			//   K M L
			//   N ^ O

			#region row -3
			DrawSquare(batch, pov, ViewFieldPosition.A, location.Direction);
			DrawSquare(batch, pov, ViewFieldPosition.E, location.Direction);
			DrawSquare(batch, pov, ViewFieldPosition.B, location.Direction);
			DrawSquare(batch, pov, ViewFieldPosition.D, location.Direction);
			DrawSquare(batch, pov, ViewFieldPosition.C, location.Direction);
			#endregion

			#region row -2
			DrawSquare(batch, pov, ViewFieldPosition.F, location.Direction);
			DrawSquare(batch, pov, ViewFieldPosition.J, location.Direction);
			DrawSquare(batch, pov, ViewFieldPosition.G, location.Direction);
			DrawSquare(batch, pov, ViewFieldPosition.I, location.Direction);
			DrawSquare(batch, pov, ViewFieldPosition.H, location.Direction);
			#endregion

			#region row -1
			DrawSquare(batch, pov, ViewFieldPosition.K, location.Direction);
			DrawSquare(batch, pov, ViewFieldPosition.M, location.Direction);
			DrawSquare(batch, pov, ViewFieldPosition.L, location.Direction);
			#endregion

			#region row 0
			DrawSquare(batch, pov, ViewFieldPosition.N, location.Direction);
			DrawSquare(batch, pov, ViewFieldPosition.Team, location.Direction);
			DrawSquare(batch, pov, ViewFieldPosition.O, location.Direction);
			#endregion


			// Clear the spritebatch
			batch.End();
			Display.PopScissor();
			batch.Begin();

		}



		/// <summary>
		/// Draws a square
		/// </summary>
		/// <param name="batch">Spritebatch handle</param>
		/// <param name="field">View field</param>
		/// <param name="position">Position of the square in the view field</param>
		/// <param name="view">Looking direction of the team</param>
		void DrawSquare(SpriteBatch batch, ViewField field, ViewFieldPosition position, CardinalPoint view)
		{
			if (field == null)
				return;

			Square square = field.Blocks[(int)position];
			Point point;
			Decoration deco = null;
			List<Item>[] list = square.GetItems(view);


			#region ceiling pit
			if (square.IsPitTarget)
			{
				//TODO
				TileDrawing td = DisplayCoordinates.GetCeilingPit(position);
				//if (td != null)
				//	batch.DrawTile(OverlayTileset, td.ID, td.Location, Color.White, 0.0f, td.Effect, 0.0f);
				//***batch.DrawTile(ItemsTileset, td.ID, td.Location, td.SwapX, td.SwapY);
			}

			#endregion


			#region Items on ground before a door
			// If there is a deco that hide ground items, skip
			deco = GetDecoration(square.Location, Compass.GetOppositeDirection(view));
			if (deco == null || (deco != null && !deco.HideItems))
			{
				if (!square.IsWall || (deco != null && !deco.HideItems))
				{
					for (int i = 0; i < 2; i++)
					{
						if (list[i].Count == 0)
							continue;

						foreach (Item item in list[i])
						{
							point = DisplayCoordinates.GetGroundPosition(position, (SquarePosition)i);
							if (!point.IsEmpty)
							{
								batch.DrawTile(Dungeon.ItemTileSet, item.GroundTileID, point,
									DisplayCoordinates.GetDistantColor(position), 0.0f,
									DisplayCoordinates.GetItemScaleFactor(position), SpriteEffects.None, 0.0f);
							}
						}
					}
				}
			}
			#endregion


			#region Walls
			if (square.IsWall)
			{
				// Walls
				foreach (TileDrawing tmp in DisplayCoordinates.GetWalls(position))
				{
					Color color = Color.White;
					int tileid = tmp.ID;

					//if (swap)
					//{
					//    color = Color.Red;
					//    tileid += 9;
					//}

					batch.DrawTile(WallTileset, tileid, tmp.Location, color, 0.0f, tmp.Effect, 0.0f);
				}
			}

			#endregion


			#region Decoration
			if (square.HasDecorations)
			{
				// Is there a forced decoration
				for (int i = 0; i < 4; i++)
				{
					deco = Decoration.GetDecoration(square.GetDecorationId((CardinalPoint)i));
					if (deco != null && deco.ForceDisplay)
						deco.DrawDecoration(batch, Decoration, position, true);
				}


				// For each directions, draws the decoration
				foreach (CardinalPoint side in DisplayCoordinates.DrawingWallSides[(int)position])
				{
					// Decoration informations
					deco = Decoration.GetDecoration(square.GetDecorationId(view, side));
					if (deco == null)
						continue;

					deco.DrawDecoration(batch, Decoration, position, side == CardinalPoint.South);
				}
			}

			#endregion


			#region Actor
			if (square.Actor != null)
				square.Actor.Draw(batch, field, position, view);
			#endregion


			#region Items on ground after a door
			if (!square.IsWall)
			{
				// If there is a deco that hide ground items, skip
				deco = GetDecoration(square.Location, Compass.GetOppositeDirection(view));
				if (deco == null || (deco != null && !deco.HideItems))
				{
					// Both ground positions
					for (int i = 2; i < 4; i++)
					{
						// No items
						if (list[i].Count == 0)
							continue;

						// Foreach item on the ground
						foreach (Item item in list[i])
						{
							// Get screen coordinate
							point = DisplayCoordinates.GetGroundPosition(position, (SquarePosition)i);
							if (!point.IsEmpty)
							{
								batch.DrawTile(Dungeon.ItemTileSet, item.GroundTileID, point,
									DisplayCoordinates.GetDistantColor(position), 0.0f,
									DisplayCoordinates.GetItemScaleFactor(position), SpriteEffects.None, 0.0f);
							}
						}
					}
				}
			}
			#endregion


			#region Monsters
			if (square.MonsterCount > 0)
			{
				// Drawing order for monsters
				int[][] order = new int[][]
				{
					new int[] {0, 1, 2, 3},	// North
					new int[] {3, 2, 1, 0},	// South
					new int[] {2, 0, 3, 1},	// West
					new int[] {1, 3, 0, 2},	// East
				};

				for (int i = 0; i < 4; i++)
				{
					Monster monster = square.Monsters[order[(int)view][i]];
					if (monster != null)
						monster.Draw(batch, view, position);
				}
			}
			#endregion


			#region Flying items

			List<ThrownItem>[] flyings = GetFlyingItems(square.Location, view);
			foreach (SquarePosition pos in Enum.GetValues(typeof(SquarePosition)))
			{
				point = DisplayCoordinates.GetFlyingItem(position, pos);
				//	if (point == Point.Empty)
				//		continue;

				// Swap the tile if throwing on the right side
				SpriteEffects fx = SpriteEffects.None;
				if (pos == SquarePosition.NorthEast || pos == SquarePosition.SouthEast)
					fx = SpriteEffects.FlipHorizontally;

				foreach (ThrownItem fi in flyings[(int)pos])
					batch.DrawTile(Dungeon.ItemTileSet, fi.Item.ThrowTileID, point,
						DisplayCoordinates.GetDistantColor(position), 0.0f,
						DisplayCoordinates.GetItemScaleFactor(position), fx, 0.0f);

			}
			#endregion

		}



		/// <summary>
		/// Draws the minimap
		/// </summary>
		/// <param name="batch">Spritebatch handle</param>
		/// <param name="location">Location on the screen</param>
		public void DrawMiniMap(SpriteBatch batch, Point location)
		{
			if (batch == null)
				return;

			Team team = GameScreen.Team;

			Color color;

			for (int y = 0; y < Size.Height; y++)
				for (int x = 0; x < Size.Width; x++)
				{
					Square block = GetSquare(new Point(x, y));

					switch (block.Type)
					{
						case SquareType.Wall:
						color = Color.Black;
						break;
						case SquareType.Illusion:
						color = Color.Gray;
						break;
						default:
						color = Color.White;
						break;
					}



					if (block.MonsterCount > 0)
						color = Color.Red;
					if (block.Actor is Door)
						color = Color.Yellow;
					if (block.Actor is Pit)
						color = Color.DarkBlue;
					if (block.Actor is Stair)
						color = Color.LightGreen;
					if (block.MonsterCount > 0)
						color = Color.Red;


					if (team.Location.Coordinate.X == x && team.Location.Coordinate.Y == y && team.Maze == this)
						color = Color.Blue;

					batch.FillRectangle(new Rectangle(location.X + x * 4, location.Y + y * 4, 4, 4), color);

				}
		}


		#endregion


		#region IO

		/// <summary>
		/// Loads the maze definition
		/// </summary>
		/// <param name="xml">XmlNode handle</param>
		/// <returns>True on success</returns>
		public bool Load(XmlNode xml)
		{
			if (xml == null || xml.Name != Tag)
				return false;

			Name = xml.Attributes["name"].Value;

			Square block = null;

			foreach (XmlNode node in xml)
			{
				if (node.NodeType == XmlNodeType.Comment)
					continue;


				switch (node.Name.ToLower())
				{
					case "tileset":
					{
						WallTilesetName = node.Attributes["wall"].Value;
						DecorationName = node.Attributes["decoration"].Value;
					}
					break;

					case "description":
					{
						Description = node.InnerText;
					}
					break;

					case "flyingitems":
					{
						foreach (XmlNode subnode in node)
						{
							ThrownItem item = new ThrownItem(null);
							item.Load(subnode);
							ThrownItems.Add(item);
						}
					}
					break;

					case MazeZone.Tag:
					{
						MazeZone zone = new MazeZone();
						zone.Load(node);
						Zones.Add(zone);
					}
					break;

					case "decorations":
					{
						FloorPitDeco = int.Parse(node.Attributes["floorpit"].Value);
						CeilingPitDeco = int.Parse(node.Attributes["ceilingpit"].Value);
						DoorDeco = int.Parse(node.Attributes["door"].Value);
					}
					break;

					case "doors":
					{
						DefaultDoorType = (DoorType)Enum.Parse(typeof(DoorType), node.Attributes["type"].Value);
					}
					break;


					#region Squares

					case "squares":
					{
						// Resize maze
						Size = new Size(int.Parse(node.Attributes["width"].Value), int.Parse(node.Attributes["height"].Value));
						Point location = new Point();

						foreach (XmlNode subnode in node)
						{
							switch (subnode.Name.ToLower())
							{
								// Add a row
								case Square.Tag:
								{
									block = new Square(this);
									block.Location = location;
									block.Load(subnode);

									Squares[location.Y][location.X] = block;
								}
								break;
							}

							// Next location
							location.X++;
							if (location.X == Size.Width)
							{
								location.Y++;
								location.X = 0;
							}
						}

					}
					break;

					#endregion


					default:
					{
					}
					break;
				}
			}



			return true;
		}



		/// <summary>
		/// Saves the maze definition
		/// </summary>
		/// <param name="writer">XmlWriter handle</param>
		/// <returns>True on success</returns>
		public bool Save(XmlWriter writer)
		{
			if (writer == null)
				return false;

			writer.WriteStartElement(Tag);
			writer.WriteAttributeString("name", Name);

			// Tilesets
			writer.WriteStartElement("tileset");
			writer.WriteAttributeString("wall", WallTilesetName);
			writer.WriteAttributeString("decoration", DecorationName);
			writer.WriteEndElement();

			writer.WriteStartElement("description");
			writer.WriteString(Description);
			writer.WriteEndElement();

			writer.WriteStartElement("doors");
			writer.WriteAttributeString("type", DefaultDoorType.ToString());
			writer.WriteEndElement();

			writer.WriteStartElement("decorations");
			writer.WriteAttributeString("ceilingpit", CeilingPitDeco.ToString());
			writer.WriteAttributeString("floorpit", FloorPitDeco.ToString());
			writer.WriteAttributeString("door", DoorDeco.ToString());
			writer.WriteEndElement();

			// Blocks
			writer.WriteStartElement("squares");
			writer.WriteAttributeString("width", Size.Width.ToString());
			writer.WriteAttributeString("height", Size.Height.ToString());

			try
			{
				foreach (List<Square> list in Squares)
					foreach (Square square in list)
						square.Save(writer);
			}
			catch (Exception e)
			{
			}

			writer.WriteEndElement();

			// Zones
			foreach (MazeZone zone in Zones)
				zone.Save(writer);


			// flying items
			if (ThrownItems.Count > 0)
			{
				writer.WriteStartElement("flyingitems");
				foreach (ThrownItem item in ThrownItems)
					item.Save(writer);
				writer.WriteEndElement();
			}

			writer.WriteEndElement();

			return true;
		}

		#endregion


		#region Resize

		/// <summary>
		/// Resizes the maze
		/// </summary>
		/// <param name="newsize">new size</param>
		public void Resize(Size newsize)
		{
			// Rows
			if (newsize.Height > Size.Height)
			{
				for (int y = Size.Height; y < newsize.Height; y++)
					InsertRow(y);
			}
			else if (newsize.Height < Size.Height)
			{
				for (int y = Size.Height - 1; y >= newsize.Height; y--)
					RemoveRow(y);
			}


			// Columns
			if (newsize.Width > Size.Width)
			{
				for (int x = Size.Width; x < newsize.Width; x++)
					InsertColumn(x);
			}
			else if (newsize.Width < Size.Width)
			{
				for (int x = Size.Width - 1; x >= newsize.Width; x--)
					RemoveColumn(x);
			}


			size = newsize;

			for (int y = 0; y < size.Height; y++)
				for (int x = 0; x < size.Width; x++)
				{
					Squares[y][x].Location = new Point(x, y);
				}
		}


		/// <summary>
		/// Inserts a row
		/// </summary>
		/// <param name="rowid">Position of insert</param>
		public void InsertRow(int rowid)
		{
			// Build the row
			List<Square> row = new List<Square>(Size.Width);
			for (int x = 0; x < Size.Width; x++)
				row.Add(new Square(this));

			// Adds the row at the end
			if (rowid >= Squares.Count)
			{
				Squares.Add(row);
			}

			// Or insert the row
			else
			{
				Squares.Insert(rowid, row);

				// Offset objects
				//	Rectangle zone = new Rectangle(0, rowid * level.BlockDimension.Height, level.Dimension.Width, level.Dimension.Height);
				//	OffsetObjects(zone, new Point(0, level.BlockDimension.Height));
			}
		}


		/// <summary>
		/// Removes a row
		/// </summary>
		/// <param name="rowid">Position of remove</param>
		public void RemoveRow(int rowid)
		{
			// Removes the row
			if (rowid >= Squares.Count)
				return;

			Squares.RemoveAt(rowid);

			// Offset objects
			//	Rectangle zone = new Rectangle(0, rowid * level.BlockDimension.Height, level.Dimension.Width, level.Dimension.Height);
			//	OffsetObjects(zone, new Point(0, -level.BlockDimension.Height));
		}


		/// <summary>
		/// Inserts a column
		/// </summary>
		/// <param name="columnid">Position of remove</param>
		public void InsertColumn(int columnid)
		{
			// Insert the column
			foreach (List<Square> row in Squares)
			{
				if (columnid >= row.Count)
				{
					row.Add(new Square(this));
				}
				else
				{
					row.Insert(columnid, new Square(this));

					// Offset objects
					//	Rectangle zone = new Rectangle(columnid * level.BlockDimension.Width, 0, level.Dimension.Width, level.Dimension.Height);
					//	OffsetObjects(zone, new Point(level.BlockDimension.Width, 0));
				}
			}
		}


		/// <summary>
		/// Removes a column
		/// </summary>
		/// <param name="columnid">Position of remove</param>
		public void RemoveColumn(int columnid)
		{
			// Remove the column
			foreach (List<Square> row in Squares)
			{
				row.RemoveAt(columnid);
			}

			// Offset objects
			//	Rectangle zone = new Rectangle(columnid * level.BlockDimension.Width, 0, level.Dimension.Width, level.Dimension.Height);
			//	OffsetObjects(zone, new Point(-level.BlockDimension.Width, 0));
		}


		/// <summary>
		/// Offsets EVERY objects (monsters, items...) in the maze
		/// </summary>
		/// <param name="zone">Each object in this rectangle</param>
		/// <param name="offset">Offset to move</param>
		void OffsetObjects(Rectangle zone, Point offset)
		{
			/*	
						// Move entities
						foreach (Entity entity in Entities.Values)
						{
							if (zone.Contains(entity.Location))
							{
								entity.Location = new Point(
									entity.Location.X + offset.X,
									entity.Location.Y + offset.Y);
							}
						}


						// Mode SpawnPoints
						foreach (SpawnPoint spawn in SpawnPoints.Values)
						{
							if (zone.Contains(spawn.Location))
							{
								spawn.Location = new Point(
									spawn.Location.X + offset.X,
									spawn.Location.Y + offset.Y);
							}
						}
			*/
		}

		#endregion


		#region Properties

		/// <summary>
		/// 
		/// </summary>
		public const string Tag = "maze";


		/// <summary>
		/// Is asset disposed
		/// </summary>
		[Browsable(false)]
		public bool IsDisposed
		{
			get;
			private set;
		}


		#region Tilesets

		/// <summary>
		/// Wall TileSet to use
		/// </summary>
		[TypeConverter(typeof(TileSetEnumerator))]
		[Category("TileSet")]
		public string WallTilesetName
		{
			get;
			set;
		}


		/// <summary>
		/// Wall tileset
		/// </summary>
		[Browsable(false)]
		public TileSet WallTileset
		{
			get;
			private set;
		}


		/// <summary>
		/// Decoration name
		/// </summary>
		[TypeConverter(typeof(TileSetEnumerator))]
		[Category("TileSet")]
		public string DecorationName
		{
			get;
			set;
		}


		/// <summary>
		/// Decoration handle
		/// </summary>
		[Browsable(false)]
		public DecorationSet Decoration
		{
			get;
			private set;
		}


		/// <summary>
		/// Doors tileset
		/// </summary>
		[Browsable(false)]
		public TileSet DoorTileset
		{
			get;
			private set;
		}

		#endregion


		/// <summary>
		/// Blocks in the maze
		/// </summary>
		List<List<Square>> Squares;


		/// <summary>
		/// Gets the size of the maze
		/// </summary>
		public Size Size
		{
			get
			{
				return size;
			}
			set
			{
				Resize(value);
			}
		}
		Size size;


		/// <summary>
		/// Rectangle (size) of the maze
		/// </summary>
		[Browsable(false)]
		public Rectangle Rectangle
		{
			get
			{
				return new Rectangle(Point.Empty, Size);
			}
		}


		/// <summary>
		/// Name of the maze
		/// </summary>
		public string Name
		{
			get;
			set;
		}


		/// <summary>
		/// Description of the maze
		/// </summary>
		public string Description
		{
			get;
			set;
		}


		/// <summary>
		/// Dungeon the maze belongs to
		/// </summary>
		[Browsable(false)]
		public Dungeon Dungeon
		{
			get;
			private set;
		}


		/// <summary>
		/// Flying items in the maze
		/// </summary>
		[Browsable(false)]
		public List<ThrownItem> ThrownItems
		{
			get;
			private set;
		}


		/// <summary>
		/// Default type of door in this maze
		/// </summary>
		public DoorType DefaultDoorType
		{
			get;
			set;
		}


		/// <summary>
		/// TODO: Move in MazeZone
		/// Level Experience Multiplier when Heroes gain experience
		/// </summary>
		public float ExperienceMultiplier;


		/// <summary>
		/// List of available zones
		/// </summary>
		public List<MazeZone> Zones
		{
			get;
			private set;
		}


		/// <summary>
		/// Decoration ID for floor pits
		/// </summary>
		public int FloorPitDeco
		{
			get;
			set;
		}


		/// <summary>
		/// Decoration ID for ceiling pits
		/// </summary>
		public int CeilingPitDeco
		{
			get;
			set;
		}


		/// <summary>
		/// Decoration ID for side door views
		/// </summary>
		public int DoorDeco
		{
			get;
			set;
		}
		#endregion
	}

}
