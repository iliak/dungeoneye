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
using ArcEngine;
using ArcEngine.Graphic;
using ArcEngine.Input;

namespace DungeonEye.Gui.CampWindows
{
	/// <summary>
	/// Rest party window
	/// </summary>
	public class RestPartyWindow : Window
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public RestPartyWindow(CampDialog camp) 
			: base(camp, "Rest Party :")
		{
			ScreenButton button;
			button = new ScreenButton("Exit", new Rectangle(256, 244, 80, 28));
			button.Selected += new EventHandler(Exit_Selected);
			Buttons.Add(button);


			MessageBox = new MessageBox("Will your healers<br />heals the party ?", MessageBoxButtons.YesNo);
			MessageBox.Selected += new EventHandler(HealAnswer);


			// TODO:
			// Someone is still
			// injured. Rest
			// until healed ?


		}


		#region Events

		/// <summary>
		/// Heals the party answer
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void HealAnswer(object sender, EventArgs e)
		{
			if (((MessageBox) sender).DialogResult == DialogResult.Yes)
				HealParty = true;
			else
				HealParty = false;

			Start = DateTime.Now;
		}

		#endregion



		/// <summary>
		/// 
		/// </summary>
		/// <param name="time"></param>
		public override void Update(GameTime time)
		{
			base.Update(time);

			// No answer, waiting
			if (Start == DateTime.MinValue)
				return;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="batch"></param>
		public override void Draw(SpriteBatch batch)
		{
			base.Draw(batch);

			// No answer, waiting
			if (Start == DateTime.MinValue)
				return;

			Team team = GameScreen.Team;

			// Number of hour sleeping
			int hours = (int)(DateTime.Now - Start).TotalSeconds;

			// Display
			batch.DrawString(GUI.MenuFont, new Point(26, 58), Color.White, "Hours rested : " + hours);

			foreach (Hero hero in team.Heroes)
			{
				if (hero == null)
					continue;

				// Hero can heal some one ?
				if (hero.CanHeal())
				{

					// Find the weakest hero and heal him
					Hero weakest = team.Heroes[0];
					foreach (Hero h in team.Heroes)
					{
						if (h == null)
							continue;

						if (h.HitPoint.Ratio < weakest.HitPoint.Ratio)
							weakest = h;
					}

					if (weakest.HitPoint.Ratio < 1.0f)
					{
						GameMessage.AddMessage(hero.Name + " casts healing on " + weakest.Name);
						hero.Heal(weakest);
					}
				}
			}
		}


		#region Events


		/// <summary>
		/// Exit button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Exit_Selected(object sender, EventArgs e)
		{
			Closing = true;
		}


		#endregion


		#region Properties


		/// <summary>
		/// Start of the rest
		/// </summary>
		DateTime Start;


		/// <summary>
		/// Does healers heals the party
		/// </summary>
		bool HealParty;

		#endregion

	}
}
