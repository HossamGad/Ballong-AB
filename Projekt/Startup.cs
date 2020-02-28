using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Projekt.Models;

namespace Projekt
{
	public class Startup
	{

		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<AppDbContext>(options =>
							options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

			services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>();

			services.AddScoped<ICategoryRepository, CategoryRepository>();
			services.AddScoped<IProdukterRepository, PodukterRepository>();
			services.AddScoped<INyProduktRepository, NyProduktRepository>();

			
			services.AddHttpContextAccessor();
			services.AddSession();

			services.AddControllersWithViews();//services.AddMvc(); would also work still
			services.AddRazorPages();

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseSession();

			app.UseRouting();
			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");

				endpoints.MapRazorPages();
			});
		}
	}
}
