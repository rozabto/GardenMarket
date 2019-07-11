using System;

namespace GardenMarket.Models
{
    public class Promotion
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime CratedOn { get; set; }
        public DateTime PromotionStart { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string ImagePath { get; set; }
    }
}
