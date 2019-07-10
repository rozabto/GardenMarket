using GardenMarket.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GardenMarket.Data
{
    public class GardenMarketDbContext : IdentityDbContext
    {
        public GardenMarketDbContext(DbContextOptions<GardenMarketDbContext> options)
            : base(options) { }

        public GardenMarketDbContext() { }

        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Characteristic> Characteristics { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<FlowerType> FlowerTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
    }
}
