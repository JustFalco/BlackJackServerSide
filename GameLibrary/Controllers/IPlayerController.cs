using DatabaseLayer.DAL.DomainModels;

namespace GameLibrary.Controllers;

public interface IPlayerController
{
    void UserLogin(string email);
    Player NewPlayer(string email);
    void Hit(Player player);
    void Stand(Player player);
    void Double(Player player);
    void Split(Player player);
}