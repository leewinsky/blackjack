using System;

namespace BlackJackApp
{
	/// <summary>
	/// Playing Card class
	/// Holds a BlackJack Value and a Suit
	/// </summary>

	public class Card : Object
	{
		private int val;
		private int suit;
		private bool dealt;

		public Card()
		{
			val = 0;
			suit = -1;
			dealt = false;
		}

		public int Value
		{
			get
			{
				return val;
			}
			set
			{
				val = value;
			}
		}

		public int Suit
		{
			get
			{
				return suit;
			}
			set
			{
				suit = value;
			}
		}

		public bool Dealt
		{
			get
			{
				return dealt;
			}
			set
			{
				dealt = value;
			}
		}
	}
}
