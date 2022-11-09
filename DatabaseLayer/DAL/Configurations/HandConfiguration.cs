using DatabaseLayer.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseLayer.DAL.Configurations;

public class HandConfiguration : IEntityTypeConfiguration<Hand>
{
	public void Configure(EntityTypeBuilder<Hand> builder)
	{

	}
}