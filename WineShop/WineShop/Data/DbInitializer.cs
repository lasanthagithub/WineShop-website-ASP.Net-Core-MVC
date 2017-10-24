using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        }
    }
}
