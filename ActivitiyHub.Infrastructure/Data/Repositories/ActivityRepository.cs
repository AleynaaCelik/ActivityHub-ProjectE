using ActivityHub.Domain.Entities;
using ActivityHub.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ActivitiyHub.Infrastructure.Data.Repositories
{
    public class ActivityRepository : Repository<Activity>, IActivityRepository
    {
        private readonly ApplicationDbContext _context;

        public ActivityRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddAsync(Activity entity)
        {
            await _context.Activities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Activity>> GetAllAsync()
        {
            return await _context.Activities.ToListAsync();
        }

        public async Task<Activity> GetByIdAsync(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }

        public async Task UpdateAsync(Activity entity)
        {
            _context.Activities.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var activity = await _context.Activities.FindAsync(id);
            if (activity != null)
            {
                _context.Activities.Remove(activity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
