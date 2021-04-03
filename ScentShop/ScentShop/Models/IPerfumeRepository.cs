using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScentShop.Models
{
    public interface IPerfumeRepository
    {
        IEnumerable<Perfume> GetAllPerfumes();
        IEnumerable<Perfume> PerfumesOfTheWeek();
        Perfume GetById(int perfumeId);
    }
}
