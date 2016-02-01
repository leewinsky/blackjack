using System;

namespace BlackJackApp
{
	/// <summary>
	/// 
	/// </summary>
	public class BJResults
	{
		public float maxCash;
		public float minCash;
		public int wins;
		public int losses;
		public int pushes;
		public int busts;
		public int myTwentyones;
		public int dealerTwentyones;
		public int movement;

		public BJResults()
		{
			maxCash = 0;
			minCash = 0;
			wins = 0;
			losses = 0;
			pushes = 0;
			busts = 0;
			myTwentyones = 0;
			dealerTwentyones = 0;
			movement = 0;
		}

		public float WinPct
		{
			get
			{
				float ret = (float)wins/(wins+losses);
				return ret;
			}
			set
			{;}
		}

		public int HandsPlayed
		{
			get
			{
				return wins+losses+pushes;
			}
		}
	}
}
