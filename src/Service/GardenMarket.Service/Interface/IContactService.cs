using GardenMarket.ViewModel;
using System.Threading.Tasks;

namespace GardenMarket.Service.Interface
{
    public interface IContactService
    {
        Task<ContactViewModel> GetViewModel();
        Task<ContactViewModel> GetViewModel(string firstname, string lastname, string email, string subject);
    }
}
