using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace GardenMarket.Models
{
    public class Comment
    {
        public string Id { get; set; }
        public virtual Product Product { get; set; }
        public virtual IdentityUser User { get; set; }
        public virtual Comment Parent { get; set; }
        public string Message { get; set; }
        public DateTime Posted { get; set; }
        public DateTime? Deleted { get; set; }
        public virtual ICollection<Comment> Children { get; set; }
    }
}