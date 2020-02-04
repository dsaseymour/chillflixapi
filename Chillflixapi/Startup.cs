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
using Entities;
using Chillflixapi.Extensions;
using Chillflixapi.Middleware;


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
            services.ConfigureRepositoryManager();
            services.AddScoped<ProfileRepository>();
            services.AddScoped<UserRepository>();
            services.AddMvcCore().AddXmlSerializerFormatters().AddJsonFormatters();
            services.ConfigureSwagger();
            
            //enable CORS to allow the SPA to call our API
            services.AddCors();
            services.ConfigureSqlContext(Configuration);

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
