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
using ArcEngine.Graphic;


namespace DungeonEye
{
	/// <summary>
	/// Base class for square actors
	/// </summary>
	abstract public class SquareActor : IDisposable
	{

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="square">Square handle</param>
		public SquareActor(Square square)
		{
			Square = square;
			IsEnabled = true;
		}


		/// <summary>
		/// 
		/// </summary>
		public virtual void Dispose()
		{
		}


		/// <summary>
		/// Draw the actor
		/// </summary>
		/// <param name="batch">Spritebatch to use</param>
		/// <param name="field">View field</param>
		/// <param name="position">Position in the view field</param>
		/// <param name="view">Looking direction of the team</param>
		public virtual void Draw(SpriteBatch batch, ViewField field, ViewFieldPosition position, CardinalPoint direction)
		{
		}



		/// <summary>
		/// Update the actor
		/// </summary>
		/// <param name="time">Elpased time</param>
		public virtual void Update(GameTime time)
		{
		}


		/// <summary>
		/// Gets a list of all targets
		/// </summary>
		/// <returns>Array of targets</returns>
		public virtual DungeonLocation[] GetTargets()
		{
			return new DungeonLocation[]
			{
			};
		}



		#region Triggers

		/// <summary>
		/// A hero interacted with a side of the square
		/// </summary>
		/// <param name="location">Location of the mouse</param>
		/// <param name="side">Wall side</param>
		/// <returns>True if the event is processed</returns>
		public virtual bool OnClick(Point location, CardinalPoint side, MouseButtons button)
		{
			return false;
		}


		/// <summary>
		/// Fired when the team enters the square
		/// </summary>
		/// <returns>True if event handled</returns>
		public virtual bool OnTeamEnter()
		{
			return false;
		}


		/// <summary>
		/// Fired when the team leaves the square
		/// </summary>
		/// <returns>True if event handled</returns>
		public virtual bool OnTeamLeave()
		{
			return false;
		}


		/// <summary>
		/// Fired when the team stands on a square
		/// </summary>
		/// <returns>True if event handled</returns>
		public virtual bool OnTeamStand()
		{
			return false;
		}


		/// <summary>
		/// Fired when a monster enters the square
		/// </summary>
		/// <param name="monster">Monster handle</param>
		/// <returns>True if event handled</returns>
		public virtual bool OnMonsterEnter(Monster monster)
		{
			return false;
		}


		/// <summary>
		/// Fired when a monster leaves the square
		/// </summary>
		/// <param name="monster">Monster handle</param>
		/// <returns>True if event handled</returns>
		public virtual bool OnMonsterLeave(Monster monster)
		{
			return false;
		}


		/// <summary>
		/// Fired when a monster stands on a square
		/// </summary>
		/// <param name="monster">Monster handle</param>
		/// <returns>True if event handled</returns>
		public virtual bool OnMonsterStand(Monster monster)
		{
			return false;
		}


		/// <summary>
		/// Fired when an item is added to the square
		/// </summary>
		/// <param name="monster">Item handle</param>
		/// <returns>True if event handled</returns>
		public virtual bool OnItemDropped(Item item)
		{
			return false;
		}


		/// <summary>
		/// Fired when an item is removed from the square
		/// </summary>
		/// <param name="monster">Item handle</param>
		/// <returns>True if event handled</returns>
		public virtual bool OnItemCollected(Item item)
		{
			return false;
		}


		#endregion


		#region Actions

		/// <summary>
		/// Enables the actor
		/// </summary>
		public virtual void Enable()
		{
			IsEnabled = true;
		}


		/// <summary>
		/// Disables the actor
		/// </summary>
		public virtual void Disable()
		{
			IsEnabled = false;
		}


		/// <summary>
		/// Activates the actor
		/// </summary>
		public virtual void Activate()
		{
			IsActivated = true;
		}


		/// <summary>
		/// Deactivates the actor
		/// </summary>
		public virtual void Deactivate()
		{
			IsActivated = false;
		}


		/// <summary>
		/// Toggles the actor state
		/// </summary>
		public virtual void Toggle()
		{
			if (IsActivated)
				Deactivate();
			else
				Activate();
		}


		/// <summary>
		/// Exchanges the actor state
		/// </summary>
		public virtual void Exchange()
		{
		}



		/// <summary>
		/// Sets to a state
		/// </summary>
		public virtual void SetTo()
		{
		}


		/// <summary>
		/// Plays a sound
		/// </summary>
		public virtual void PlaySound()
		{
		}


		/// <summary>
		/// Stops a sound
		/// </summary>
		public virtual void StopSound()
		{
		}


		#endregion


		#region IO

		/// <summary>
		/// Loads the door's definition from a bank
		/// </summary>
		/// <param name="node">Xml handle</param>
		/// <returns></returns>
		public virtual bool Load(XmlNode node)
		{
			if (node == null)
				return false;


			switch (node.Name)
			{
				case "isactivated":
				{
					IsActivated = bool.Parse(node.InnerXml);
				}
				break;

				case "isenabled":
				{
					IsEnabled = bool.Parse(node.InnerXml);
				}
				break;

				default:
				{
					Trace.WriteLine("[SquareActor] Load() : Unknown node \"" + node.Name + "\" found @ " + Square.Location.ToString() + ".");
				}
				break;
			}

			return true;
		}



		/// <summary>
		/// Saves the door definition
		/// </summary>
		/// <param name="writer">XML writer handle</param>
		/// <returns></returns>
		public virtual bool Save(XmlWriter writer)
		{
			if (writer == null)
				return false;

			writer.WriteElementString("isactivated", IsActivated.ToString());
			writer.WriteElementString("isenabled", IsEnabled.ToString());

			return true;
		}

		#endregion


		#region Properties

		/// <summary>
		/// Parent square
		/// </summary>
		public Square Square
		{
			get;
			private set;
		}


		/// <summary>
		/// Does the items can pass through
		/// </summary>
		public virtual bool CanPassThrough
		{
			get;
			set;
		}


		/// <summary>
		/// Does the square is blocking for monster or the team
		/// </summary>
		public virtual bool IsBlocking
		{
			get;
			set;
		}


		/// <summary>
		/// Does the square accept items
		/// </summary>
		public bool AcceptItems
		{
			get;
			set;
		}


		/// <summary>
		/// Does the actor is activated
		/// </summary>
		public bool IsActivated
		{
			get;
			set;
		}


		/// <summary>
		/// Does the actor is enabled
		/// </summary>
		public bool IsEnabled
		{
			get;
			set;
		}


		#endregion
	}
}
