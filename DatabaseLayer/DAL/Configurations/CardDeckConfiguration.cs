using DatabaseLayer.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseLayer.DAL.Configurations;

public class CardDeckConfiguration : IEntityTypeConfiguration<CardDeck>
{
	public void Configure(EntityTypeBuilder<CardDeck> builder)
	{
		builder.HasMany(c => c.Deck);
	}
}