using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Projekt.Controllers
{
    [Authorize]
    public class CategoriesController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public ViewResult List()
        {
            return View();
        }
            public IActionResult NyCategory()
        {
           
            return View();
        }

        [HttpPost]
        
        public IActionResult NyCategory(Category nyCategory)
        {
            
            if (nyCategory.CategoryName == "")
            {
                ModelState.AddModelError("", "Skriv projekt namn");
            }

            if (ModelState.IsValid)
            {

                _categoryRepository.CreateNewCategoryAndAddToDatabase(nyCategory);
                return RedirectToAction("Complete");
            }

            return View(nyCategory);
        }

        public IActionResult Complete()
        {
            ViewBag.Complete = "Thank you";
            return View();
        }
    }
}
