using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace обучениеwebd.Data.Interface
{
    interface ICareCosmetics
    {
        IEnumerable<CareCosmetic> AllCareCosmetics { get; set; }
        IEnumerable<CareCosmetic> FavouriteCareCosmetics { get; }
        CareCosmetic getCareCosmetic(int CareCosmeticId);
    }
}
