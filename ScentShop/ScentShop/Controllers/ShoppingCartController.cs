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
                ShoppingCart = _shoppingCart,
                Total = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCarViewModel);
        }

        // perfumeId is used in asp-route-perfumeId
        public RedirectToActionResult AddToShoppingCart(int perfumeId)
        {
            var selectedPerfume = _perfumeRepository.GetAllPerfumes().FirstOrDefault(p => p.Id == perfumeId);

            if (selectedPerfume != null)
            {
                _shoppingCart.AddToCart(selectedPerfume, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int perfumeId)
        {
            var selectedPerfume = _perfumeRepository.GetAllPerfumes().FirstOrDefault(p => p.Id == perfumeId);

            if (selectedPerfume != null)
            {
                _shoppingCart.RemoveFromCart(selectedPerfume);
            }
            return RedirectToAction("Index");
        }
    }
}
