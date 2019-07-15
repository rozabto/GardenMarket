using System.Collections.Generic;

namespace GardenMarket.Models
{
    public class SubSubCategory
    {
        public SubSubCategory()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public float LowestPrice { get; set; }
        public float HighestPrice { get; set; }
        public string Name { get; set; }
        public int SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
