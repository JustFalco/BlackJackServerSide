using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.DAL.DomainModels;
using DatabaseLayer.Repositories;

namespace GameLibrary.Controllers
{
	public class GameController
	{

		private GameRepository gameRepository;

		public GameController(GameRepository repository)
		{
			//Eerst met cache praten, dan met repository
			gameRepository = repository;
		}

		public bool CheckIfGameExists(int gameId)
		{
			if (gameRepository.GetGameFromDatabase(gameId) != null)
			{
				return true;
			}

			return false;
		}

		public void ContinueGame()
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
