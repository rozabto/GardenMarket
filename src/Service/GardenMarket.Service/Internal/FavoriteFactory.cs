using GardenMarket.Models;
using GardenMarket.Service.Interface;

namespace GardenMarket.Service.Internal
{
    public class FavoriteFactory : IFavoriteFactory
    {
        public Favorite Create(int productId, string userId) =>
            new Favorite
            {
                ProductId = productId,
                UserId = userId,
                IsLicked = true
            };
    }
}
