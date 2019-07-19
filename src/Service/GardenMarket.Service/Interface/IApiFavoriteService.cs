using System.Threading.Tasks;

namespace GardenMarket.Service.Interface
{
    public interface IApiFavoriteService
    {
        Task Check(int id, string userId);
    }
}
