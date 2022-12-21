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
        private readonly ICardRepository _cardRepository;
        private readonly ICardDeckRepository _cardDeckRepository;


        public GameController(IGameRepository gameRepository, IMemoryCache cache, IPlayerRepository playerRepository, IPlayerController playerController, ICardRepository cardRepository, ICardDeckRepository cardDeckRepository)
        {
            //Eerst met cache praten, dan met gameRepository
            _gameRepository = gameRepository;
            _cache = cache;
            _playerRepository = playerRepository;
            _playerController = playerController;
            _cardRepository = cardRepository;
            _cardDeckRepository = cardDeckRepository;
        }

        public Game GetGame(int gameId)
        {
            //TODO ik voorzie problemen met het ophalen van een game op basis van gameid ivb met het fijt dat gameid automatisch aangemaakt wordt
            Game game = null;

            if (_cache.TryGetValue(gameId, out game))
            {
                return game;
            }

            try
            {
                game = _gameRepository.GetGameFromDatabase(gameId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            

            if (game == null)
            {
                throw new ArgumentException("Game is null");
            }
            
            return game;
        }

        public async Task<Game> SaveGame(Game game)
        {
            try
            {
                /*_cache.Set(game.GameId, game);*/
                var result = await _gameRepository.SaveGameInDatabase(game);
                Console.WriteLine("Saving game");
                if (result != null)
                {
                    return result;
                }

                throw new Exception("Game not saved");
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

		public async Task<Game> NewGame()
		{
            Game game = new Game();
            game.IsActiveGame = true;

            

            List<Card> tempCards = new List<Card>();

            foreach (var c in _cardRepository.GetAllAsync().Result)
            {
                tempCards.Add(c);
            }

            game.Cards.Cards = tempCards;

            game.Cards.ShuffleDeck();
            await _cardDeckRepository.SaveDeck(game.Cards);

            SaveGame(game);
            return game;
        }

		public async void AddPlayerToGame(Player player, int gameId)
        {
            if (player == null)
            {
                throw new NullReferenceException("Cannot find player");
            }

            Game game = GetGame(gameId);
            game.PlayersInGame.Add(player);

            SaveGame(game);
        }

        public Game PlayGame(string choice, int gameId)
        {
            Game game = GetGame(gameId);
            switch (choice)
            {
                case "double":
                    _playerController.Double(game.getCurrentPlayer());
                    break;
                case "split":
                    _playerController.Split(game.getCurrentPlayer());
                    break;
                case "stand":
                    _playerController.Stand(game.getCurrentPlayer());
                    break;
                case "hit":
                    _playerController.Hit(game.getCurrentPlayer());
                    break;
                default:
                    break;
            }
            SaveGame(game);
            return game;
        }
	}
}
