using DatabaseLayer.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseLayer.DAL.Configurations;

internal class PlayerConfiguration : IEntityTypeConfiguration<Player>
{
	public void Configure(EntityTypeBuilder<Player> builder)
	{
		builder.Property(p => p.Name).HasMaxLength(60);
		builder.Property(p => p.Email).IsRequired(true);
		builder.Ignore(p => p.Hands);
	}
}