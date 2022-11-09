﻿using DatabaseLayer.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseLayer.DAL.Configurations;

public class CardConfiguration : IEntityTypeConfiguration<Card>
{
	public void Configure(EntityTypeBuilder<Card> builder)
	{
		builder.HasMany(c => c.CardInDecks);
		builder.HasMany(c => c.CardInHands);
	}
}