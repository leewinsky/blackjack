using System;

namespace BlackJackApp
{
	/// <summary>
	/// 
	/// </summary>
	public class CardHand
	{
		public Card[] Cards;
		
		public CardHand( int numCards )
		{
			Cards = new Card[numCards];
			for ( int i=0; i<numCards; i++ )
				Cards[i] = new Card();
		}

		//BlackJack total
		public int Total
		{
			get
			{
				return CalcTotal();
			}
			set
			{
				;
			}
		}

		//BlackJack - Dealer's face up card
		public int Showing
		{
			get
			{
				return Cards[0].Value;
			}
			set
			{
				;
			}
		}

		public bool AddCard( Card c )
		{
			//find next empty spot
			int pos = 0;
			while ( Cards[pos].Value > 0 && pos < Cards.Length )
				pos++;

			if ( pos >= Cards.Length )
				return false;

			Cards[pos].Value = c.Value;
			Cards[pos].Suit = c.Suit;

			return true;
		}
		private int CalcTotal()
		{
			int total = 0;
			for ( int i=0; i<Cards.Length; i++ )
				total += Cards[i].Value;
			if ( total > 21 ) //look for an Ace to convert from 11 to 1
			{
				for ( int i=0; i<Cards.Length; i++ )
				{
					if ( Cards[i].Value == 11 )
					{
						Cards[i].Value = 1;
						break;//only convert the first one we find
					}
				}
				total = 0;
				for ( int i=0; i<Cards.Length; i++ )
					total += Cards[i].Value;
			}
			return total;
		}

	}
}
