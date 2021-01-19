using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EFCoreFluentApi1.Context
{
    class MyContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder().
                   SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", false, true)
                   .Build();
            

            DbContextOptions options = new DbContextOptionsBuilder<MyContext>()
                .UseSqlServer(configuration.GetConnectionString("MyConnectionString"))
                .EnableSensitiveDataLogging(true).Options;

            return new MyContext(options);
        }

        
    }
}
