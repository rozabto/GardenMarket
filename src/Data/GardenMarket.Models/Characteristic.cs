using System.Collections.Generic;

namespace GardenMarket.Models
{
    public class Characteristic
    {
        public Characteristic()
        {
            Types = new HashSet<FlowerType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual ICollection<FlowerType> Types { get; set; }
    }
}
