using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using AutoMapper;
using GamesStoreAPI.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace GamesStoreAPI.Config
{
    public static class AppConfiguration
    {
        public static void ConfigureDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GamesStoreContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Local"))
            );
        }
        public static void ConfigureServices(this IServiceCollection services)
        {
            string[] projects = new string[] { "GamesStoreAPI.BusinessLogic" };

            foreach (string project in projects)
            {
                List<Type> implementations = Assembly
                    .Load(project)
                    .GetTypes()
                    .Where(p => p.Name.EndsWith("Service") && !p.IsInterface)
                    .ToList();

                foreach (Type implementation in implementations)
                {
                    Type implentationInterface = implementation.GetInterface("I" + implementation.Name);

                    if (implentationInterface != null)
                        services.AddScoped(implentationInterface, implementation);
                    else
                        services.AddScoped(implementation);
                }
            }

            // services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddAutoMapper(typeof(Startup));

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Games Store API",
                    Description = "A simple example ASP.NET Core Web API using best practices",
                    Contact = new OpenApiContact
                    {
                        Name = "Luis Romero",
                        Email = "rl.luisfe@gmail.com",
                        Url = new Uri("https://luisferomero.github.io/"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under MIT",
                        Url = new Uri("https://opensource.org/licenses/MIT"),
                    }
                });
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

        }
    }
}