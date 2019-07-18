using System.Collections.Generic;

namespace GardenMarket.Models
{
    public class SubCategory
    {
        public SubCategory()
        {
            SubSubCategories = new List<SubSubCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public IReadOnlyList<SubSubCategory> SubSubCategories { get; set; }
    }
}
