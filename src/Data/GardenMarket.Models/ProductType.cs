namespace GardenMarket.Models
{
    public class ProductType
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CharacteristicTypeId { get; set; }
        public CharacteristicType CharacteristicType { get; set; }
    }
}
