using DatabaseLayer.DAL.Configurations;
using DatabaseLayer.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DatabaseLayer.DAL.Contexts;

public class GameContextInMem : DbContext
{
	public DbSet<Game> Games { get; set; }
	public DbSet<Card> Cards { get; set; }
	public DbSet<CardDeck> CardDecks { get; set; }
	public DbSet<Hand> Hands { get; set; }
	public DbSet<Player> Players { get; set; }

	public GameContextInMem()
	{

	}

	public GameContextInMem(DbContextOptions<GameContextInMem> context) : base(context)
	{

	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		if (!optionsBuilder.IsConfigured)
		{
			optionsBuilder.UseInMemoryDatabase(databaseName: "BlackJackGameDB");
		}
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfiguration(new GameConfiguration());
		modelBuilder.ApplyConfiguration(new CardConfiguration());
		modelBuilder.ApplyConfiguration(new CardDeckConfiguration());
		modelBuilder.ApplyConfiguration(new HandConfiguration());
		modelBuilder.ApplyConfiguration(new PlayerConfiguration());
	}
}