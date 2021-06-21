//  ApplicationDbContextFactory.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       23:20:52 21/6/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using StarData.Infrastructure.Data;

namespace StartData.Migrations
{
    /// <summary>
    /// dotnet ef migrations add InitialCreate
    /// dotnet ef database update
    /// </summary>
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<StarDataContext>
    {
        public ApplicationDbContextFactory()
        {
        }

        public StarDataContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", true)
                 .AddEnvironmentVariables()
                 .Build();

            var builder = new DbContextOptionsBuilder();

            var connectionString = configuration
                        .GetConnectionString("StarDataConnection");

            builder.UseSqlServer(connectionString,
                        x => x.MigrationsAssembly(typeof(ApplicationDbContextFactory).Assembly.FullName));



            return new StarDataContext(builder.Options);
        }
    }
}
