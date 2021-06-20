using Complaints.Core.Models;
using Complaints.Data;
using Complaints.Repository.Implementations;
using Complaints.Repository.Interfaces;
using Complaints.Services.Implementations;
using Complaints.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Complaints.Web
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
            services.AddTransient<IComplaintTypeService, ComplaintTypeService>();
            services.AddTransient<IClaimTypeService, ClaimTypeService>();

            services.AddTransient<IComplaintTypeRepository, ComplaintTypeRepository>();
            services.AddTransient<IClaimTypeRepository, ClaimTypeRepository>();

            services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            string connectionString = Configuration["Data:Complaints:ConnectionString"];

            services.AddMvc();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString, builder => builder.MigrationsAssembly(typeof(Startup).Assembly.FullName)));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=List}/{id?}");
            });
        }
    }
}
