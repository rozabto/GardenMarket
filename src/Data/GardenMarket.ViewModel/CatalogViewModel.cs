using GardenMarket.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GardenMarket.ViewModel
{
    public class CatalogViewModel
    {
        public Category Category { get; set; }

        public IReadOnlyList<CharacteristicCategory> CharacteristicCategories { get; set; }

        public SubSubCategory SubSubCategory { get; set; }

    }
}
