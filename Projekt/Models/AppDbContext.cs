using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Projekt.Models
{
	public class AppDbContext: IdentityDbContext<IdentityUser>
    {
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{


		}
        
        public DbSet<NyProdukt> DbNyProdukt { get; set; }

        public DbSet<Produkter> Produkter { get; set; }
		public DbSet<Category> Categories { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Sovrum" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Badrum" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Vardagsrum" });

            //seed pies

            modelBuilder.Entity<Produkter>().HasData(new Produkter
            {
                ProduktId = 1,
                Name = "Golv(Missoni Home)",
                Price = 56.95M,
                ShortDescription = "Missoni Home",
                LongDescription =
                    "Golv som passar till vardagsrum, och är inspirerat av ett tyg från Missoni och har ett distinkt grafiskt mönster med en flödande gradient, presenterad i tidlöst svart. ",
                CategoryId = 1,
                ImageUrl = "https://www.systerlycklig.se/images/2.112861/missoni-home-handduk-giacomo-70x115-cm.jpeg",
                ImageThumbnailUrl = "https://www.systerlycklig.se/images/2.112861/missoni-home-handduk-giacomo-70x115-cm.jpeg",
            });

            modelBuilder.Entity<Produkter>().HasData(new Produkter
            {
                ProduktId = 2,
                Name = "Golv(Artisan - Coal)",
                Price = 76.95M,
                ShortDescription = "Artisan - Coal",
                LongDescription =
                    "Ett varmt, taktilt golv med en handgjord känsla – dåtid möter nutid i en svart/grå nyans. ",
                CategoryId = 2,
                ImageUrl = "https://www.systerlycklig.se/images/2.111554/designers-guild-matta-eberson-cobalt-160x260-cm.jpeg",
                ImageThumbnailUrl =" https://www.systerlycklig.se/images/2.111554/designers-guild-matta-eberson-cobalt-160x260-cm.jpeg",
            });
            modelBuilder.Entity<Produkter>().HasData(new Produkter
            {
                ProduktId = 3,
                Name = "Golv(BKB - Metallic Alpha)",
                Price = 83.95M,
                ShortDescription = "BKB - Metallic Alpha",
                LongDescription =
                   "Ett golv inspirerat av Sisalmattor, med en mjuk, strukturerad och ändå slitstark känsla. ",
                CategoryId = 3,
                ImageUrl = "https://www.systerlycklig.se/images/2.115904/designers-guild-matta-caretti-linen-160x260-cm.jpeg",
                ImageThumbnailUrl = "https://www.systerlycklig.se/images/2.115904/designers-guild-matta-caretti-linen-160x260-cm.jpeg",
            });
            modelBuilder.Entity<Produkter>().HasData(new Produkter
            {
                ProduktId = 4,
                Name = "Matta(Duet - Duet Glow)",
                Price = 83.95M,
                ShortDescription = "Duet - Duet Glow",
                LongDescription =
                   "Glow är en mörk, svartblå matta med kopparinslag. Mattan är producerad i vårt egna originalmaterial av vinyl som förstärkts genom att addera ull och glittrigt garn. ",
                CategoryId = 1,
                ImageUrl = "https://www.systerlycklig.se/images/2.115969/designers-guild-matta-ashbee-berry-250x350-cm.jpeg",
                ImageThumbnailUrl = "https://www.systerlycklig.se/images/2.115969/designers-guild-matta-ashbee-berry-250x350-cm.jpeg",
            });

            modelBuilder.Entity<Produkter>().HasData(new Produkter
            {
                ProduktId = 5,
                Name = "Matta(Castillion Fuchsia)",
                Price = 105.95M,
                ShortDescription = "Castillion Fuchsia",
                LongDescription =
                   "Matta Castillion Fuchsia från Designers Guild är en handvävd matta med modernt diagonalt rutmönster. ",
                CategoryId = 3,
                ImageUrl = "https://www.systerlycklig.se/images/2.153034/designers-guild-matta-castillion-fuchsia-160x260-cm.jpeg",
                ImageThumbnailUrl = "https://www.systerlycklig.se/images/2.153034/designers-guild-matta-castillion-fuchsia-160x260-cm.jpeg",
            });
            modelBuilder.Entity<Produkter>().HasData(new Produkter
            {
                ProduktId = 6,
                Name = "Matta(Giacomo)",
                Price = 116.95M,
                ShortDescription = "Giacomo",
                LongDescription =
                   "Badrumsmatta Giacomo från italienska Missoni med klassiskt zickzackmönster. ",
                CategoryId = 2,
                ImageUrl = "https://www.systerlycklig.se/images/2.110160/missoni-home-badrumsmatta-giacomo.jpeg",
                ImageThumbnailUrl = "https://www.systerlycklig.se/images/2.110160/missoni-home-badrumsmatta-giacomo.jpeg",
            });

            modelBuilder.Entity<Produkter>().HasData(new Produkter
            {
                ProduktId = 7,
                Name = "Marmor(Aura Marengo Blank )",
                Price = 610.95m,
                ShortDescription = "Aura Marengo Blank ",
                LongDescription =
                   "En slitstark och vacker klinker i grå nyanser och naturliga marmoreringar. ",
                CategoryId = 3,
                ImageUrl = "https://www.systerlycklig.se/images/2.199538/sandberg-tapet-hannes-morkbla.jpeg",
                ImageThumbnailUrl = "https://www.systerlycklig.se/images/2.199538/sandberg-tapet-hannes-morkbla.jpeg",
            });
            modelBuilder.Entity<Produkter>().HasData(new Produkter
            {
                ProduktId = 8,
                Name = "Marmor(Alvesta Assos Grey Matt)",
                Price = 568.95m,
                ShortDescription = "Alvesta Assos Grey Matt",
                LongDescription =
                   "marmorerad granitkeramik i grå nyanser. Dramatiskt mönster med känsla av mörka moln som hopar sig. ",
                CategoryId = 1,
                ImageUrl = "https://www.systerlycklig.se/images/2.199595/sandberg-tapet-hannes-svart.jpeg",
                ImageThumbnailUrl = "https://www.systerlycklig.se/images/2.199595/sandberg-tapet-hannes-svart.jpeg",
            });
            modelBuilder.Entity<Produkter>().HasData(new Produkter
            {
                ProduktId = 9,
                Name = "Marmor(Marquina )",
                Price = 428.95m,
                ShortDescription = "Marquina ",
                LongDescription =
                   " slät yta och marmor-känsla. Ger en exklusiv och vacker vägg. ",
                CategoryId = 2,
                ImageUrl = "https://cdn.cdon.com/media-dynamic/images/product/kidsbaby/kidsbabydefault/image838/kakel_d-sign_metro_marquina_10x20-49323698-69612507-xtra1.jpg",
                ImageThumbnailUrl = "https://cdn.cdon.com/media-dynamic/images/product/kidsbaby/kidsbabydefault/image838/kakel_d-sign_metro_marquina_10x20-49323698-69612507-xtra1.jpg",
            });
        }
    }
}
