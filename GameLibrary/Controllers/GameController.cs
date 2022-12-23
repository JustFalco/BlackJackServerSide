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

        public async Task<Game> GetGame(int gameId)
        {
            //TODO ik voorzie problemen met het ophalen van een game op basis van gameid ivb met het fijt dat gameid automatisch aangemaakt wordt
            Game game = null;

            if (_cache.TryGetValue(gameId, out game))
            {
                return game;
            }

            try
            {
                game = await _gameRepository.GetGameFromDatabase(gameId);
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
                _cache.Set(game.GameId, game);
                var result = await _gameRepository.SaveGameInDatabase(game);
                Console.WriteLine("Saving game");
                if (result == null)
                {
                    throw new Exception("Game not saved");
                }
                return result;
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


		public async Task<Player> AddPlayerToGame(Player player, Game game)
        {
            return await _gameRepository.AddPlayerToGame(game, player);
        }

        public async Task<Game> DealPlayers(int gameId)
        {
            Game game = await GetGame(gameId);
            foreach (var player in game.PlayersInGame)
            {
                player.Hands.First().cardsInHand.Add(_gameRepository.GetRandomCard());
                player.Hands.First().cardsInHand.Add(_gameRepository.GetRandomCard());
            }

            Player dealer = new Player
            {
                Email = "Dealer",
                UserName = "Dealer"
            };

            dealer.Hands.First().Add(_gameRepository.GetRandomCard());
            Card card = _gameRepository.GetRandomCard();
            card.IsHidden = true;
            dealer.Hands.First().Add(card);

            game.PlayersInGame.Add(dealer);

            SaveGame(game);
            return game;
        }

        public async Task<Game> DealerEndGame(int gameId)
        {
            Game game = await GetGame(gameId);
            Player dealer = game.PlayersInGame.Where(p => p.Email == "Dealer").First();

            if (dealer == null)
            {
                throw new Exception("No dealer found!");
            }

            if (dealer.Hands.First().GetLowestValue() >= 17)
            {
                dealer.Hands.First().StandBust();
            }

            while (dealer.Hands.First().IsActiveHand)
            {
                
                dealer.Hands.First().Add(_gameRepository.GetRandomCard());
                if (dealer.Hands.First().GetLowestValue() >= 17)
                {
                    dealer.Hands.First().StandBust();
                }
            }

            foreach (var c in dealer.Hands.First().cardsInHand)
            {
                c.IsHidden = false;
            }

            await SaveGame(game);
            return game;
        }

        public async Task<Game> PlayGame(string choice, int gameId)
        {
            Game game = await GetGame(gameId);
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
