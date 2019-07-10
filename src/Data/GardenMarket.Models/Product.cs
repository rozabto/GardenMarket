using System;
using System.Collections.Generic;

namespace GardenMarket.Models
{
    public class Product
    {
        public Product()
        {
            ProductTypes = new HashSet<ProductType>();
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Sales { get; set; }
        public int InStock { get; set; }
        public bool HasDiscount { get; set; }
        public int? PrecentDiscount { get; set; }
        public int SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? Deleted { get; set; }
        public DateTime? DiscountStart { get; set; }
        public TimeSpan? DiscountEnd { get; set; }
        public int? TypeId { get; set; }
        public int? CommentId { get; set; }
        public virtual ICollection<ProductType> ProductTypes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}