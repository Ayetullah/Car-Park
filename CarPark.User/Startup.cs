using CarPark.Business.Abstract;
using CarPark.Business.Concrete;
using CarPark.Core.Repository.Abstract;
using CarPark.Data.Access.Abstract;
using CarPark.Data.Access.Concrete;
using CarPark.Data.Access.Context;
using CarPark.Data.Access.Repository;
using CarPark.User.Resources;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Localization.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CarPark.User
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
            services.AddScoped(typeof(IRepository<>), typeof(MsSqlRepositoryBase<>));
            services.AddScoped<IPersonelDataAccess, PersonelDataAccess>();
            services.AddScoped<IPersonelService, PersonelManager>();
            services.AddDbContext<MsSqlDbContext>(opt =>
            opt.UseSqlServer(
                    Configuration.GetConnectionString("DefaulConnection")
                ));
            services.AddControllersWithViews();

            #region Localization
            services.AddLocalization(opt => {
                opt.ResourcesPath = "Resources";
            });

            services.Configure<RequestLocalizationOptions>(opt => {
                var supportedCultures = new List<CultureInfo> { 
                    new CultureInfo("en-US"),
                    new CultureInfo("tr-TR"),
                    new CultureInfo("ar-SA")
                };
                opt.DefaultRequestCulture = new RequestCulture("tr-TR");
                opt.SupportedCultures = supportedCultures;
                opt.SupportedUICultures = supportedCultures;

                //opt.RequestCultureProviders = new List<IRequestCultureProvider> { 
                //    new QueryStringRequestCultureProvider(),
                //    new CookieRequestCultureProvider(),
                //    new AcceptLanguageHeaderRequestCultureProvider()
                //};
                opt.RequestCultureProviders = new[] { new RouteDataRequestCultureProvider() {
                     Options = opt
                    } 
                };
            });
            #endregion

            services.AddMvc()
                .AddDataAnnotationsLocalization(
                    opt => opt.DataAnnotationLocalizerProvider = (type, fact) =>
                    {
                        var assemblyName = new AssemblyName(typeof(SharedModelResource).GetTypeInfo().Assembly.FullName);
                        return fact.Create(nameof(SharedModelResource), assemblyName.Name);
                    }
                )
                .AddViewLocalization();

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

            app.UseRouting();

            app.UseAuthorization();
            #region Localization
            var options = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(options.Value);
            #endregion
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
