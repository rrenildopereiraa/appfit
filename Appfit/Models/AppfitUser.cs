﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Appfit.Models
{
    public class AppfitUser : IdentityUser
    {

        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [MaxLength(20)]
        public string Phone { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Address { get; set; } = string.Empty;

        [MaxLength(100)]
        public string ImageFileName { get; set; } = string.Empty;

        public DateTime RegisteredAt { get; set; }
    }
}