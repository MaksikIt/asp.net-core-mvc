using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using обучениеwebd.Data.Interface;
using обучениеwebd.ViewModels;

namespace обучениеwebd.Controllers
{
    public class CareCosmeticController : Controller 
    {
        private ICareCosmetics _allCosmetics;
        private ICategory _allCategory;
        public CareCosmeticController(ICareCosmetics iAllCosmetics, ICategory iCategory)
        {
            _allCosmetics = iAllCosmetics;
            _allCategory = iCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Уходовая косметика";
            CosmeticsListViewModel obj = new CosmeticsListViewModel();
            obj.AllCareCosmetics = _allCosmetics.AllCareCosmetics;
            return View(obj);
        }

        public ViewResult CategoryHeir()
        {
            CategoryHeirViewModel obj = new CategoryHeirViewModel();
            obj.AllCategories = _allCategory.AllCategory;
            obj.AllCareCosmetics = _allCosmetics.AllCareCosmetics;
            return View(obj);
        }

        public ViewResult CategoryHands()
        {
            CategoryHeirViewModel obj = new CategoryHeirViewModel();
            obj.AllCategories = _allCategory.AllCategory;
            obj.AllCareCosmetics = _allCosmetics.AllCareCosmetics;
            return View(obj);
        }

        public ViewResult CategoryFace()
        {
            CategoryHeirViewModel obj = new CategoryHeirViewModel();
            obj.AllCategories = _allCategory.AllCategory;
            obj.AllCareCosmetics = _allCosmetics.AllCareCosmetics;
            return View(obj);
        }
    }
}
