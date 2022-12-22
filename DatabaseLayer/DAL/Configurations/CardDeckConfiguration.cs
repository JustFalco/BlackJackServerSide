using DatabaseLayer.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseLayer.DAL.Configurations;

public class CardDeckConfiguration : IEntityTypeConfiguration<CardDeck>
{
	public void Configure(EntityTypeBuilder<CardDeck> builder)
    {
        CardDeck cardDeck = new CardDeck();

        cardDeck.CardDeckId = 1;

        List<Card> tempCards = new List<Card>();
        int id = 1;

        for (int i = 0; i < 8; i++)
        {
            foreach (Enum type in Enum.GetValues(typeof(CardType)))
            {
                foreach (Enum value in Enum.GetValues(typeof(CardValue)))
                {
                    CardColor color;

                    if ((CardType)type == CardType.SPADES || (CardType)type == CardType.CLUBS)
                    {
                        color = CardColor.BLACK;
                    }
                    else
                    {
                        color = CardColor.RED;
                    }

                    Card card = new Card
                    {
                        Id = id,
                        CardType = (CardType)type,
                        Value = (CardValue)value,
                        Color = color
                    };

                    tempCards.Add(card);
                    id++;

                }


            }
        }


        cardDeck.Cards = tempCards;

        builder.HasData(cardDeck);
    }
}