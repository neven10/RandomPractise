using System.Collections.Generic;

namespace CoreVjezbaMvc.Data.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Desc { get; set; }
        public List<Drink>  Drinks { get; set; }
}
}