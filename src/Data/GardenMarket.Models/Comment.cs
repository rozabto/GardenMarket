using Microsoft.AspNetCore.Identity;
using System;

namespace GardenMarket.Models
{
    public class Comment
    {
        public string Id { get; set; }
        public string ProductId { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public string CommentId { get; set; }
        public Comment Parent { get; set; }
        public string Message { get; set; }
        public byte Review { get; set; }
        public DateTime Posted { get; set; }
    }
}