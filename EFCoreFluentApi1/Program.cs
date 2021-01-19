using EFCoreFluentApi1.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace EFCoreFluentApi1
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder().
                    SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", false, true)
                    .Build();


            DbContextOptions options = new DbContextOptionsBuilder<MyContext>()
                .UseSqlServer(configuration.GetConnectionString("MyConnectionString"))
                .EnableSensitiveDataLogging(true).Options;

            using (var context = new MyContext(options))
            {
                var result = context.Audit.Include(e => e.ModEmployee).ToList(); //ModEmployee is populated 
                //var result = context.Audit.ToList(); //ModEmployee = null
                foreach (var value in result)
                {
                    Console.WriteLine($"█ Audit: {value.AuditId}");
                    Console.WriteLine(JsonSerializer.Serialize(value));
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
