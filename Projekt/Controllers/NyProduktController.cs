using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Projekt.Controllers
{
    [Authorize]
    public class NyProduktController : Controller
	{
        private readonly INyProduktRepository _NyProduktRepository;
        private readonly IProdukterRepository _ProdukterRepository;
        private readonly ICategoryRepository _categoryRepository;

        public NyProduktController(INyProduktRepository NyProduktRepository, IProdukterRepository produkterRepository, ICategoryRepository categoryRepository)
        {
            _NyProduktRepository = NyProduktRepository;
            _ProdukterRepository = produkterRepository;
            _categoryRepository = categoryRepository;
        }
    }
}
