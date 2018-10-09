﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
<<<<<<< HEAD
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
=======
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RazorPagesMovie.Models;
>>>>>>> e386c088684990027c234fafd34d9f652b4a037c

namespace RazorPagesMovie
{
    public class Program
    {
        public static void Main(string[] args)
        {
<<<<<<< HEAD
            CreateWebHostBuilder(args).Build().Run();
=======
           var host =  CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.GetRequiredService<RazorPagesMovieContext>();
                    context.Database.Migrate();
                    SeedData.Initialize(services);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB."); 
                }
            }

            host.Run();
>>>>>>> e386c088684990027c234fafd34d9f652b4a037c
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
