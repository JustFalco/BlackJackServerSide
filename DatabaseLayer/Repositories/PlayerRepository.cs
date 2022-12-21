using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.DAL.Contexts;
using DatabaseLayer.DAL.DomainModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shared.Exeptions;
using Shared.Utils;

namespace DatabaseLayer.Repositories
{
	public class PlayerRepository : IPlayerRepository
    {
		private readonly PlayerContext _playerContext;
        private readonly UserManager<Player> _userManager;

        public PlayerRepository(PlayerContext playerContext, UserManager<Player> userManager)
		{
			_playerContext = playerContext;
            _userManager = userManager;
            playerContext.Database.EnsureCreated();
            _playerContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
		}

		public async Task<IEnumerable<Player>> getAllPlayers()
		{
			return await _playerContext.Players.ToListAsync();
		}

		public async Task<Player> AddPlayerToDB(Player newPlayer)
		{
            if (await GetPlayerByEmail(newPlayer.Email) != null)
            {
                throw new DuplicateObjectInDBExeption($"User with email {newPlayer.Email} already exists");
            }
            
            var result = await _userManager.CreateAsync(newPlayer);
            if (result.Succeeded)
            {
                return newPlayer;
            }
            else
            {
                //TODO geef errors terug
                return null;
            }

        }

		public async Task<Player> GetPlayerByEmail(string email)
		{
            if (!EmailValidator.Validate(email))
            {
                throw new IllegalEmailExeption($"The email {email} is illegal and cannot be used to search for players");
            }
			return _playerContext.Players.Where(p => p.Email == email).FirstOrDefault();
		}

	}
}
