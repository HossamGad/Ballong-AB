using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models;
using Projekt.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Projekt.Controllers
{
    [Authorize]
	public class ProdukterController : Controller
	{

        private readonly IProdukterRepository _produkterRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProdukterController(IProdukterRepository produkterRepository, ICategoryRepository categoryRepository)
        {
            _produkterRepository = produkterRepository;
            _categoryRepository = categoryRepository;
           
        }


        public ViewResult List(string category)
        {
            IEnumerable<Produkter> produkter;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                produkter = _produkterRepository.AllProdukter.OrderBy(p => p.ProduktId);
                currentCategory = " ";
            }
            else
            {
                produkter = _produkterRepository.AllProdukter.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ProduktId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ProdukterListViewModel
            {
                Produkter = produkter,
                CurrentCategory = currentCategory
            });
        }


        public IActionResult Details(int id)
        {
            var produkter = _produkterRepository.GetProductById(id);
            if (produkter == null)
                return NotFound();

            return View(produkter);
        }

        public IActionResult NyProdukt1(string currentCategory)
        {
            Produkter nyProdukt = new Produkter();
            var Category = _categoryRepository.GetCategoryByName(currentCategory);
            nyProdukt.CategoryId = Category.CategoryId;

            return View(nyProdukt);
        }

        [HttpPost]
        public IActionResult NyProdukt1(Produkter nyProdukt)
        {
            if (nyProdukt.Name == "")
            {
                ModelState.AddModelError("", "produkt namn:");
            }

            if (ModelState.IsValid)
            {

                _produkterRepository.CreateNewProductAndAddToDatabase(nyProdukt);
                return RedirectToAction("Complete");
            }

            return View(nyProdukt);
        }

        public IActionResult Complete()
        {
            ViewBag.Complete = "Thank you";
            return View();
        }

        public IActionResult UpdateProdukt1(int ProduktId)
        {
            var produkt = _produkterRepository.GetProductById(ProduktId);

            return View(produkt);
        }

        [HttpPost]
        


        public IActionResult UpdateProdukt1(int ProduktId, Produkter nyProdukt)
        {
            nyProdukt.ProduktId = ProduktId;

            if (nyProdukt.Name == "")
            {
                ModelState.AddModelError("", "Produkt namn");
            }

            if (ModelState.IsValid)
            {

                _produkterRepository.UpdateProductAndAddToDatabase(nyProdukt);
                return RedirectToAction("UpdateComplete");
            }

            return View(nyProdukt);
        }

        public IActionResult UpdateComplete()
        {
            ViewBag.UpdateComplete = "Uppdateringen är klar";
            return View();
        }
    }    
}

