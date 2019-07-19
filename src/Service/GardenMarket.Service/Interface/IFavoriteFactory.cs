using GardenMarket.Models;

namespace GardenMarket.Service.Interface
{
    public interface IFavoriteFactory
    {
        Favorite Create(int productId, string userId);
    }
}