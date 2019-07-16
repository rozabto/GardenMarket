using GardenMarket.Models;

namespace GardenMarket.Service.Interface
{
    public interface IProductService : IServiceModel<Product>, IServiceDeleteModel<Product>, IServiceListIdModel<Product>
    {
    }
}