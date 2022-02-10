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

        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;

            var car = from s in _context.Cars select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                car = car.Where(s => s.City.Contains(searchString)
                    || s.Type.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    car = car.OrderByDescending(s => s.Type);
                    break;
              
                default:
                    car = car.OrderBy(s => s.Type);
                    break;
            }

            int pageSize = 3;
            return View(await PaginatedList<Car>.CreateAsync(car.AsNoTracking(), pageNumber ?? 1, pageSize));
            
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
