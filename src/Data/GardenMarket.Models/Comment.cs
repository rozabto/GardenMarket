using System;

namespace GardenMarket.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime Posted { get; set; }
    }
}
