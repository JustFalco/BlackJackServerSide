using DatabaseLayer.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseLayer.DAL.Configurations;

public class CardConfiguration : IEntityTypeConfiguration<Card>
{
	public void Configure(EntityTypeBuilder<Card> builder)
    {
        int id = 1;
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
                    CardId = id,
                    ActiveCard = true,
                    CardType = (CardType)type,
                    Value = (CardValue)value,
                    Color = color
                };

                builder.HasData(card);
                id++;
            }

            
        }
    }
}