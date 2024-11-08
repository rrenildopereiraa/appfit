using System.ComponentModel.DataAnnotations;

namespace Appfit.Models
{
    public class GymDto
    {
        [Required, MaxLength(100)]
        public string LocationName { get; set; } = string.Empty;

        [Required, MaxLength(200)]
        public string Address { get; set; } = string.Empty;

        [Required, MaxLength(20)]
        public string Phone { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string OpeningHours { get; set; } = string.Empty;
        public IFormFile? ImageFile { get; set; }
    }
}
