using GardenMarket.Models;
using System.Collections.Generic;

namespace GardenMarket.ViewModel
{
    public class HeaderViewModel
    {
        public IReadOnlyList<Category> Categories { get; set; }
        public IReadOnlyList<int> ProductIds { get; set; }
        public int Count { get; set; }
    }
}