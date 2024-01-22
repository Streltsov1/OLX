using Microsoft.EntityFrameworkCore;
using OLX.Data.Entities;
namespace OLX.Data
{
    public class OLXDbContext : DbContext
    {
        public DbSet<Announcement> Announcements { get; set; }

        public OLXDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Announcement>().HasData(new[]
            {
                new Announcement() { Id = 1, Title = "iPhone X", Category = "Electronics", City = "Rivne", ContactInformation= "3124324235" , Description = "iPhone X for sale in good condition", Price = 750, SellerName="Mark" },
                new Announcement() { Id = 2, Title = "PowerBall", Category = "Sport",City = "Kiyv",ContactInformation= "3124324235", Price = 45.5M, SellerName="Katya"  },
                new Announcement() { Id = 3, Title = "Nike T-Shirt", Category = "Fashion", City = "Lviv",ContactInformation= "3124324235", Price = 189, SellerName="Oleg"  },
                new Announcement() { Id = 4, Title = "Samsung S23", Category = "Electronics", City = "Kharkiv",ContactInformation= "3124324235", Description = "New samsung s23 phone for sale", Price = 600, SellerName="Boris"},
                new Announcement() { Id = 5, Title = "Air Ball", Category = "Toys & Hobbies", City = "Rivne",ContactInformation= "3124324235", Price = 50, SellerName="Max" },
                new Announcement() { Id = 6, Title = "MacBook Pro 2019", Category = "Electronics", City = "Kiyv",ContactInformation= "3124324235", Description = "Used macbook pro 2019 for sale", Price = 1200, SellerName="Anya" }
            });
        }
    }
}
