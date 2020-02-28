using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projekt.Models
{
    
    public class Produkter
	{
        [Key]
        [Required]

        public int ProduktId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public bool ProductOfTheWeek { get; internal set; }
        public bool IsProductOfTheWeek { get; set; }
        public List<NyProdukt> Nyproduktlist { get; set; }

    }
}
