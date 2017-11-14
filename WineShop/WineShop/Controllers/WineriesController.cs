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

        public WineriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
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
            return View();
        }
    }
}
