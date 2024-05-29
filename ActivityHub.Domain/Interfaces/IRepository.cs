using ActivityHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ActivityHub.Domain.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid id);

        // Async methods
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(Guid id);
    }
}
