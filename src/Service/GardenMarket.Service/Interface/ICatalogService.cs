using GardenMarket.ViewModel;
using System.Threading.Tasks;

namespace GardenMarket.Service.Interface
{
    public interface ICatalogService
    {
        Task<CatalogViewModel> GetViewModel(int id);
    }
}
