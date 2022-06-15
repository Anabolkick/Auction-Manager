using System;
using AuctionLibrary;
using Microsoft.EntityFrameworkCore;

namespace Auction_Manager
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<SellRequest> SellRequests { get; set; }
        public DbSet<BuyRequest> BuyRequests { get; set; }

        public AppDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {                        
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=lab_4;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(c => c.SellRequests)
                .WithOne(e => e.Seller);

            modelBuilder.Entity<User>()
                .HasMany(c => c.BuyRequests)
                .WithOne(e => e.Buyer);
        }
    }
}
