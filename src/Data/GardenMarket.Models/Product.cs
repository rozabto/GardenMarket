using GardenMarket.Models.Enum;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace GardenMarket.Models
{
    public class Product
    {
        public Product()
        {
            Comments = new HashSet<Comment>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Characteristics { get; set; }
        public int Sales { get; set; }
        public int InStock { get; set; }
        public Brand Brand { get; set; }
        public FlowerType Type { get; set; }
        public FlowerColor Color { get; set; }
        public Category Category { get; set; }
        public SubCategory SubCategory { get; set; }
        public SubSubCategory SubSubCategory { get; set; }
        public DateTime Posted { get; set; }
        public DateTime? Deleted { get; set; }
        public virtual IdentityUser User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}