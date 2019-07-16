using GardenMarket.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GardenMarket.ViewModel
{
    public class ProductViewModel
    {
        public Product Product { get; set; }

        public IReadOnlyList<FlowerType> Colors { get; set; }
    }
}
