using Microsoft.AspNetCore.Mvc;
using ScentShop.Models;
using ScentShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScentShop.Controllers
{
    public class PerfumeController : Controller
    {
        private readonly IPerfumeRepository _perfumeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PerfumeController(IPerfumeRepository perfumeRepository, ICategoryRepository categoryRepository)
        {
            this._perfumeRepository = perfumeRepository;
            this._categoryRepository = categoryRepository;
        }

        //public ViewResult List()
        //{
        //    PerfumesListViewModel perfumesListViewModel = new PerfumesListViewModel
        //    {
        //        Perfumes = _perfumeRepository.GetAllPerfumes(),

        //        CurrentCategory = "For Her & For Him"
        //    };

        //    return View(perfumesListViewModel);
        //}


        public ViewResult List(string category, string searchString)
        {
            IEnumerable<Perfume> perfumes;
            string currentCategory;

            perfumes = _perfumeRepository.GetAllPerfumes();
            currentCategory = "All Perfumes";

            if (!string.IsNullOrEmpty(searchString))
            {
                perfumes = _perfumeRepository.GetAllPerfumesByName(searchString);
            }

            if (!string.IsNullOrEmpty(category))
            {
                currentCategory = _categoryRepository.GetAllCategories()
                    .FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }

            var perfumeListViewModel = new PerfumesListViewModel
            {
                Perfumes = perfumes,
                SearchString = searchString,
                CurrentCategory = currentCategory

            };

            return View(perfumeListViewModel);
        }


        public IActionResult Details(int id)
        {
            var perfume = _perfumeRepository.GetById(id);

            if (perfume == null)
            {
                return NotFound();
            }

            return View(perfume);
        }
    }
}
