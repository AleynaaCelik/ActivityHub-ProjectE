using ActivityHub.Domain.Entities;

namespace ActivityHub.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(Guid id);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(Guid id);


        //Task GetByIdAsync(Guid id);
    }
}
