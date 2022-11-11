using DatabaseLayer.DAL.Configurations;
using DatabaseLayer.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DatabaseLayer.DAL.Contexts;

public class GameContext : DbContext
{
	private string connectionString = "server=localhost;Port=3307;database=BlackJackGame;user=root;password=SecretPassword@01;";

	public DbSet<Game> Games { get; set; }
	public DbSet<Card> Cards { get; set; }
	public DbSet<CardDeck> CardDecks { get; set; }
	public DbSet<Hand> Hands { get; set; }
	public DbSet<Player> Players { get; set; }


	public GameContext()
	{
		
	}

	public GameContext(DbContextOptions<GameContext> context) : base(context)
	{

	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		if (!optionsBuilder.IsConfigured)
		{
			optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
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