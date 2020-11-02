using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmdarisInternship.Infrastructure.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AmdarisInternship
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AmdarisInternshipContext appContext = new AmdarisInternshipContext();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
