using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreVjezbaMvc.Data.Model
{
    public class Drink
    {
        public int DrinkId { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsPrefered { get; set; }
        public int InStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
