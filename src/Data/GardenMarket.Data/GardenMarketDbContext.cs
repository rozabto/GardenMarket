using GardenMarket.Models.Dto;
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

        public IList<ProductDto> Products => new List<ProductDto>
        {
            new ProductDto
            {
                Id = 1,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin eget leo luctus, elementum lectus id, pharetra quam. Cras ultrices velit nulla, ut blandit velit venenatis vel.",
                Name = "Poppy"
            },
            new ProductDto
            {
                Id = 2,
                Description = "Nulla mi ipsum, tristique ac odio in, placerat elementum urna. Nulla lacus sem, dictum id lectus ut, fringilla vulputate elit. Nunc in vestibulum nulla.",
                Name = "Rosa"
            },
            new ProductDto
            {
                Id = 3,
                Description = "Nulla velit tellus, convallis nec sagittis non, vestibulum et quam. Morbi dictum accumsan turpis sit amet aliquam. Sed interdum arcu aliquam, fringilla purus ac, consequat massa.",
                Name = "Begonia"
            }
        };

        #endregion
    }
}
