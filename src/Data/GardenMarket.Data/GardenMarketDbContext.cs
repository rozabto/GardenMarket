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
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<User>().HasData(
        //        new[]
        //        {
        //            new User
        //            {
        //                Id = "6d7de6c5-2c4e-4ff9-86ed-cb219f8bfe02",
        //                SecurityStamp = "BRLKQIVSEK6NH4FXG2XXEGDGY774DKR4",
        //                ConcurrencyStamp = "39d7264f-79e1-4743-af43-e593cf65412b",
        //                Email = "user@gmail.com",
        //                EmailConfirmed = true,
        //                NormalizedUserName = "USER@GMAIL.COM",
        //                UserName = "user@gmail.com",
        //                NormalizedEmail = "USER@GMAIL.COM",
        //                PasswordHash = "AQAAAAEAACcQAAAAEMh81L3Cw6KEGfSzBiedaoJcv+rGScQee1k6D2AMsBDxOQVywpv7q/qa4b+d6yS4yw=="//user123
        //            }
        //        });
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
        //            #region Растения
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
        //            #endregion
        //            #region Градина
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
        //            },
        //            #endregion
        //            #region Свободно време
        //            new SubCategory
        //            {
        //                Id = 26,
        //                CategoryId = 3,
        //                Name = "Палатки"
        //            },
        //            new SubCategory
        //            {
        //                Id = 27,
        //                CategoryId = 3,
        //                Name = "Спални чували"
        //            },
        //            new SubCategory
        //            {
        //                Id = 28,
        //                CategoryId = 3,
        //                Name = "Къмпинг оборудване"
        //            },
        //            new SubCategory
        //            {
        //                Id = 29,
        //                CategoryId = 3,
        //                Name = "Столове и маси"
        //            },
        //            new SubCategory
        //            {
        //                Id = 30,
        //                CategoryId = 3,
        //                Name = "Грил"
        //            },
        //            new SubCategory
        //            {
        //                Id = 31,
        //                CategoryId = 3,
        //                Name = "Скара"
        //            },
        //            new SubCategory
        //            {
        //                Id = 32,
        //                CategoryId = 3,
        //                Name = "Оборудване за барбекю"
        //            },
        //            new SubCategory
        //            {
        //                Id = 33,
        //                CategoryId = 3,
        //                Name = "Соларни лампи"
        //            },
        //            new SubCategory
        //            {
        //                Id = 34,
        //                CategoryId = 3,
        //                Name = "Фенери"
        //            },
        //            new SubCategory
        //            {
        //                Id = 35,
        //                CategoryId = 3,
        //                Name = "Сфери"
        //            }
        //            #endregion
        //        });
        //    modelBuilder.Entity<Characteristic>().HasData(
        //        new[]
        //        {
        //            new Characteristic
        //            {
        //                Id = 1,
        //                Name = "Цвят"
        //            },
        //            new Characteristic
        //            {
        //                Id = 2,
        //                Name = "Сезони"
        //            },
        //            new Characteristic
        //            {
        //                Id = 3,
        //                Name = "Произведено в"
        //            }
        //        });
        //    Need help for this one!!!!

        //   modelBuilder.Entity<CharacteristicCategory>().HasData(
        //       new[]
        //       {
        //            new CharacteristicCategory
        //            {
        //                Id = 1,
        //                CharacteristicId = 1,
        //                SubCategoryId = 1
        //            },
        //            new CharacteristicCategory
        //            {
        //                Id = 2,
        //                CharacteristicId = 2,
        //                SubCategoryId = 1
        //            },
        //            new CharacteristicCategory
        //            {
        //                Id = 3,
        //                CharacteristicId = 3,
        //                SubCategoryId = 1
        //            }
        //       });
        //   modelBuilder.Entity<FlowerType>().HasData(
        //       new[]
        //       {
        //            #region Цвят
        //            new FlowerType
        //            {
        //                Id = 1,
        //                CharacteristicId = 1,
        //                Name = "Бял"
        //            },
        //            new FlowerType
        //            {
        //                Id = 2,
        //                CharacteristicId = 1,
        //                Name = "Сив"
        //            },
        //            new FlowerType
        //            {
        //                Id = 3,
        //                CharacteristicId = 1,
        //                Name = "Черен"
        //            },
        //            new FlowerType
        //            {
        //                Id = 4,
        //                CharacteristicId = 1,
        //                Name = "Син"
        //            },
        //            new FlowerType
        //            {
        //                Id = 5,
        //                CharacteristicId = 1,
        //                Name = "Червен"
        //            },
        //            new FlowerType
        //            {
        //                Id = 6,
        //                CharacteristicId = 1,
        //                Name = "Жълт"
        //            },
        //            new FlowerType
        //            {
        //                Id = 7,
        //                CharacteristicId = 1,
        //                Name = "Оранжев"
        //            },
        //            new FlowerType
        //            {
        //                Id = 8,
        //                CharacteristicId = 1,
        //                Name = "Кафяв"
        //            },
        //            new FlowerType
        //            {
        //                Id = 9,
        //                CharacteristicId = 1,
        //                Name = "Зелен"
        //            },
        //            new FlowerType
        //            {
        //                Id = 10,
        //                CharacteristicId = 1,
        //                Name = "Лилав"
        //            },
        //            #endregion
        //            #region Сезони
        //            new FlowerType
        //            {
        //                Id = 11,
        //                CharacteristicId = 2,
        //                Name = "Пролет"
        //            },
        //            new FlowerType
        //            {
        //                Id = 12,
        //                CharacteristicId = 2,
        //                Name = "Лято"
        //            },
        //            new FlowerType
        //            {
        //                Id = 13,
        //                CharacteristicId = 2,
        //                Name = "Есен"
        //            },
        //            new FlowerType
        //            {
        //                Id = 14,
        //                CharacteristicId = 2,
        //                Name = "Зима"
        //            },
        //            new FlowerType
        //            {
        //                Id = 15,
        //                CharacteristicId = 2,
        //                Name = "Целогодишно"
        //            },
        //            #endregion
        //            #region Произведено в
        //            new FlowerType
        //            {
        //                Id = 16,
        //                CharacteristicId = 3,
        //                Name = "България"
        //            },
        //            new FlowerType
        //            {
        //                Id = 17,
        //                CharacteristicId = 3,
        //                Name = "САЩ"
        //            },
        //            new FlowerType
        //            {
        //                Id = 18,
        //                CharacteristicId = 3,
        //                Name = "Блала"
        //            },
        //            new FlowerType
        //            {
        //                Id = 19,
        //                CharacteristicId = 3,
        //                Name = "Китай"
        //            }
        //            #endregion
        //       });
        //   modelBuilder.Entity<Product>().HasData(
        //       new[]
        //       {
        //            new Product
        //            {
        //                Id = 1,
        //                Name = "ВОДЕН ИРИС",
        //                CreatedOn = DateTime.UtcNow,
        //                Description = "Дължимата цена за Обработка и транспорт се изчислява преди финализиране на поръчката.",
        //                InStock = 10,
        //                Price = 6.99m,
        //                Sales = 4,
        //                SubCategoryId = 1,
        //                UserId = "6d7de6c5-2c4e-4ff9-86ed-cb219f8bfe02"
        //            },
        //            new Product
        //            {
        //                Id = 2,
        //                Name = "ВОДЕН ИРИС",
        //                CreatedOn = DateTime.UtcNow,
        //                Description = "Дължимата цена за Обработка и транспорт се изчислява преди финализиране на поръчката.",
        //                InStock = 10,
        //                Price = 6.99m,
        //                Sales = 4,
        //                SubCategoryId = 1,
        //                UserId = "6d7de6c5-2c4e-4ff9-86ed-cb219f8bfe02"
        //            },
        //            new Product
        //            {
        //                Id = 3,
        //                Name = "ВОДЕН ИРИС",
        //                CreatedOn = DateTime.UtcNow,
        //                Description = "Дължимата цена за Обработка и транспорт се изчислява преди финализиране на поръчката.",
        //                InStock = 10,
        //                Price = 6.99m,
        //                Sales = 4,
        //                SubCategoryId = 1,
        //                UserId = "6d7de6c5-2c4e-4ff9-86ed-cb219f8bfe02"
        //            },
        //            new Product
        //            {
        //                Id = 4,
        //                Name = "ВОДЕН ИРИС",
        //                CreatedOn = DateTime.UtcNow,
        //                Description = "Дължимата цена за Обработка и транспорт се изчислява преди финализиране на поръчката.",
        //                InStock = 10,
        //                Price = 6.99m,
        //                Sales = 4,
        //                SubCategoryId = 1,
        //                UserId = "6d7de6c5-2c4e-4ff9-86ed-cb219f8bfe02"
        //            },
        //            new Product
        //            {
        //                Id = 5,
        //                Name = "ВОДЕН ИРИС",
        //                CreatedOn = DateTime.UtcNow,
        //                Description = "Дължимата цена за Обработка и транспорт се изчислява преди финализиране на поръчката.",
        //                InStock = 10,
        //                Price = 6.99m,
        //                Sales = 4,
        //                SubCategoryId = 1,
        //                UserId = "6d7de6c5-2c4e-4ff9-86ed-cb219f8bfe02"
        //            },
        //            new Product
        //            {
        //                Id = 6,
        //                Name = "ВОДЕН ИРИС",
        //                CreatedOn = DateTime.UtcNow,
        //                Description = "Дължимата цена за Обработка и транспорт се изчислява преди финализиране на поръчката.",
        //                InStock = 10,
        //                Price = 6.99m,
        //                Sales = 4,
        //                SubCategoryId = 1,
        //                UserId = "6d7de6c5-2c4e-4ff9-86ed-cb219f8bfe02"
        //            },
        //            new Product
        //            {
        //                Id = 7,
        //                Name = "ВОДЕН ИРИС",
        //                CreatedOn = DateTime.UtcNow,
        //                Description = "Дължимата цена за Обработка и транспорт се изчислява преди финализиране на поръчката.",
        //                InStock = 10,
        //                Price = 6.99m,
        //                Sales = 4,
        //                SubCategoryId = 1,
        //                UserId = "6d7de6c5-2c4e-4ff9-86ed-cb219f8bfe02"
        //            },
        //            new Product
        //            {
        //                Id = 8,
        //                Name = "ВОДЕН ИРИС",
        //                CreatedOn = DateTime.UtcNow,
        //                Description = "Дължимата цена за Обработка и транспорт се изчислява преди финализиране на поръчката.",
        //                InStock = 10,
        //                Price = 6.99m,
        //                Sales = 4,
        //                SubCategoryId = 1,
        //                UserId = "6d7de6c5-2c4e-4ff9-86ed-cb219f8bfe02"
        //            },
        //            new Product
        //            {
        //                Id = 9,
        //                Name = "ВОДЕН ИРИС",
        //                CreatedOn = DateTime.UtcNow,
        //                Description = "Дължимата цена за Обработка и транспорт се изчислява преди финализиране на поръчката.",
        //                InStock = 10,
        //                Price = 6.99m,
        //                Sales = 4,
        //                SubCategoryId = 1,
        //                UserId = "6d7de6c5-2c4e-4ff9-86ed-cb219f8bfe02"
        //            },
        //            new Product
        //            {
        //                Id = 10,
        //                Name = "ВОДЕН ИРИС",
        //                CreatedOn = DateTime.UtcNow,
        //                Description = "Дължимата цена за Обработка и транспорт се изчислява преди финализиране на поръчката.",
        //                InStock = 10,
        //                Price = 6.99m,
        //                Sales = 4,
        //                SubCategoryId = 1,
        //                UserId = "6d7de6c5-2c4e-4ff9-86ed-cb219f8bfe02"
        //            }
        //       });
        //    modelBuilder.Entity<ProductImage>().HasData(
        //        new[]
        //        {
        //            new ProductImage
        //            {
        //                Id = 1,
        //                ProductId = 1,
        //                Path = "img/product-img/product1.jpg"
        //            },
        //            new ProductImage
        //            {
        //                Id = 2,
        //                ProductId = 2,
        //                Path = "img/product-img/product1.jpg"
        //            },
        //            new ProductImage
        //            {
        //                Id = 3,
        //                ProductId = 3,
        //                Path = "img/product-img/product1.jpg"
        //            },
        //            new ProductImage
        //            {
        //                Id = 4,
        //                ProductId = 4,
        //                Path = "img/product-img/product1.jpg"
        //            },
        //            new ProductImage
        //            {
        //                Id = 5,
        //                ProductId = 5,
        //                Path = "img/product-img/product1.jpg"
        //            },
        //            new ProductImage
        //            {
        //                Id = 6,
        //                ProductId = 6,
        //                Path = "img/product-img/product1.jpg"
        //            },
        //            new ProductImage
        //            {
        //                Id = 7,
        //                ProductId = 7,
        //                Path = "img/product-img/product1.jpg"
        //            },
        //            new ProductImage
        //            {
        //                Id = 8,
        //                ProductId = 8,
        //                Path = "img/product-img/product1.jpg"
        //            },
        //            new ProductImage
        //            {
        //                Id = 9,
        //                ProductId = 9,
        //                Path = "img/product-img/product1.jpg"
        //            },
        //            new ProductImage
        //            {
        //                Id = 10,
        //                ProductId = 10,
        //                Path = "img/product-img/product1.jpg"
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
        //                Message = "Hello there (general Ken-obi), this is a very BAD product, kappa",
        //                Posted = DateTime.UtcNow,
        //                ProductId = 1,
        //                UserId = "6d7de6c5-2c4e-4ff9-86ed-cb219f8bfe02"
        //            }
        //        });
        //    modelBuilder.Entity<Favorite>().HasData(
        //        new[]
        //        {
        //            new Favorite
        //            {
        //                Id = 1,
        //                IsLicked = true,
        //                ProductId = 1,
        //                UserId = "6d7de6c5-2c4e-4ff9-86ed-cb219f8bfe02"
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
        //                UserId = "6d7de6c5-2c4e-4ff9-86ed-cb219f8bfe02"
        //            }
        //        });

        //    Others
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