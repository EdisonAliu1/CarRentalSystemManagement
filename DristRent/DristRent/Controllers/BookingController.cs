using DristRent.Data;
using DristRent.Infrastructure;
using DristRent.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DristRent.Controllers
{
    
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookingController(ApplicationDbContext context)
        {
            _context = context;
        }
        //Get /booked
        public IActionResult Index()
        {
            List<BookedItem> booked = HttpContext.Session.GetJson<List<BookedItem>>("Booked") ?? new List<BookedItem>();

            BookingViewModel bookingVM = new BookingViewModel
            {
                BookedItems = booked,
                Total = booked.Sum(x => x.Price * x.Quantity)
        };
            return View(bookingVM);
        }
    }
}
