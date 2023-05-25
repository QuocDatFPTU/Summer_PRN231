using System;
using System.Collections.Generic;

#nullable disable

namespace NguyenQuocDat_SE1608_A01.Core.Entities
{
    public partial class Category
    {
        public Category()
        {
            FlowerBouquets = new HashSet<FlowerBouquet>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public virtual ICollection<FlowerBouquet> FlowerBouquets { get; set; }
    }
}
