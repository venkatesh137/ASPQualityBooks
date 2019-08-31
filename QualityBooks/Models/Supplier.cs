using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QualityBooks.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Mobile Phone Number")]
        public string MobilePhoneNumber { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Home Phone Number")]
        public string HomePhoneNumber { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Work Phone Number")]
        public string WorkPhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        //public ICollection<Book> books { get; set; }
    }
}
