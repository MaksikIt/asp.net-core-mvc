using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using обучениеwebd.Data.Interface;

namespace обучениеwebd.Data.Mocks
{
    public class MockCareCosmetic : ICareCosmetics
    {
        public IEnumerable<CareCosmetic> AllCareCosmetics {
            get
            {
                var listCareCosmetics = new List<CareCosmetic>
                {
                    new CareCosmetic {CosmeticName = "Для волос", Desc = "Профессиональная уходовая косметика для волос" } ,
                    new CareCosmetic {CategoryName = "Для лица", Desc = "Профессиональная уходовая косметика для лица" } ,
                    new CareCosmetic {CategoryName = "Для тела", Desc = "Профессиональная уходовая косметика для тела" } ,
                    new CareCosmetic {CategoryName = "Для рук", Desc = "Профессиональная уходовая косметика для рук" } ,

                };
                return listCareCosmetics;
            };
            set => throw new NotImplementedException(); }

        public IEnumerable<CareCosmetic> FavouriteCareCosmetics => throw new NotImplementedException();

        public CareCosmetic getCareCosmetic(int CareCosmeticId)
        {
            throw new NotImplementedException();
        }
    }
}
