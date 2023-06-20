using ASP.NET_Lab_3.Data.Models;
using System.Collections.Generic;

namespace ASP.NET_Lab_3.Data.Interfaces
{
    public interface IClothesColor
    {
        IEnumerable<Color> AllColors { get; }
    }
}
