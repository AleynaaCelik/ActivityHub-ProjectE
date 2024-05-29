using ActivityHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ActivityHub.Domain.Interfaces
{
    public interface IActivityRepository
    {
        Task AddAsync(Activity entity);
        Task<IEnumerable<Activity>> GetAllAsync();
        Task<Activity> GetByIdAsync(Guid id);
        Task UpdateAsync(Activity entity);
        Task DeleteAsync(Guid id);
    }
}
