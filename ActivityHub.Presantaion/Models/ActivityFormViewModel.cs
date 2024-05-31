using ActivityHub.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ActivityHub.Presantaion.Models
{
    public class ActivityFormViewModel
    {
        [Required]
        public ActivityType Type { get; set; }
    }
}
