using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.DAL.Contexts;
using DatabaseLayer.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DatabaseLayer.Repositories
{
	public class PlayerRepository
	{
		private GameContext _gameContext;

		public PlayerRepository(GameContext playerContext)
		{
			_gameContext = playerContext;
			_gameContext.Database.EnsureCreated();
			_gameContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
		}

		public List<Player> getAllPlayers()
		{
			return _gameContext.Players.ToList();
		}

		public void AddPlayerToDB(Player player)
		{
			_gameContext.Players.AddAsync(player);
			_gameContext.SaveChanges();
		}

		public Player? GetPlayerByEmail(string Email)
		{
			return _gameContext.Players.Where(p => p.Email == Email).First();
		}

	}
}
