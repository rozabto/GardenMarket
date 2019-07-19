using GardenMarket.Models;
using GardenMarket.Service.Interface;

namespace GardenMarket.Service.Internal
{
    public class CartFactory : ICartFactory
    {
        public Cart Create(int productId, string userId) =>
            new Cart
            {
                Amount = 1,
                ProductId = productId,
                UserId = userId
            };
    }
}
