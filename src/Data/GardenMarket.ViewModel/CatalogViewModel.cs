using GardenMarket.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GardenMarket.ViewModel
{
    public class CatalogViewModel
    {
        public IReadOnlyList<SubCategory> SubCategories { get; set; }

        public IReadOnlyList<Characteristic> Characteristics { get; set; }

        public SubSubCategory SubSubCategory { get; set; }

    }
}
