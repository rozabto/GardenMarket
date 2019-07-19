using GardenMarket.Models;

namespace GardenMarket.Service.Interface
{
    public interface ICartFactory
    {
        Cart Create(int productId, string userId);
    }
}
