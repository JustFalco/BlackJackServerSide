using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.DAL.Contexts;
using DatabaseLayer.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using Shared.Exeptions;
using Shared.Utils;

namespace DatabaseLayer.Repositories
{
	public class PlayerRepository : IPlayerRepository
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
            if (string.IsNullOrEmpty(player.Email) || string.IsNullOrEmpty(player.Name))
            {
                throw new ArgumentNullException("player name and email cannot be empty");
            }
            if (!EmailValidator.Validate(player.Email))
            {
                throw new IllegalEmailExeption($"The email {player.Email} is illegal and cannot be used to search for players");
            }
            if (GetPlayerByEmail(player.Email) != null)
            {
                throw new DuplicateObjectInDBExeption($"User with email {player.Email} already exists");
            }
			_gameContext.Players.AddAsync(player);
			_gameContext.SaveChanges();
		}

		public Player GetPlayerByEmail(string email)
		{
            if (!EmailValidator.Validate(email))
            {
                throw new IllegalEmailExeption($"The email {email} is illegal and cannot be used to search for players");
            }
			return _gameContext.Players.Where(p => p.Email == email).FirstOrDefault();
		}

	}
}
