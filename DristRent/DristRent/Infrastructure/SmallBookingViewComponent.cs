using DristRent.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DristRent.Infrastructure
{
    public class SmallBookingViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<BookedItem> booked = HttpContext.Session.GetJson<List<BookedItem>>("Booked");

            SmallBookingViewModel smallBookedVM;
           
            if(booked == null || booked.Count == 0)
            {
                smallBookedVM = null;
            }
            else
            {
                smallBookedVM = new SmallBookingViewModel
                {
                    NumberOfItems = booked.Sum(x => x.Days),
                    TotalAmount = booked.Sum(x => x.Days * x.Price)
                };
            }
            return View(smallBookedVM);
        }
    }
}
