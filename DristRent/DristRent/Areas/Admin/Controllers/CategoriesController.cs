using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DristRent.Data;
using DristRent.Models;

namespace DristRent.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Categories
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.OrderBy(x => x.Sorting).ToListAsync());
        }

        //Get/admin/categories
        public IActionResult Create() => View();



        // GET: Admin/Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Admin/Categories/Create


        // POST: Admin/Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                category.Slug = category.Name.ToLower().Replace(" ", "-");
                category.Sorting = 100;

                var slug = await _context.Categories.FirstOrDefaultAsync(x => x.Slug == category.Slug);
                if (slug != null)
                {
                    ModelState.AddModelError("", "The category already exists.");
                    return View(category);
                }

                _context.Add(category);
                await _context.SaveChangesAsync();

                TempData["Success"] = "The category has been added!";

                return RedirectToAction("Index");
            }

            return View(category);
        }
        //Get  Admin/Categories/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            Category category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }
        // POST: Admin/Categories/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Category category)
        {
            if (ModelState.IsValid) {
                category.Slug = category.Id == 1 ? "home" : category.Name.ToLower().Replace(" ", "-");

                var slug = await _context.Categories.Where(x => x.Id != category.Id).FirstOrDefaultAsync(x => x.Slug == category.Slug);
                if (slug != null)
                {
                    ModelState.AddModelError("", "The category alreay exists.");
                    return View(category);
                }

                _context.Update(category);
                await _context.SaveChangesAsync();
                TempData["Success"] = "The category has been edited";

                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }


        //// GET: Admin/Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null)
            {
                TempData["Error"] = "The page does not exist!";
            }

            var category = await _context.Categories
            .FirstOrDefaultAsync(m => m.Id == id);


            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        //GET: Admin/Categories/Delete/5
        //public async Task<IActionResult> Delete(int id)
        //    {
        //        Category category = await _context.Categories.FindAsync(id);

        //        if (category == null)
        //        {
        //            TempData["Error"] = "The page does not exist!";
        //        }
        //        else
        //        {
        //            _context.Categories.Remove(category);
        //            await _context.SaveChangesAsync();

        //            TempData["Success"] = "The page has been deleted!";
        //        }

        //        return RedirectToAction("Index");
        //    }

        // POST: Admin/Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }

        // POST /admin/categories/reorder
        [HttpPost]
        public async Task<IActionResult> Reorder(int[] id)
        {
            //Home is first so it's 0
            int count = 1;

            foreach (var categoryId in id)
            {
                Category category = await _context.Categories.FindAsync(categoryId);
                category.Sorting = count;
                _context.Update(category);
                await _context.SaveChangesAsync();
                count++;
            }

            return Ok();
        }
    }
}


