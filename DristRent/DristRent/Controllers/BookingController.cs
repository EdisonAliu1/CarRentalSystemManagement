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
                Total = booked.Sum(x => x.Price * x.Days)
        };
            return View(bookingVM);
        }

        //Get /booking/decrease/5
        public IActionResult Decrease(int id)
        { 

            List<BookedItem> booked = HttpContext.Session.GetJson<List<BookedItem>>("Booked");

            BookedItem bookedItem = booked.Where(x => x.CarId == id).FirstOrDefault();

            if (bookedItem.Days > 1)
            {
                --bookedItem.Days;
              
            }
            else
            {
                booked.RemoveAll(x => x.CarId == id);
            }
           

            if(booked.Count == 0)
            {
                HttpContext.Session.Remove("Booked");
            }
            else
            {
                HttpContext.Session.SetJson("Booked", booked);
            }
            return RedirectToAction("Index");
        }
        //get /booking/remove/5
        public IActionResult Remove(int id)
        {

            List<BookedItem> booked = HttpContext.Session.GetJson<List<BookedItem>>("Booked");

                booked.RemoveAll(x => x.CarId == id);

            if (booked.Count == 0)
            {
                HttpContext.Session.Remove("Booked");
            }
            else
            {
                HttpContext.Session.SetJson("Booked", booked);
            }
            return RedirectToAction("Index");
        }

        //Get/booked/add/5
        public async Task<IActionResult> Add(int id)
        {
            Car car = await _context.Cars.FindAsync(id);

            List<BookedItem> booked = HttpContext.Session.GetJson<List<BookedItem>>("Booked") ?? new List<BookedItem>();

            BookedItem bookedItem = booked.Where(x => x.CarId == id).FirstOrDefault();

            if(bookedItem == null)
            {
                booked.Add(new BookedItem(car));
            }
            else
            {
                bookedItem.Days += 1;
            }
            HttpContext.Session.SetJson("Booked", booked);
            return RedirectToAction(nameof(Index));
        }
    }
}
