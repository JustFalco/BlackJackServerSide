using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace DatabaseLayer.DAL.DomainModels
{
	public class Player : IdentityUser<int>
    {
		[NotMapped]
        public List<Hand> Hands { get; set; }

		[JsonIgnore]
		public List<Game> GamesPlayed { get; set; }

		[JsonIgnore]
        public override string? ConcurrencyStamp { get; set; }

		[JsonIgnore]
        public override bool EmailConfirmed { get; set; }

		[JsonIgnore]
        public override string? NormalizedEmail { get; set; }

		[JsonIgnore]
        public override int AccessFailedCount { get; set; }

		[JsonIgnore]
        public override bool LockoutEnabled { get; set; }

		[JsonIgnore]
        public override DateTimeOffset? LockoutEnd { get; set; }

		[JsonIgnore]
        public override string? NormalizedUserName { get; set; }

		[JsonIgnore]
        public override string? PasswordHash { get; set; }

		[JsonIgnore]
        public override string? PhoneNumber { get; set; }

		[JsonIgnore]
        public override bool PhoneNumberConfirmed { get; set; }

		[JsonIgnore]
        public override string? SecurityStamp { get; set; }

		[JsonIgnore]
        public override bool TwoFactorEnabled { get; set; }

		public double Balance { get; set; }

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

        public void Reset()
        {
            Hands = new List<Hand>();
            Hands.Add(new Hand());
        }
    }
}
