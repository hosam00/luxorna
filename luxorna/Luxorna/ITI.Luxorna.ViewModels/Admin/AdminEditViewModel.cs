using ITI.Luxorna.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.ViewModels
{
    public class AdminEditViewModel
    {
        [Required]
        
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Password { get; set; }
        [Required]
        [MaxLength(500)]
        public string Image { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int CreateBy { get; set; }
        public int UpdateBy { get; set; }
        // public List<Role>Roles{ get; set; }
    }
}
