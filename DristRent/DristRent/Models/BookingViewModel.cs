using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DristRent.Models
{
    public class BookingViewModel
    {
        public List<BookedItem> BookedItems { get; set; }
        public decimal Total { get; set; }
    }
}
