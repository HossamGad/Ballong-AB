using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
	public class NyProduktRepository : INyProduktRepository
    {
        private readonly AppDbContext database;


        public NyProduktRepository(AppDbContext appDbContext)
        {
            database = appDbContext;
        }

        // hämta alla kommentarer
        public IEnumerable<NyProdukt> AllaNyProdukt
        {
            get { return database.DbNyProdukt.Include(a => a.Name); }

        }

        // hämta alla kommentarer för angiven produkt
        public IEnumerable<NyProdukt> GetAllNewProduct()
        {
            return database.DbNyProdukt;

        }
        public IEnumerable<NyProdukt> GetNewProductByProductName(string Name)
        {
            return database.DbNyProdukt.Where(c => c.Name == Name);
        }
        public IEnumerable<NyProdukt> GetNewProductById(int ProduktId)
        {
            return database.DbNyProdukt.Where(c => c.ProduktId == ProduktId);
        }
        public IEnumerable<NyProdukt> GetNewProductByProductText(string Text)
        {
            return database.DbNyProdukt.Where(c => c.Text == Text);
        }
        
            public IEnumerable<NyProdukt> GetNewProductByProductPrice(float Price)
        {
            return database.DbNyProdukt.Where(c => c.Price == Price);
        }

        // lägg till ny kommentar
        public void CreateNewProductAndAddToDatabase(NyProdukt nyProdukt)
        {
            database.DbNyProdukt.Add(nyProdukt);
            database.SaveChanges();

        }

       
        public IEnumerable<NyProdukt> GetNewProductByProductId(int CategoryId)
        {
            return database.DbNyProdukt.Where(p => p.CategoryId == CategoryId);
        }

       
    }
}
