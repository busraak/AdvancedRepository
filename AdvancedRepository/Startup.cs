using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Data;
using AdvancedRepository.Models.ViewModels;
using AdvancedRepository.Repository.Classes;
using AdvancedRepository.Repository.Interfaces;
using AdvancedRepository.UnitofWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromDays(1); //1 gün geçerli
                options.Cookie.IsEssential = true;
            });

            services.AddDbContext<SirketContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Baglanti")));
            services.AddScoped<IProductRepos,ProductRepos>(); //dependency injection 
            //services.AddScoped<ICategoryRepos, CategoryRepos>(); //dependency injection // unitofwork un icinde newlendigi icin burada tanýmlamaya ihtiyac yok.
            services.AddScoped<IUnitRepos, UnitRepos>(); //dependency injection 
            services.AddScoped<ISupplierRepos, SupplierRepos>(); //dependency injection 
            services.AddScoped<IEmployeeRepos, EmployeeRepos>(); //dependency injection 
            services.AddScoped<ICountryRepos, CountryRepos>(); //dependency injection 
            services.AddScoped<ICityRepos, CityRepos>(); //dependency injection 
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICustomerRepos, CustomerRepos>();
            services.AddScoped<IFatMasterRepos, FatMasterRepos>();
            services.AddScoped<IFatDetailRepos, FatDetailRepos>();
            services.AddScoped<IAuthRepos, AuthRepos>();
            services.AddScoped<IBasketDetailRepos, BasketDetailRepos>();
            services.AddScoped<IBasketMasterRepos, BasketMasterRepos>();

            services.AddScoped<CountriesModel>();
            services.AddScoped<ProductsModel>();
            services.AddScoped<CategoriesModel>();
            services.AddScoped<UnitsModel>();
            services.AddScoped<EmployeeModel>();
            services.AddScoped<CitiesModel>();
            services.AddScoped<CustomersModel>();
            services.AddScoped<FatMasterModel>();
            services.AddScoped<FatDetailModel>();
            services.AddScoped<LoginModel>();
            services.AddScoped<BasketModel>();
            services.AddScoped<List<BasketList>>();
            services.AddScoped<BasketList>();
            services.AddScoped<Users>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession(); // session ý kullanabilmemize imkan saglar. (session: tarayýcýnýn hafýzasýnda sakladýgý degiskenler)

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
