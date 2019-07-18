using System.Collections.Generic;

namespace GardenMarket.Models
{
    public class Category
    {
        public Category()
        {
            SubCategories = new List<SubCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public IReadOnlyList<SubCategory> SubCategories { get; set; }
    }
}
