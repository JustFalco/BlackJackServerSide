using DatabaseLayer.DAL.DomainModels;

namespace DatabaseLayer.Repositories;

public interface IPlayerRepository
{
    List<Player> getAllPlayers();
    void AddPlayerToDB(Player player);
    Player GetPlayerByEmail(string email);
}