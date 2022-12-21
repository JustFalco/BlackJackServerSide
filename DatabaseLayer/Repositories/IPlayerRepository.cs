using DatabaseLayer.DAL.DomainModels;

namespace DatabaseLayer.Repositories;

public interface IPlayerRepository
{
    Task<IEnumerable<Player>> getAllPlayers();
    Task<Player> AddPlayerToDB(Player newPlayer);
    Task<Player> GetPlayerByEmail(string email);
}