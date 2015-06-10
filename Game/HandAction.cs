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

namespace DungeonEye
{

	/// <summary>
	/// Result of a hand usage
	/// </summary>
	public class HandAction
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="result"></param>
		public HandAction(ActionResult result)
		{
			Result = result;
			Time = DateTime.Now;
		}


		/// <summary>
		/// Gets whether the action is outdated
		/// </summary>
		/// <param name="time"></param>
		/// <param name="length"></param>
		/// <returns></returns>
		public bool IsOutdated(DateTime time, int length)
		{
			return Time + TimeSpan.FromMilliseconds(length) < time;
		}

		#region Properties


		/// <summary>
		/// Time of the action
		/// </summary>
		public DateTime Time
		{
			get;
			private set;
		}

		/// <summary>
		/// Result
		/// </summary>
		public ActionResult Result
		{
			get;
			private set;
		}

		#endregion
	}



	/// <summary>
	/// Result of an action taken by a hero
	/// </summary>
	public enum ActionResult
	{
		/// <summary>
		/// Last action has no report
		/// </summary>
		Ok,

		/// <summary>
		/// Need ammo
		/// </summary>
		NoAmmo,

		/// <summary>
		/// Hero can't reach target
		/// </summary>
		CantReach,
	}


}
