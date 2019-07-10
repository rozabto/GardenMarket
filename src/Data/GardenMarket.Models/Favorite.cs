namespace GardenMarket.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        public bool IsLicked { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; }
    }
}