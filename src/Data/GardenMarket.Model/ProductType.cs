namespace GardenMarket.Models
{
    public class ProductType
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public FlowerType Type { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
