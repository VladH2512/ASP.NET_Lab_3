using ASP.NET_Lab_3.Data.Interfaces;
using ASP.NET_Lab_3.Data.Models;
using ASP.NET_Lab_3.Data;
using Microsoft.EntityFrameworkCore;


namespace ASP.NET_Lab_3.Data.Repository
{
    public class ClothesRepository : IAllClothes
    {
        private readonly AppDBContent appDBContent;
        public ClothesRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Clothes> Clothes => appDBContent.Clothes.Include(c => c.Category);

        public IEnumerable<Clothes> ClothesChildish => appDBContent.Clothes.Where(p => p.CategoryId == 1).Include(c => c.Category);

        public IEnumerable<Clothes> ClothesMale => appDBContent.Clothes.Where(p => p.CategoryId == 2).Include(c => c.Category);

        public IEnumerable<Clothes> ClothesFemale => appDBContent.Clothes.Where(p => p.CategoryId == 3).Include(c => c.Category);

        public Clothes getObjectClothes(int clothId) => appDBContent.Clothes.FirstOrDefault(p => p.Id == clothId);
    }
}

