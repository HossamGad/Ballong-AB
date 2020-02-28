using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class MockProdukterRepository: IProdukterRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Produkter> AllProdukter =>
            new List<Produkter>
            {
                new Produkter {ProduktId = 1, Name="Hem Golv", Price=15.95M, ShortDescription="Missoni Home", LongDescription="Golv som passar till vardagsrum, och är inspirerat av ett tyg från Missoni och har ett distinkt grafiskt mönster med en flödande gradient, presenterad i tidlöst svart..", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", InStock=true, ProductOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"},
                new Produkter {ProduktId = 2, Name="Hem Mattor", Price=18.95M, ShortDescription="Missoni Home", LongDescription="svartblå matta med kopparinslag. Mattan är producerad i vårt egna originalmaterial av vinyl som förstärkts genom att addera ull och glittrigt garn.", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", InStock=true, ProductOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg"},
                new Produkter {ProduktId = 3, Name="Hem Tillbehör", Price=15.95M, ShortDescription="Missoni Home", LongDescription="Innovativ svetsningsprodukt som är bättre för miljön och hälsosammare för installatören.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", InStock=true, ProductOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg"},
            };

        //public IEnumerable<Produkter> ProductOfTheWeek { get; }

       


        public Produkter GetProductById(int ProduktId)
        {
            return AllProdukter.FirstOrDefault(p => p.ProduktId == ProduktId);
        }

        public void CreateNewProductAndAddToDatabase(Produkter nyProdukt)
        {

        }

        public void UpdateProductAndAddToDatabase(Produkter nyProdukt)
        {

        }
    }
}
