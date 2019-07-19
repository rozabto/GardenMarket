using GardenMarket.Models;
using System.Collections.Generic;

namespace GardenMarket.ViewModel
{
    public class CatalogViewModel
    {
        public int ProductCount { get; set; }
        public IReadOnlyList<SubCategory> SubCategories { get; set; }
        public IReadOnlyList<Characteristic> Characteristics { get; set; }
        public SubSubCategory SubSubCategory { get; set; }
    }
}
