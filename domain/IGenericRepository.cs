using System.Collections.Generic;
using System.Threading.Tasks;

namespace domain
{
    //Used from https://github.com/ahuimanu/CIDM4390/blob/SPRING2022/Testing/domain/IGenericRepository.cs
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetById(object id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}