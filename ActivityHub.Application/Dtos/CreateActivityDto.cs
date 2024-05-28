using ActivityHub.Domain.Enums;

namespace ActivityHub.Application.DTOs
{
    public class CreateActivityDto
    {
        public string Name { get; set; }
        public ActivityType Type { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
    }
}
