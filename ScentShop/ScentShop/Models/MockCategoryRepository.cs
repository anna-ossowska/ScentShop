using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScentShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories()
        {
            return new List<Category>()
            {
                new Category{CategoryId = 1, CategoryName = "For Her"},
                new Category{CategoryId = 2, CategoryName = "For Him"}
            };
        }
    }
}
