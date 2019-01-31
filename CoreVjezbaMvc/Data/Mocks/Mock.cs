using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreVjezbaMvc.Data.Interfaces;
using CoreVjezbaMvc.Data.Model;

namespace CoreVjezbaMvc.Data
{
    public class MockCategoryRep : ICategoryRepository
    {
        public IEnumerable<Category> Category
        {
            get
            {
                return new List<Category>
                     {
                         new Category {  CategoryName= "Alcoholic", Desc = "All alcoholic drinks" },
                         new Category { CategoryName = "Non-alcoholic", Desc = "All non-alcoholic drinks" }
                     };
            }
        }

       
    }
}
