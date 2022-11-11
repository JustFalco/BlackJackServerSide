using DatabaseLayer.DAL.DomainModels;

namespace DatabaseLayer.Repositories;

public interface IGameRepository
{
    Task SaveGameInDatabase(Game game);
    Game? GetGameFromDatabase(int gameId);
}