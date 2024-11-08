using System.ComponentModel.DataAnnotations;

namespace Appfit.Models
{
    public class GymDto
    {
        [Required, MaxLength(100)]
        public string LocationName { get; set; } = "";

        [Required, MaxLength(200)]
        public string Address { get; set; } = "";

        [Required, MaxLength(20)]
        public string Phone { get; set; } = "";

        [Required, MaxLength(100)]
        public string OpeningHours { get; set; } = "";
        public IFormFile? ImageFile { get; set; }
    }
}
