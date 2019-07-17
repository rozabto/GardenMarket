using System;
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
        public virtual Category Category { get; set; }
        public ICollection<SubSubCategory> SubSubCategories { get; set; }

        public object Select(Func<object, object> p) => throw new NotImplementedException();
    }
}
