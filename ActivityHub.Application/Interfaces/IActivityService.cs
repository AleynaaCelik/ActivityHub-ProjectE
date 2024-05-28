using ActivityHub.Application.DTOs;

namespace ActivityHub.Application.Interfaces
{
    public interface IActivityService
    {
        Task AddActivityAsync(CreateActivityDto createActivityDto);
        Task<IEnumerable<ActivityDto>> GetAllActivitiesAsync();
        Task<ActivityDto> GetActivityByIdAsync(Guid id);
        Task UpdateActivityAsync(Guid id, CreateActivityDto createActivityDto);
        Task DeleteActivityAsync(Guid id);
    }
}
