using Microsoft.AspNetCore.Mvc;
using ScentShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScentShop.Components
{
    public class CategoryTag : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryTag(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.GetAllCategories();

            return View(categories);
        }
    }
}
