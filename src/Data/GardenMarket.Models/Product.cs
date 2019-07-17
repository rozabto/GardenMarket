using System;
using System.Collections.Generic;

namespace GardenMarket.Models
{
    public class Product
    {
        public Product()
        {
            Images = new List<ProductImage>();
            Types = new List<ProductType>();
            Colors = new List<ProductColor>();
            Comments = new List<Comment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Sales { get; set; }
        public int InStock { get; set; }
        public bool HasDiscount { get; set; }
        public int? PrecentDiscount { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int SubSubCategoryId { get; set; }
        public virtual SubSubCategory SubSubCategory { get; set; }
        public string UserId { get; set; }
        public virtual AppUser User { get; set; }
        public int? PromotionId { get; set; }
        public virtual Promotion Promotion { get; set; }
        public DateTime? DiscountStart { get; set; }
        public TimeSpan? DiscountEnd { get; set; }
        public ICollection<ProductImage> Images { get; set; }
        public ICollection<ProductType> Types { get; set; }
        public ICollection<ProductColor> Colors { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
