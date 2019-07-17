namespace GardenMarket.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public string UserId { get; set; }
        public virtual AppUser User { get; set; }
    }
}
