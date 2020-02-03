using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.AzureADB2C.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Serilog;
using Microsoft.OpenApi.Models;
using Repositories;



namespace Chillflixapi
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
            services.AddDbContextPool<ChillflixapiContext>(options => options.UseMySQL(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddScoped<ProfileRepository>();
            services.AddScoped<UserRepository>();
            services.AddMvcCore().AddXmlSerializerFormatters().AddJsonFormatters();
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

            //enable CORS to allow the SPA to call our API
            services.AddCors();
            //Using DbContext with dependency injection
            // Use connection string from appsettings.json file
            services.AddDbContext<ChillflixapiContext>(options =>
            {
                options.UseSqlServer(Configuration["AppSettings:ConnectionString"]);
            });

            services.AddAuthentication(AzureADB2CDefaults.BearerAuthenticationScheme)
        .AddAzureADB2CBearer(options => Configuration.Bind("AzureAdB2C", options));


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSerilogRequestLogging();
            app.ConfigureCustomExceptionMiddleware();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            //Enable middleware to serve generated Swagger as a JSON endpoint
            app.UseSwagger();
            //Enable middleware to server swagger ui
            //Specify Swagger JSON Endpoint
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ChillFlix APIV1");
            });

            app.UseMvc();
        }
    }
}
