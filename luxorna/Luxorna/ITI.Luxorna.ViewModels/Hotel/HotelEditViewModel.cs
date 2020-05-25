using ITI.Luxorna.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.ViewModels
{
     public class HotelEditViewModel
    {
        [Required]
        public int ID { get; set;}
        [Required]

        public string Name { get; set;}
        

        public string Description { get; set;}
        [Required]

        public string Address { get; set;}
        [Required]
        public int Stars { get; set;}
        [Required]
        public decimal Price { get; set;}
        
        public string SectionName { get; set; }
        public int SectionID { get; set;}
        [Required]
        public ICollection<HotelImage> HotelImages { get; set;}
        [Required]
        public int CreateBy { get; set; }
        public int UpdateBy { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
