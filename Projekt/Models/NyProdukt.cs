using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
	public class NyProdukt
	{
        [Key]
        [Required]
        public int CategoryId { get; set; }
        public int ProduktId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Text { get; set; }
        public double Price { get; set; }
    }
}
