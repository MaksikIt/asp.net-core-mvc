using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using обучениеwebd.Data.Interface;
using обучениеwebd.Data.Models;

namespace обучениеwebd.Data.Mocks
{
    public class MockCareCosmetic : ICareCosmetics
    {
        public ICategory CategoryCare = new MockCategory();

        public List<CareCosmetic> AllCareCosmetics
        {
            get
            {
                List<CareCosmetic> listCareCosmetics = new List<CareCosmetic>
                {
                    new CareCosmetic {CosmeticName = "Очищающий гель для сухой кожи лица", ShortDesc = "CeraVe", Cotegory =  CategoryCare.AllCategory.ElementAt(0), Available = true, Img = "https://avatars.mds.yandex.net/get-mpic/5173454/img_id6577925693647797144.jpeg/orig", Price = 500, IsFavourite = true} ,
                    new CareCosmetic {CosmeticName = "Маска для волос с кератином", ShortDesc = "Kallos Cosmetics", Cotegory = CategoryCare.AllCategory.ElementAt(0), Available = true, Img = "https://avatars.mds.yandex.net/get-mpic/5173454/img_id6577925693647797144.jpeg/orig", Price = 500, IsFavourite = false} ,
                    new CareCosmetic {CosmeticName = "Натуральный крем для рук и ногтей", ShortDesc = "SYNERGETIC", Cotegory = CategoryCare.AllCategory.ElementAt(3), Available = true, Img = "https://avatars.mds.yandex.net/get-mpic/5173454/img_id6577925693647797144.jpeg/orig", Price = 500, IsFavourite = true} ,
                    new CareCosmetic {CosmeticName = "Натуральный крем для тела питательный ", ShortDesc = "SYNERGETIC", Cotegory = CategoryCare.AllCategory.ElementAt(2), Available = true, Img = "https://avatars.mds.yandex.net/get-mpic/5173454/img_id6577925693647797144.jpeg/orig", Price = 500, IsFavourite = true} ,

                };
                return listCareCosmetics;
            }
        }
            

        public IEnumerable<CareCosmetic> FavouriteCareCosmetics => throw new NotImplementedException();

        public CareCosmetic getCareCosmetic(int CareCosmeticId)
        {
            throw new NotImplementedException();
        }
    }
}
