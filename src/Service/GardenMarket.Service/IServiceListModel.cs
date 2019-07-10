using System.Collections.Generic;
using System.Threading.Tasks;

namespace GardenMarket.Service
{
    public interface IServiceListModel<T>
    {
        IList<T> GetAllByUserId(string id);
        Task<IList<T>> GetAllByUserIdAsync(string id);
    }
}
