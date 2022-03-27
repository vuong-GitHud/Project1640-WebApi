using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1640.Data.EF
{
    public class Project1640DbContextFactory : IDesignTimeDbContextFactory<Project1640DbContext>
    {
        public Project1640DbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("Project1640Db");

            var optionsBuilder = new DbContextOptionsBuilder<Project1640DbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new Project1640DbContext(optionsBuilder.Options);
        }
    }
}
