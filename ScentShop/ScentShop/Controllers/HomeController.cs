using Microsoft.AspNetCore.Mvc;
using ScentShop.Models;
using ScentShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScentShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPerfumeRepository _perfumeRepository;

        public HomeController(IPerfumeRepository perfumeRepository)
        {
            this._perfumeRepository = perfumeRepository;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                PerfumesOfTheWeek = _perfumeRepository.PerfumesOfTheWeek()
            };

            return View(homeViewModel);
        }
    }
}
