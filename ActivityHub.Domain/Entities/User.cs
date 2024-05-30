namespace ActivityHub.Domain.Entities
{
    public class User : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Navigation property
        public ICollection<UserActivity> UserActivities { get; set; }
    }
}
