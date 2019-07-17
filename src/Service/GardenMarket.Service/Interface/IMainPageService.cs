using GardenMarket.ViewModel;
using System.Threading.Tasks;

namespace GardenMarket.Service.Interface
{
    public interface IMainPageService
    {
        Task<MainPageViewModel> GetViewModel();
    }
}
