using System.Collections.Generic;

namespace GardenMarket.Models
{
    public class Category
    {
        public Category()
        {
            SubCategories = new HashSet<SubCategory>();
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubCategoriesId { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
