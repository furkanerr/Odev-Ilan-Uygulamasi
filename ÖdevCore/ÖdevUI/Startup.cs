using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bitirme÷devi.BLL.Abstract;
using Bitirme÷devi.BLL.Concrete;
using Bitirme÷devi.DAL.Abstract;
using Bitirme÷devi.DAL.Concrete;
using Bitirme÷devi.DAL.Concrete.EntityFramework;

using BitirmeProjesiUI.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BitirmeProjesiUI
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
            services.AddMvc();
            services.AddSession();
            services.AddDistributedMemoryCache();
            services.AddScoped<IAdsDal,EfAdsDal>();
            services.AddScoped<ICategoryDal,EfCategoryDal>();
            services.AddScoped<ICityDal,EfCityDal>();
            services.AddScoped<IGenderDal,EfGenderDal>();
            services.AddScoped<IPetTypeDal,EfPetTypeDal>();
            services.AddScoped<IPetBreedDal,EfPetBreedDal>();
            services.AddScoped<IUserDal,EfUserDal>();
            services.AddScoped<IPasswordCodeDal,EfPasswordCode>();

            services.AddScoped<IAdsService,AdsManager>();
            services.AddScoped<IPasswordCodeService,PasswordCodeManager>();
            services.AddScoped<ICategoryService,CategoryManager>();
            services.AddScoped<ICityService,CityManager>();
            services.AddScoped<IGenderService,GenderManager>();
            services.AddScoped<IPetTypeService,PetTypeManager>();
            services.AddScoped<IPetBreedService,PetBreedManager>();
            services.AddScoped<IUserService,UserManager>();
            services.AddScoped<ICommentDal,EfCommentDal>();
            services.AddScoped<ICommentService,CommentManager>();

          


            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
           
            app.UseNodeModules(env.ContentRootPath);
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Anasayfa}/{action=Anasayfa}/{id?}");
            });
        }
    }
}
