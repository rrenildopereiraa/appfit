namespace Appfit.Models
{
    public class BookingViewModel
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public UserViewModel User { get; set; }

        public int WorkoutClassId { get; set; }
        public ClassViewModel WorkoutClass { get; set; }

        public DateTime BookingDate { get; set; }
        public bool isConfirmed { get; set; }
    }
}
