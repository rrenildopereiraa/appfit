namespace Appfit.Models
{
    public class AppfitSubscription
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public AppfitUser? User { get; set; }
        public int GymId { get; set; }
        public AppfitGym? Gym { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsSubscribed { get; set; }
    }
}
