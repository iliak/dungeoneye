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
using System.Drawing;
using System.Text;
using System.Xml;
using ArcEngine.Input;

namespace DungeonEye
{
	/// <summary>
	/// Represents the player's heroes in the dungeon
	/// => rename to Party
	/// </summary>
	public class Team
	{

		/// <summary>
		/// Constructor
		/// </summary>
		public Team()
		{
			TeamSpeed = TimeSpan.FromSeconds(0.15f);

			Heroes = new List<Hero>();
			for (int i = 0; i < 6; i++)
				Heroes.Add(null);
		}


		/// <summary>
		/// Initialize the team
		/// </summary>
		/// <returns>True on success</returns>
		public bool Init()
		{

			// Set initial location
			if (Location == null)
			{
				Location = new DungeonLocation();
				Teleport(GameScreen.Dungeon.StartLocation);
				Location.Direction = GameScreen.Dungeon.StartLocation.Direction;
			}
			else
			{
				Teleport(Location);
			}

			// Select the first hero
			SelectedHero = Heroes[0];

			return true;
		}


		/// <summary>
		/// Disposes resources
		/// </summary>
		public void Dispose()
		{

		}


		/// <summary>
		/// Gets the entity in front the team at a given sqaure position
		/// </summary>
		/// <param name="position">Square position</param>
		/// <returns>Entity handle or null</returns>
		public Entity GetFrontEntity(SquarePosition position)
		{
			// Center position
			if (position == SquarePosition.Center)
				return null;

			int[][] id = new int[][]
			{
				new int[]{2, 2, 1, 1},		// From NW
				new int[]{3, 3, 0, 0},		// From NE
				new int[]{0, 0, 3, 3},		// From SW
				new int[]{1, 1, 2, 2},		// From SE
			};

			SquarePosition pos = (SquarePosition)id[(int)position][(int)Direction];

			return FrontSquare.GetMonster(pos);
		}




		#region IO

		///// <summary>
		///// Loads a team party
		///// </summary>
		///// <param name="filename">File name to load</param>
		///// <returns>True if loaded</returns>
		//public bool LoadParty()
		//{
		//    return true;
		//}


		/// <summary>
		/// Loads a party
		/// </summary>
		/// <param name="filename">Xml data</param>
		/// <returns>True if team successfuly loaded, otherwise false</returns>
		public bool Load(XmlNode xml)
		{
			if (xml == null || xml.Name.ToLower() != "team")
				return false;


			// Clear the team
			for (int i = 0; i < Heroes.Count; i++)
				Heroes[i] = null;


			foreach (XmlNode node in xml)
			{
				if (node.NodeType == XmlNodeType.Comment)
					continue;


				switch (node.Name.ToLower())
				{
					//case "dungeon":
					//{
					//    Dungeon = ResourceManager.CreateAsset<Dungeon>(node.Attributes["name"].Value);
					//    //Dungeon.Team = this;
					//}
					//break;

					case "location":
					{
						Location = new DungeonLocation(node);
					}
					break;


					case "position":
					{
						HeroPosition position = (HeroPosition)Enum.Parse(typeof(HeroPosition), node.Attributes["slot"].Value, true);
						Hero hero = new Hero();
						hero.Load(node.FirstChild);
						AddHero(hero, position);
					}
					break;

					case "message":
					{
						GameMessage.AddMessage(node.Attributes["text"].Value, Color.FromArgb(int.Parse(node.Attributes["A"].Value), int.Parse(node.Attributes["R"].Value), int.Parse(node.Attributes["G"].Value), int.Parse(node.Attributes["B"].Value)));
					}
					break;
				}
			}


			SelectedHero = Heroes[0];
			return true;
		}



		/// <summary>
		/// Saves the party
		/// </summary>
		/// <returns>Xml definition of the team</returns>
		public XmlNode Save()
		{
			StringBuilder sb = new StringBuilder();
			using (XmlWriter writer = XmlWriter.Create(sb))
			{
				writer.WriteStartElement("team");

				Location.Save("location", writer);


				// Save each hero
				foreach (Hero hero in Heroes)
				{
					if (hero != null)
					{
						writer.WriteStartElement("position");
						writer.WriteAttributeString("slot", GetHeroPosition(hero).ToString());
						hero.Save(writer);
						writer.WriteEndElement();
					}
				}


				System.ComponentModel.TypeConverter colorConverter = System.ComponentModel.TypeDescriptor.GetConverter(typeof(Color));
				foreach (ScreenMessage message in GameMessage.Messages)
				{
					writer.WriteStartElement("message");
					writer.WriteAttributeString("text", message.Message);
					writer.WriteAttributeString("R", message.Color.R.ToString());
					writer.WriteAttributeString("G", message.Color.G.ToString());
					writer.WriteAttributeString("B", message.Color.B.ToString());
					writer.WriteAttributeString("A", message.Color.A.ToString());
					writer.WriteEndElement();
				}



				writer.WriteEndElement();
			}

			string xml = sb.ToString();
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(xml);

			return doc.DocumentElement;
		}


		#endregion


		#region Hand management


		/// <summary>
		/// Sets the item in the hand
		/// </summary>
		/// <param name="item">Item handle</param>
		public void SetItemInHand(Item item)
		{
			// Set the item in the hand
			ItemInHand = item;

			// Display a message
			if (ItemInHand != null)
			{
				GameMessage.BuildMessage(2, ItemInHand.GetName());

				// Change cursor
				Mouse.SetTile(item.TileID);
			}
			else
			{
				Mouse.SetTile(0);
			}
		}

		#endregion


		#region Misc


		/// <summary>
		/// Does the Team can see this place
		/// </summary>
		/// <param name="maze">Maze</param>
		/// <param name="location">Place to see</param>
		/// <returns>True if can see the location</returns>
		/// http://tom.cs.byu.edu/~455/3DDDA.pdf
		/// http://www.tar.hu/gamealgorithms/ch22lev1sec1.html
		/// http://www.cse.yorku.ca/~amana/research/grid.pdf
		/// http://www.siggraph.org/education/materials/HyperGraph/scanline/outprims/drawline.htm#dda
		public bool CanSee(Maze maze, Point location)
		{
			Point dist = Point.Empty;

			// Not the same maze
			if (Maze != maze)
				return false;


			Rectangle rect = Rectangle.Empty;
			switch (Location.Direction)
			{
				case CardinalPoint.North:
				{
					if (!new Rectangle(Location.Coordinate.X - 1, Location.Coordinate.Y - 3, 3, 4).Contains(location) &&
						location != new Point(Location.Coordinate.X - 3, Location.Coordinate.Y - 3) &&
						location != new Point(Location.Coordinate.X - 2, Location.Coordinate.Y - 3) &&
						location != new Point(Location.Coordinate.X - 2, Location.Coordinate.Y - 2) &&
						location != new Point(Location.Coordinate.X + 3, Location.Coordinate.Y - 3) &&
						location != new Point(Location.Coordinate.X + 2, Location.Coordinate.Y - 3) &&
						location != new Point(Location.Coordinate.X + 2, Location.Coordinate.Y - 2))
						return false;

					// Is there a wall between the Team and the location
					int dx = location.X - Location.Coordinate.X;
					int dy = location.Y - Location.Coordinate.Y;
					float delta = (float)dy / (float)dx;
					float y = 0;
					for (int pos = Location.Coordinate.Y; pos >= location.Y; pos--)
					{
						if (Maze.GetSquare(new Point(pos, Location.Coordinate.Y + (int)y)).Type == SquareType.Wall)
							return false;

						y += delta;
					}

					return true;
				}

				case CardinalPoint.South:
				{
					if (!new Rectangle(Location.Coordinate.X - 1, Location.Coordinate.Y, 3, 4).Contains(location) &&
						location != new Point(Location.Coordinate.X - 3, Location.Coordinate.Y + 3) &&
						location != new Point(Location.Coordinate.X - 2, Location.Coordinate.Y + 3) &&
						location != new Point(Location.Coordinate.X - 2, Location.Coordinate.Y + 2) &&
						location != new Point(Location.Coordinate.X + 3, Location.Coordinate.Y + 3) &&
						location != new Point(Location.Coordinate.X + 2, Location.Coordinate.Y + 3) &&
						location != new Point(Location.Coordinate.X + 2, Location.Coordinate.Y + 2))
						return false;


					// Is there a wall between the Team and the location
					int dx = location.X - Location.Coordinate.X;
					int dy = location.Y - Location.Coordinate.Y;
					float delta = (float)dy / (float)dx;
					float y = 0;
					for (int pos = Location.Coordinate.Y; pos <= location.Y; pos++)
					{
						if (Maze.GetSquare(new Point(pos, Location.Coordinate.Y + (int)y)).Type == SquareType.Wall)
							return false;

						y += delta;
					}

					return true;
				}

				case CardinalPoint.West:
				{
					if (!new Rectangle(Location.Coordinate.X - 3, Location.Coordinate.Y - 1, 4, 3).Contains(location) &&
						location != new Point(Location.Coordinate.X - 3, Location.Coordinate.Y - 3) &&
						location != new Point(Location.Coordinate.X - 3, Location.Coordinate.Y - 2) &&
						location != new Point(Location.Coordinate.X - 2, Location.Coordinate.Y - 2) &&
						location != new Point(Location.Coordinate.X - 3, Location.Coordinate.Y + 3) &&
						location != new Point(Location.Coordinate.X - 3, Location.Coordinate.Y + 2) &&
						location != new Point(Location.Coordinate.X - 2, Location.Coordinate.Y + 2))
						return false;



					// Is there a wall between the Team and the location
					int dx = location.X - Location.Coordinate.X;
					int dy = location.Y - Location.Coordinate.Y;
					float delta = (float)dy / (float)dx;
					float y = 0;
					for (int pos = Location.Coordinate.X; pos >= location.X; pos--)
					{
						if (Maze.GetSquare(new Point(pos, Location.Coordinate.Y + (int)y)).Type == SquareType.Wall)
							return false;

						y += delta;
					}

					return true;
				}

				case CardinalPoint.East:
				{
					if (!new Rectangle(Location.Coordinate.X, Location.Coordinate.Y - 1, 4, 3).Contains(location) &&
						location != new Point(Location.Coordinate.X + 3, Location.Coordinate.Y - 3) &&
						location != new Point(Location.Coordinate.X + 3, Location.Coordinate.Y - 2) &&
						location != new Point(Location.Coordinate.X + 2, Location.Coordinate.Y - 2) &&
						location != new Point(Location.Coordinate.X + 3, Location.Coordinate.Y + 3) &&
						location != new Point(Location.Coordinate.X + 3, Location.Coordinate.Y + 2) &&
						location != new Point(Location.Coordinate.X + 2, Location.Coordinate.Y + 2))
						return false;

					// Is there a wall between the Team and the location
					int dx = location.X - Location.Coordinate.X;
					int dy = location.Y - Location.Coordinate.Y;
					float delta = (float)dy / (float)dx;
					float y = 0;
					for (int pos = Location.Coordinate.X; pos <= location.X; pos++)
					{
						if (Maze.GetSquare(new Point(pos, Location.Coordinate.Y + (int)y)).Type == SquareType.Wall)
							return false;

						y += delta;
					}

					return true;
				}

			}

			return false;
		}



		/// <summary>
		/// Returns the distance between the Team and a location
		/// </summary>
		/// <param name="location">Location to check</param>
		/// <returns>Distance with the Team</returns>
		public Point Distance(Point location)
		{
			return new Point(location.X - Location.Coordinate.X, location.Y - Location.Coordinate.Y);
		}

		#endregion


		#region Movement


		/// <summary>
		/// Move the team according its facing direction
		/// </summary>
		/// <param name="front">MoveForward / backward offset</param>
		/// <param name="strafe">Left / right offset</param>
		/// <returns>True if move allowed, otherwise false</rereturns>
		public bool Walk(int front, int strafe)
		{

			switch (Location.Direction)
			{
				case CardinalPoint.North:
				return Move(new Point(front, strafe));

				case CardinalPoint.South:
				return Move(new Point(-front, -strafe));

				case CardinalPoint.East:
				return Move(new Point(-strafe, front));

				case CardinalPoint.West:
				return Move(new Point(strafe, -front));
			}


			return false;
		}



		/// <summary>
		/// Move team despite the direction the team is facing
		/// (useful for forcefield)
		/// </summary>
		/// <param name="offset">Direction of the move</param>
		/// <param name="count">Number of square</param>
		public void Offset(CardinalPoint direction, int count)
		{
			Point offset = Point.Empty;

			switch (direction)
			{
				case CardinalPoint.North:
				offset = new Point(0, -1);
				break;
				case CardinalPoint.South:
				offset = new Point(0, 1);
				break;
				case CardinalPoint.West:
				offset = new Point(-1, 0);
				break;
				case CardinalPoint.East:
				offset = new Point(1, 0);
				break;
			}

			Move(offset);
		}


		/// <summary>
		/// Move the team
		/// </summary>
		/// <param name="offset">Step offset</param>
		/// <returns>True if the team moved, or false</returns>
		private bool Move(Point offset)
		{
			// Can't move and force is false
			if (!CanMove)
				return false;

			// Get informations about the destination square
			Point dst = Location.Coordinate;
			dst.Offset(offset);


			// Check all blocking states
			bool state = true;

			// Is blocking
			Square dstsquare = Maze.GetSquare(dst);
			if (dstsquare.IsBlocking)
				state = false;

			// Monsters
			if (dstsquare.MonsterCount > 0)
				state = false;

			// If can't pass through
			if (!state)
			{
				GameMessage.BuildMessage(1);
				return false;
			}


			// Leave the current square
			if (Square != null)
				Square.OnTeamLeave();


			Location.Coordinate.Offset(offset);
			LastMove = DateTime.Now;
			HasMoved = true;

			// Enter the new square
			Square = Maze.GetSquare(Location.Coordinate);
			if (Square != null)
				Square.OnTeamEnter();


			return true;
		}



		/// <summary>
		/// Teleport to a new maze
		/// </summary>
		/// <param name="name">Name of the maze</param>
		/// <returns>True on success</returns>
		public bool Teleport(string name)
		{
			DungeonLocation loc = new DungeonLocation(name, Location.Coordinate);
			return Teleport(loc);
		}


		/// <summary>
		/// Teleports the team into the current dungeon
		/// </summary>
		/// <param name="location">Location in the dungeon</param>
		/// <returns>True if teleportion is ok, or false if M. Spoke failed !</returns>
		public bool Teleport(DungeonLocation location)
		{
			return Teleport(location, GameScreen.Dungeon);
		}


		/// <summary>
		/// Teleport the team to a new location, but don't change direction
		/// </summary>
		/// <param name="location">Location in the dungeon</param>
		/// <returns>True if teleportion is ok, or false if M. Spoke failed !</returns>
		public bool Teleport(DungeonLocation location, Dungeon dungeon)
		{
			if (dungeon == null || location == null)
				return false;

			// Destination maze
			Maze maze = dungeon.GetMaze(location.Maze);
			if (maze == null)
				return false;

			Maze = maze;

			// Leave current square
			if (Square != null)
				Square.OnTeamLeave();

			// Change location
			Location.Coordinate = location.Coordinate;
			Location.Maze = Maze.Name;
			Location.Direction = location.Direction;


			// New block
			Square = Maze.GetSquare(location.Coordinate);

			// Enter new block
			Square.OnTeamEnter();

			return true;
		}


		#endregion


		#region Heroes

		/// <summary>
		/// Make damage to the whole team
		/// </summary>
		/// <param name="damage">Attack roll</param>
		/// <param name="type">Type of saving throw</param>
		/// <param name="difficulty">Difficulty</param>
		public void Damage(Dice damage, SavingThrowType type, int difficulty)
		{
			foreach (Hero hero in Heroes)
				if (hero != null)
					hero.Damage(damage, type, difficulty);
		}

		/*
				/// <summary>
				/// Hit all heroes in the team
				/// </summary>
				/// <param name="damage">Amount of damage</param>
				public void Hit(int damage)
				{
					foreach (Hero hero in Heroes)
					{
						if (hero != null)
							hero.HitPoint.Current -= damage;
					}
				}
		*/

		/// <summary>
		/// Add experience to the whole team
		/// </summary>
		/// <param name="amount">Amount to be distributed among the entire team</param>
		public void AddExperience(int amount)
		{
			if (amount == 0)
				return;

			int value = amount / HeroCount;
			foreach (Hero hero in Heroes)
				if (hero != null)
					hero.AddExperience(value);
		}


		/// <summary>
		/// Returns next hero in the team
		/// </summary>
		/// <returns></returns>
		public Hero GetNextHero()
		{
			int i = 0;
			for (i = 0; i < HeroCount; i++)
			{
				if (Heroes[i] == SelectedHero)
				{
					i++;
					if (i == HeroCount)
						i = 0;

					break;
				}
			}

			return Heroes[i];
		}


		/// <summary>
		/// Returns previous hero
		/// </summary>
		/// <returns></returns>
		public Hero GetPreviousHero()
		{
			int i = 0;
			for (i = 0; i < HeroCount; i++)
			{
				if (Heroes[i] == SelectedHero)
				{
					i--;
					if (i < 0)
						i = HeroCount - 1;

					break;
				}
			}

			return Heroes[i];
		}


		/// <summary>
		/// Returns the position of a hero in the team
		/// </summary>
		/// <param name="hero">Hero handle</param>
		/// <returns>Position of the hero in the team</returns>
		public HeroPosition GetHeroPosition(Hero hero)
		{
			int pos = -1;

			for (int id = 0; id < Heroes.Count; id++)
			{
				if (Heroes[id] == hero)
				{
					pos = id;
					break;
				}
			}

			if (pos == -1)
				throw new ArgumentOutOfRangeException("hero");

			return (HeroPosition)pos;
		}


		/// <summary>
		/// Gets if the hero is in front row
		/// </summary>
		/// <param name="hero">Hero handle</param>
		/// <returns>True if in front line</returns>
		public bool IsHeroInFront(Hero hero)
		{
			return GetHeroFromPosition(HeroPosition.FrontLeft) == hero || GetHeroFromPosition(HeroPosition.FrontRight) == hero;
		}


		/// <summary>
		/// Returns the ground position of a hero
		/// </summary>
		/// <param name="Hero">Hero handle</param>
		/// <returns>Ground position of the hero</returns>
		public SquarePosition GetHeroGroundPosition(Hero Hero)
		{
			SquarePosition groundpos = SquarePosition.Center;


			// Get the hero position in the team
			HeroPosition pos = GetHeroPosition(Hero);


			switch (Location.Direction)
			{
				case CardinalPoint.North:
				{
					if (pos == HeroPosition.FrontLeft)
						groundpos = SquarePosition.NorthWest;
					else if (pos == HeroPosition.FrontRight)
						groundpos = SquarePosition.NorthEast;
					else if (pos == HeroPosition.MiddleLeft || pos == HeroPosition.RearLeft)
						groundpos = SquarePosition.SouthWest;
					else
						groundpos = SquarePosition.SouthEast;
				}
				break;
				case CardinalPoint.East:
				{
					if (pos == HeroPosition.FrontLeft)
						groundpos = SquarePosition.NorthEast;
					else if (pos == HeroPosition.FrontRight)
						groundpos = SquarePosition.SouthEast;
					else if (pos == HeroPosition.MiddleLeft || pos == HeroPosition.RearLeft)
						groundpos = SquarePosition.NorthWest;
					else
						groundpos = SquarePosition.SouthWest;
				}
				break;
				case CardinalPoint.South:
				{
					if (pos == HeroPosition.FrontLeft)
						groundpos = SquarePosition.SouthEast;
					else if (pos == HeroPosition.FrontRight)
						groundpos = SquarePosition.SouthWest;
					else if (pos == HeroPosition.MiddleLeft || pos == HeroPosition.RearLeft)
						groundpos = SquarePosition.NorthEast;
					else
						groundpos = SquarePosition.NorthWest;
				}
				break;
				case CardinalPoint.West:
				{
					if (pos == HeroPosition.FrontLeft)
						groundpos = SquarePosition.SouthWest;
					else if (pos == HeroPosition.FrontRight)
						groundpos = SquarePosition.NorthWest;
					else if (pos == HeroPosition.MiddleLeft || pos == HeroPosition.RearLeft)
						groundpos = SquarePosition.SouthEast;
					else
						groundpos = SquarePosition.NorthEast;
				}
				break;
			}


			return groundpos;
		}


		/// <summary>
		/// Returns the Hero at a given position in the team
		/// </summary>
		/// <param name="pos">Position rank</param>
		/// <returns>Hero handle or null</returns>
		public Hero GetHeroFromPosition(HeroPosition pos)
		{
			return Heroes[(int)pos];
		}


		/// <summary>
		/// Returns the Hero under the mouse location
		/// </summary>
		/// <param name="location">Screen location</param>
		/// <returns>Hero handle or null</returns>
		public Hero GetHeroFromLocation(Point location)
		{

			for (int y = 0; y < 3; y++)
				for (int x = 0; x < 2; x++)
				{
					// find the hero under the location 
					if (new Rectangle(366 + x * 144, 2 + y * 104, 130, 104).Contains(location))
						return Heroes[y * 2 + x];
				}

			return null;
		}



		/// <summary>
		/// Removes a hero from the team
		/// </summary>
		/// <param name="position">Hero's position</param>
		public void DropHero(HeroPosition position)
		{
			Heroes[(int)position] = null;
			ReorderHeroes();
		}


		/// <summary>
		/// Removes a hero from the team
		/// </summary>
		/// <param name="position">Hero's position</param>
		public void DropHero(Hero hero)
		{
			if (hero == null)
				return;

			for (int i = 0; i < Heroes.Count; i++)
			{
				if (Heroes[i] == hero)
				{
					Heroes[i] = null;
					ReorderHeroes();
					return;
				}
			}
		}


		/// <summary>
		/// Adds a hero to the team
		/// </summary>
		/// <param name="hero"></param>
		/// <param name="position"></param>
		public void AddHero(Hero hero, HeroPosition position)
		{
			Heroes[(int)position] = hero;
		}


		/// <summary>
		/// Reorder heroes
		/// </summary>
		public void ReorderHeroes()
		{
			Heroes.RemoveAll(item => item == null);

			while (Heroes.Count < 6)
				Heroes.Add(null);

		}


		#endregion


		#region Properties

		/// <summary>
		/// 
		/// </summary>
		public const string Tag = "Team";


		/// <summary>
		/// If the team moved during the last update
		/// </summary>
		public bool HasMoved
		{
			get;
			private set;
		}


		/// <summary>
		/// Gets if the whole team is dead
		/// </summary>
		public bool IsDead
		{
			get
			{
				foreach (Hero hero in Heroes)
				{
					if (hero != null && !hero.IsDead)
						return false;
				}

				return true;
			}
		}


		/// <summary>
		/// Gets if the whole team is uncounscious
		/// </summary>
		public bool IsUncounscious
		{
			get
			{
				foreach (Hero hero in Heroes)
				{
					if (hero != null && !hero.IsUnconscious)
						return false;
				}

				return true;
			}
		}


		/// <summary>
		/// Does the team can move
		/// </summary>
		public bool CanMove
		{
			get
			{
				if (LastMove + TeamSpeed > DateTime.Now)
					return false;

				return true;
			}
		}


		/// <summary>
		/// Last time the team moved
		/// </summary>
		DateTime LastMove
		{
			get;
			set;
		}


		/// <summary>
		/// Speed of the team.
		/// TODO: Check all heroes and return the slowest one
		/// </summary>
		TimeSpan TeamSpeed
		{
			get;
			set;
		}


		/// <summary>
		/// All heroes in the team
		/// </summary>
		public List<Hero> Heroes
		{
			get;
			private set;
		}


		/// <summary>
		/// Return the currently selected hero
		/// </summary>
		public Hero SelectedHero;


		/// <summary>
		/// Item hold in the hand
		/// </summary>
		public Item ItemInHand
		{
			get;
			private set;
		}


		/// <summary>
		/// Number of heroes in the team
		/// </summary>
		public int HeroCount
		{
			get
			{
				if (Heroes == null)
					return 0;

				int count = 0;
				foreach (Hero hero in Heroes)
				{
					if (hero != null)
						count++;
				}

				return count;
			}
		}


		/// <summary>
		/// Current maze
		/// </summary>
		public Maze Maze
		{
			get;
			private set;
		}


		/// <summary>
		/// Square where the team is
		/// </summary>
		public Square Square
		{
			get;
			private set;
		}


		/// <summary>
		/// Gets the front wall side
		/// </summary>
		public CardinalPoint FrontWallSide
		{
			get
			{
				return Compass.GetOppositeDirection(Direction);
			}
		}


		/// <summary>
		/// Returns the location in front of the team
		/// </summary>
		public DungeonLocation FrontLocation
		{
			get
			{
				DungeonLocation location = new DungeonLocation(Location);

				switch (Location.Direction)
				{
					case CardinalPoint.North:
					location.Coordinate = new Point(Location.Coordinate.X, Location.Coordinate.Y - 1);
					break;
					case CardinalPoint.South:
					location.Coordinate = new Point(Location.Coordinate.X, Location.Coordinate.Y + 1);
					break;
					case CardinalPoint.West:
					location.Coordinate = new Point(Location.Coordinate.X - 1, Location.Coordinate.Y);
					break;
					case CardinalPoint.East:
					location.Coordinate = new Point(Location.Coordinate.X + 1, Location.Coordinate.Y);
					break;
				}

				return location;
			}
		}


		/// <summary>
		/// Returns the Square in front of the team
		/// </summary>
		public Square FrontSquare
		{
			get
			{
				return Maze.GetSquare(FrontLocation.Coordinate);
			}
		}


		/// <summary>
		/// Direction the team is facing
		/// </summary>
		public CardinalPoint Direction
		{
			get
			{
				return Location.Direction;
			}
			set
			{
				Location.Direction = value;
			}
		}


		/// <summary>
		/// Location of the team
		/// </summary>
		public DungeonLocation Location
		{
			get;
			private set;
		}


		#endregion

	}


	#region Enums

	/// <summary>
	/// Position of a Hero in the team
	/// </summary>
	public enum HeroPosition
	{
		/// <summary>
		/// Front left
		/// </summary>
		FrontLeft = 0,

		/// <summary>
		/// Front right
		/// </summary>
		FrontRight = 1,

		/// <summary>
		/// Center left
		/// </summary>
		MiddleLeft = 2,

		/// <summary>
		/// Center right
		/// </summary>
		MiddleRight = 3,

		/// <summary>
		/// Rear left
		/// </summary>
		RearLeft = 4,

		/// <summary>
		/// Rear right
		/// </summary>
		RearRight = 5
	}

	#endregion

}
