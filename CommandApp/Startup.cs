using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandApp.Entity;
using CommandApp.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using Swashbuckle.AspNetCore.Swagger;

namespace CommandApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<AppDbContext>(
                options => options.UseSqlite("Data Source= mydb.db;")
            );
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info{Title = "sds", Version = "v1"});
            });

            services.AddMediatR();
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CommandLogger<,>));
            
            return services.BuildServiceProvider();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            
            

            app.UseMvc();

            using (var context = app.ApplicationServices.GetService<AppDbContext>())
            {
                context.Database.Migrate();
            }
        }
    }
}