using GardenMarket.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GardenMarket.Service.Interface
{
    public interface IHeaderService
    {
        Task<HeaderViewModel> GetViewModel(IReadOnlyList<int> productIds);
    }
}
