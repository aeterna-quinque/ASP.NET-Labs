using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MvcCreditApp1.Models;

namespace MvcCreditApp1.Data
{
    public class CreditContext : DbContext
    {

        public CreditContext() { }

        public CreditContext (DbContextOptions<CreditContext> options)
            : base(options)
        {
        }

        public DbSet<Bid> Bids { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("CreditContext"));
        }
    }
}
