using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
	public class MockCategoryRepository: ICategoryRepository
	{
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Golv", Description="Golv Produkter"},
                new Category{CategoryId=2, CategoryName="Mattor", Description="Mattor passar till allt"},
                new Category{CategoryId=3, CategoryName="Tillbehör", Description="Alla tillbehör som behövs"}
            };

        public Category GetProductById(int CategoryId)
        {
            return AllCategories.FirstOrDefault(p => p.CategoryId == CategoryId);
        }

        public void CreateNewCategoryAndAddToDatabase(Category nyCategory)
        {

        }
        public Category GetCategoryByName(string currentCategory)
        {
            return AllCategories.FirstOrDefault(p => p.CategoryName == currentCategory);
        }
    }
}
