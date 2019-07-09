using System.Collections.Generic;
using System.Threading.Tasks;

namespace GardenMarket.Service
{
    public interface IServiceModel<T>
    {
        IList<T> GetAll();
        T GetById(string id);
        void Add(T obj);
        void Remove(T obj);
        Task<IList<T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);
        Task AddAsync(T obj);
        Task RemoveAsync(T obj);
    }
}
