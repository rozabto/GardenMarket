namespace GardenMarket.Models
{
    public class ProductColor
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
