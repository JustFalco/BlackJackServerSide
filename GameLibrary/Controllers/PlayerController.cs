using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.DAL.DomainModels;
using DatabaseLayer.Repositories;
using Microsoft.AspNetCore.Identity;
using Shared.DTOs;

namespace GameLibrary.Controllers
{
	public class PlayerController : IPlayerController
    {
        private readonly IPlayerRepository _repository;
        private readonly UserManager<Player> _userManager;
        private readonly SignInManager<Player> _signInManager;
        private readonly IGameRepository _gameRepository;

        public PlayerController(IPlayerRepository repository, UserManager<Player> userManager, SignInManager<Player> signInManager, IGameRepository gameRepository)
        {
            _repository = repository;
            _userManager = userManager;
            _signInManager = signInManager;
            _gameRepository = gameRepository;
        }


        public async Task<Player> NewPlayer(PlayerDTO playerData)
        {
            Player newPlayer = new Player();

			newPlayer.Email = playerData.Email;
            newPlayer.PasswordHash = _userManager.PasswordHasher.HashPassword(newPlayer, playerData.Password);
            newPlayer.UserName = playerData.Email;

            var result = await _repository.AddPlayerToDB(newPlayer);

            return result;
        }

		public void Hit(Player player)
		{
			if (player.GetFirstActiveHand().CanHit())
            {
                player.GetFirstActiveHand().cardsInHand.Add(_gameRepository.GetRandomCard());
            }
        }

		public void Stand(Player player)
		{
			player.GetFirstActiveHand().StandBust();
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
