using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WineShop.Models
{
    public class Winery
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        public Country Country { get; set; }

        // Add relatioship - One (Winery) to many (Wine)
        public virtual ICollection<Wine> Wines { get; set; }
    }

    public enum Country
    {
        France, Germany, Italy, Poland, India, UK, Netherlands, Other
    }
}
