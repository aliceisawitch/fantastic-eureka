using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using NetCoreWebApp_1.Models;

namespace NetCoreWebApp_1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {   
            services.AddTransient<ISamochodRepository, MockSamochodRepository>();   //długość życia - za każdym razem otrzymujemy nową instancję klasy
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {   //KOLEJNOSC MA TU ZNACZENIE//
            app.UseDeveloperExceptionPage(); //OBSLUGA EXCEPTION PAGE - dowiemy się dzięki temu co się popsuło
            app.UseStatusCodePages(); // wyświetla status żądania
            app.UseStaticFiles(); //obsługa plików statycznych tj. jpg domyslnie przeszukuje wwwroot
            app.UseMvcWithDefaultRoute(); //Obsługa Mvc z domyślnym routingiem TEN KOMPONENT ZAWSZE OSTATNI PO USE STATIC FILE (OBNIZENIE OBCIAZENIA SERVERA)
        }
    }
}
