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



        // Edit - Get the value from DB and dispaly to edit
        public IActionResult Edit(int? id) // ? - canbe empty or null value
        {
            // Check whether id contain a value or not
            if (id == null)
            {
                Response.StatusCode = 400;
                return Content("No item found");
            }

            // Get a winery info ffrom the passesd id
            Winery winery = _context.Winery.Single(model => model.Id == id);


            // check the passed id has a record
            if (winery == null)
            {
                Response.StatusCode = 400;
                return Content("No item found");
            }

            // if the passed id has a record in winery return it
            return View(winery);
        }

        // Edit - Once the edition is submitted. DB is updated.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Winery winery)
        {
            if (ModelState.IsValid)
            {
                _context.Winery.Update(winery);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(winery);
        }


        // Delete - Get the value from DB and dispaly to edit

        public IActionResult Delete(int? id)
        {
            // Check whether id contain a value or not
            if (id == null)
            {
                Response.StatusCode = 400;
                return Content("No item found");
            }

            // Get a winery info ffrom the passesd id
            Winery winery = _context.Winery.Single(model => model.Id == id);


            // check the passed id has a record
            if (winery == null)
            {
                Response.StatusCode = 400;
                return Content("No item found");
            }

            // if the passed id has a record in winery return it
            return View(winery);
        }

        // Delete - Once the edition is submitted. DB is updated.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {

            // Get a winery info ffrom the passesd id
            Winery winery = _context.Winery.Single(model => model.Id == id);
            _context.Winery.Remove(winery);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
