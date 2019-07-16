namespace GardenMarket.Models
{
    public class CharacteristicCategory
    {
        public int Id { get; set; }
        public int CharacteristicId { get; set; }
        public virtual Characteristic Characteristic { get; set; }
        public int SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
    }
}