using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DristRent.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }
        public bool Taken { get; set; }
    }
}
