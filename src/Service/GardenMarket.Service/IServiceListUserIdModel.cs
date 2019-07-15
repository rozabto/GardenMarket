using System.Collections.Generic;
using System.Threading.Tasks;

namespace GardenMarket.Service
{
    public interface IServiceListUserIdModel<T>
    {
        IReadOnlyList<T> GetAllByUserId(string id);
        Task<IReadOnlyList<T>> GetAllByUserIdAsync(string id);
    }
}
