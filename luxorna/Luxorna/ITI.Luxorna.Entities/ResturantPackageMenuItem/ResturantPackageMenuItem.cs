using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.Entities
{
   public  class ResturantPackageMenuItem:BaseModel
    {
       public int ResturantPackageID { get; set; }
        public int ResturantMenuItemID { get; set; }
        public virtual ResturantPacakge ResturantPacakge { get; set; }
        public virtual ResturantMenuItem ResturantMenuItem { get; set; }


    }
}
