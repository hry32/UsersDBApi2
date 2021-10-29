using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using UsersDBApi2.Models;
using Serilog;
using Users.Services.Services;
using Users.Data.Models;
using Users.Data.Interfaces;
using Users.Data.Settings;
using Users.Services.Extensions;

namespace UsersDBApi2
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
           var connection = Configuration.GetConnectionString("DBConnection");
        
            services.AddDbContextPool<UserContext>(options => options.UseSqlServer(connection));
            services.AddControllers();
            services.AddScoped<IUserService, Userservice>();
            //services.AddDbContext<UserContext>(opt => opt.UseInMemoryDatabase("UserList"));


            services.AddHttpContextAccessor();
            services.AddControllers();

            services.AddTransient<ITenantService, TenantService>();
            services.AddTransient<IProductService, ProductService>();
            services.Configure<TenantSettings>(Configuration.GetSection(nameof(TenantSettings)));
            services.AddAndMigrateTenantDatabases(Configuration);


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSerilogRequestLogging();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
