using System;
using System.Collections.Generic;
using System.Text;

namespace GardenMarket.ViewModels
{
    public class HomePageViewModel
    {
        public IList<ProductSampleViewModel> ProductSample { get; set; }
        public string Name { get; set; }
    }
}
