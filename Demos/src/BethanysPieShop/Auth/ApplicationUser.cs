using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BethanysPieShop.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime Birthdate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}