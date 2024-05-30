using ActivityHub.Domain.Enums;

namespace ActivityHub.Domain.Entities
{
    public class Activity : EntityBase
    {
        public string Name { get; set; }
        public ActivityType Type { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }

        // Navigation property
        public ICollection<UserActivity> UserActivities { get; set; }
    }
}
