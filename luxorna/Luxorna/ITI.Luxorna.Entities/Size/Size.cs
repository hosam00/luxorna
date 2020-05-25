using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.Entities
{
    public class Size:BaseModel
    {
        public string ItemSize { get; set; } 
        public virtual ICollection<ResturantItemSize> ResturantItemSizes { get; set; }
       

    }
}
