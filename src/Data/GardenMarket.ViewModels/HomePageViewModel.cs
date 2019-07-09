using GardenMarket.Models;
using System.Collections.Generic;

namespace GardenMarket.ViewModels
{
    public class HomePageViewModel
    {
        public IList<Product> ProductSample { get; set; }
        public string Name { get; set; }
    }
}
