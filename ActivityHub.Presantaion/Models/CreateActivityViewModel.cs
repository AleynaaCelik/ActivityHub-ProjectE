using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ActivityHub.Presantaion.Models
{
    public class CreateActivityViewModel
    {
        [Required]
        public string OutdoorOrIndoor { get; set; }

        [Required]
        public List<string> Interests { get; set; } = new List<string>();

        [Required]
        public string CrowdPreference { get; set; }
    }
}
