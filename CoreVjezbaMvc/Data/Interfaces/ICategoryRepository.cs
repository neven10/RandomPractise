using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreVjezbaMvc.Data.Model;

namespace CoreVjezbaMvc.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Category { get; }
    }
}
