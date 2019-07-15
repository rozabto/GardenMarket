using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace GardenMarket.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser() : base() { }

        public string ImagePath { get; set; }
    }
}
