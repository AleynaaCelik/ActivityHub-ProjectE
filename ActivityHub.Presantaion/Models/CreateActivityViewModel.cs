using ActivityHub.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ActivityHub.Presantaion.Models
{
    public class CreateActivityViewModel
    {
        [Required(ErrorMessage = "Etkinlik adı gereklidir.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Etkinlik türü gereklidir.")]
        public ActivityType Type { get; set; }

        [Required(ErrorMessage = "Etkinlik tarihi gereklidir.")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Description { get; set; }

        public Guid UserId { get; set; }
    }
}
