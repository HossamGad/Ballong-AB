using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models;
using Projekt.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Projekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdukterRepository _produkterRepository;

        public HomeController(IProdukterRepository produkterRepository)
        {
            _produkterRepository = produkterRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
