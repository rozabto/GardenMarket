namespace GardenMarket.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        public bool IsLicked { get; set; }
        public string UserId { get; set; }
        public virtual AppUser User { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
