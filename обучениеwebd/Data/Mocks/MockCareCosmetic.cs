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
                    new CareCosmetic {CosmeticName = "Очищающий гель для сухой кожи лица", ShortDesc = "CeraVe", Category =  CategoryCare.AllCategory[1].CategoryName, Available = true, Img = "/img/Img1.png", Price = 500, IsFavourite = true} ,//создать функцию вынимающая значение из allCategory
                    new CareCosmetic {CosmeticName = "Спрей для волос востанавливающий ", ShortDesc = "Kallos Cosmetics", Category = CategoryCare.AllCategory[0].CategoryName, Available = true, Img = "https://avatars.mds.yandex.net/get-mpic/5173454/img_id6577925693647797144.jpeg/orig", Price = 500, IsFavourite = false} ,
                    new CareCosmetic {CosmeticName = "Спрей для волос востанавливающий ", ShortDesc = "Kallos Cosmetics", Category = CategoryCare.AllCategory[0].CategoryName, Available = true, Img = "https://avatars.mds.yandex.net/get-mpic/5173454/img_id6577925693647797144.jpeg/orig", Price = 500, IsFavourite = false} ,
                    new CareCosmetic {CosmeticName = "Бальзам для ломких волос", ShortDesc = "Kallos Cosmetics", Category = CategoryCare.AllCategory[0].CategoryName, Available = true, Img = "/img/Img1.png", Price = 500, IsFavourite = false} ,
                    new CareCosmetic {CosmeticName = "Шампунь для всех типов волос", ShortDesc = "Kallos Cosmetics", Category = CategoryCare.AllCategory[0].CategoryName, Available = true, Img = "https://avatars.mds.yandex.net/get-mpic/5173454/img_id6577925693647797144.jpeg/orig", Price = 500, IsFavourite = false} ,
                    new CareCosmetic {CosmeticName = "Скраб для рук", ShortDesc = "SYNERGETIC", Category = CategoryCare.AllCategory[3].CategoryName, Available = true, Img = "https://avatars.mds.yandex.net/get-mpic/5173454/img_id6577925693647797144.jpeg/orig", Price = 500, IsFavourite = true} ,
                    new CareCosmetic {CosmeticName = "Крем для рук возрастной", ShortDesc = "SYNERGETIC", Category = CategoryCare.AllCategory[3].CategoryName, Available = true, Img = "https://avatars.mds.yandex.net/get-mpic/5173454/img_id6577925693647797144.jpeg/orig", Price = 500, IsFavourite = true} ,
                    new CareCosmetic {CosmeticName = "Крем для рук для всех типов кожи", ShortDesc = "SYNERGETIC", Category = CategoryCare.AllCategory[3].CategoryName, Available = true, Img = "https://avatars.mds.yandex.net/get-mpic/5173454/img_id6577925693647797144.jpeg/orig", Price = 500, IsFavourite = true} ,
                    new CareCosmetic {CosmeticName = "Натуральный крем для рук и ногтей", ShortDesc = "SYNERGETIC", Category = CategoryCare.AllCategory[3].CategoryName, Available = true, Img = "https://avatars.mds.yandex.net/get-mpic/5173454/img_id6577925693647797144.jpeg/orig", Price = 500, IsFavourite = true} ,
                    new CareCosmetic {CosmeticName = "Натуральный крем для тела питательный ", ShortDesc = "SYNERGETIC", Category = CategoryCare.AllCategory[2].CategoryName, Available = true, Img = "https://avatars.mds.yandex.net/get-mpic/5173454/img_id6577925693647797144.jpeg/orig", Price = 500, IsFavourite = true} ,

                };
                return listCareCosmetics;
            }
        }
            

        public List<CareCosmetic> FavouriteCareCosmetics => throw new NotImplementedException();

        public CareCosmetic getCareCosmetic(int CareCosmeticId)
        {
            throw new NotImplementedException();
        }
    }
}
