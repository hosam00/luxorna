using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.Entities
{
    public class Section:PlaceModel
    {
        public virtual ICollection<Hotel> Hotels { get; set; }
        public virtual ICollection<Resturant> Resturants { get; set; }
        public virtual ICollection<Temple> Temples { get; set; }
        public virtual ICollection<Museum> Museums { get; set; }



    }
}
