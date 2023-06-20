using ASP.NET_Lab_3.Data.Interfaces;
using ASP.NET_Lab_3.Data.Models;

namespace ASP.NET_Lab_3.Data.Repository
{
    public class CategoryRepository : IClothesCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
