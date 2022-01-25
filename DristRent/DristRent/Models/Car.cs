using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DristRent.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Type { get; set; }
        public int CategoryId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string PlateNum { get; set; }
        public string Image { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category category { get; set; }
    }
}
