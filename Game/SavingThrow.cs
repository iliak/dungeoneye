using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonEye
{
	/// <summary>
	/// Gives the creature's Fortitude, Reflex, and Will save modifiers.
	/// </summary>
	public class SavingThrow
	{
	}






	/// <summary>
	/// The different kinds of saving throws.
	/// </summary>
	/// <remarks>
	/// http://www.12tomidnight.com/d20modernsrd/SavingThrows.php
	/// </remarks>
	public enum SavingThrowType
	{

		/// <summary>
		/// These saves measure the character's ability to stand up to massive physical punishment
		/// or attacks against his or her vitality and health such as poison and paralysis. 
		/// Apply the character's Constitution modifier to his or her Fortitude saving throws.
		/// </summary>
		Fortitude,

		/// <summary>
		/// These saves test the character's ability to dodge massive attacks such as explosions or car wrecks.
		/// (Often, when damage is inevitable, the character gets to make a Reflex save to take only half damage.)
		/// Apply the character's Dexterity modifier to his or her Reflex saving throws.
		/// </summary>
		Reflex,

		/// <summary>
		/// These saves reflect the character's resistance to mental influence and domination as well as to many 
		/// magical effects. Apply the character's Wisdom modifier to his or her Will saving throws.
		/// </summary>
		Will,
	}

}
