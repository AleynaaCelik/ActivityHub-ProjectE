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
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepository;

        public ActivityService(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }

        public async Task AddActivityAsync(CreateActivityDto createActivityDto)
        {
            var activity = new Activity
            {
                Name = createActivityDto.Name,
                Type = createActivityDto.Type,
                Date = createActivityDto.Date,
                Description = createActivityDto.Description,
                UserId = createActivityDto.UserId
            };
            await _activityRepository.AddAsync(activity);
        }

        public async Task<IEnumerable<ActivityDto>> GetAllActivitiesAsync()
        {
            var activities = await _activityRepository.GetAllAsync();
            return activities.Select(activity => MapToActivityDto(activity));
        }

        public async Task<ActivityDto> GetActivityByIdAsync(Guid id)
        {
            var activity = await _activityRepository.GetByIdAsync(id);
            return MapToActivityDto(activity);
        }

        public async Task UpdateActivityAsync(Guid id, CreateActivityDto createActivityDto)
        {
            var activity = new Activity
            {
                Id = id,
                Name = createActivityDto.Name,
                Type = createActivityDto.Type,
                Date = createActivityDto.Date,
                Description = createActivityDto.Description,
                UserId = createActivityDto.UserId
            };
            await _activityRepository.UpdateAsync(activity);
        }

        public async Task DeleteActivityAsync(Guid id)
        {
            await _activityRepository.DeleteAsync(id);
        }

        private ActivityDto MapToActivityDto(Activity activity)
        {
            return new ActivityDto
            {
                Id = activity.Id,
                Name = activity.Name,
                Type = activity.Type,
                Date = activity.Date,
                Description = activity.Description,
                UserName = activity.User != null ? $"{activity.User.FirstName} {activity.User.LastName}" : string.Empty
            };
        }
    }
}
