using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.Entities
{
    public class User:AdminUserModel
    {
        public string Phone { get; set; }
        public DateTime DeleteDate { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Country Country { get; set; }
        public int CountryID { get; set; }

    }
}
