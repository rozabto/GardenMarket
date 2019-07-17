namespace GardenMarket.Models
{
    public class CharacteristicType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CharacteristicId { get; set; }
        public virtual Characteristic Characteristic { get; set; }
    }
}
