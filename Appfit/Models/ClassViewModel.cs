using System.ComponentModel.DataAnnotations;

namespace Appfit.Models
{
    public class ClassViewModel
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Category { get; set; } = string.Empty;

        public int GymId { get; set; }

        public GymViewModel? Gym { get; set; }

        public string? CoachId { get; set; }
        public UserViewModel? Coach { get; set; }

        public int MaxAttendees { get; set; } = 20;

        public TimeSpan Duration { get; set; }
        public DateTime StartTime { get; set; }
    }
}
