using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ITJobProject.Data.EF
{
    public class ITJobDbContextFactory : IDesignTimeDbContextFactory<ITJobDbContext>

    {
        public ITJobDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ITJobSolutionDb");
            var optionsBuilder = new DbContextOptionsBuilder<ITJobDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
                return new ITJobDbContext(optionsBuilder.Options);
        }
    }
}
