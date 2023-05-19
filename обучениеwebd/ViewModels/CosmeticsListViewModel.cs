using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using обучениеwebd.Data.Models;

namespace обучениеwebd.ViewModels
{
    public class CosmeticsListViewModel
    {
        public List<CareCosmetic> AllCareCosmetics { get; set; }
        public string CarsCategory { get; set; }
    }
}
