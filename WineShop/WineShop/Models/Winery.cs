using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineShop.Models
{
    public class Winery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }

        // Add relatioship
        public virtual ICollection<Wine> Wines { get; set; }
    }

    public enum Country
    {
        France, Germany, Italy, Poland, India, UK, Netherlands, Other
    }
}
