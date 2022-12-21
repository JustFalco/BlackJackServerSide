using DatabaseLayer.DAL.DomainModels;

namespace GameLibrary.Controllers;

public interface IGameController
{
    Game GetGame(int gameId);
    Task<Game> SaveGame(Game game);
    bool CheckIfGameExists(int gameId);
    void ContinueGame(int gameId);
    Task<Game> NewGame();
    void AddPlayerToGame(Player player, int gameId);
    Game PlayGame(string choice, int gameId);
}