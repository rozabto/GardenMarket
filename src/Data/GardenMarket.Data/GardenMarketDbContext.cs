using GardenMarket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Category>().HasData(
        //        new[]
        //        {
        //            new Category
        //            {
        //                Id = 1,
        //                Name = "Flowers"
        //            },
        //            new Category
        //            {
        //                Id = 2,
        //                Name = "Garden"
        //            }
        //        });
        //    modelBuilder.Entity<SubCategory>().HasData(
        //        new[]
        //        {
        //            new SubCategory
        //            {
        //                Id = 1,
        //                CategoryId = 1,
        //                Name = ""
        //            }
        //        });
        //    modelBuilder.Entity<Characteristic>().HasData(
        //        new[]
        //        {
        //            new Characteristic
        //            {
        //                Id = 1,
        //                SubCategoryId = 1,
        //                Name = ""
        //            }
        //        });
        //    modelBuilder.Entity<FlowerType>().HasData(
        //        new[]
        //        {
        //            new FlowerType
        //            {
        //                Id = 1,
        //                CharacteristicId = 1,
        //                Name = ""
        //            }
        //        });
        //    modelBuilder.Entity<Product>().HasData(
        //        new[]
        //        {
        //            new Product
        //            {
        //                Id = 1,
        //                Name = "",
        //                CreatedOn = DateTime.UtcNow,
        //                Description = "",
        //                InStock = 10,
        //                Price = 10,
        //                Sales = 4,
        //                SubCategoryId = 1,
        //                UserId = ""
        //            }
        //        });
        //    modelBuilder.Entity<ProductType>().HasData(
        //        new[]
        //        {
        //            new ProductType
        //            {
        //                Id = 1,
        //                ProductId = 1,
        //                TypeId = 1
        //            }
        //        });
        //    modelBuilder.Entity<Comment>().HasData(
        //        new[]
        //        {
        //            new Comment
        //            {
        //                Id = 1,
        //                Message = "",
        //                Posted = DateTime.UtcNow,
        //                ProductId = 1,
        //                UserId = ""
        //            }
        //        });

        //    //Can be dropped
        //    modelBuilder.Entity<Favorite>().HasData(
        //        new[]
        //        {
        //            new Favorite
        //            {
        //                Id = 1,
        //                IsLicked = true,
        //                ProductId = 1,
        //                UserId = ""
        //            }
        //        });
        //    modelBuilder.Entity<Cart>().HasData(
        //        new[]
        //        {
        //            new Cart
        //            {
        //                Id = 1,
        //                Amount = 3,
        //                ProductId = 1,
        //                UserId = ""
        //            }
        //        });

        //    //Others
        //    modelBuilder.Entity<IdentityRole>().HasData(
        //        new[]
        //        {
        //            new IdentityRole
        //            {
        //                Name = "Admin",
        //                NormalizedName = "ADMIN"
        //            }
        //        });
        //}
    }
}