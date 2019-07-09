using GardenMarket.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GardenMarket.Data
{
    public class GardenMarketDbContext : IdentityDbContext
    {
        public GardenMarketDbContext(DbContextOptions<GardenMarketDbContext> options)
            : base(options) { }

        public GardenMarketDbContext() { }

        #region For Testing

        public IList<Product> Products => new List<Product>
        {
            new Product
            {
                Id = "1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin eget leo luctus, elementum lectus id, pharetra quam. Cras ultrices velit nulla, ut blandit velit venenatis vel.",
                Name = "Poppy"
            },
            new Product
            {
                Id = "2",
                Description = "Nulla mi ipsum, tristique ac odio in, placerat elementum urna. Nulla lacus sem, dictum id lectus ut, fringilla vulputate elit. Nunc in vestibulum nulla.",
                Name = "Rosa"
            },
            new Product
            {
                Id = "3",
                Description = "Nulla velit tellus, convallis nec sagittis non, vestibulum et quam. Morbi dictum accumsan turpis sit amet aliquam. Sed interdum arcu aliquam, fringilla purus ac, consequat massa.",
                Name = "Begonia"
            }
        };

        public IList<Cart> Carts => new List<Cart>();

        public IList<Favorite> Favorites => new List<Favorite>();

        #endregion
    }
}
