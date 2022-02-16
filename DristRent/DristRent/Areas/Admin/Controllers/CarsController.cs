using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DristRent.Data;
using DristRent.Models;
using DristRent.Infrastructure;

using System.IO;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace DristRent.Areas.Admin
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class CarsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public CarsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            this.webHostEnvironment = webHostEnvironment;
        }

        // GET: Admin/Cars
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber /*int p = 1*/)
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

        // GET: Admin/Cars/Details/5
        public async Task<IActionResult> Details(int id)
        {
          
            var car = await _context.Cars
                .Include(c => c.category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // GET: Admin/Cars/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories.OrderBy(x=>x.Sorting), "Id", "Name");
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Car car)  
        {
            if (ModelState.IsValid)
            {
                string imageName = "noimage.png";
                if(car.ImageUpload != null)
                {
                    string uploadsDir = Path.Combine(webHostEnvironment.WebRootPath,"media/cars");
                    //if we upload the same pic it is not gonna allow us
                    imageName = Guid.NewGuid().ToString() + "_" + car.ImageUpload.FileName;
                    string filePath = Path.Combine(uploadsDir, imageName);
                    FileStream fs = new FileStream(filePath, FileMode.Create);
                    await car.ImageUpload.CopyToAsync(fs);
                    fs.Close();
                }
                car.Image = imageName;

                _context.Add(car);
                
                await _context.SaveChangesAsync();
                
                TempData["Success"] = "The car has been added";
                return RedirectToAction(nameof(Index));
            }
            
            return View(car);
        }

        
        // GET: Admin/Cars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", car.CategoryId);
            return View(car);
        }

        // POST: Admin/Cars/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Car car)
        {
          

            if (ModelState.IsValid)

            {
                string uploadsDir = Path.Combine(webHostEnvironment.WebRootPath, "media/cars");
               
                if (car.ImageUpload != null)
                {
                    
                    string imageName = Guid.NewGuid().ToString() + "_" + car.ImageUpload.FileName;
                    string filePath = Path.Combine(uploadsDir, imageName);
                    FileStream fs = new FileStream(filePath, FileMode.Create);
                    await car.ImageUpload.CopyToAsync(fs);
                    fs.Close();
                    car.Image = imageName;
                }

                _context.Update(car);

                await _context.SaveChangesAsync();

                TempData["Success"] = "The car has been Edited! ";
                return RedirectToAction(nameof(Index));
            }

            return View(car);
            
        }

        // GET: Admin/Cars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars
                .Include(c => c.category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // POST: Admin/Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarExists(int id)
        {
            return _context.Cars.Any(e => e.Id == id);
        }
    }

}
