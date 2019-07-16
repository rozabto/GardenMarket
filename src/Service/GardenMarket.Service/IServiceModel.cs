using System.Collections.Generic;
using System.Threading.Tasks;

namespace GardenMarket.Service
{
    public interface IServiceModel<T>
    {
        IReadOnlyList<T> GetAll();

        T GetById(int id);

        void Add(T obj);

        void Remove(T obj);

        Task<IReadOnlyList<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task AddAsync(T obj);

        Task RemoveAsync(T obj);
    }
}