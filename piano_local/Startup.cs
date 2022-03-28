using BLL.AdminService;
using DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using piano_local.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Threading.Tasks;

namespace piano_local
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

            services.AddLocalization(opt => { opt.ResourcesPath = "Resources"; });
            services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();
            services.AddSingleton<LocalizationService>();
            services.AddSingleton(new ResourceManager("piano_local.Resources.ApplicationResource", Assembly.GetExecutingAssembly()));
            services.Configure<RequestLocalizationOptions>(
                opt =>
                {
                    var supportedCultures = new List<CultureInfo>
                    {
                        new CultureInfo("en-US"),
                        new CultureInfo("it-IT"),
                        new CultureInfo("nl-NL"),
                        new CultureInfo("ur-UR"),
                    };
                    opt.DefaultRequestCulture = new RequestCulture("en-US");
                    opt.SupportedCultures = supportedCultures;
                    opt.SupportedUICultures = supportedCultures;
                });
            services.AddControllersWithViews();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseRequestLocalization(app.ApplicationServices.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value);

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                    areaName: "SuperAdmin",
                    name: "default",
                    pattern: "SuperAdmin/{controller=Main}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                    areaName: "Cook",
                    name: "default",
                    pattern: "Cook/{controller=Main}/{action=Index}/{id?}");


                endpoints.MapAreaControllerRoute(
                    areaName: "PackerStaff",
                    name: "default",
                    pattern: "PackerStaff/{controller=Main}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                    areaName: "Driver",
                    name: "default",
                    pattern: "Driver/{controller=Main}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                    areaName: "Receptionist",
                    name: "default",
                    pattern: "Receptionist/{controller=Main}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
        }
    }
}
