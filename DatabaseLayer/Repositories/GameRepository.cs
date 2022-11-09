using DatabaseLayer.DAL.Contexts;
using DatabaseLayer.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DatabaseLayer.Repositories;

public class GameRepository
{
	private GameContext _gameContext;
	private GameContextInMem _inMemGameContext;

	public GameRepository(GameContext gameContext)
	{
		_gameContext = gameContext;
		_gameContext.Database.EnsureCreated();
		_gameContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
	}

	public GameRepository(GameContextInMem gameContext)
	{
		_inMemGameContext = gameContext;
		_gameContext.Database.EnsureCreated();
		_gameContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
	}

	public async void SaveGameInMemory(Game game)
	{
		_inMemGameContext.Games.AddAsync(game);
		_inMemGameContext.SaveChanges();
	}

	public async void SaveGameInDatabase(Game game)
	{
		_gameContext.Games.AddAsync(game);
		_gameContext.SaveChanges();
	}

	public Game? GetGameFromDatabase(int gameId)
	{
		return _gameContext.Games.Where(g => g.GameId == gameId).FirstOrDefault();
	}

	public Game? GetGameFromMemory(int gameId)
	{
		return _inMemGameContext.Games.Where(g => g.GameId == gameId).FirstOrDefault();
	}
}