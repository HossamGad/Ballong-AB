using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.ViewModels
{
	public class ProdukterListViewModel
	{
		public IEnumerable<Produkter> Produkter { get; set; }
		public string CurrentCategory { get; set; }
		public int CategoryId { get; set; }
	}
}
