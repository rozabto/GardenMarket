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

        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Characteristic> Characteristics { get; set; }
        public DbSet<CharacteristicCategory> CharacteristicCategories { get; set; }
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
        //                Name = "Растения"
        //            },
        //            new Category
        //            {
        //                Id = 2,
        //                Name = "Градина"
        //            },
        //            new Category
        //            {
        //                Id = 3,
        //                Name = "Свободно Време"
        //            }
        //        });
        //    modelBuilder.Entity<SubCategory>().HasData(
        //        new[]
        //        {
        //            new SubCategory
        //            {
        //                Id = 1,
        //                CategoryId = 1,
        //                Name = "Цъфтящи растения"
        //            },
        //            new SubCategory
        //            {
        //                Id = 2,
        //                CategoryId = 1,
        //                Name = "Нецъфтящи растения"
        //            },
        //            new SubCategory
        //            {
        //                Id = 3,
        //                CategoryId = 1,
        //                Name = "Насекомоядни растения"
        //            },
        //            new SubCategory
        //            {
        //                Id = 4,
        //                CategoryId = 1,
        //                Name = "Сукуленти"
        //            },
        //            new SubCategory
        //            {
        //                Id = 5,
        //                CategoryId = 1,
        //                Name = "Вечнозелени храсти и дръвчета"
        //            },
        //            new SubCategory
        //            {
        //                Id = 6,
        //                CategoryId = 1,
        //                Name = "Цъфтящи храсти и дръвчета"
        //            },
        //            new SubCategory
        //            {
        //                Id = 7,
        //                CategoryId = 1,
        //                Name = "Водни растения"
        //            },
        //            new SubCategory
        //            {
        //                Id = 8,
        //                CategoryId = 1,
        //                Name = "Бегония"
        //            },
        //            new SubCategory
        //            {
        //                Id = 9,
        //                CategoryId = 1,
        //                Name = "Здравец"
        //            },
        //            new SubCategory
        //            {
        //                Id = 10,
        //                CategoryId = 1,
        //                Name = "Циганче"
        //            },
        //            new SubCategory
        //            {
        //                Id = 11,
        //                CategoryId = 1,
        //                Name = "Функия"
        //            },
        //            new SubCategory
        //            {
        //                Id = 12,
        //                CategoryId = 1,
        //                Name = "Семена"
        //            },
        //            new SubCategory
        //            {
        //                Id = 13,
        //                CategoryId = 1,
        //                Name = "Луковици"
        //            },
        //            new SubCategory
        //            {
        //                Id = 14,
        //                CategoryId = 2,
        //                Name = "Торове"
        //            },
        //            new SubCategory
        //            {
        //                Id = 15,
        //                CategoryId = 2,
        //                Name = "Почви"
        //            },
        //            new SubCategory
        //            {
        //                Id = 16,
        //                CategoryId = 2,
        //                Name = "Тревни смески"
        //            },
        //            new SubCategory
        //            {
        //                Id = 17,
        //                CategoryId = 2,
        //                Name = "Саксии"
        //            },
        //            new SubCategory
        //            {
        //                Id = 18,
        //                CategoryId = 2,
        //                Name = "Вази"
        //            },
        //            new SubCategory
        //            {
        //                Id = 19,
        //                CategoryId = 2,
        //                Name = "Кашпи"
        //            },
        //            new SubCategory
        //            {
        //                Id = 20,
        //                CategoryId = 2,
        //                Name = "Сандъци"
        //            },
        //            new SubCategory
        //            {
        //                Id = 21,
        //                CategoryId = 2,
        //                Name = "Цветарници"
        //            },
        //            new SubCategory
        //            {
        //                Id = 22,
        //                CategoryId = 2,
        //                Name = "Лейки"
        //            },
        //            new SubCategory
        //            {
        //                Id = 23,
        //                CategoryId = 2,
        //                Name = "Пулверизатори"
        //            },
        //            new SubCategory
        //            {
        //                Id = 24,
        //                CategoryId = 2,
        //                Name = "Декоративни фигурки"
        //            },
        //            new SubCategory
        //            {
        //                Id = 25,
        //                CategoryId = 2,
        //                Name = "Декоративни камъни"
        //            }
        //        });
        //    modelBuilder.Entity<Characteristic>().HasData(
        //        new[]
        //        {
        //            new Characteristic
        //            {
        //                Id = 1,
        //                Name = "Цвят"
        //            }
        //        });
        //    modelBuilder.Entity<CharacteristicCategory>().HasData(
        //        new[]
        //        {
        //            new CharacteristicCategory
        //            {
        //                Id = 1,
        //                CharacteristicId = 1,
        //                SubCategoryId = 1
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
