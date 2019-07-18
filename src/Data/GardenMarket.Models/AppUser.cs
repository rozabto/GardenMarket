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

        public IReadOnlyList<Comment> Comments { get; set; }
        public IReadOnlyList<Favorite> Favorites { get; set; }
        public IReadOnlyList<Cart> Carts { get; set; }
        public IReadOnlyList<Product> Products { get; set; }
        public IReadOnlyList<Promotion> Promotions { get; set; }
    }
}