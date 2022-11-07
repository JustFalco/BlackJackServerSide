using DatabaseLayer.DAL.Configurations;
using DatabaseLayer.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DatabaseLayer.DAL.Contexts;

public class PlayerContext : DbContext
{

	private string connectionString = $"Server=localhost;Port=3307;Database=BlackJackPlayer;Uid=root;Pwd=SecretPassword@01;";

	public DbSet<Player> Players { get; set; }

	public PlayerContext()
	{

	}

	public PlayerContext(DbContextOptions<PlayerContext> context) : base(context)
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
		modelBuilder.ApplyConfiguration(new PlayerConfiguration());
	}
}