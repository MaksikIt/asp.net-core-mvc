using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using обучениеwebd.Data.Models;

namespace обучениеwebd.ViewModels
{
    public class CategoryHeirViewModel
    {
        public List<Category> AllCategories { get; set; }
        public List<CareCosmetic> AllCareCosmetics { get; set; }
    }
}
