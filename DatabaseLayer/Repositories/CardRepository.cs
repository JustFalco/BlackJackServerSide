using DatabaseLayer.DAL.Contexts;
using DatabaseLayer.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DatabaseLayer.Repositories;

public class CardRepository : ICardRepository
{
    private readonly PlayerContext _playerContext;

    public CardRepository(PlayerContext playerContext)
    {
        _playerContext = playerContext;
        _playerContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }

    public async Task<IEnumerable<Card>> GetAllAsync()
    {
        var result = _playerContext.Cards
            .AsNoTracking()
            .AsNoTrackingWithIdentityResolution()
            .ToListAsync();
        return await result;
    }
}