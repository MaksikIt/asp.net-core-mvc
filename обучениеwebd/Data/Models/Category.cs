using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace обучениеwebd.Data.Models
{
    public class Category
    {
        public int Id {get; set;}
        public string CategoryName { get; set; }
        public dynamic Desc { get; set; }
        public List<CareCosmetic> CareCosmetics { get; set; }
    }
}
