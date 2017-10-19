using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineShop.Models
{
    public class Wine
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int YearOfBotteling { get; set; }
        public double AlcholPercentage { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public WineType WineType { get; set; }

        // Creating a relationship - Many to one
        public int WineryID { get; set; }
        public virtual Winery Winery { get; set; }



    }

    public enum WineType
    {
        Sauvignon, Rieslinger, Syrah,
        Merlot, Cabernet, Other
    }
}
