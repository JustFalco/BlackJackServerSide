using DatabaseLayer.DAL.Contexts;
using DatabaseLayer.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using Shared.Exeptions;
using System;

namespace DatabaseLayer.Repositories;

public class GameRepository : IGameRepository
{
    private readonly PlayerContext _playerContext;

    public GameRepository(PlayerContext playerContext)
	{
        _playerContext = playerContext;
        _playerContext.Database.EnsureCreated();
        _playerContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }

    public async Task<IEnumerable<Card>> GetAllCardsAsync()
    {
        var result = _playerContext.Cards
            .ToListAsync();
        return await result;
    }

    public async Task<Game> SaveGameInDatabase(Game game)
	{
        if (game == null)
        {
			throw new ArgumentNullException(nameof(game));
        }

        if (_playerContext.Games.Count(g => g.GameId == game.GameId) == 0)
        {
            _playerContext.Games.Add(game);
        }

        await _playerContext.SaveChangesAsync();

        return game;
    }

    public async Task<Game> GetGameFromDatabase(int gameId)
    {
        try
        {
            var result = await _playerContext.Games.Where(g => g.GameId == gameId)
                .Include(game => game.PlayersInGame)
                .AsNoTracking()
                .AsNoTrackingWithIdentityResolution()
                .ToListAsync();

            if (result.Count == 0 || result.Count > 2)
            {
                throw new ArgumentException("Could not find game in database");
            }

            return result.First();

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }


    public async Task<Player> AddPlayerToGame(Game game, Player player)
    {
        game.PlayersInGame.Add(player);

        await _playerContext.SaveChangesAsync();
        return player;
    }

    public Card GetRandomCard()
    {
        Random numGen = new Random();
        int min = _playerContext.Cards.OrderBy(c => c.Id).First().Id;
        int max = _playerContext.Cards.OrderBy(c => c.Id).Last().Id;

        return _playerContext.Cards.Where(c => c.Id == numGen.NextInt64(min, max)).First();

    }

}