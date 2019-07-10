using Microsoft.AspNetCore.Identity;

namespace GardenMarket.Models
{
    public class Favorite
    {
        public string Id { get; set; }
        public virtual Product Product { get; set; }
        public virtual IdentityUser User { get; set; }
    }
}