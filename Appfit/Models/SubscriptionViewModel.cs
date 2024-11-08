namespace Appfit.Models
{
    public class SubscriptionViewModel
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public UserViewModel User { get; set; }
        public int GymId { get; set; }
        public GymViewModel Gym { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsSubscribed { get; set; }
    }
}
