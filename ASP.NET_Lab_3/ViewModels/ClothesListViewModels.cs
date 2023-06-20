using ASP.NET_Lab_3.Data.Models;
using System.Collections.Generic;

namespace ASP.NET_Lab_3.ViewModels
{
    public class ClothesListViewModels
    {
        public IEnumerable<Clothes> allClothes { get; set; }
        public string currCategory { get; set; }
    }
}
