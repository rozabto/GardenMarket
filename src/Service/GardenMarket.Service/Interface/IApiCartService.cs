using System.Threading.Tasks;

namespace GardenMarket.Service.Interface
{
    public interface IApiCartService
    {
        Task Check(int id, string userId);
    }
}
