using GardenMarket.Models;

namespace GardenMarket.Service.Interface
{
    public interface IFavoriteService : IServiceModel<Favorite>, IServiceListUserIdModel<Favorite>
    {
    }
}