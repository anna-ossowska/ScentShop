using ScentShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScentShop.ViewModels
{
    public class DetailsViewModel
    {
        public Perfume Perfume { get; set; }
        public string InStock { get; set; }
        public int CategoryId { get; set; }
    }
}
