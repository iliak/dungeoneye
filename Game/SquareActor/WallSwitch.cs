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
using System.Windows.Forms;
using System.Xml;
using ArcEngine.Graphic;
using DungeonEye.Script;


namespace DungeonEye
{
	/// <summary>
	/// Wall switch actor
	/// </summary>
	public class WallSwitch : SquareActor
	{


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="square">Parent square handle</param>
		public WallSwitch(Square square)
			: base(square)
		{
			ActivatedDecoration = -1;
			DeactivatedDecoration = -1;
			Scripts = new List<WallSwitchScript>();
			Reusable = true;
			WasUsed = false;
		}


		/// <summary>
		/// 
		/// </summary>
		public override void Dispose()
		{

			foreach (WallSwitchScript script in Scripts)
				script.Dispose();
			Scripts = null;

			base.Dispose();
		}


		#region Triggers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="location"></param>
		/// <param name="side"></param>
		/// <param name="button"></param>
		/// <returns></returns>
		public override bool OnClick(Point location, CardinalPoint side, MouseButtons button)
		{
			// No wall side or no decoration
			if (side != Side || Square.Maze.Decoration == null)
				return false;

			// Not in the decoration zone
			if (!Square.Maze.Decoration.IsPointInside(IsActivated ? ActivatedDecoration : DeactivatedDecoration, location))
				return false;

			// Switch already used and not reusable
			if ((WasUsed && !Reusable) || !IsEnabled)
			{
				GameMessage.AddMessage("It's already unlocked.", GameColors.Red);
				return true;
			}

			// Does an item is required ?
			if (!string.IsNullOrEmpty(NeededItem))
			{

				// No item in hand or not the good item
				if (GameScreen.Team.ItemInHand == null || GameScreen.Team.ItemInHand.Name != NeededItem)
				{
					GameMessage.AddMessage("You need a key to open this lock");
					return true;
				}

				// Picklock
				if (GameScreen.Team.ItemInHand.Name == "PickLock")
				{
					// TODO: already unlocked => "It's already unlocked"
					if (PickLock())
					{
						GameMessage.AddMessage("You pick the lock.", GameColors.Green);
					}
					else
					{
						GameMessage.AddMessage("You failed to pick the lock", GameColors.Yellow);
					}

					return true;
				}

				// Consume item
				if (ConsumeItem)
					GameScreen.Team.SetItemInHand(null);
			}

			Toggle();

			return true;
		}


		/// <summary>
		/// Executes scripts
		/// </summary>
		void Run()
		{

			// Execute each scripts
			foreach (WallSwitchScript script in Scripts)
				script.Run();
		}

		#endregion


		#region Actions

		public override void Activate()
		{
			base.Activate();
			Run();
			WasUsed = true;
		}

		/// <summary>
		/// 
		/// </summary>
		public override void Deactivate()
		{
			base.Deactivate();
			Run();
			WasUsed = true;
		}

		#endregion


		/// <summary>
		/// Try to picklock the switch
		/// </summary>
		/// <returns>True if the lockpick succeeded, otherwise false</returns>
		public bool PickLock()
		{
			return false;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="batch"></param>
		/// <param name="field"></param>
		/// <param name="position"></param>
		/// <param name="direction"></param>
		public override void Draw(SpriteBatch batch, ViewField field, ViewFieldPosition position, CardinalPoint direction)
		{
			// Foreach wall side
			foreach (TileDrawing td in DisplayCoordinates.GetWalls(position))
			{
				// Not the good side
				if (Compass.GetDirectionFromView(direction, td.Side) != Side)
					continue;

				DecorationSet decoset = field.Maze.Decoration;
				if (decoset == null)
					return;

				Decoration deco = decoset.GetDecoration(IsActivated ? ActivatedDecoration : DeactivatedDecoration);
				if (deco == null)
					return;

				deco.DrawDecoration(batch, decoset, position, Compass.IsSideFacing(direction, Side));
			}
		}



		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override DungeonLocation[] GetTargets()
		{
			List<DungeonLocation> list = new List<DungeonLocation>();

			foreach (WallSwitchScript script in Scripts)
				if (script.Action != null && script.Action.Target != null)
					list.Add(script.Action.Target);

			return list.ToArray();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("WallSwitch : Facing " + Side.ToString() + " - ");

			if (WasUsed)
				sb.Append("used - ");

			sb.Append(Scripts.Count + " script(s) - ");

			if (!string.IsNullOrEmpty(NeededItem))
				sb.Append("Need \"" + NeededItem + "\" - ");

			if (Reusable)
				sb.Append("reusable - ");

			return sb.ToString();
		}


		#region I/O


		/// <summary>
		/// 
		/// </summary>
		/// <param name="node"></param>
		/// <returns></returns>
		public override bool Load(XmlNode xml)
		{
			if (xml == null || xml.Name != Tag)
				return false;

			foreach (XmlNode node in xml)
			{
				switch (node.Name.ToLower())
				{
					case "decoration":
					{
						ActivatedDecoration = int.Parse(node.Attributes["activated"].Value);
						DeactivatedDecoration = int.Parse(node.Attributes["deactivated"].Value);
					}
					break;

					case "consumeitem":
					{
						ConsumeItem = bool.Parse(node.InnerText);
					}
					break;

					case "reusable":
					{
						Reusable = bool.Parse(node.InnerText);
					}
					break;

					case "side":
					{
						Side = (CardinalPoint)Enum.Parse(typeof(CardinalPoint), node.InnerText);
					}
					break;

					case "activateitem":
					{
						NeededItem = node.InnerText;
					}
					break;

					case "picklock":
					{
						LockLevel = int.Parse(node.InnerText);
					}
					break;

					case "scripts":
					{
						foreach (XmlNode sub in node)
						{
							WallSwitchScript script = new WallSwitchScript();
							script.Load(sub);
							Scripts.Add(script);
						}
					}
					break;

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
		/// 
		/// </summary>
		/// <returns></returns>
		public override bool Save(XmlWriter writer)
		{
			if (writer == null)
				return false;


			writer.WriteStartElement(Tag);

			writer.WriteAttributeString("side", Side.ToString());
			writer.WriteAttributeString("reusable", Reusable.ToString());
			writer.WriteAttributeString("activateitem", NeededItem);
			writer.WriteAttributeString("consumeitem", ConsumeItem.ToString());
			writer.WriteAttributeString("picklock", LockLevel.ToString());
			writer.WriteAttributeString("activated", ActivatedDecoration.ToString());
			writer.WriteAttributeString("deactivated", DeactivatedDecoration.ToString());

			if (Scripts.Count > 0)
			{
				writer.WriteStartElement("scripts");
				foreach (WallSwitchScript script in Scripts)
					script.Save(writer);
				writer.WriteEndElement();
			}


			base.Save(writer);

			writer.WriteEndElement();

			return true;
		}



		#endregion



		#region Properties

		/// <summary>
		/// 
		/// </summary>
		public const string Tag = "wallswitch";


		/// <summary>
		/// Defines if the switch can be used repeatedly. 
		/// Otherwise, after one use, the switch will no longer function.
		/// </summary>
		public bool Reusable
		{
			get;
			set;
		}


		/// <summary>
		/// Switch is already used
		/// </summary>
		public bool WasUsed
		{
			get;
			set;
		}


		/// <summary>
		/// Activated decoration id
		/// </summary>
		public int ActivatedDecoration
		{
			get;
			set;
		}


		/// <summary>
		/// Deactivated decoration id
		/// </summary>
		public int DeactivatedDecoration
		{
			get;
			set;
		}


		/// <summary>
		/// Item needed to activate the switch
		/// </summary>
		public string NeededItem
		{
			get;
			set;
		}


		/// <summary>
		/// Consume item on use
		/// </summary>
		public bool ConsumeItem
		{
			get;
			set;
		}


		/// <summary>
		/// Wall side
		/// </summary>
		public CardinalPoint Side
		{
			get;
			set;
		}


		/// <summary>
		/// Pick lock level required to unlock the switch
		/// </summary>
		public int LockLevel
		{
			get;
			set;
		}


		/// <summary>
		/// List of scripts
		/// </summary>
		public List<WallSwitchScript> Scripts
		{
			get;
			private set;
		}


		#endregion
	}
}
