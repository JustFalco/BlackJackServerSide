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

        int id = 1;

        for (int i = 0; i < 8; i++)
        {
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
                        Id = id,
                        CardType = (CardType)type,
                        Value = (CardValue)value,
                        Color = color
                    };

                    modelBuilder.Entity<Card>().HasData(card);
                    

                    id++;

                }


            }
        }

        modelBuilder.ApplyConfiguration(new PlayerConfiguration());
        modelBuilder.ApplyConfiguration(new HandConfiguration());
        modelBuilder.ApplyConfiguration(new GameConfiguration());
    }
}