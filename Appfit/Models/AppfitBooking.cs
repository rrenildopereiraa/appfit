namespace Appfit.Models
{
    public class AppfitBooking
    {
        public int Id { get; set; }

        public string? UserId { get; set; }
        public AppfitUser? User { get; set; }

        public int WorkoutClassId { get; set; }
        public AppfitClass? WorkoutClass { get; set; }

        public DateTime BookingDate { get; set; }
        public bool isConfirmed { get; set; }
    }
}
