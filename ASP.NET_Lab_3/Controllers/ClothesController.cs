using ASP.NET_Lab_3.Data.Interfaces;
using ASP.NET_Lab_3.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Lab_3.Data.Controllers
{
    public class ClothesController: Controller
    {
        private readonly IAllClothes _allClothes;
        private readonly IClothesColor _allColor;

        public ClothesController(IAllClothes allClothes, IClothesColor allColor)
        {
            _allClothes = allClothes;
            _allColor = allColor;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Сторінка з одягом";
            ClothesListViewModels obj = new ClothesListViewModels();
            obj.allClothes = _allClothes.Clothes;
            obj.currCategory = "Одяг";
            return View(obj);
        }

        public ViewResult BabyList()
        {
            ViewBag.Title = "Сторінка з дитячим одягом";
            ClothesListViewModels obj = new ClothesListViewModels();
            obj.allClothes = _allClothes.ClothesChildish;
            obj.currCategory = "Дитячий Одяг";
            return View(obj);
        }

        public ViewResult MensList()
        {
            ViewBag.Title = "Сторінка з чоловічим одягом";
            ClothesListViewModels obj = new ClothesListViewModels();
            obj.allClothes = _allClothes.ClothesMale;
            obj.currCategory = "Чоловічий Одяг";
            return View(obj);
        }

        public ViewResult WomensList()
        {
            ViewBag.Title = "Сторінка з жіночим одягом";
            ClothesListViewModels obj = new ClothesListViewModels();
            obj.allClothes = _allClothes.ClothesFemale;
            obj.currCategory = "Жіночий Одяг";
            return View(obj);
        }
    }
}
