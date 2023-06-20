using ASP.NET_Lab_3.Data.Models;

namespace ASP.NET_Lab_3.Data.Interfaces
{
    public interface IClothesCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
