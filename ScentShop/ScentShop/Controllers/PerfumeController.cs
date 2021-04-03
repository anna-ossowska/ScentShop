using Microsoft.AspNetCore.Mvc;
using ScentShop.Models;
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

        public ViewResult List()
        {
            return View(_perfumeRepository.GetAllPerfumes());
        }
    }
}
