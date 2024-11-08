using System.ComponentModel.DataAnnotations;

namespace Appfit.Models
{
    public class ClassViewModel
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        [MaxLength(50)]
        public string Category { get; set; } = "";

        public int GymId { get; set; }

        public GymViewModel Gym { get; set; }

        public string? CoachId { get; set; }
        public UserViewModel Coach { get; set; }

        public int MaxAttendees { get; set; } = 20;

        public TimeSpan Duration { get; set; }
        public DateTime StartTime { get; set; }
    }
}
