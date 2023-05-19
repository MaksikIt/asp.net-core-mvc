using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using обучениеwebd.Data.Interface;
using обучениеwebd.Data.Models;

namespace обучениеwebd.Data.Mocks
{
    public class MockCategory : ICategory
    {
        public List<Category> AllCategory
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryName = "Для волос", Desc = "Профессиональная уходовая косметика для волос" } ,
                    new Category {CategoryName = "Для лица", Desc = "Профессиональная уходовая косметика для лица" } ,
                    new Category {CategoryName = "Для тела", Desc = "Профессиональная уходовая косметика для тела" } ,
                    new Category {CategoryName = "Для рук", Desc = "Профессиональная уходовая косметика для рук" } ,

                };
                
            }
        }
    }
}
