using DatabaseLayer.DAL.Contexts;
using DatabaseLayer.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using Shared.Exeptions;

namespace DatabaseLayer.Repositories;

public class GameRepository : IGameRepository
{
	private GameContext _gameContext;
    private DbContextOptions<GameContext> options;

	public GameRepository(GameContext gameContext)
	{
		_gameContext = gameContext;
		_gameContext.Database.EnsureCreated();
		_gameContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
	}

	public async Task SaveGameInDatabase(Game game)
	{
        if (game == null || game.PlayersInGame.Count == 0 || game.Cards == null)
        {
			throw new ArgumentNullException(nameof(game));
        }
		try
		{
			_gameContext.Games.AddAsync(game);
			_gameContext.SaveChanges();
		}
		catch (Exception e)
		{
			Console.WriteLine(e);
			throw;
		}
		
	}

    public Game? GetGameFromDatabase(int gameId)
    {
        Game gameFromDatabase = _gameContext.Games.Where(g => g.GameId == gameId)
            .Include(g => g.Cards)
            .Include(g => g.PlayersInGame)
            .Include(g => g.Cards)
            .ToList().FirstOrDefault();

        if (gameFromDatabase == null)
        {
            throw new NoEntitiesInDatabaseExeption("Could not find game in database");
        }

        return gameFromDatabase;
    }
}