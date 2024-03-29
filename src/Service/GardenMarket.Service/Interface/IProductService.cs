﻿using GardenMarket.ViewModel;
using System.Threading.Tasks;

namespace GardenMarket.Service.Interface
{
    public interface IProductService
    {
        Task<ProductViewModel> GetViewModel(int id);
    }
}
