namespace ActivityHub.Domain.Entities
{
    public class UserActivity : EntityBase
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid ActivityId { get; set; }
        public Activity Activity { get; set; }
    }
}
