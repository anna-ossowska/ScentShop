using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScentShop.Models
{
    public class MockPerfumeRepository : IPerfumeRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        
        public List<Perfume> perfumes;
        
        public IEnumerable<Perfume> GetAllPerfumes()
        {
            return perfumes = new List<Perfume>()
            {
                new Perfume {Id = 1,
                             Name = "Bright Crystal",
                             Brand = "Versace",
                             Capacity = 198,
                             Price = 140M,
                             Description = "Inspired by a mixture of Donatella Versace's favorite floral fragrances, Bright Crystal is a fresh, sensual blend of refreshing chilled yuzu and pomegranate mingled with soothing blossoms of peony, magnolia, and lotus flower, warmed with notes of musk and amber.",
                             IsPerfumeOfTheWeek = true,
                             InStock = true,
                             Category = _categoryRepository.GetAllCategories().ToList()[0]
                },
                new Perfume {Id = 2,
                             Name = "N°5",
                             Brand = "Chanel",
                             Capacity = 50,
                             Price = 108M,
                             Description = "With its unprecedented use of aldehydes, which add layers of complexity, N°5 was the world’s first abstract fragrance. The Eau de Parfum draws inspiration from the Parfum with which it shares its floral aldehyde signature. This floral bouquet composed around May Rose and Jasmine features bright citrus top notes. Aldehydes create a unique presence while the smooth touch of Bourbon Vanilla leaves an incredibly sensual trail.",
                             IsPerfumeOfTheWeek = false,
                             InStock = true,
                             Category = _categoryRepository.GetAllCategories().ToList()[0]
                },
                new Perfume {Id = 3,
                             Name = "J'adore",
                             Brand = "Dior",
                             Capacity = 100,
                             Price = 135M,
                             Description = "This fragrance opens with the exotic, floral-fruity notes of ylang ylang, while Damascus rose, and both Grasse jasmine and Indian jasmine sambac exude a seductive warmth. This scent is the ultimate expression of femininity and luxury and is floral yet mysterious, a confident signature to celebrate your feminine allure.",
                             IsPerfumeOfTheWeek = true,
                             InStock = true,
                             Category = _categoryRepository.GetAllCategories().ToList()[0]
                },
                new Perfume {Id = 4,
                             Name = "Bleu de Chanel",
                             Brand = "Chanel",
                             Capacity = 50,
                             Price = 80M,
                             Description = "BLEU DE CHANEL unites the invigorating zest of Grapefruit and the power of an aromatic accord with the woody whisper of Dry Cedar. New Caledonian Sandalwood lends it a warm and sensual trail. A meeting of strength and elegance.",
                             IsPerfumeOfTheWeek = true,
                             InStock = true,
                             Category = _categoryRepository.GetAllCategories().ToList()[1]
                },
                new Perfume {Id = 4,
                             Name = "Oud Wood",
                             Brand = "Tom Ford",
                             Capacity = 50,
                             Price = 250M,
                             Description = "A composition of exotic, smoky woods including rare oud, sandalwood, rosewood, eastern spices, and sensual amber—revealing oud‘s rich and compelling power.",
                             IsPerfumeOfTheWeek = false,
                             InStock = true,
                             Category = _categoryRepository.GetAllCategories().ToList()[1]
                }
            };
        }

        public Perfume GetById(int id)
        {
            return perfumes.SingleOrDefault(p => p.Id == id);
        }

        public IEnumerable<Perfume> PerfumesOfTheWeek()
        {
            return from p in perfumes
                   orderby p.Name
                   where p.IsPerfumeOfTheWeek == true
                   select p;
        }

        public IEnumerable<Perfume> GetAllPerfumesByName(string searchString)
        {
            return from p in perfumes
                   where p.Name.Contains(searchString.ToLower()) || p.Brand.Contains(searchString.ToLower())
                   select p;
        }
    }
}
