using ActivityHub.Application.DTOs;

namespace ActivityHub.Application.Interfaces
{
    public interface IUserService
    {
        Task AddUserAsync(CreateUserDto createUserDto);
        Task<IEnumerable<UserDto>> GetAllUsersAsync();
        Task<UserDto> GetUserByIdAsync(Guid id);
    }
}
