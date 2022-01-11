using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using piano_pizza.Exceptions;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using piano_pizza.Request_Culture_Provider;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Resources;
using System.Reflection;
using piano_pizza.Resources;
using BLL.AdminService;

namespace piano_pizza
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
            services.AddTransient<IAdminService, AdminService>();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 1;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
            })
             .AddEntityFrameworkStores<ApplicationDbContext>()
             .AddDefaultTokenProviders();

            services.AddControllersWithViews();

            services.AddLocalization(opt => { opt.ResourcesPath = "Resources"; });

            services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();

            services.AddSingleton<LocalizationService>();

            services.AddSingleton(new ResourceManager("piano_pizza.Resources.ApplicationResource", Assembly.GetExecutingAssembly()));

            services.Configure<RequestLocalizationOptions>(options =>
            {
                List<CultureInfo> supportedCultures = new List<CultureInfo>
                {
                    new CultureInfo("en-US"),
                    new CultureInfo("it-IT"),
                    new CultureInfo("nl-Nl"),
                };
                options.DefaultRequestCulture = new RequestCulture("en-US");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            var requestLocalizationOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(requestLocalizationOptions.Value);
            
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseExceptionHandlerMiddleware();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                    areaName:"SuperAdmin",
                    name: "default",
                    pattern: "SuperAdmin/{controller=Main}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                    areaName: "Cook",
                    name: "default",
                    pattern: "Cook/{controller=Main}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                    areaName: "Packer",
                    name: "default",
                    pattern: "Packer/{controller=Main}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                    areaName: "Receptionist",
                    name: "default",
                    pattern: "Receptionist/{controller=Main}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });


            //var options = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            //var supportedCultures = new[] { "en-US", "fr", "nl-Nl" };
            //var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(supportedCultures[0])
            //    .AddSupportedCultures(supportedCultures)
            //    .AddSupportedUICultures();

            //app.UseRequestLocalization(localizationOptions);

           

        }
    }
}
