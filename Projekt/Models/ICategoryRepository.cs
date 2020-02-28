using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
	public interface ICategoryRepository
	{
		IEnumerable<Category> AllCategories { get; }
		Category GetProductById(int CategoryId);
		Category GetCategoryByName(string currentCategory);

		void CreateNewCategoryAndAddToDatabase(Category nyCategory);
	}
}
