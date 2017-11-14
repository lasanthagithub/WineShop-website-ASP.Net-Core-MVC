using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WineShop.Models;
using WineShop.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WineShop.Controllers
{
    public class WineriesController : Controller
    {

        // Deal with databases
        private ApplicationDbContext _context;

        public WineriesController(ApplicationDbContext context) // constructor
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Winery> wineries = _context.Winery.ToList();
            return View(wineries);
        }

        // Create get method
        public IActionResult Create()
        {
            return View();
        }

        // Create post method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Winery winery)
        {
            if (ModelState.IsValid)
            {
                _context.Winery.Add(winery);
                _context.SaveChanges(); // add data to the database

                return RedirectToAction("Index");
            }
            return View(winery);
        }
    }
}
