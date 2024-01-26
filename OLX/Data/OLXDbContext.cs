using Microsoft.EntityFrameworkCore;
using OLX.Data.Entities;
namespace OLX.Data
{
    public class OLXDbContext : DbContext
    {
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }

        public OLXDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Announcement>()
                .HasOne(x => x.Category)
                .WithMany(x => x.Announcements)
                .HasForeignKey(x => x.CategoryId);
            modelBuilder.Entity<Announcement>().Property(x => x.CategoryId).HasDefaultValue(9);
            modelBuilder.Entity<Announcement>().Property(x => x.ImageUrl).HasDefaultValue("https://th.bing.com/th/id/OIP.gV1cXI_SNBK_nU1yrE_hcwHaGp?w=196&h=180&c=7&r=0&o=5&pid=1.7");
            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category() { Id = 1, Name = "Electronics" },
                new Category() { Id = 2, Name = "Sport" },
                new Category() { Id = 3, Name = "Fashion" },
                new Category() { Id = 4, Name = "Home & Garden" },
                new Category() { Id = 5, Name = "Transport" },
                new Category() { Id = 6, Name = "Toys & Hobbies" },
                new Category() { Id = 7, Name = "Musical Instruments" },
                new Category() { Id = 8, Name = "Art" },
                new Category() { Id = 9, Name = "Other" }
            });
            modelBuilder.Entity<City>().HasData(new[]
            {
                new City() { Id = 1, Name = "Vinnytsia"},
                new City() { Id = 2, Name = "Dnipro"},
                new City() { Id = 3, Name = "Donetsk"},
                new City() { Id = 4, Name = "Zhytomyr"},
                new City() { Id = 5, Name = "Zaporizhzhia"},
                new City() { Id = 6, Name = "Ivano-Frankivsk"},
                new City() { Id = 7, Name = "Kyiv"},
                new City() { Id = 8, Name = "Kropyvnytskyi"},
                new City() { Id = 9, Name = "Luhansk"},
                new City() { Id = 10, Name = "Lutsk"},
                new City() { Id = 11, Name = "Lviv"},
                new City() { Id = 12, Name = "Mykolaiv"},
                new City() { Id = 13, Name = "Odesa"},
                new City() { Id = 14, Name = "Poltava"},
                new City() { Id = 15, Name = "Rivne"},
                new City() { Id = 16, Name = "Sumy"},
                new City() { Id = 17, Name = "Ternopil"},
                new City() { Id = 18, Name = "Uzhgorod"},
                new City() { Id = 19, Name = "Kharkiv"},
                new City() { Id = 20, Name = "Kherson"},
                new City() { Id = 21, Name = "Khmelnytskyi"},
                new City() { Id = 22, Name = "Cherkasy"},
                new City() { Id = 23, Name = "Chernivtsi"},
                new City() { Id = 24, Name = "Chernihiv"},
            });
            modelBuilder.Entity<Announcement>().HasData(new[]
            {
                new Announcement() { Id = 1, Title = "iPhone X", CategoryId = 1, CityId = 15, ContactInformation= "3124324235" , Description = "iPhone X for sale in good condition", Price = 750, SellerName="Mark", ImageUrl="https://th.bing.com/th/id/OIP.3auup9shWZkERJu29Y4uIQHaFj?w=239&h=180&c=7&r=0&o=5&pid=1.7" },
                new Announcement() { Id = 2, Title = "PowerBall", CategoryId = 2,CityId = 7,ContactInformation= "3124324235", Price = 45.5M, SellerName="Katya"  },
                new Announcement() { Id = 3, Title = "Nike T-Shirt", CategoryId = 3, CityId = 11,ContactInformation= "3124324235", Price = 189, SellerName="Oleg"  },
                new Announcement() { Id = 4, Title = "Samsung S23", CategoryId = 1, CityId = 12,ContactInformation= "3124324235", Description = "New samsung s23 phone for sale", Price = 600, SellerName="Boris", ImageUrl="https://th.bing.com/th/id/OIP.qPr57iPly0B_1IhUEyYE6QHaHa?w=162&h=180&c=7&r=0&o=5&pid=1.7"},
                new Announcement() { Id = 5, Title = "Air Ball", CategoryId = 2, CityId = 15,ContactInformation= "3124324235", Price = 50, SellerName="Max" },
                new Announcement() { Id = 6, Title = "MacBook Pro 2019", CategoryId = 1, CityId = 16,ContactInformation= "3124324235", Description = "Used macbook pro 2019 for sale", Price = 1200, SellerName="Anya" }
            });

        }
    }
}
