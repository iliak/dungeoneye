using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;

namespace DungeonEye.Script.Actions
{
	/// <summary>
	/// 
	/// </summary>
	public class EnableChoice : ActionBase
	{
		/// <summary>
		/// 
		/// </summary>
		public EnableChoice()
		{
			Name = Tag;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override bool Run()
		{


			return true;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="xml"></param>
		/// <returns></returns>
		public override bool Load(XmlNode xml)
		{
			return true;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="writer"></param>
		/// <returns></returns>
		public override bool Save(XmlWriter writer)
		{
			return true;
		}




		#region Properties



		/// <summary>
		/// 
		/// </summary>
		public const string Tag = "EnableChoice";


		#endregion
	}
}
