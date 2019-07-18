namespace GardenMarket.Models
{
    public class CharacteristicCategory
    {
        public int Id { get; set; }
        public int CharacteristicId { get; set; }
        public Characteristic Characteristic { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
