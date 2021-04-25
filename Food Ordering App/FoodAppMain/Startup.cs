using FoodAppBO;
using FoodAppBO.Interface;
using FoodAppDO;
using FoodAppDO.Interface;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace FoodAppMain
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
            services.ConfigureApplicationCookie(options =>
            {
                options.LogoutPath = "/Account/Logout";
                options.LoginPath = "/Account/Login";
                options.AccessDeniedPath = "/Account/Login";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = new TimeSpan(30, 0, 0, 0);

            });

            services.AddAuthentication(options =>   // we tell about the authentication scheme like here we are using cookies
            {
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options =>
            {
                options.SlidingExpiration = true;// if we want to increase its expiry cookie to 24 hrs after its login 
                options.ExpireTimeSpan = new TimeSpan(0, 0, 10, 0);
            });

            services.AddControllersWithViews();
            services.AddDbContext<FoodAppEntity.Entities.FoodAppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("FoodAppDb")));
            services.AddScoped<IFoodAppBusinessComponent, FoodAppBusinessComponent>();
            services.AddScoped<IFoodAppDataAccess, FoodAppDataAccess>();

            
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}
