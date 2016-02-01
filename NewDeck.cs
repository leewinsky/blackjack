using System;

namespace BlackJackApp
{
	/// <summary>
	/// Creats a fresh deck of 52 cards, ordered by suit and value
	/// </summary>

	public class NewDeck
	{
		public Card[] Cards;
		public NewDeck()
		{
			int index=0;
			Cards = new Card[52];
			for ( int z=0; z<52; z++ )
				Cards[z] = new Card();

			for ( int i=0; i<4; i++ )//Suits
			{
				for ( int j=1; j<14; j++ )//Values
				{
					Cards[index].Suit = i;
					if ( j == 1 )
						Cards[index].Value = 11;
					else if ( j > 10 )
						Cards[index].Value = 10;
					else
						Cards[index].Value = j;
					index++;
				}
			}
		}
	}
}
