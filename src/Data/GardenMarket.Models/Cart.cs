namespace GardenMarket.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
    }
}
