using System.Collections.Generic;

namespace GardenMarket.Models
{
    public class FlowerType
    {
        public FlowerType()
        {
            ProductTypes = new HashSet<ProductType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ProductId { get; set; }
        public int CharacteristicId { get; set; }
        public virtual Characteristic Characteristic { get; set; }
        public virtual ICollection<ProductType> ProductTypes { get; set; }
    }
}