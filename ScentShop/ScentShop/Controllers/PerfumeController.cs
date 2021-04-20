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


        public ViewResult List(string category, string searchString, string sortOrder)
        {
            IEnumerable<Perfume> perfumes;
            string currentCategory;

            perfumes = _perfumeRepository.GetAllPerfumes();
            currentCategory = "All Perfumes";

            if (string.IsNullOrEmpty(category))
            {
                perfumes = _perfumeRepository.GetAllPerfumes();
                currentCategory = "All Perfumes";
            }
            else
            {
                perfumes = _perfumeRepository.GetAllPerfumes()
                    .Where(p => p.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategories()
                    .FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }

            if (!string.IsNullOrEmpty(searchString))
            {
                perfumes = _perfumeRepository.GetAllPerfumesByName(searchString);
            }

            ViewBag.NameSortParam = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.PriceSortParam = sortOrder == "price_desc" ? "price_asc" : "price_desc";
            ViewBag.BrandSortParam = sortOrder == "brand_desc" ? "brand_asc" : "brand_desc";
            ViewBag.CapacitySortParam = sortOrder == "capacity_desc" ? "capacity_asc" : "capacity_desc";

            switch (sortOrder)
            {
                case "name_desc":
                    perfumes = perfumes.OrderByDescending(p => p.Name);
                    break;
                case "price_asc":
                    perfumes = perfumes.OrderBy(p => p.Price);
                    break;
                case "price_desc":
                    perfumes = perfumes.OrderByDescending(p => p.Price);
                    break;
                case "brand_asc":
                    perfumes = perfumes.OrderBy(p => p.Brand);
                    break;
                case "brand_desc":
                    perfumes = perfumes.OrderByDescending(p => p.Brand);
                    break;
                case "capacity_asc":
                    perfumes = perfumes.OrderBy(p => p.Capacity);
                    break;
                case "capacity_desc":
                    perfumes = perfumes.OrderByDescending(p => p.Capacity);
                    break;
                default:
                    perfumes = perfumes.OrderBy(p => p.Name);
                    break;
            }

            var perfumeListViewModel = new PerfumesListViewModel
            {
                Perfumes = perfumes,
                SearchString = searchString,
                CurrentCategory = currentCategory
            };

            return View(perfumeListViewModel);
        }

        public ViewResult Details(int id)
        {
            var perfume = _perfumeRepository.GetById(id);

            var categoryId = perfume.CategoryId;

            string isInStock;

            if (perfume.InStock)
            {
                isInStock = "In Stock";
            }
            else
            {
                isInStock = "Out of Stock";
            }

            var detailsViewModel = new DetailsViewModel
            {
                Perfume = perfume,
                InStock = isInStock,
                CategoryId = categoryId
            };

            return View(detailsViewModel);
        }
    }
}
