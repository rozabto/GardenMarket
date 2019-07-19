using System.Collections.Generic;

namespace GardenMarket.Models
{
    public class SubSubCategory
    {
        public SubSubCategory()
        {
            Products = new List<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public float LowestPrice { get; set; }
        public float HighestPrice { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public IReadOnlyList<Product> Products { get; set; }
    }
}
