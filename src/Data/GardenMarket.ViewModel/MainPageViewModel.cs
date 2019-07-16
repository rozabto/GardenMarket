using GardenMarket.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GardenMarket.ViewModel
{
    public class MainPageViewModel
    {
        public IReadOnlyList<Product> Products { get; set; }
    }
}
