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
using System.Text;
using System.Windows.Forms;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Graphic;
using OpenTK;

namespace DungeonEye.Forms
{
	/// <summary>
	/// Dungeon location control
	/// </summary>
	public partial class DungeonLocationControl : UserControl
	{

		/// <summary>
		/// Constructor
		/// </summary>
		public DungeonLocationControl()
		{
			InitializeComponent();

		}



		/// <summary>
		/// Gets mazeblock location from a coordinate in the control
		/// </summary>
		/// <param name="point">Coordinate in the control</param>
		/// <returns></returns>
		public DungeonLocation GetLocation(Point point)
		{
			DungeonLocation loc = new DungeonLocation(Maze.Name, point);


			return loc;
		}



		#region Form events


		/// <summary>
		/// Form closing
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			DrawTimer.Stop();

            if (Batch != null)
                Batch.Dispose();
            Batch = null;

			if (Icons != null)
				Icons.Dispose();
			Icons = null;

			if (CheckerBoard != null)
				CheckerBoard.Dispose();
			CheckerBoard = null;

		}



		/// <summary>
		/// Form loading
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GlControlBox_Load(object sender, EventArgs e)
		{
			if (DesignMode)
				return;

			GlControlBox.MakeCurrent();
			Display.Init();

			// Spritebatch
            Batch = new SpriteBatch();

			// Preload background texture resource
			CheckerBoard = new Texture2D(ResourceManager.GetInternalResource("ArcEngine.Resources.checkerboard.png"));
			CheckerBoard.HorizontalWrap = TextureWrapFilter.Repeat;
			CheckerBoard.VerticalWrap = TextureWrapFilter.Repeat;


			// Preload texture resources
			Icons = new TileSet();
			Icons.Texture = new Texture2D(ResourceManager.GetInternalResource("DungeonEye.Forms.data.editor.png"));

			int id = 0;
			for (int y = 0; y < Icons.Texture.Size.Height - 50; y += 25)
			{
				for (int x = 0; x < Icons.Texture.Size.Width; x += 25)
				{
					Tile tile = Icons.AddTile(id++);
					tile.Rectangle = new Rectangle(x, y, 25, 25);
				}
			}
			Icons.AddTile(100).Rectangle = new Rectangle(0, 245, 6, 11); // alcoves
			Icons.AddTile(101).Rectangle = new Rectangle(6, 248, 11, 6); // alcoves


			ParentForm.FormClosing += new FormClosingEventHandler(ParentForm_FormClosing);
			DrawTimer.Start();
	
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GlControl_Resize(object sender, EventArgs e)
		{
			if (DesignMode)
				return;

			GlControlBox.MakeCurrent();
			Display.ViewPort = new Rectangle(new Point(), GlControlBox.Size);
		}



		/// <summary>
		/// Draws the maze
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GlControl_Paint(object sender, PaintEventArgs e)
		{
			if (DesignMode)
				return;

			GlControlBox.MakeCurrent();
			Display.ClearBuffers();

            Batch.Begin();

			// Background texture
            Rectangle dst = new Rectangle(Point.Empty, GlControlBox.Size);
            Batch.Draw(CheckerBoard, dst, dst, Color.White);


			if (Maze != null)
			{

				// Blocks
				for (int y = 0; y < Maze.Size.Height; y++)
				{
					for (int x = 0; x < Maze.Size.Width; x++)
					{
						Square block = Maze.GetSquare(new Point(x, y));
						Point location = new Point(x, y);
						Color color = Color.White;
						if (block.Type == SquareType.Illusion)
							color = Color.LightGreen;

						Batch.DrawTile(Icons, block.Type == SquareType.Ground ? 1 : 0, new Point(Offset.X + x * 25, Offset.Y + y * 25));

						if (block.ItemCount > 0)
						{
							Batch.DrawTile(Icons, 19, new Point(Offset.X + x * 25, Offset.Y + y * 25));
						}


						if (block.Actor != null)
						{
							// Doors
							if (block.Actor is Door)
							{
								Door door = block.Actor as Door;

								int tileid = 0;

								if (Maze.IsDoorNorthSouth(location))
									tileid = 3;
								else
									tileid = 2;


								// Door opened or closed
								if (door.State == DoorState.Broken || door.State == DoorState.Opened || door.State == DoorState.Opening)
									tileid += 2;

								Batch.DrawTile(Icons, tileid, new Point(Offset.X + x * 25, Offset.Y + y * 25));
							}


							if (block.Actor is PressurePlate)
							{
								Batch.DrawTile(Icons, 18, new Point(Offset.X + x * 25, Offset.Y + y * 25));
							}

							if (block.Actor is Pit)
							{
								Batch.DrawTile(Icons, 19, new Point(Offset.X + x * 25, Offset.Y + y * 25));
							}

							if (block.Actor is Teleporter)
							{
								Batch.DrawTile(Icons, 11, new Point(Offset.X + x * 25, Offset.Y + y * 25));
							}

							if (block.Actor is ForceField)
							{
								ForceField field = block.Actor as ForceField;

								int id;
								if (field.Type == ForceFieldType.Spin)
									id = 12;
								else if (field.Type == ForceFieldType.Move)
								{
									id = 13 + (int) field.Direction;
								}
								else
									id = 17;

								Batch.DrawTile(Icons, id, new Point(Offset.X + x * 25, Offset.Y + y * 25));
							}


							if (block.Actor is Stair)
							{
								Stair stair = block.Actor as Stair;
								Batch.DrawTile(Icons, stair.Type == StairType.Up ? 6 : 7, new Point(Offset.X + x * 25, Offset.Y + y * 25));
							}
/*
							// Alcoves
							if (block.HasAlcoves)
							{
								// Alcoves coords
								Point[] alcoves = new Point[]
								{
									new Point(7, 0),
									new Point(7, 19),
									new Point(0, 7),
									new Point(19, 7),
								};


								foreach (CardinalPoint side in Enum.GetValues(typeof(CardinalPoint)))
								{
									if (block.HasAlcove(side))
									{
										Batch.DrawTile(Icons, 100 + ((int) side > 1 ? 0 : 1),
											new Point(Offset.X + x * 25 + alcoves[(int) side].X,
												Offset.Y + y * 25 + alcoves[(int) side].Y));

									}
								}
							}
*/
						}


						// Draw monsters
						if (block.HasMonster)
						{
							Batch.DrawTile(Icons, 8, new Point(Offset.X + location.X * 25, Offset.Y + location.Y * 25));
						}


					}
				}


				// Target
				if (Target.Maze == Maze.Name)
					Batch.DrawRectangle(new Rectangle(Offset.X + Target.Coordinate.X * 25, Offset.Y + Target.Coordinate.Y * 25, 25, 25), Color.White);

			}

            Batch.End();
			GlControlBox.SwapBuffers();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GlControlBox_DoubleClick(object sender, EventArgs e)
		{

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GlControlBox_MouseUp(object sender, MouseEventArgs e)
		{

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

			DrawTimer.Start();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GlControlBox_MouseMove(object sender, MouseEventArgs e)
		{
			BlockUnderMouse = new Point((e.Location.X - Offset.X) / 25, (e.Location.Y - Offset.Y) / 25);
		}



		#endregion



		#region Properties


		/// <summary>
		/// Dungeon
		/// </summary>
		public Dungeon Dungeon
		{
			get;
			set;
		}


		/// <summary>
		/// Maze to display
		/// </summary>
		public Maze Maze
		{
			get;
			set;
		}


		/// <summary>
		/// Target location
		/// </summary>
		public DungeonLocation Target
		{
			get;
			set;
		}


		/// <summary>
		/// Checkerboard background texture
		/// </summary>
		Texture2D CheckerBoard;


		/// <summary>
		/// Maze icons
		/// </summary>
		TileSet Icons;


		/// <summary>
		/// Draw offset of the map
		/// </summary>
		Point Offset;


		/// <summary>
		/// Last location of the mouse
		/// </summary>
		Point LastMousePos;


        /// <summary>
        /// SpriteBatch
        /// </summary>
        SpriteBatch Batch;


		/// <summary>
		/// Gets the block coordinate under the mouse
		/// </summary>
		public Point BlockUnderMouse
		{
			get;
			private set;
		}

		#endregion

	}
}
