using ASP.NET_Lab_3.Data.Models;
using System.Collections.Generic;

namespace ASP.NET_Lab_3.Data.Interfaces
{
    public interface IClothesCompany
    {
        IEnumerable<Company> AllCompanies { get; }
    }
}
