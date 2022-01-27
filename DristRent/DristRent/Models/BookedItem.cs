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
        public int Days { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get{ return Days * Price;} }
        public string Image { get; set; }
        //public date
        public BookedItem()
        {
            
        }
        public BookedItem(Car car)
        {
            Price = car.Price;
            CarId = car.Id;
            CarType = car.Type;
            Days = 1;
            Image = car.Image;
            
        }
    }
}
