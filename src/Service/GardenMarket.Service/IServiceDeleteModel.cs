using System.Collections.Generic;
using System.Threading.Tasks;

namespace GardenMarket.Service
{
    public interface IServiceDeleteModel<T>
    {
        IList<T> GetAllIncludingRemoved();
        IList<T> GetRemoved();
        void RemovePermanently(T obj);
        Task<IList<T>> GetAllIncludingRemovedAsync();
        Task<IList<T>> GetRemovedAsync();
        Task RemovePermanentlyAsync(T obj);
    }
}
