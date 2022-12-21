using DatabaseLayer.DAL.DomainModels;

namespace DatabaseLayer.Repositories;

public interface ICardDeckRepository
{
    Task<CardDeck> SaveDeck(CardDeck cardDeck);
}