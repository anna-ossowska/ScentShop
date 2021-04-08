using Microsoft.AspNetCore.Mvc;
using ScentShop.Models;
using ScentShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScentShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IPerfumeRepository _perfumeRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IPerfumeRepository perfumeRepository, ShoppingCart shoppingCart)
        {
            this._perfumeRepository = perfumeRepository;
            this._shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCarViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart
            };

            return View(shoppingCarViewModel);
        }
    }
}
