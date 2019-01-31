using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreVjezbaMvc.Data.Interfaces;
using CoreVjezbaMvc.Data.Model;

namespace CoreVjezbaMvc.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> Category => _appDbContext.Category;
    }
}
