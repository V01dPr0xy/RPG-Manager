using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RPG_Manager.Areas.RPGArea.Data;

namespace RPG_Manager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            using(var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var con = services.GetRequiredService<CharacterContext>();
                    DBInit.Init(con);
                }
                catch (Exception ex)
                {
                    var log = services.GetRequiredService<ILogger<Program>>();
                    log.LogError(ex, "An error occurred whilst seeding the database");
                }
            }
            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
