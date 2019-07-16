using Microsoft.AspNetCore.Identity;

namespace GardenMarket.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser() : base()
        {
        }

        public string ImagePath { get; set; }
    }
}