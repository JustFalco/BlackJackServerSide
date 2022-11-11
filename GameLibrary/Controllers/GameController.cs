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
	public class GameController
	{
        private readonly IGameRepository _repository;
        private readonly IMemoryCache _cache;


        public GameController(IGameRepository repository, IMemoryCache cache)
        {
            //Eerst met cache praten, dan met repository
            _repository = repository;
            _cache = cache;
        }

		public bool CheckIfGameExists(int gameId)
		{
			if (_repository.GetGameFromDatabase(gameId) != null)
			{
				return true;
			}

			return false;
		}

		public void ContinueGame(int gameId)
        {
            throw new NotImplementedException();
		}

		public int NewGame()
		{
			return new Game().GameId;
		}

		public void AddPlayerToGame(int gameId, string email)
		{
			
		}
	}
}
