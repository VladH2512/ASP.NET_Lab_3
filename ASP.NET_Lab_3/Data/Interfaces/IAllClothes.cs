using ASP.NET_Lab_3.Data.Models;
using System.Collections.Generic;

namespace ASP.NET_Lab_3.Data.Interfaces
{
    public interface IAllClothes
    {
        IEnumerable<Clothes> Clothes { get; }
        IEnumerable<Clothes> ClothesChildish { get; }
        IEnumerable<Clothes> ClothesMale { get; }
        IEnumerable<Clothes> ClothesFemale { get; }
        Clothes getObjectClothes(int clothId);
    }
}
