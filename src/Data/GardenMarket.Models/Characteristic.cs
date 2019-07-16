using System.Collections.Generic;

namespace GardenMarket.Models
{
    public class Characteristic
    {
        public Characteristic()
        {
            CharacteristicCategories = new HashSet<CharacteristicCategory>();
            Types = new HashSet<FlowerType>();
        }

        public int Id { get; set; }
        public bool Display { get; set; }
        public string Name { get; set; }
        public virtual ICollection<CharacteristicCategory> CharacteristicCategories { get; set; }
        public virtual ICollection<FlowerType> Types { get; set; }
    }
}