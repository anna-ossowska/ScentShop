using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScentShop.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int PerfumeId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Perfume Perfume { get; set; }
        public Order Order { get; set; }
    }
}
