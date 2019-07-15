using System.Collections.Generic;
using System.Threading.Tasks;

namespace GardenMarket.Service
{
    public interface IServiceListIdModel<T>
    {
        IReadOnlyList<T> GetAllById(int id);
        Task<IReadOnlyList<T>> GetAllByIdAsync(int id);
    }
}
