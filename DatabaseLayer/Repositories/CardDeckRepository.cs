using DatabaseLayer.DAL.Contexts;
using DatabaseLayer.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DatabaseLayer.Repositories;

public class CardDeckRepository : ICardDeckRepository
{
    private readonly PlayerContext _playerContext;

    public CardDeckRepository(PlayerContext playerContext)
    {
        _playerContext = playerContext;
    }

    public async Task<CardDeck> SaveDeck(CardDeck cardDeck)
    {
        _playerContext.CardDecks.Add(cardDeck);
        await _playerContext.SaveChangesAsync();
        return cardDeck;
    }
}