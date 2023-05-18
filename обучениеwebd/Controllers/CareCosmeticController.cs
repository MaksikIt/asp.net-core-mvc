using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using обучениеwebd.Data.Interface;

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
            var cosmetics = _allCosmetics.AllCareCosmetics;
            return View(cosmetics);
        }
    }
}
