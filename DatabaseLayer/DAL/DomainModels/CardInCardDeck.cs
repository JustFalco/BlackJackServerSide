namespace DatabaseLayer.DAL.DomainModels;

public class CardInCardDeck
{
    public int CardId { get; set; }
    public Card Card { get; set; }

    public int CardDeckId { get; set; }
    public CardDeck CardDeck { get; set;}
}