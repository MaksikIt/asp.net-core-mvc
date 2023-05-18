using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using обучениеwebd.Data.Models;

namespace обучениеwebd.Data.Interface
{
    public interface ICategory
    {
        IEnumerable<Category> AllCategory { get; }
    }
}
