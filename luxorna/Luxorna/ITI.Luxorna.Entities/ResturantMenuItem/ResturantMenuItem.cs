using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.Entities
{
    public class ResturantMenuItem:BaseModel
    {
        public string ItemName { get; set; }
      

        public string Image { get; set; }
        public int RestrantID { get; set; }
        public virtual Resturant Resturant { get; set; }
        public virtual ICollection<ResturantItemSize> ResturantItemSizes { get; set; }
        public virtual ICollection<ResturantPackageMenuItem> ResturantPackageMenuItems { get; set; }

    }
}
