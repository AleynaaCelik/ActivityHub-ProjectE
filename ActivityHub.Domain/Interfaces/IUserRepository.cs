using ActivityHub.Domain.Entities;

namespace ActivityHub.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task GetByIdAsync(Guid id);
    }
}
