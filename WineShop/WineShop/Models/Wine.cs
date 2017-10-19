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

    }
}
