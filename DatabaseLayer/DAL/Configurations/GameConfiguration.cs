using DatabaseLayer.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseLayer.DAL.Configurations;

public class GameConfiguration : IEntityTypeConfiguration<Game>
{
	public void Configure(EntityTypeBuilder<Game> builder)
	{
		
	}
}