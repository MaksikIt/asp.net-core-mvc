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
            CosmeticsListViewModel obj = new CosmeticsListViewModel();
            obj.AllCareCosmetics = _allCosmetics.AllCareCosmetics;
            return View(obj);
        }
    }
}
