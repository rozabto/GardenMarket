using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace GardenMarket.Models
{
    public class User : IdentityUser
    {
        public string ImagePath { get; set; }
    }
}
