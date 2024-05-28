using ActivityHub.Domain.Enums;

namespace ActivityHub.Application.DTOs
{
    public class ActivityDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ActivityType Type { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
    }
}
