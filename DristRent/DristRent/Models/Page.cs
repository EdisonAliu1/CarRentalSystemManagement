using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DristRent.Models
{
    public class Page
    {
        public int Id { get; set; }

        [Required, MinLength(2, ErrorMessage="Minimum length is 2")]
        public string Title { get; set; }

        [Required]
       // [Display(Name = "Fruit")] we can use this to show another name on the table
        public string Slug { get; set; }

        [Required, MinLength(4, ErrorMessage = "Minimum length is 4")]
        public string Content { get; set; }

        public int Sorting { get; set; }
    }
}
