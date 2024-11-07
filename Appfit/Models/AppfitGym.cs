using System.ComponentModel.DataAnnotations;

namespace Appfit.Models
{
    public class AppfitGym
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string LocationName { get; set; } = string.Empty;

        [MaxLength(200)]
        public string Address { get; set; } = string.Empty;

        [MaxLength(20)]
        public string Phone { get; set; } = string.Empty;
        public string OpeningHours { get; set; } = string.Empty;
    }
}
