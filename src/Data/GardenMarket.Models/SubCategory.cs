using System.Collections.Generic;

namespace GardenMarket.Models
{
    public class SubCategory
    {
        public SubCategory()
        {
            SubSubCategories = new HashSet<SubSubCategory>();
            CharacteristicCategories = new HashSet<CharacteristicCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int SubSubCategoriesId { get; set; }
        public virtual ICollection<SubSubCategory> SubSubCategories { get; set; }
        public int CharacteristicCategoriesId { get; set; }
        public virtual ICollection<CharacteristicCategory> CharacteristicCategories { get; set; }
    }
}
