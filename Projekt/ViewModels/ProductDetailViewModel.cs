using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.ViewModels
{
	public class ProductDetailViewModel
	{
		public Produkter ProductDetail { get; set; }

		public Produkter ProduktId { get; set; }
		public List<NyProdukt> Nyproduktlist { get; set; }


		public string GradeAverage { get; set; }
	}
}
