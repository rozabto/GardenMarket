using GardenMarket.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GardenMarket.Data
{
    public class GardenMarketDbContext : IdentityDbContext<AppUser>
    {
        public GardenMarketDbContext(DbContextOptions<GardenMarketDbContext> options)
            : base(options) { }

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
        public DbSet<SubSubCategory> SubSubCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new[]
                {
                    new Category
                    {
                        Id = 1,
                        Name = "Растения"
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Градина"
                    },
                    new Category
                    {
                        Id = 3,
                        Name = "Свободно Време"
                    }
                });
            modelBuilder.Entity<SubCategory>().HasData(
                new[]
                {
                    #region Растения
                    new SubCategory
                    {
                        Id = 1,
                        CategoryId = 1,
                        Name = "Стайни растения"
                    },
                    new SubCategory
                    {
                        Id = 2,
                        CategoryId = 1,
                        Name = "Външни растения"
                    },
                    new SubCategory
                    {
                        Id = 3,
                        CategoryId = 1,
                        Name = "Сенколюбиви растения"
                    },
                    new SubCategory
                    {
                        Id = 4,
                        CategoryId = 1,
                        Name = "Разсад"
                    },
                    #endregion Растения
                    #region Градина
                    new SubCategory
                    {
                        Id = 5,
                        CategoryId = 2,
                        Name = "Торове"
                    },
                    new SubCategory
                    {
                        Id = 6,
                        CategoryId = 2,
                        Name = "Саксии"
                    },
                    new SubCategory
                    {
                        Id = 7,
                        CategoryId = 2,
                        Name = "Напояване"
                    },
                    new SubCategory
                    {
                        Id = 8,
                        CategoryId = 2,
                        Name = "Градински декорации"
                    },
                    #endregion Градина
                    #region Свободно време
                    new SubCategory
                    {
                        Id = 9,
                        CategoryId = 3,
                        Name = "Къмпинг"
                    },
                    new SubCategory
                    {
                        Id = 10,
                        CategoryId = 3,
                        Name = "Барбекю"
                    },
                    new SubCategory
                    {
                        Id = 11,
                        CategoryId = 3,
                        Name = "Осветление"
                    }
                    #endregion Свободно време
                });
            modelBuilder.Entity<SubSubCategory>().HasData(
                new[]
                {
                    #region Растения
                    new SubSubCategory
                    {
                        Id = 1,
                        SubCategoryId = 1,
                        Name = "Цъфтящи растения",
                        LowestPrice = 1.99f,
                        HighestPrice = 62.99f
                    },
                    new SubSubCategory
                    {
                        Id = 2,
                        SubCategoryId = 1,
                        Name = "Нецъфтящи растения"
                    },
                    new SubSubCategory
                    {
                        Id = 3,
                        SubCategoryId = 1,
                        Name = "Насекомоядни растения"
                    },
                    new SubSubCategory
                    {
                        Id = 4,
                        SubCategoryId = 1,
                        Name = "Сукуленти"
                    },
                    new SubSubCategory
                    {
                        Id = 5,
                        SubCategoryId = 2,
                        Name = "Вечнозелени храсти и дръвчета"
                    },
                    new SubSubCategory
                    {
                        Id = 6,
                        SubCategoryId = 2,
                        Name = "Цъфтящи храсти и дръвчета"
                    },
                    new SubSubCategory
                    {
                        Id = 7,
                        SubCategoryId = 2,
                        Name = "Водни растения"
                    },
                    new SubSubCategory
                    {
                        Id = 8,
                        SubCategoryId = 3,
                        Name = "Бегония"
                    },
                    new SubSubCategory
                    {
                        Id = 9,
                        SubCategoryId = 3,
                        Name = "Здравец"
                    },
                    new SubSubCategory
                    {
                        Id = 10,
                        SubCategoryId = 3,
                        Name = "Циганче"
                    },
                    new SubSubCategory
                    {
                        Id = 11,
                        SubCategoryId = 3,
                        Name = "Функия"
                    },
                    new SubSubCategory
                    {
                        Id = 12,
                        SubCategoryId = 4,
                        Name = "Семена"
                    },
                    new SubSubCategory
                    {
                        Id = 13,
                        SubCategoryId = 4,
                        Name = "Луковици"
                    },
                    #endregion Растения
                    #region Градина
                    new SubSubCategory
                    {
                        Id = 14,
                        SubCategoryId = 5,
                        Name = "Торове"
                    },
                    new SubSubCategory
                    {
                        Id = 15,
                        SubCategoryId = 5,
                        Name = "Почви"
                    },
                    new SubSubCategory
                    {
                        Id = 16,
                        SubCategoryId = 5,
                        Name = "Тревни смески"
                    },
                    new SubSubCategory
                    {
                        Id = 17,
                        SubCategoryId = 6,
                        Name = "Саксии"
                    },
                    new SubSubCategory
                    {
                        Id = 18,
                        SubCategoryId = 6,
                        Name = "Вази"
                    },
                    new SubSubCategory
                    {
                        Id = 19,
                        SubCategoryId = 6,
                        Name = "Кашпи"
                    },
                    new SubSubCategory
                    {
                        Id = 20,
                        SubCategoryId = 6,
                        Name = "Сандъци"
                    },
                    new SubSubCategory
                    {
                        Id = 21,
                        SubCategoryId = 6,
                        Name = "Цветарници"
                    },
                    new SubSubCategory
                    {
                        Id = 22,
                        SubCategoryId = 7,
                        Name = "Лейки"
                    },
                    new SubSubCategory
                    {
                        Id = 23,
                        SubCategoryId = 7,
                        Name = "Пулверизатори"
                    },
                    new SubSubCategory
                    {
                        Id = 24,
                        SubCategoryId = 8,
                        Name = "Декоративни фигурки"
                    },
                    new SubSubCategory
                    {
                        Id = 25,
                        SubCategoryId = 8,
                        Name = "Декоративни камъни"
                    },
                    #endregion Градина
                    #region Свободно време
                    new SubSubCategory
                    {
                        Id = 26,
                        SubCategoryId = 9,
                        Name = "Палатки"
                    },
                    new SubSubCategory
                    {
                        Id = 27,
                        SubCategoryId = 9,
                        Name = "Спални чували"
                    },
                    new SubSubCategory
                    {
                        Id = 28,
                        SubCategoryId = 9,
                        Name = "Къмпинг оборудване"
                    },
                    new SubSubCategory
                    {
                        Id = 29,
                        SubCategoryId = 9,
                        Name = "Столове и маси"
                    },
                    new SubSubCategory
                    {
                        Id = 30,
                        SubCategoryId = 10,
                        Name = "Грил"
                    },
                    new SubSubCategory
                    {
                        Id = 31,
                        SubCategoryId = 10,
                        Name = "Скара"
                    },
                    new SubSubCategory
                    {
                        Id = 32,
                        SubCategoryId = 10,
                        Name = "Оборудване за барбекю"
                    },
                    new SubSubCategory
                    {
                        Id = 33,
                        SubCategoryId = 11,
                        Name = "Соларни лампи"
                    },
                    new SubSubCategory
                    {
                        Id = 34,
                        SubCategoryId = 11,
                        Name = "Фенери"
                    },
                    new SubSubCategory
                    {
                        Id = 35,
                        SubCategoryId = 11,
                        Name = "Сфери"
                    }
                    #endregion Свободно време
                });
            modelBuilder.Entity<Characteristic>().HasData(
                new[]
                {
                    new Characteristic
                    {
                        Id = 1,
                        Name = "Цвят",
                        Display = true
                    },
                    new Characteristic
                    {
                        Id = 2,
                        Name = "Сезони",
                        Display = true
                    },
                    new Characteristic
                    {
                        Id = 3,
                        Name = "Произведено в",
                        Display = true
                    },
                    new Characteristic
                    {
                        Id = 4,
                        Name = "Размер",
                        Display = false
                    }
                });
            modelBuilder.Entity<CharacteristicCategory>().HasData(
                new[]
                {
                    #region Растения
                    new CharacteristicCategory
                    {
                        Id = 1,
                        CharacteristicId = 2,
                        SubCategoryId = 1
                    },
                    new CharacteristicCategory
                    {
                        Id = 2,
                        CharacteristicId = 2,
                        SubCategoryId = 2
                    },
                    new CharacteristicCategory
                    {
                        Id = 3,
                        CharacteristicId = 4,
                        SubCategoryId = 2
                    },
                    new CharacteristicCategory
                    {
                        Id = 4,
                        CharacteristicId = 2,
                        SubCategoryId = 3
                    },
                    new CharacteristicCategory
                    {
                        Id = 5,
                        CharacteristicId = 2,
                        SubCategoryId = 4
                    },
                    #endregion Растения
                    #region Градина
                    new CharacteristicCategory
                    {
                        Id = 6,
                        CharacteristicId = 1,
                        SubCategoryId = 6
                    },
                    new CharacteristicCategory
                    {
                        Id = 7,
                        CharacteristicId = 3,
                        SubCategoryId = 6
                    },
                    new CharacteristicCategory
                    {
                        Id = 8,
                        CharacteristicId = 1,
                        SubCategoryId = 7
                    },
                    new CharacteristicCategory
                    {
                        Id = 9,
                        CharacteristicId = 1,
                        SubCategoryId = 8
                    },
                    new CharacteristicCategory
                    {
                        Id = 10,
                        CharacteristicId = 3,
                        SubCategoryId = 8
                    },
                    #endregion Градина
                    #region Свободно време
                    new CharacteristicCategory
                    {
                        Id = 11,
                        CharacteristicId = 1,
                        SubCategoryId = 9
                    },
                    new CharacteristicCategory
                    {
                        Id = 12,
                        CharacteristicId = 3,
                        SubCategoryId = 10
                    },
                    new CharacteristicCategory
                    {
                        Id = 13,
                        CharacteristicId = 3,
                        SubCategoryId = 11
                    }
                    #endregion Свободно време
                });
            modelBuilder.Entity<FlowerType>().HasData(
                new[]
                {
                    #region Цвят
                    new FlowerType
                    {
                        Id = 1,
                        CharacteristicId = 1,
                        Name = "Бял"
                    },
                    new FlowerType
                    {
                        Id = 2,
                        CharacteristicId = 1,
                        Name = "Сив"
                    },
                    new FlowerType
                    {
                        Id = 3,
                        CharacteristicId = 1,
                        Name = "Черен"
                    },
                    new FlowerType
                    {
                        Id = 4,
                        CharacteristicId = 1,
                        Name = "Син"
                    },
                    new FlowerType
                    {
                        Id = 5,
                        CharacteristicId = 1,
                        Name = "Червен"
                    },
                    new FlowerType
                    {
                        Id = 6,
                        CharacteristicId = 1,
                        Name = "Жълт"
                    },
                    new FlowerType
                    {
                        Id = 7,
                        CharacteristicId = 1,
                        Name = "Оранжев"
                    },
                    new FlowerType
                    {
                        Id = 8,
                        CharacteristicId = 1,
                        Name = "Кафяв"
                    },
                    new FlowerType
                    {
                        Id = 9,
                        CharacteristicId = 1,
                        Name = "Зелен"
                    },
                    new FlowerType
                    {
                        Id = 10,
                        CharacteristicId = 1,
                        Name = "Лилав"
                    },
                    #endregion Цвят
                    #region Сезони
                    new FlowerType
                    {
                        Id = 11,
                        CharacteristicId = 2,
                        Name = "Пролет"
                    },
                    new FlowerType
                    {
                        Id = 12,
                        CharacteristicId = 2,
                        Name = "Лято"
                    },
                    new FlowerType
                    {
                        Id = 13,
                        CharacteristicId = 2,
                        Name = "Есен"
                    },
                    new FlowerType
                    {
                        Id = 14,
                        CharacteristicId = 2,
                        Name = "Зима"
                    },
                    new FlowerType
                    {
                        Id = 15,
                        CharacteristicId = 2,
                        Name = "Целогодишно"
                    },
                    #endregion Сезони
                    #region Произведено в
                    new FlowerType
                    {
                        Id = 16,
                        CharacteristicId = 3,
                        Name = "България"
                    },
                    new FlowerType
                    {
                        Id = 17,
                        CharacteristicId = 3,
                        Name = "САЩ"
                    },
                    new FlowerType
                    {
                        Id = 18,
                        CharacteristicId = 3,
                        Name = "Блала"
                    },
                    new FlowerType
                    {
                        Id = 19,
                        CharacteristicId = 3,
                        Name = "Китай"
                    }
                    #endregion Произведено в
                });
        }
    }
}