//adding all the d ifferent necessary libraries to run the webAPI
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BookingSystemNew.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration {  get; }

        public void ConfigurationServices(IServiceCollection services)
        {
            services.AddControllers();
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CwkBooking.Api", Version = "v1" });
            });
            services.AddSingleton<DtataSource>();

        }
        //the method/function im writing below gets called at the runtime and its basic functionality is to configure all the HTTP requests
        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) {  
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CwkBooking.Api v1"));
            }
            app.UseHttpsRedirection();
            app.UseAuthorization(();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
