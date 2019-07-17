namespace GardenMarket.Models
{
    public class ProductType
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int CharacteristicTypeId { get; set; }
        public virtual CharacteristicType CharacteristicType { get; set; }
    }
}
