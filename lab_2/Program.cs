// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace lab_2;

class Program

{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    } 
    public static IHostBuilder CreateHostBuilder(string[] args)
    { return Host.CreateDefaultBuilder(args)

            .ConfigureServices((hostContext, services) =>
            {
                services.AddHostedService<Princess>();
                services.AddScoped<Hall>();
                services.AddScoped<Friend>();
                services.AddScoped<ContenderGenerator>();
            });
    }
}

