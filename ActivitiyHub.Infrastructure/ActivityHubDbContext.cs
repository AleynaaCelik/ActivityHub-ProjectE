using ActivityHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitiyHub.Infrastructure
{
    public class ActivityHubDbContext : DbContext
    {
        public ActivityHubDbContext(DbContextOptions<ActivityHubDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Additional configuration if needed
        }
    }
}
