using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace обучениеwebd.Data
{
    public class CareCosmetic
    {
        public int Id { get; set; }
        public string CosmeticName{ get; set; }
        public string  ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public string Img { get; set; } // url адрес картинки 
        public ushort Price { get; set; }
        public bool IsFavourite { get; set; } // если значение true то отображается в разделе лучшие товары
        public bool Available { get; set; } // в наличии ли товары
        public int CategoryId { get; set; }
        public virtual Category Cotegory { get; set; }
    }
}
