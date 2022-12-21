using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace DatabaseLayer.DAL.DomainModels
{
	public class Player : IdentityUser<int>
    {
        public List<Hand> Hands { get; set; }

		public List<Game> GamesPlayed { get; set; }

		public Player()
		{
			Hands = new List<Hand>();
			Hands.Add(new Hand());
		}

		public Hand? GetFirstActiveHand()
		{
			foreach (Hand hand in Hands)
			{
				if (hand.IsActiveHand)
				{
					return hand;
				}
			}

			return null;
		}

        public override string ToString()
        {
            return "email: " + Email;
        }
    }
}
