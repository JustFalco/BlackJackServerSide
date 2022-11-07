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
		private PlayerContext _playerContext;

		public PlayerRepository(PlayerContext playerContext)
		{
			_playerContext = playerContext;
			_playerContext.Database.EnsureCreated();
			_playerContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
		}

		public List<Player> getAllPlayers()
		{
			return _playerContext.Players.ToList();
		}

		public void AddPlayerToDB(Player player)
		{
			_playerContext.Players.AddAsync(player);
			_playerContext.SaveChanges();
		}
	}
}
