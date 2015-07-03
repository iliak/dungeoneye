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
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Forms;
using ArcEngine.Graphic;
using ArcEngine.Interface;
using DungeonEye.Script;


namespace DungeonEye.Forms
{
	/// <summary>
	/// Pressure plate control editor
	/// </summary>
	public partial class PressurePlateControl : UserControl
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="pressureplate">Pressure plate handle</param>
		/// <param name="dungeon">Maze maze handle</param>
		public PressurePlateControl(PressurePlate pressureplate, Maze maze)
		{
			if (maze == null)
				throw new ArgumentNullException("maze");

			InitializeComponent();

			ActionBox.Scripts = pressureplate.Scripts;
			ActionBox.Dungeon = maze.Dungeon;

			Maze = maze;
			DecorationSet = maze.Decoration;

			ActorPropertiesBox.Actor = pressureplate;
			PressurePlate = pressureplate;
		}


		/// <summary>
		/// Update user interface
		/// </summary>
		void UpdateUI()
		{
			if (PressurePlate == null)
				return;

			IsHiddenBox.Checked = PressurePlate.IsHidden;
			DecorationIdBox.Value = PressurePlate.DecorationPrimary;
			WasUsedBox.Checked = PressurePlate.WasUsed;
			ReusableBox.Checked = PressurePlate.Reusable;
		}



		/// <summary>
		/// 
		/// </summary>
		void RenderScene()
		{
			VisualBox.MakeCurrent();
			Display.ClearBuffers();

			Batch.Begin();

			// Background
			Batch.DrawTile(Maze.WallTileset, 0, Point.Empty);

			// Draw decoration
			if (DecorationSet != null)
				DecorationSet.Draw(Batch, PressurePlate.DecorationPrimary, ViewFieldPosition.L);

			Batch.End();

			VisualBox.SwapBuffers();
		}


		#region Control events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ReusableBox_CheckedChanged(object sender, EventArgs e)
		{
			if (PressurePlate == null)
				return;

			PressurePlate.Reusable = ReusableBox.Checked;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void VisualBox_Load(object sender, EventArgs e)
		{
			VisualBox.MakeCurrent();
			Display.ViewPort = new Rectangle(Point.Empty, VisualBox.Size);
			Display.RenderState.ClearColor = Color.Black;
			Display.RenderState.Blending = true;
			Display.BlendingFunction(BlendingFactorSource.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ActivatedGLBox_Paint(object sender, PaintEventArgs e)
		{
			RenderScene();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DecorationIdBox_ValueChanged(object sender, EventArgs e)
		{
			if (PressurePlate == null)
				return;

			PressurePlate.DecorationPrimary = (int) DecorationIdBox.Value;
			RenderScene();
		}


	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WasUsedBox_CheckedChanged(object sender, EventArgs e)
		{
			if (PressurePlate == null)
				return;

			PressurePlate.WasUsed = WasUsedBox.Checked;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PressurePlateControl_Load(object sender, EventArgs e)
		{
			ParentForm.FormClosing +=new FormClosingEventHandler(ParentForm_FormClosing);

			Batch = new SpriteBatch();


			UpdateUI();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Batch != null)
				Batch.Dispose();
			Batch = null;

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HiddenBox_CheckedChanged(object sender, EventArgs e)
		{
			if (PressurePlate == null)
				return;

			PressurePlate.IsHidden = IsHiddenBox.Checked;
		}



		#endregion


		#region Properties

		/// <summary>
		/// 
		/// </summary>
		PressurePlate PressurePlate;

		/// <summary>
		/// Spritebatch handle
		/// </summary>
		SpriteBatch Batch;


		/// <summary>
		/// Decoration handle
		/// </summary>
		DecorationSet DecorationSet;


		/// <summary>
		/// 
		/// </summary>
		Maze Maze;


		#endregion

	}
}
