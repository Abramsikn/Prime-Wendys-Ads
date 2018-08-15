using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrimeWendys.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.EntityFrameworkCore;

namespace Prime_Wendys
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
            services.AddDbContext<PrimeWendysDB>(db => db.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("prime-wendys", new Info { Title = "Prime-Wendys ,REST API", Description = "Prime-Wendys", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(cors => cors.WithOrigins("http://localhost:4200", "https://270.0.0.1:4200")
                  .WithMethods("POST", "GET", "PUT", "DELETE")
                  .WithHeaders("Accept", "Authorization", "Content-Type", "Origin"));
            app.UseSwagger(); 

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/prime-wendys/swagger.json/", "Prime-Wendys API");
            });
            app.UseMvc();
        }
    }
}
