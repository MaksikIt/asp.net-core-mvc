﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace обучениеwebd.Data.Interface
{
    public interface ICareCosmetics
    {
        IEnumerable<CareCosmetic> AllCareCosmetics { get; }
        IEnumerable<CareCosmetic> FavouriteCareCosmetics { get; }
        CareCosmetic getCareCosmetic(int CareCosmeticId);
    }
}
