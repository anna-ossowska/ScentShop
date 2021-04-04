using ScentShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScentShop.ViewModels
{
    public class PerfumesListViewModel
    {
        public IEnumerable<Perfume> Perfumes { get; set; }
        public string CurrentCategory { get; set; }
    }
}
