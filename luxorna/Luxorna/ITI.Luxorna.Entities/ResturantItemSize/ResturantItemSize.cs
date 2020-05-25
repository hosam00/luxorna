using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.Entities
{
    public class ResturantItemSize : BaseModel
    {
        public int SizeID{get;set;}
        public int ResturantMenuItemID { get; set; }
        public decimal Price { get; set;}

        public virtual Size Size { get; set; }
        public virtual ResturantMenuItem ResturantMenuItem { get; set; }

    }
}
