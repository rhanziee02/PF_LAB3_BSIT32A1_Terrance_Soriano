using Microsoft.EntityFrameworkCore;
using PF_LAB3_BSIT32A1_Terrance_Soriano.Models;

namespace PF_LAB3_BSIT32A1_Terrance_Soriano.Data
{
    public class GreedDbContext : DbContext
    {
        public GreedDbContext(DbContextOptions<GreedDbContext> options) : base(options)
        {
        }

        public DbSet<Card> Cards { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Card entity
            modelBuilder.Entity<Card>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Name).IsRequired().HasMaxLength(100);
                entity.Property(c => c.CharacterName).IsRequired().HasMaxLength(100);
                entity.Property(c => c.Description).HasMaxLength(500);
                entity.Property(c => c.SpecialAbility).HasMaxLength(200);
                entity.Property(c => c.CharacterImageUrl).HasMaxLength(255);
                entity.Property(c => c.DateCreated).HasDefaultValueSql("GETDATE()");
                
                // Index for better performance
                entity.HasIndex(c => c.Name);
                entity.HasIndex(c => c.Rarity);
                entity.HasIndex(c => c.CardType);
            });

            // Seed some initial data
            modelBuilder.Entity<Card>().HasData(
                new Card 
                { 
                    Id = 1, 
                    Name = "Gon's Rock", 
                    CharacterName = "Gon Freecss", 
                    Rarity = CardRarity.Common, 
                    CardType = CardType.Attack, 
                    CardNumber = 1, 
                    PowerLevel = 3,
                    Description = "A simple rock throw attack",
                    SpecialAbility = "Can break through basic defenses",
                    DateCreated = DateTime.Now
                },
                new Card 
                { 
                    Id = 2, 
                    Name = "Killua's Lightning", 
                    CharacterName = "Killua Zoldyck", 
                    Rarity = CardRarity.Rare, 
                    CardType = CardType.Magic, 
                    CardNumber = 2, 
                    PowerLevel = 7,
                    Description = "Electricity-based attack",
                    SpecialAbility = "Paralyzes opponent for one turn",
                    DateCreated = DateTime.Now
                },
                new Card 
                { 
                    Id = 3, 
                    Name = "Kurapika's Chain", 
                    CharacterName = "Kurapika", 
                    Rarity = CardRarity.SuperRare, 
                    CardType = CardType.Magic, 
                    CardNumber = 3, 
                    PowerLevel = 8,
                    Description = "Judgment chain ability",
                    SpecialAbility = "Can bind and restrict enemy movement",
                    DateCreated = DateTime.Now
                }
            );
        }
    }
}
