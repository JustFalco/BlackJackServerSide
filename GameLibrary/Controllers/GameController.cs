using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.DAL.DomainModels;
using DatabaseLayer.Repositories;
using Microsoft.Extensions.Caching.Memory;

namespace GameLibrary.Controllers
{
	public class GameController : IGameController
    {
        private readonly IGameRepository _gameRepository;
        private readonly IMemoryCache _cache;
        private readonly IPlayerRepository _playerRepository;
        private readonly IPlayerController _playerController;


        public GameController(IGameRepository gameRepository, IMemoryCache cache, IPlayerRepository playerRepository, IPlayerController playerController)
        {
            //Eerst met cache praten, dan met gameRepository
            _gameRepository = gameRepository;
            _cache = cache;
            _playerRepository = playerRepository;
            _playerController = playerController;
        }

        public Game GetGame(int gameId)
        {
            //TODO ik voorzie problemen met het ophalen van een game op basis van gameid ivb met het fijt dat gameid automatisch aangemaakt wordt
            Game game = null;

            if (_cache.TryGetValue(gameId, out game))
            {
                return game;
            }
            
            game = _gameRepository.GetGameFromDatabase(gameId);

            if (game == null)
            {
                throw new NullReferenceException("Game is null");
            }
            
            return game;
        }

        public void SaveGame(Game game)
        {
            try
            {
                _cache.Set(game.GameId, game);
                _gameRepository.SaveGameInDatabase(game);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

		public bool CheckIfGameExists(int gameId)
		{
			if (_gameRepository.GetGameFromDatabase(gameId) != null)
			{
				return true;
			}

			return false;
		}

		public void ContinueGame(int gameId)
        {
            throw new NotImplementedException();
		}

		public Game NewGame()
		{
            Game game = new Game();
            game.IsActiveGame = true;
            SaveGame(game);
            return game;
        }

		public void AddPlayerToGame(int gameId, string email)
        {
            Player playerToBeAdded = _playerRepository.GetPlayerByEmail(email);

            if (playerToBeAdded == null)
            {
                playerToBeAdded = _playerController.NewPlayer(email);
            }

            Game game = GetGame(gameId);
            game.PlayersInGame.Add(playerToBeAdded);

            SaveGame(game);
        }

        public void PlayGame(int gameId)
        {

        }
	}
}
