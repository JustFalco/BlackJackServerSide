using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.DAL.DomainModels;
using DatabaseLayer.Repositories;

namespace GameLibrary.Controllers
{
	public class PlayerController
	{
		private PlayerRepository playerRepository;

		public PlayerController(PlayerRepository repository)
		{
			playerRepository = repository;
		}

		public void UserLogin(string email)
		{
			if (playerRepository.GetPlayerByEmail(email) == null)
			{
				throw new Exception($"user with email {email} not found");
			}
		}

		public void Hit(Player player)
		{
			if (player.GetFirstActiveHand().CanHit())
			{

			}
			throw new NotImplementedException();
		}

		public void Stand(Player player)
		{
			player.GetFirstActiveHand().StandBust();
			throw new NotImplementedException();
		}

		public void Double(Player player)
		{
			throw new NotImplementedException();
		}

		public void Split(Player player)
		{
			throw new NotImplementedException();
		}
	}
}
