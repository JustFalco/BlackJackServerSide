using DatabaseLayer.DAL.Configurations;
using DatabaseLayer.DAL.DomainModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DatabaseLayer.DAL.Contexts;

public class PlayerContext : IdentityDbContext<Player, IdentityRole<int>, int>
{
    private string connectionString = "Server=.; Database=BlackJackUsers; Trusted_Connection=True; trustServerCertificate=true";

    public DbSet<Player> Players { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<CardDeck> CardDecks { get; set; }
    public DbSet<Hand> Hands { get; set; }
    public DbSet<Game> Games { get; set; }

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
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new PlayerConfiguration());
        modelBuilder.ApplyConfiguration(new CardConfiguration());
        modelBuilder.ApplyConfiguration(new CardDeckConfiguration());
        modelBuilder.ApplyConfiguration(new HandConfiguration());
        modelBuilder.ApplyConfiguration(new GameConfiguration());
    }
}