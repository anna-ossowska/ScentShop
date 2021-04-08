using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScentShop.Models;

namespace ScentShop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public decimal Total { get; set; }
        public Perfume Perfume { get; set; }
    }
}
