using ASP.NET_Lab_3.Data.Models;

namespace ASP.NET_Lab_3.Data.Interfaces
{
    public interface IClothesTypes
    {
        IEnumerable<Types> AllTypes { get; }
    }
}
