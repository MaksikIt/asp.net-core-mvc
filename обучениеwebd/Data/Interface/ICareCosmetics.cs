using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using обучениеwebd.Data.Models;

namespace обучениеwebd.Data.Interface
{
    public interface ICareCosmetics
    {
        List<CareCosmetic> AllCareCosmetics { get; }
        IEnumerable<CareCosmetic> FavouriteCareCosmetics { get; }
        CareCosmetic getCareCosmetic(int CareCosmeticId);
    }
}
