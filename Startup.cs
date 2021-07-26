using CodexEvents.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodexEvents.DataAccessLayer.UserRepository;
using CodexEvents.Services.LoginService;
using CodexEvents.Services.ProfileService;
using CodexEvents.DataAccessLayer.EventRepository;
using CodexEvents.Services.EventService;
using CodexEvents.DataAccessLayer.EventRegistrationRepository;
using CodexEvents.Services.EventRegistrationService;

namespace CodexEvents
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
            services.AddMvc().AddSessionStateTempDataProvider();
            services.AddSession();
            services.AddControllersWithViews();
            services.AddDbContext<CodexEventsDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultDBConnection")));
            services.AddTransient<IUserRepository, UserRepositoryImpl>();
            services.AddTransient<ILoginService, LoginServiceImpl>();
            services.AddTransient<IProfileService, ProfileServiceImpl>();
            services.AddTransient<IEventRepository, EventRepositoryImpl>();
            services.AddTransient<IEventService, EventServiceImpl>();
            services.AddTransient<IEventRegistrationRepository, EventRegistrationRepositoryImpl>();
            services.AddTransient<IEventRegistrationService, EventRegistrationServiceImpl>();
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

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
