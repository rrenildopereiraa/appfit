using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Appfit.Models
{
    public class UserViewModel : IdentityUser
    {

        [MaxLength(50)]
        public string FirstName { get; set; } = "";

        [MaxLength(50)]
        public string LastName { get; set; } = "";

        [MaxLength(20)]
        public string Phone { get; set; } = "";

        [MaxLength(100)]
        public string Address { get; set; } = "";

        [MaxLength(100)]
        public string ImageFileName { get; set; } = "";

        public DateTime RegisteredAt { get; set; }
    }
}
