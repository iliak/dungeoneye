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
using System.Windows.Forms;
using System.Xml;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Forms;
using ArcEngine.Graphic;
using ArcEngine.Interface;
using DungeonEye.Script;
using DungeonEye.Script.Actions;

namespace DungeonEye.Forms
{
	/// <summary>
	/// Dungeon form editor
	/// </summary>
	public partial class DungeonForm : AssetEditorBase
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="node">Dungeon node definition</param>
		public DungeonForm(XmlNode node)
		{
			InitializeComponent();

			// Create the dungeon
			Dungeon dungeon = new Dungeon();
			dungeon.Load(node);
			dungeon.Init();


			ItemTileSetBox.DataSource = ResourceManager.GetAssets<TileSet>();
			ItemTileSetBox.SelectedItem = dungeon.ItemTileSetName;

			DecorationNameBox.Items.AddRange(ResourceManager.GetAssets<DecorationSet>().ToArray());
			DecorationNameBox.Items.Insert(0, "");
			WallTileSetNameBox.Items.AddRange(ResourceManager.GetAssets<TileSet>().ToArray());
			WallTileSetNameBox.Items.Insert(0, "");





			PreviewLoc = new DungeonLocation(dungeon.StartLocation);


			//		RebuildMazeList();
			DungeonNoteBox.Text = dungeon.Note;

			StartLocationBox.Dungeon = dungeon;
			StartLocationBox.SetTarget(dungeon.StartLocation);


			KeyboardScheme = ResourceManager.CreateAsset<InputScheme>(Game.InputSchemeName);
			if (KeyboardScheme == null)
			{
				KeyboardScheme = new InputScheme();
				KeyboardScheme["MoveForward"] = Keys.Z;
				KeyboardScheme["MoveBackward"] = Keys.S;
				KeyboardScheme["StrafeLeft"] = Keys.Q;
				KeyboardScheme["StrafeRight"] = Keys.D;
				KeyboardScheme["TurnLeft"] = Keys.A;
				KeyboardScheme["TurnRight"] = Keys.E;
				KeyboardScheme["Inventory"] = Keys.I;
				KeyboardScheme["SelectHero1"] = Keys.D1;
				KeyboardScheme["SelectHero2"] = Keys.D2;
				KeyboardScheme["SelectHero3"] = Keys.D3;
				KeyboardScheme["SelectHero4"] = Keys.D4;
				KeyboardScheme["SelectHero5"] = Keys.D5;
				KeyboardScheme["SelectHero6"] = Keys.D6;
			}




			Dungeon = dungeon;
		}


		/// <summary>
		/// Move the team
		/// </summary>
		/// <param name="front"></param>
		/// <param name="strafe"></param>
		/// <returns>True if move allowed, otherwise false</rereturns>
		public void PreviewMove(int front, int strafe)
		{

			// Destination point
			Point offset = Point.Empty;


			switch (PreviewLoc.Direction)
			{
				case CardinalPoint.North:
				{
					//	dst = new Point(PreviewLoc.Position.X + front, PreviewLoc.Position.Y + strafe);
					offset = new Point(front, strafe);
				}
				break;

				case CardinalPoint.South:
				{
					//	dst = new Point(PreviewLoc.Position.X - front, PreviewLoc.Position.Y - strafe);
					offset = new Point(-front, -strafe);
				}
				break;

				case CardinalPoint.East:
				{
					//	dst = new Point(PreviewLoc.Position.X - strafe, PreviewLoc.Position.Y + front);
					offset = new Point(-strafe, front);
				}
				break;

				case CardinalPoint.West:
				{
					//	dst = new Point(PreviewLoc.Position.X + strafe, PreviewLoc.Position.Y - front);
					offset = new Point(strafe, -front);
				}
				break;
			}



			PreviewLoc.Coordinate.Offset(offset);

			SquareDescriptionBox.Text = "Preview pos : " + PreviewLoc.Position.ToString();

		}


		/// <summary>
		/// save the asset to the manager
		/// </summary>
		public override void Save()
		{
			ResourceManager.AddAsset<Dungeon>(Dungeon.Name, ResourceManager.ConvertAsset(Dungeon));
		}


		/// <summary>
		/// Uncheck all buttons
		/// </summary>
		/// <param name="button">Button to avoid</param>
		void UncheckButtons(ToolStripButton button)
		{
			ToolStripButton[] buttons = new ToolStripButton[]
			{
				WallBox,
				StairBox,
				TeleporterBox,
				DoorBox,
				PitBox,
				WrittingBox,
				LauncherBox,
				GeneratorBox,
				SwitchBox,
				PressurePlateBox,

				EventBox,

				PressurePlateBox,

				AddItemBox,
				AddMonsterBox,

				ZoneBox,

				NoGhostsBox,
				NoMonstersBox,
				AlcoveBox,

				ForceFieldBox
			};


			foreach (ToolStripButton but in buttons)
			{
				if (but != button)
					but.Checked = false;
			}
		}



		/// <summary>
		/// Edits the square
		/// </summary>
		/// <param name="square">Square handle</param>
		void EditSquare(Square square, bool showactortab)
		{
			SquareForm form = new SquareForm(Maze, square);
			if (showactortab)
				form.ActivateActorTab();

			form.ShowDialog();
		}


		/// <summary>
		/// Change the selected maze
		/// </summary>
		/// <param name="name">Maze's name</param>
		void ChangeMaze(string name)
		{
			if (string.IsNullOrEmpty(name) || Dungeon == null)
				return;

			Maze = Dungeon.GetMaze(name);
			PreviewLoc.Maze = Maze.Name;

			UpdateMazeTab();
		}


		/// <summary>
		/// Update maze tab controls
		/// </summary>
		void UpdateMazeTab()
		{
			if (Maze == null)
				return;

			Maze maze = Maze;
			Maze = null;


			DecorationNameBox.SelectedItem = maze.DecorationName;
			WallTileSetNameBox.SelectedItem = maze.WallTilesetName;
			FloorPitDecoIdBox.Value = maze.FloorPitDeco;
			CeilingDecoIdBox.Value = maze.CeilingPitDeco;
			DoorDecoIdBox.Value = maze.DoorDeco;

			Maze = maze;
		}


		/// <summary>
		/// Renders the dungeon
		/// </summary>
		private void RenderDungeon()
		{
			if (SpriteBatch == null)
				return;

			glControl.MakeCurrent();
			Display.ClearBuffers();

			SpriteBatch.Begin();

			// Background texture
			Rectangle dst = new Rectangle(Point.Empty, glControl.Size);
			SpriteBatch.Draw(CheckerBoard, dst, dst, Color.White);


			// Nom maze, bye bye
			if (Maze == null)
			{
				SpriteBatch.End();
				glControl.SwapBuffers();
				return;
			}


			#region Squares
			for (int y = 0 ; y < Maze.Size.Height ; y++)
			{
				for (int x = 0 ; x < Maze.Size.Width ; x++)
				{
					Point coord = new Point(x, y);
					Square block = Maze.GetSquare(coord);
					int tileid = block.Type == SquareType.Ground ? 1 : 0;

					// Location of the block on the screen
					Point location = new Point(Offset.X + x * 25, Offset.Y + y * 25);


					Color color = Color.White;
					if (block.Type == SquareType.Illusion)
						color = Color.LightGreen;

					SpriteBatch.DrawTile(Icons, tileid, location, color);

					if (block.ItemCount > 0)
					{
						SpriteBatch.DrawTile(Icons, 19, location);
					}


					#region Actor
					if (block.Actor != null)
					{
						// Doors
						if (block.Actor is Door)
						{
							Door door = block.Actor as Door;

							if (Maze.IsDoorNorthSouth(block.Location))
								tileid = 3;
							else
								tileid = 2;


							// Door opened or closed
							if (door.State == DoorState.Broken || door.State == DoorState.Opened || door.State == DoorState.Opening)
								tileid += 2;

							SpriteBatch.DrawTile(Icons, tileid, location);
						}


						else if (block.Actor is PressurePlate)
						{
							SpriteBatch.DrawTile(Icons, 18, location);
						}

						else if (block.Actor is Pit)
						{
							SpriteBatch.DrawTile(Icons, 9, location);
						}

						else if (block.Actor is Teleporter)
						{
							SpriteBatch.DrawTile(Icons, 11, location);
						}

						else if (block.Actor is ForceField)
						{
							ForceField field = block.Actor as ForceField;

							if (field.Type == ForceFieldType.Spin)
								tileid = 12;
							else if (field.Type == ForceFieldType.Move)
							{
								tileid = 13 + (int) field.Direction;
							}
							else
								tileid = 17;

							SpriteBatch.DrawTile(Icons, tileid, location);
						}

						else if (block.Actor is Stair)
						{
							Stair stair = block.Actor as Stair;
							tileid = stair.Type == StairType.Up ? 6 : 7;
							SpriteBatch.DrawTile(Icons, tileid, location);
						}

						else if (block.Actor is EventSquare)
						{
							SpriteBatch.DrawTile(Icons, 26, location);
						}
						else if (block.Actor is WallSwitch)
						{
							// Display coords
							Point[] sides = new Point[]
							{
								new Point(7, 0),
								new Point(7, 19),
								new Point(0, 7),
								new Point(19, 7),
							};

							WallSwitch wall = block.Actor as WallSwitch;

							tileid = (int) wall.Side > 1 ? 102 : 103;
							SpriteBatch.DrawTile(Icons, tileid, new Point(
								Offset.X + x * 25 + sides[(int) wall.Side].X,
								Offset.Y + y * 25 + sides[(int) wall.Side].Y));
						}
					}
					#endregion


					#region Decoration
					if (block.HasDecorations)
					{

						foreach (CardinalPoint side in Enum.GetValues(typeof(CardinalPoint)))
						{
							if (block.HasDecoration(side))
							{
								Point[] from = new Point[]
								{
									new Point(1, 1),
									new Point(1, 24),
									new Point(1, 1),
									new Point(24, 1),
								};

								Point[] to = new Point[]
								{
									new Point(24, 1),
									new Point(24, 24),
									new Point(1, 24),
									new Point(24, 24),
								};

								Point offset = new Point(Offset.X + x * 25, Offset.Y + y * 25);

								SpriteBatch.DrawLine(
									new Point(from[(int) side].X + offset.X, from[(int) side].Y + offset.Y),
									new Point(to[(int) side].X + offset.X,   to[(int) side].Y + offset.Y),
									Color.LightGreen);
							}
						}
					}
					#endregion


					if (block.NoMonster)
					{
						SpriteBatch.FillRectangle(new Rectangle(location.X, location.Y, 25, 25), Color.FromArgb(128, Color.Blue));
					}


					if (block.NoGhost)
					{
						SpriteBatch.FillRectangle(new Rectangle(location.X, location.Y, 25, 25), Color.FromArgb(128, Color.Green));
					}


					// Monsters
					if (block.Monsters[0] != null)
						SpriteBatch.FillRectangle(new Rectangle(location.X + 4, location.Y + 4, 4, 4), Color.Red);
					if (block.Monsters[1] != null)
						SpriteBatch.FillRectangle(new Rectangle(location.X + 16, location.Y + 4, 4, 4), Color.Red);
					if (block.Monsters[2] != null)
						SpriteBatch.FillRectangle(new Rectangle(location.X + 4, location.Y + 16, 4, 4), Color.Red);
					if (block.Monsters[3] != null)
						SpriteBatch.FillRectangle(new Rectangle(location.X + 16, location.Y + 16, 4, 4), Color.Red);

				}
			}
			#endregion


			// Preview pos
			SpriteBatch.DrawTile(Icons, 22 + (int) PreviewLoc.Direction, new Point(Offset.X + PreviewLoc.Coordinate.X * 25, Offset.Y + PreviewLoc.Coordinate.Y * 25));


			// Starting point
			if (Dungeon.StartLocation.Maze == Maze.Name)
			{
				SpriteBatch.DrawTile(Icons, 20,
					new Point(Offset.X + Dungeon.StartLocation.Coordinate.X * 25, Offset.Y + Dungeon.StartLocation.Coordinate.Y * 25));
			}


			// Surround the selected object
			if (CurrentSquare != null)
				SpriteBatch.DrawRectangle(new Rectangle(CurrentSquare.Location.X * 25 + Offset.X, CurrentSquare.Location.Y * 25 + Offset.Y, 25, 25), Color.White);


			// If the current actor has scripts
			if (SquareUnderMouse != null && SquareUnderMouse.Actor != null)
			{
				SquareActor actor = SquareUnderMouse.Actor;
				foreach(DungeonLocation target in actor.GetTargets())
				{
					if (target == null)
						continue;

					//DungeonLocation target = script.Action.Target;
					if (target.Maze == Maze.Name)
					{
						Point from = new Point(BlockCoord.X * 25 + Offset.X + 12, BlockCoord.Y * 25 + Offset.Y + 12);
						Point to = new Point(target.Coordinate.X * 25 + Offset.X + 12, target.Coordinate.Y * 25 + Offset.Y + 12);
						SpriteBatch.DrawLine(from, to, Color.Red);
						SpriteBatch.DrawRectangle(new Rectangle(target.Coordinate.X * 25 + Offset.X, target.Coordinate.Y * 25 + Offset.Y, 25, 25), Color.Red);
					}
				}
			}


			#region Display zones
			/*
			if (DisplayZonesBox.Checked)
			{

				foreach (MazeZone zone in Maze.Zones)
				{
					Rectangle rect = new Rectangle(zone.Rectangle.X * 25, zone.Rectangle.Y * 25, zone.Rectangle.Width * 25, zone.Rectangle.Height * 25);
					Color color = Color.FromArgb(100, Color.Red);

					if (CurrentZone == zone)
					{
						color = Color.FromArgb(100, Color.Red);
						SpriteBatch.DrawRectangle(rect, Color.White);
					}

					SpriteBatch.FillRectangle(rect, color);
				}


				if (CurrentZone != null)
				{
					Rectangle rect = new Rectangle(CurrentZone.Rectangle.X * 25, CurrentZone.Rectangle.Y * 25, CurrentZone.Rectangle.Width * 25, CurrentZone.Rectangle.Height * 25);
					SpriteBatch.FillRectangle(rect, Color.FromArgb(128, Color.Blue));
				}
			}
*/
			#endregion


			SpriteBatch.End();
			glControl.SwapBuffers();
		}


		#region Events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MazePropertiesBox_Click(object sender, EventArgs e)
		{
			MazePropertiesForm form = new MazePropertiesForm(Maze);
			form.ShowDialog();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToggleStripButtons(object sender, EventArgs e)
		{
			ToolStripButton button = sender as ToolStripButton;

			if (button.Checked)
				UncheckButtons(button);
		}


		/// <summary>
		/// On form loading
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DungeonForm_Load(object sender, EventArgs e)
		{

			glControl.MakeCurrent();
			Display.Init();

			SpriteBatch = new SpriteBatch();


			// Preload background texture resource
			CheckerBoard = new Texture2D(ResourceManager.GetInternalResource("ArcEngine.Resources.checkerboard.png"));
			CheckerBoard.HorizontalWrap = TextureWrapFilter.Repeat;
			CheckerBoard.VerticalWrap = TextureWrapFilter.Repeat;

			// Preload texture resources
			Icons = new TileSet();
			Icons.Texture = new Texture2D(ResourceManager.GetInternalResource("DungeonEye.Forms.data.editor.png"));
			int id = 0;
			for (int y = 0 ; y < Icons.Texture.Size.Height - 50 ; y += 25)
			{
				for (int x = 0 ; x < Icons.Texture.Size.Width ; x += 25)
				{
					Tile tile = Icons.AddTile(id++);
					tile.Rectangle = new Rectangle(x, y, 25, 25);
				}
			}
			Icons.AddTile(100).Rectangle = new Rectangle(0, 245, 6, 11); // alcoves
			Icons.AddTile(101).Rectangle = new Rectangle(6, 248, 11, 6); // alcoves
			Icons.AddTile(102).Rectangle = new Rectangle(17, 243, 10, 13); // wall switch
			Icons.AddTile(103).Rectangle = new Rectangle(27, 246, 13, 10); // wall switch


			RebuildMazeList();

			if (Dungeon.StartLocation != null && !string.IsNullOrEmpty(Dungeon.StartLocation.Maze) && MazeListBox.Items.Contains(Dungeon.StartLocation.Maze))
				MazeListBox.SelectedItem = Dungeon.StartLocation.Maze;
			else if (MazeListBox.Items.Count > 0)
				MazeListBox.SelectedIndex = 0;

			DrawTimer.Start();

		}


		/// <summary>
		/// On mouse down
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GlControl_MouseDown(object sender, MouseEventArgs e)
		{
			LastMousePos = e.Location;

			// No maze
			if (Maze == null)
				return;

			// Get maze coord
			Point coord = new Point((e.Location.X - Offset.X) / 25, (e.Location.Y - Offset.Y) / 25);
			if (!Maze.Contains(coord))
				return;

			// Get the corresponding square
			Square block = Maze.GetSquare(coord);

			#region Middle button
			if (e.Button == MouseButtons.Middle)
			{
				LastMousePos = e.Location;
				Cursor = Cursors.SizeAll;

				return;
			}
			#endregion


			#region Left button
			else if (e.Button == MouseButtons.Left)
			{
				BlockCoord = coord;


				// Add wall
				if (WallBox.Checked)
				{
					if (block.Type == SquareType.Wall)
						EditWallType = SquareType.Illusion;
					else
						EditWallType = SquareType.Wall;

					block.Type = EditWallType;
				}
				else if (NoGhostsBox.Checked)
				{
					block.NoGhost = true;
				}
				else if (NoMonstersBox.Checked)
				{
					block.NoMonster = true;
				}


				#region Zone

				else if (ZoneBox.Checked)
				{
					CurrentZone = new MazeZone();
					CurrentZone.Rectangle = new Rectangle(coord, new Size(1, 1));
				}

				#endregion


				// Select object
				else
				{
					if (PreviewLoc.Coordinate == BlockCoord)
						DragPreview = true;
				}
			}
			#endregion


			#region Right button
			else if (e.Button == MouseButtons.Right)
			{

				if (WallBox.Checked)
				{
					block.Type = SquareType.Ground;
				}
				else if (NoGhostsBox.Checked)
				{
					block.NoGhost = false;
				}
				else if (NoMonstersBox.Checked)
				{
					block.NoMonster = false;
				}
			}
			#endregion

		}




		/// <summary>
		/// On double click edit block informations
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void glControl_DoubleClick(object sender, EventArgs e)
		{
			// No maze or not a double left mouse click
			if (Maze == null)
				return;


			MouseEventArgs arg = e as MouseEventArgs;


			if (arg.Button == MouseButtons.Left)
			{

				// Get mouse coordinate
				Point pos = glControl.PointToClient(MousePosition);
				pos = new Point((pos.X - Offset.X) / 25, (pos.Y - Offset.Y) / 25);
				if (!Maze.Contains(pos))
					return;

				Square square = Maze.GetSquare(pos);
				if (square == null)
					return;

				// Edit square
				EditSquare(Maze.GetSquare(pos), false);
			}
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GlControl_MouseMove(object sender, MouseEventArgs e)
		{

			if (Maze == null)
				return;

			BlockCoord = new Point((e.Location.X - Offset.X) / 25, (e.Location.Y - Offset.Y) / 25);
			SquareUnderMouse = Maze.GetSquare(BlockCoord);



			// If scrolling with the middle mouse button
			if (e.Button == MouseButtons.Middle)
			{
				// Smooth the value
				Offset.X -= (LastMousePos.X - e.X) * 2;
				Offset.Y -= (LastMousePos.Y - e.Y) * 2;


				// Store last mouse location
				LastMousePos = e.Location;

				return;
			}

			else if (e.Button == MouseButtons.Left)
			{
				if (WallBox.Checked)
				{
					SquareUnderMouse.Type = EditWallType;
					return;
				}
				else if (NoGhostsBox.Checked)
				{
					SquareUnderMouse.NoGhost = true;
				}
				else if (NoMonstersBox.Checked)
				{
					SquareUnderMouse.NoMonster = true;
				}
				else if (ZoneBox.Checked)
				{
					CurrentZone.Rectangle = new Rectangle(CurrentZone.Rectangle.Location,
						new Size(BlockCoord.X - CurrentZone.Rectangle.Left + 1, BlockCoord.Y - CurrentZone.Rectangle.Top + 1));
				}


				if (DragPreview)
				{
					PreviewLoc.Coordinate = BlockCoord;
				}
			}

			else if (e.Button == MouseButtons.Right)
			{
				if (WallBox.Checked)
				{
					SquareUnderMouse.Type = SquareType.Ground;
				}
				else if (NoGhostsBox.Checked)
				{
					SquareUnderMouse.NoGhost = false;
				}
				else if (NoMonstersBox.Checked)
				{
					SquareUnderMouse.NoMonster = false;
				}
			}


			// Debug
			SquareCoordBox.Text = new Point((e.Location.X - Offset.X) / 25, (e.Location.Y - Offset.Y) / 25).ToString();
			SquareDescriptionBox.Text = SquareUnderMouse.ToString();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GlControl_MouseUp(object sender, MouseEventArgs e)
		{

			// Middle button
			if (e.Button == MouseButtons.Middle)
			{
				Cursor = Cursors.Default;
				return;
			}

			// Left mouse button
			else if (e.Button == MouseButtons.Left)
			{
				if (ZoneBox.Checked)
				{
					DungeonEye.Forms.Wizards.NewNameWizard wizard = new DungeonEye.Forms.Wizards.NewNameWizard(string.Empty);
					if (wizard.ShowDialog() == DialogResult.OK)
					{
						CurrentZone.Name = wizard.NewName;
						Maze.Zones.Add(CurrentZone);
						//RebuildZones();
					}
					else
					{
						CurrentZone = null;
					}

					ZoneBox.Checked = false;
				}

				DragPreview = false;
				return;
			}


		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GlControl_Paint(object sender, PaintEventArgs e)
		{
			RenderDungeon();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GlControl_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{

			// Escape unchecks all buttons
			if (e.KeyCode == Keys.Escape)
			{
				UncheckButtons(null);
				CurrentSquare = null;
			}

			else if (e.KeyCode == Keys.Delete)
			{
				if (CurrentSquare != null)
				{
					// Remove actor
					if (CurrentSquare.Actor != null)
						CurrentSquare.Actor = null;
				}
				//   if (ObjectPropertyBox.SelectedObject == null)
				//      return;

				//   //if (ObjectPropertyBox.SelectedObject is Monster)
				//   //{
				//   //   Monster monster = ObjectPropertyBox.SelectedObject as Monster;
				//   //   Maze.Monsters.Remove(monster);
				//   //}

				//   ObjectPropertyBox.SelectedObject = null;
			}
			else if (e.KeyCode == KeyboardScheme["TurnLeft"])
			{
				PreviewLoc.Direction = Compass.Rotate(PreviewLoc.Direction, CompassRotation.Rotate270);
			}

			// Turn right
			else if (e.KeyCode == KeyboardScheme["TurnRight"])
				PreviewLoc.Direction = Compass.Rotate(PreviewLoc.Direction, CompassRotation.Rotate90);


			// Move forward
			else if (e.KeyCode == KeyboardScheme["MoveForward"])
				PreviewMove(0, -1);


			// Move backward
			else if (e.KeyCode == KeyboardScheme["MoveBackward"])
				PreviewMove(0, 1);


			// Strafe left
			else if (e.KeyCode == KeyboardScheme["StrafeLeft"])
				PreviewMove(-1, 0);

			// Strafe right
			else if (e.KeyCode == KeyboardScheme["StrafeRight"])
				PreviewMove(1, 0);
		}




		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void glControl_MouseClick(object sender, MouseEventArgs e)
		{
			if (Maze == null)
				return;

			// Change selected square
			Point coord = new Point((e.Location.X - Offset.X) / 25, (e.Location.Y - Offset.Y) / 25);

			Square square = null;
			if (Maze.Contains(coord))
				square = Maze.GetSquare(coord);

			if (square == null)
				return;

			#region Left mouse button
			if (e.Button == MouseButtons.Left)
			{
				if (TeleporterBox.Checked)
				{
					square.Actor = new Teleporter(square);
					EditSquare(square, true);
					UncheckButtons(null);
				}
				else if (DoorBox.Checked)
				{
					square.Actor = new Door(square);
					EditSquare(square, true);
					UncheckButtons(null);
				}
				else if (PressurePlateBox.Checked)
				{
					square.Actor = new PressurePlate(square);
					EditSquare(square, true);
					UncheckButtons(null);
				}
				else if (StairBox.Checked)
				{
					square.Actor = new Stair(square);
					EditSquare(square, true);
					UncheckButtons(null);
				}
				else if (PitBox.Checked)
				{
					square.Actor = new Pit(square);
					EditSquare(square, true);
					UncheckButtons(null);
				}
				else if (EventBox.Checked)
				{
					square.Actor = new EventSquare(square);
					EditSquare(square, true);
					UncheckButtons(null);
				}
				else if (AlcoveBox.Checked)
				{
					square.Actor = new AlcoveActor(square);
					EditSquare(square, true);
					UncheckButtons(null);
				}
				else if (SwitchBox.Checked)
				{
					square.Actor = new WallSwitch(square);
					EditSquare(square, true);
					UncheckButtons(null);
				}
				else if (GeneratorBox.Checked)
				{
					square.Actor = new Generator(square);
					EditSquare(square, true);
					UncheckButtons(null);
				}
				else if (LauncherBox.Checked)
				{
					square.Actor = new Launcher(square);
					EditSquare(square, true);
					UncheckButtons(null);
				}
				else if (ForceFieldBox.Checked)
				{
					square.Actor = new ForceField(square);
					EditSquare(square, true);
					UncheckButtons(null);
				}
				else
				{
					CurrentSquare = square;
				}
			}
			#endregion

			#region Right mouse button

			else if (e.Button == MouseButtons.Right)
			{
			}
			#endregion

		}



		/// <summary>
		/// Resize OpenGL controls
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GlControl_Resize(object sender, EventArgs e)
		{
			if (SpriteBatch == null)
				return;


			glControl.MakeCurrent();
			Display.ViewPort = new Rectangle(new Point(), glControl.Size);

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DungeonNoteBox_TextChanged(object sender, EventArgs e)
		{
			if (Dungeon == null)
				return;
			Dungeon.Note = DungeonNoteBox.Text;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MazeListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ChangeMaze(MazeListBox.SelectedItem.ToString());
		}


		/// <summary>
		/// Form closing
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DungeonForm_FormClosed(object sender, FormClosedEventArgs e)
		{

			DrawTimer.Stop();

			if (Dungeon != null)
				Dungeon.Dispose();
			Dungeon = null;

			if (SpriteBatch != null)
				SpriteBatch.Dispose();
			SpriteBatch = null;

			if (Icons != null)
				Icons.Dispose();
			Icons = null;

			if (CheckerBoard != null)
				CheckerBoard.Dispose();
			CheckerBoard = null;
		}


		/// <summary>
		/// Adds a maze
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddMazeButton_Click(object sender, EventArgs e)
		{
			new Wizards.NewMazeWizard(Dungeon).ShowDialog();

			RebuildMazeList();
		}


		/// <summary>
		///  Removes a maze
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RemoveMazeButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Delete current maze ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
				return;

			Dungeon.RemoveMaze(MazeListBox.SelectedItem.ToString());
			RebuildMazeList();


			if (MazeListBox.Items.Count > 0)
				MazeListBox.SelectedIndex = 0;
			else
				Maze = null;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ResetOffsetBox_Click(object sender, EventArgs e)
		{
			Offset = Point.Empty;
		}


		/// <summary>
		/// Draw timer
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DrawTimer_Tick(object sender, EventArgs e)
		{
			DrawTimer.Stop();


			GlControl_Paint(null, null);

			if (GlPreviewControl.Created)
				GlPreviewControl_Paint(null, null);

			DrawTimer.Start();
		}


		/// <summary>
		/// Set the starting point
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void StartLocationMenu_Click(object sender, EventArgs e)
		{
			Dungeon.StartLocation = new DungeonLocation(PreviewLoc);
		}


		#endregion


		#region Preview control events


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GlPreviewControl_Load(object sender, EventArgs e)
		{
			GlPreviewControl.MakeCurrent();
			Display.Init();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GlPreviewControl_Paint(object sender, PaintEventArgs e)
		{
			if (SpriteBatch == null)
				return;

			GlPreviewControl.MakeCurrent();

			Display.ClearBuffers();

			if (Maze == null)
			{
				GlPreviewControl.SwapBuffers();
				return;
			}

			SpriteBatch.Begin();
			Maze.Draw(SpriteBatch, PreviewLoc);
			SpriteBatch.End();

			GlPreviewControl.SwapBuffers();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GlPreviewControl_Resize(object sender, EventArgs e)
		{

			GlPreviewControl.MakeCurrent();
			Display.ViewPort = new Rectangle(new Point(), GlPreviewControl.Size);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ForwardBox_Click(object sender, EventArgs e)
		{
			PreviewMove(0, -1);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TurnLeftBox_Click(object sender, EventArgs e)
		{
			PreviewLoc.Direction = Compass.Rotate(PreviewLoc.Direction, CompassRotation.Rotate270);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void StrafeLeftBox_Click(object sender, EventArgs e)
		{
			PreviewMove(-1, 0);
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BackwardBox_Click(object sender, EventArgs e)
		{
			PreviewMove(0, 1);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TurnRightBox_Click(object sender, EventArgs e)
		{
			PreviewLoc.Direction = Compass.Rotate(PreviewLoc.Direction, CompassRotation.Rotate90);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void StrafeRightBox_Click(object sender, EventArgs e)
		{
			PreviewMove(1, 0);
		}


		#endregion


		#region Misc

		/// <summary>
		/// Rebuild maze list
		/// </summary>
		void RebuildMazeList()
		{
			MazeListBox.BeginUpdate();
			MazeListBox.Items.Clear();

			foreach (Maze maze in Dungeon.MazeList)
				MazeListBox.Items.Add(maze.Name);

			MazeListBox.EndUpdate();

			if (Maze == null)
				return;

			MazeListBox.SelectedItem = Maze.Name;
		}

		#endregion


		#region Dungeon tab events


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		private void StartLocationBox_TargetChanged(object sender, DungeonLocation target)
		{
			if (Dungeon == null)
				return;

			Dungeon.StartLocation = target;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ItemTileSetBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Dungeon == null)
				return;


			Dungeon.ItemTileSetName = (string) ItemTileSetBox.SelectedItem;
			Dungeon.LoadItemTileSet();
		}




		#endregion


		#region Maze tab events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DoorDecoIdBox_ValueChanged(object sender, EventArgs e)
		{
			if (Maze == null)
				return;

			Maze.DoorDeco = (int)DoorDecoIdBox.Value;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FloorPitDecoIdBox_ValueChanged(object sender, EventArgs e)
		{
			if (Maze == null)
				return;

			Maze.FloorPitDeco = (int)FloorPitDecoIdBox.Value;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CeilingDecoIdBox_ValueChanged(object sender, EventArgs e)
		{
			if (Maze == null)
				return;

			Maze.CeilingPitDeco = (int)CeilingDecoIdBox.Value;
		}

	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MazeTab_Enter(object sender, EventArgs e)
		{
			UpdateMazeTab();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DecorationNameBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Maze == null)
				return;

			Maze.DecorationName = (string) DecorationNameBox.SelectedItem;
			Maze.LoadDecoration();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WallTileSetNameBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Maze == null)
				return;

			Maze.WallTilesetName = (string) WallTileSetNameBox.SelectedItem;
			Maze.LoadWallTileSet();
		}

		#endregion


		#region Properties

		/// <summary>
		/// Asset
		/// </summary>
		public override IAsset Asset
		{
			get
			{
				return Dungeon;
			}
		}


		/// <summary>
		/// Dungeon to edit
		/// </summary>
		Dungeon Dungeon;


		/// <summary>
		/// Current maze
		/// </summary>
		Maze Maze;


		/// <summary>
		/// Preview location
		/// </summary>
		DungeonLocation PreviewLoc;


		/// <summary>
		/// Square under the mouse
		/// </summary>
		Square SquareUnderMouse;


		/// <summary>
		/// Maze icons
		/// </summary>
		TileSet Icons;


		/// <summary>
		/// Spritebtach
		/// </summary>
		SpriteBatch SpriteBatch;


		/// <summary>
		/// Draw offset of the map
		/// </summary>
		Point Offset;


		/// <summary>
		/// Last location of the mouse
		/// </summary>
		Point LastMousePos;


		/// <summary>
		/// Background texture
		/// </summary>
		Texture2D CheckerBoard;


		/// <summary>
		/// Location of the mazeblock
		/// </summary>
		Point BlockCoord;


		/// <summary>
		/// Dragging preview position
		/// </summary>
		bool DragPreview;


		/// <summary>
		/// Allow the player to personalize keyboard input shceme
		/// </summary>
		InputScheme KeyboardScheme;


		/// <summary>
		/// Current maze zone
		/// </summary>
		MazeZone CurrentZone;


		/// <summary>
		/// Square currently selected
		/// </summary>
		Square CurrentSquare;


		/// <summary>
		/// Type of wall to paste in edit mode
		/// </summary>
		SquareType EditWallType;


		#endregion

	}
}
