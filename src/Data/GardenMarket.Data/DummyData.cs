using GardenMarket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace GardenMarket.Data
{
    public class DummyData
    {
        public static async Task Initialize(GardenMarketDbContext context, UserManager<AppUser> userManager)
        {
            context.Database.EnsureCreated();

            if (await userManager.FindByEmailAsync("user@gmail.com") == null)
            {
                var user = new AppUser
                {
                    Email = "user@gmail.com",
                    UserName = "user@gmail.com",
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                    await userManager.AddPasswordAsync(user, "User123");
            }

            if (await userManager.FindByEmailAsync("admin@gmail.com") == null)
            {
                var user = new AppUser
                {
                    UserName = "admin",
                    Email = "admin@gmail.com",
                    PhoneNumber = "7788951456"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                    await userManager.AddPasswordAsync(user, "Admin123");
            }

            var userId = (await userManager.FindByEmailAsync("user@gmail.com")).Id;

            var products = new[]
            {
                new Product
                {
                    Name = "ВОДЕН ИРИС",
                    CreatedOn = DateTime.UtcNow,
                    Description = "Дължимата цена за Обработка и транспорт се изчислява преди финализиране на поръчката.",
                    InStock = 10,
                    Price = 6.99m,
                    Sales = 4,
                    SubSubCategoryId = 1,
                    UserId = userId
                },
                new Product
                {
                    Name = "ГРАДИНСКО МУШКАТО",
                    CreatedOn = DateTime.UtcNow,
                    Description = "За мушкатото едва ли има какво ново да се каже, тъй като то е добре познато в българските домове. Различните сортове предлагат различна форма на цветовете, а при правилно съчетание на растенията можете да получите чудесна градина в цветовете на дъгата. Особеност на растението е миризмата на листата му, която е по-силна от тази на цветовете. Едно от най-големите предимства на мушкатото е фактът, че то се отглежда много лесно и не изисква особени грижи.",
                    InStock = 14,
                    Price = 7.99m,
                    Sales = 2,
                    SubSubCategoryId = 1,
                    UserId = userId
                },
                new Product
                {
                    Name = "АФРИКАНСКА ТЕМЕНУЖКА",
                    CreatedOn = DateTime.UtcNow,
                    Description = "Едно от най-лесните за отглеждане стайни растения, цъфтящо през цялата година. Изберете между стотиците разновидности като форма и цвят на цъфтежа и на листата. Растението харесва топлината и филтрираната слънчева светлина, а при поливане избягвайте да мокрите листата му, за да не се появят по тях кафяви петна.",
                    InStock = 10,
                    Price = 2.99m,
                    Sales = 4,
                    SubSubCategoryId = 1,
                    UserId = userId
                },
                new Product
                {
                    Name = "АНТУРИУМ",
                    CreatedOn = DateTime.UtcNow,
                    Description = "Аантуриумът цъфти в ярки нюанси на розовото, червеното, лавандуловото и бялото, като цъфтежът може да продължи повече от 2 месеца. Той обича светлината, но при по-ниска интензивност на естествената светлина може да се отглежда като листно растение.",
                    InStock = 10,
                    Price = 3.99m,
                    Sales = 4,
                    SubSubCategoryId = 1,
                    UserId = userId
                },
                new Product
                {
                    Name = "ПОРФИРОКОМА (БРАЗИЛСКА ЗАРЯ)",
                    CreatedOn = DateTime.UtcNow,
                    Description = "Ако се чудите откъде идва прякорът на порфирокомата - \"бразилска заря\", то отговорът е, че през летните месеци растението развива тъмночервени прицветници, разцъфващи в лавандулово, като по този начин се създава истинска експлозия от цветове. Когато пък цветчетата прецъфтят, растението може да изстреля малките си черни семенца на другия край на помещението. Когато пък не цъфти, то продължава да удивлява с красивите си листа, прошарени със сребристо. Порфирокомата е подходящ избор и за градината, стига да е разположена на сянка.",
                    InStock = 10,
                    Price = 17.99m,
                    Sales = 4,
                    SubSubCategoryId = 1,
                    UserId = userId
                },
                new Product
                {
                    Name = "КОЛЕДНИЧЕ (КОЛЕДЕН КАКТУС)",
                    CreatedOn = DateTime.UtcNow,
                    Description = "Растението цъфти при условия на по-ниска температура и скъсяване на деня. През есента то трябва да се държи на хладно място (не студено) с достъп до слънчева светлина, докато пъпките му започнат да се развиват.",
                    InStock = 10,
                    Price = 15.99m,
                    Sales = 4,
                    SubSubCategoryId = 1,
                    UserId = userId
                },
                new Product
                {
                    Name = "МИНИ ПОРТОКАЛ КАЛАМОНДИН",
                    CreatedOn = DateTime.UtcNow,
                    Description = "Той е хибрид между мандарина и кумкуат (вид цитрусово растение, подобно на портокал) и представлява храстовидно растение с лъскави зелени листа. То цъфти с ароматни бели цветове през късната зима и ранната пролет, като по-късно се оформят малки плодчета с диаметър 2-3 см.",
                    InStock = 10,
                    Price = 12.99m,
                    Sales = 4,
                    SubSubCategoryId = 1,
                    UserId = userId
                },
                new Product
                {
                    Name = "ЕУФОРБИЯ (ХРИСТОВ ВЕНЕЦ)",
                    CreatedOn = DateTime.UtcNow,
                    Description = "Еуфорбията е роднина на коледната звезда и се отглежда сравнително лесно, стига да й осигурите много светлина и ниска влажност.  Всички части на растението са отровни (особено млечния сок), ако се погълнат или сдъвчат от малки деца или домашни любимци. Освен това растението има много бодли, създавайки опасност за нараняване.",
                    InStock = 10,
                    Price = 1.99m,
                    Sales = 4,
                    SubSubCategoryId = 1,
                    UserId = userId
                },
                new Product
                {
                    Name = "ЕХМЕЯ",
                    CreatedOn = DateTime.UtcNow,
                    Description = "Плътните сиво-зелени листа на това растение, родственик на ананаса, растат във формата на ваза. Цъфтежът му пък е в розово или пурпурно и издържа дълго време.",
                    InStock = 10,
                    Price = 62.99m,
                    Sales = 4,
                    SubSubCategoryId = 1,
                    UserId = userId
                },
                new Product
                {
                    Name = "ГЛОКСИНИЯ",
                    CreatedOn = DateTime.UtcNow,
                    Description = "Глоксинията цъфти през късна зима или ранна пролет, като цветовете й са във формата на камбанки с ширина 7-8 см. и наситени нюанси. Растението е родственик на африканската теменужка и предпочита топлината и високата влажност. Избягвайте да мокрите листата му, за да не остават кафяви петна. Когато цветовете прецъфтят, оставете растението да изпадне в летаргия като преустановете поливането. Когато започне да расте отново, започнете да поливате отново.",
                    InStock = 10,
                    Price = 23.99m,
                    Sales = 4,
                    SubSubCategoryId = 1,
                    UserId = userId
                }
            };

            if (await context.Products.FindAsync(10) == null)
            {
                await context.Products.AddRangeAsync(products);
                await context.SaveChangesAsync();
            }
            if (await context.ProductImages.FirstOrDefaultAsync(f => f.Path == "img/product-img/product1.jpg") == null)
                await context.ProductImages.AddRangeAsync(
                    new[]
                        {
                            new ProductImage
                            {
                                ProductId = products[0].Id,
                                Path = "img/product-img/product1.jpg"
                            },
                            new ProductImage
                            {
                                ProductId = products[1].Id,
                                Path = "img/product-img/product1.jpg"
                            },
                            new ProductImage
                            {
                                ProductId = products[2].Id,
                                Path = "img/product-img/product1.jpg"
                            },
                            new ProductImage
                            {
                                ProductId = products[3].Id,
                                Path = "img/product-img/product1.jpg"
                            },
                            new ProductImage
                            {
                                ProductId = products[4].Id,
                                Path = "img/product-img/product1.jpg"
                            },
                            new ProductImage
                            {
                                ProductId = products[5].Id,
                                Path = "img/product-img/product1.jpg"
                            },
                            new ProductImage
                            {
                                ProductId = products[6].Id,
                                Path = "img/product-img/product1.jpg"
                            },
                            new ProductImage
                            {
                                ProductId = products[7].Id,
                                Path = "img/product-img/product1.jpg"
                            },
                            new ProductImage
                            {
                                ProductId = products[8].Id,
                                Path = "img/product-img/product1.jpg"
                            },
                            new ProductImage
                            {
                                ProductId = products[9].Id,
                                Path = "img/product-img/product1.jpg"
                            }
                        });
            if (await context.ProductTypes.FirstOrDefaultAsync(f => f.TypeId == 15) == null)
                await context.ProductTypes.AddRangeAsync(
                    new[]
                    {
                        new ProductType
                        {
                            ProductId = products[0].Id,
                            TypeId = 15
                        },
                        new ProductType
                        {
                            ProductId = products[1].Id,
                            TypeId = 15
                        },
                        new ProductType
                        {
                            ProductId = products[2].Id,
                            TypeId = 15
                        },
                        new ProductType
                        {
                            ProductId = products[3].Id,
                            TypeId = 12
                        },
                        new ProductType
                        {
                            ProductId = products[4].Id,
                            TypeId = 12
                        },
                        new ProductType
                        {
                            ProductId = products[5].Id,
                            TypeId = 14
                        },
                        new ProductType
                        {
                            ProductId = products[6].Id,
                            TypeId = 11
                        },
                        new ProductType
                        {
                            ProductId = products[7].Id,
                            TypeId = 15
                        },
                        new ProductType
                        {
                            ProductId = products[8].Id,
                            TypeId = 15
                        },
                        new ProductType
                        {
                            ProductId = products[9].Id,
                            TypeId = 12
                        }
                    });
            if (await context.Comments.FirstOrDefaultAsync(f => f.Message == "Какво е това?") == null)
            {
                var comments = new[]
                {
                    new Comment
                    {
                        Message = "Hello there (general Ken-obi), this is a very BAD product, kappa",
                        Posted = DateTime.UtcNow,
                        ProductId = products[0].Id,
                        UserId = userId
                    },
                    new Comment
                    {
                        Message = "Имам вече 2 от тези.",
                        Posted = DateTime.UtcNow,
                        ProductId = products[0].Id,
                        UserId = userId
                    },
                    new Comment
                    {
                        Message = "Какво е това?",
                        Posted = DateTime.UtcNow,
                        ProductId = products[0].Id,
                        UserId = userId
                    },
                    new Comment
                    {
                        Message = "Кога ще получите още от тези",
                        Posted = DateTime.UtcNow,
                        ProductId = products[0].Id,
                        UserId = userId
                    }
                };
                await context.Comments.AddRangeAsync(comments);
                await context.SaveChangesAsync();
                await context.Comments.AddAsync(new Comment
                {
                    Message = "You are cringe itself.",
                    Posted = DateTime.UtcNow,
                    ProductId = products[0].Id,
                    ParentId = comments[0].Id,
                    UserId = userId
                });
            }
            if (await context.Favorites.FirstOrDefaultAsync(f => f.IsLicked == true) == null)
                await context.Favorites.AddRangeAsync(
                    new[]
                    {
                        new Favorite
                        {
                            IsLicked = true,
                            ProductId = products[0].Id,
                            UserId = userId
                        }
                    });
            if (await context.Carts.FirstOrDefaultAsync(f => f.UserId == userId) == null)
                await context.Carts.AddRangeAsync(
                    new[]
                    {
                        new Cart
                        {
                            Amount = 3,
                            ProductId = products[0].Id,
                            UserId = userId
                        }
                    });
            await context.SaveChangesAsync();
        }
    }
}