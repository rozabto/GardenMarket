using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace GardenMarket.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            Products = new HashSet<Product>();
            Favorites = new HashSet<Favorite>();
            Carts = new HashSet<Cart>();
            Promotions = new HashSet<Promotion>();
        }

        public string ImagePath { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Promotion> Promotions { get; set; }
    }
}
