using GardenMarket.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace GardenMarket.Service.Interface
{
    public interface IProductService
    {
        IList<ProductSampleViewModel> GetAll();
    }
}
