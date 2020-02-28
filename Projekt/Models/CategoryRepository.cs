using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
	public class CategoryRepository: ICategoryRepository
    {
		
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => _appDbContext.Categories;
        public Category GetProductById(int CategoryId)
        {
            return _appDbContext.Categories.FirstOrDefault(p => p.CategoryId == CategoryId);
        }

        // lägg till ny category
        public void CreateNewCategoryAndAddToDatabase(Category nyCategory)
        {
            _appDbContext.Categories.Add(nyCategory);
            _appDbContext.SaveChanges();

        }
        public Category GetCategoryByName(string currentCategory)
        {
            return _appDbContext.Categories.FirstOrDefault(p => p.CategoryName == currentCategory);
        }
    }
}

