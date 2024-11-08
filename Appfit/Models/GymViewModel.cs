using System.ComponentModel.DataAnnotations;

namespace Appfit.Models
{
    public class GymViewModel
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string LocationName { get; set; } = "";

        [MaxLength(200)]
        public string Address { get; set; } = "";

        [MaxLength(20)]
        public string Phone { get; set; } = "";

        [MaxLength(100)]
        public string OpeningHours { get; set; } = "";

        [MaxLength(100)]
        public string ImageFileName { get; set; } = "";
    }
}
