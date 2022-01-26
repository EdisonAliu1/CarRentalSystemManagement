using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DristRent.Models
{
    public class BookedItem
    {
        public int CarId { get; set; }
        public string CarType { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get{ return Quantity * Price;} }
        public string Image { get; set; }
        //public date

        public BookedItem(Car car)
        {
            CarId = car.Id;
            CarType = car.Type;
            Quantity = 1;
            Image = car.Image;
        }
    }
}
