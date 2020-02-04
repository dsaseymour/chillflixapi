using System;
using Contracts;
using Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Repositories;

namespace Chillflixapi.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) {
            //Using DbContext with dependency injection
            // Use connection string from appsettings.json file
            services.AddDbContext<ChillflixapiContext>(options =>
            {
                options.UseSqlServer(configuration["AppSettings:ConnectionString"]);
            });
        }

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            //Register Swagger Generator, Define Swagger Documents
            services.AddSwaggerGen((options) => {
                options.SwaggerDoc(
                    "v1",
                    new OpenApiInfo
                    {
                        Title = "Chillflix API",
                        Version = "v1",
                        Description = "Chillflix an ASP.NET Core Application",
                        Contact = new OpenApiContact
                        {
                            Name = "Danny Seymour",
                            Url = new Uri("https://dannyseymour.me"),
                        }
                    }
                    );
            });
        }





    }
}
