using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WineShop.Models;

namespace WineShop.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // check for the database. If exist, nothing done. If not, create a new
            context.Database.EnsureCreated();

            // Look for data in Wine database
            if (context.Wine.Any())
            {
                return; // DB has been seeded
            }

            // Creating some data
            var wines = new Wine[]
            {
                new Wine{ID=5, Name = "JundaWine", Price = 19.99, YearOfBotteling = 1995, AlcholPercentage = 10, WineryID = 2},
                new Wine{ID=6, Name = "JundaNoWine", Price = 19.99, YearOfBotteling = 1990, AlcholPercentage = 10, WineryID = 1}
            };

            // Add new data to DB just for checking
            foreach (Wine w in wines)
            {
                context.Wine.Add(w);
            }



            // Look for data in Winery database
            //if (context.Winery.Any())
            //{
            //    return; // DB has been seeded
            //}
        }
    }
}
