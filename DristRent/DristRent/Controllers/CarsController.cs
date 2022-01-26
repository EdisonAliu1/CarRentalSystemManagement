using DristRent.Data;
using DristRent.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DristRent.Controllers
{
    public class CarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;

        }
        public async Task<IActionResult> Index(int p = 1)
        {
            int pageSize = 6;
            var cars = _context.Cars.OrderByDescending(x => x.Id)              
                .Skip((p - 1) * pageSize)
                .Take(pageSize);

            ViewBag.PageNumber = p;
            ViewBag.PageRange = pageSize;
            ViewBag.TotalPages = (int)Math.Ceiling((decimal)_context.Cars.Count() / pageSize);


            return View(await cars.ToListAsync());
        }
        //Get /Products/Category
        public async Task<IActionResult> CarsByCategory(string categorySlug, int p = 1)
        {
            Category category = await _context.Categories.Where(x => x.Slug == categorySlug).FirstOrDefaultAsync();
            if (category == null) return RedirectToAction("Index");
            int pageSize = 6;
            var cars = _context.Cars.OrderByDescending(x => x.Id)
                .Where(x => x.CategoryId == category.Id)
                .Skip((p - 1) * pageSize)
                .Take(pageSize);

            ViewBag.PageNumber = p;
            ViewBag.PageRange = pageSize;
            ViewBag.TotalPages = (int)Math.Ceiling((decimal)_context.Cars.Count() / pageSize);
            ViewBag.CategoryName = category.Name;
            ViewBag.CategorySlug = categorySlug;


            return View(await cars.ToListAsync());
        }
    }

}
