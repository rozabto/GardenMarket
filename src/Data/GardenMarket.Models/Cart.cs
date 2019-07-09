namespace GardenMarket.Models
{
    public class Cart
    {
        public string Id { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
        public string UserId { get; set; }
    }
}