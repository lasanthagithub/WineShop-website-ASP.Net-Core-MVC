using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WineShop.Models
{
    public class Wine
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(25, ErrorMessage ="Name must be shorter than 25 characters")]
        public string Name { get; set; }

        [Range(10, 200)]
        public double Price { get; set; }

        [Range(1900, 2999)]
        public int YearOfBotteling { get; set; }

        [Range(8.5, 22, ErrorMessage = "Alchol % should be between 8.5 to 22 %")]
        public double AlcholPercentage { get; set; }

        public string ImagePath { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }


        public WineType WineType { get; set; }

        // Creating a relationship - Many (wine) to one (Winery)
        public int WineryID { get; set; }
        public virtual Winery Winery { get; set; }



    }

    public enum WineType
    {
        Sauvignon, Rieslinger, Syrah,
        Merlot, Cabernet, Other
    }
}
