using GardenMarket.Models;
using System.Collections.Generic;

namespace GardenMarket.ViewModel
{
    public class MainPageViewModel
    {
        public IReadOnlyList<Favorite> Favorites { get; set; }
        public IReadOnlyList<Product> Products { get; set; }
    }
}
