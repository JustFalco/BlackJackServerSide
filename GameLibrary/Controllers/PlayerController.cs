using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.DAL.DomainModels;
using DatabaseLayer.Repositories;

namespace GameLibrary.Controllers
{
	public class PlayerController : IPlayerController
    {
        private readonly IPlayerRepository _repository;

        public PlayerController(IPlayerRepository repository)
        {
            _repository = repository;
        }

		public void UserLogin(string email)
		{
			if (_repository.GetPlayerByEmail(email) == null)
			{
				throw new Exception($"user with email {email} not found");
			}
		}

        public Player NewPlayer(string email)
        {
            Player player = new Player
            {
                Email = email,
				Name = email
            };

            return player;
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
