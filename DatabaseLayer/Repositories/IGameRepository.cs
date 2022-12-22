using DatabaseLayer.DAL.DomainModels;

namespace DatabaseLayer.Repositories;

public interface IGameRepository
{
    Task<IEnumerable<Card>> GetAllCardsAsync();
    Task<Game> SaveGameInDatabase(Game game);
    Task<Game> GetGameFromDatabase(int gameId);
    Task<Player> AddPlayerToGame(Game game, Player player);
    Card GetRandomCard();
}