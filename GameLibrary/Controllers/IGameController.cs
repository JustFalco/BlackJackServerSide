using DatabaseLayer.DAL.DomainModels;

namespace GameLibrary.Controllers;

public interface IGameController
{
    Game GetGame(int gameId);
    void SaveGame(Game game);
    bool CheckIfGameExists(int gameId);
    void ContinueGame(int gameId);
    Game NewGame();
    void AddPlayerToGame(int gameId, string email);
}