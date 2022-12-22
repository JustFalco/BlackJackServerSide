using DatabaseLayer.DAL.DomainModels;

namespace GameLibrary.Controllers;

public interface IGameController
{
    Task<Game> GetGame(int gameId);
    Task<Game> SaveGame(Game game);
    bool CheckIfGameExists(int gameId);
    void ContinueGame(int gameId);
    Task<Player> AddPlayerToGame(Player player, Game game);
    Task<Game> PlayGame(string choice, int gameId);
}