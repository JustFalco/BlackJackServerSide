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

    
}