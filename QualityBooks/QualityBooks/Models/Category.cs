using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QualityBooks.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.")]
        public string Name { get; set; }

        public ICollection<Book> books { get; set; }
    }
}
