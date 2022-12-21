using DatabaseLayer.DAL.Contexts;
using DatabaseLayer.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using Shared.Exeptions;

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

	public async Task<Game> SaveGameInDatabase(Game game)
	{
        if (game == null)
        {
			throw new ArgumentNullException(nameof(game));
        }

        _playerContext.Cards.AsNoTracking().AsNoTrackingWithIdentityResolution();

        _playerContext.Games.Add(game);

        _playerContext.Cards.AsNoTracking().AsNoTrackingWithIdentityResolution();

        await _playerContext.SaveChangesAsync();
        return game;
    }

    public Game? GetGameFromDatabase(int gameId)
    {

        Game gameFromDatabase = null;
        try
        {
            gameFromDatabase = _playerContext.Games.Where(g => g.GameId == gameId)
                .AsNoTracking()
                .Include(g => g.Cards)
                .Include(g => g.PlayersInGame)
                .ToList().FirstOrDefault();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        

        if (gameFromDatabase != null)
        {
            return gameFromDatabase;
        }
        

        throw new ArgumentException("Could not find game in database");
    }
}