using ScentShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScentShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Perfume> PerfumesOfTheWeek { get; set; }
    }
}
