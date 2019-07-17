using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace GardenMarket.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Comments = new List<Comment>();
        }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}