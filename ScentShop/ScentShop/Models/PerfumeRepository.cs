using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace ScentShop.Models
{
    public class PerfumeRepository : IPerfumeRepository
    {
        private readonly AppDbContext _appDbContext;

        public PerfumeRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public IEnumerable<Perfume> GetAllPerfumes()
        {
            return _appDbContext.Perfumes.Include(c => c.Category);
        }

        public Perfume GetById(int perfumeId)
        {
            return _appDbContext.Perfumes.SingleOrDefault(p => p.Id == perfumeId);
        }

        public IEnumerable<Perfume> PerfumesOfTheWeek()
        {
            return _appDbContext.Perfumes.Include(c => c.Category).Where(p => p.IsPerfumeOfTheWeek == true);
        }
    }
}
