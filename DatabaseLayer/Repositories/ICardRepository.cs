using DatabaseLayer.DAL.DomainModels;

namespace DatabaseLayer.Repositories;

public interface ICardRepository
{
    Task<IEnumerable<Card>> GetAllAsync();
}