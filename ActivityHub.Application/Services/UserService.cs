using ActivityHub.Application.DTOs;
using ActivityHub.Application.Interfaces;
using ActivityHub.Domain.Entities;
using ActivityHub.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityHub.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task AddUserAsync(CreateUserDto createUserDto)
        {
            var user = new User
            {
                FirstName = createUserDto.FirstName,
                LastName = createUserDto.LastName,
                Email = createUserDto.Email,
                Password = createUserDto.Password
            };
            await _userRepository.AddAsync(user);
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return users.Select(user => new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            });
        }

        public async Task<UserDto> GetUserByIdAsync(Guid id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };
        }
    }
}
