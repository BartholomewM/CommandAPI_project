
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
// IHostingEnvironment it was old instead i am using IWebHostEnvironment
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace CommandAPI;
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
    }

    public void Configure(
        IApplicationBuilder app, 
        IWebHostEnvironment env
        )
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        // app.Run(async (context) =>
        // {
        //     await context.Response.WriteAsync("Hello World!");
        // });

        app.UseRouting();

        // app.UseEndpoints( (endpoints) => {
        //     endpoints.MapGet("/", async (context) => {
        //         await context.Response.WriteAsync("Hellow World !!!");
        //     });
        // });
        app.UseEndpoints( (endpoints) => {
            endpoints.MapControllers();
        });
    }
}


