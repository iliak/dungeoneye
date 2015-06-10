using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;

namespace DungeonEye.Script.Actions
{
	/// <summary>
	/// Deactivates a target
	/// </summary>
	public class DeactivateTarget : ActionBase
	{

		/// <summary>
		/// 
		/// </summary>
		public DeactivateTarget()
		{
			Name = Tag;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override bool Run()
		{
			if (Target == null)
				return false;

			Square target = Target.GetSquare(GameScreen.Dungeon);
			if (target == null)
				return false;

			if (target.Actor != null && target.Actor.IsActivated)
				target.Actor.Deactivate();

			return true;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string str = "Deactivates target at ";

			if (Target != null)
				str += Target.ToStringShort();

			return str;
		}


		#region IO

		/// <summary>
		/// 
		/// </summary>
		/// <param name="xml"></param>
		/// <returns></returns>
		public override bool Load(XmlNode xml)
		{
			if (xml == null)
				return false;

			foreach (XmlNode node in xml)
			{
				switch (node.Name.ToLower())
				{

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
		/// <param name="writer"></param>
		/// <returns></returns>
		public override bool Save(XmlWriter writer)
		{
			if (writer == null)
				return false;


			writer.WriteStartElement(Name);

			base.Save(writer);

			writer.WriteEndElement();

			return true;
		}

		#endregion


		#region Properties


		/// <summary>
		/// 
		/// </summary>
		public const string Tag = "DeactivateTarget";



		#endregion
	}
}
