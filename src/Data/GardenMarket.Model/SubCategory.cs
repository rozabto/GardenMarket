using System.Collections.Generic;

namespace GardenMarket.Models
{
    public class SubCategory
    {
        public SubCategory()
        {
            Products = new HashSet<Product>();
            Characteristics = new HashSet<Characteristic>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Characteristic> Characteristics { get; set; }
    }
}
