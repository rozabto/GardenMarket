using System.Collections.Generic;
using System.Threading.Tasks;

namespace GardenMarket.Service
{
    public interface IServiceDeleteModel<T>
    {
        IReadOnlyList<T> GetAllIncludingRemoved();
        IReadOnlyList<T> GetRemoved();
        void RemovePermanently(T obj);
        Task<IReadOnlyList<T>> GetAllIncludingRemovedAsync();
        Task<IReadOnlyList<T>> GetRemovedAsync();
        Task RemovePermanentlyAsync(T obj);
    }
}
