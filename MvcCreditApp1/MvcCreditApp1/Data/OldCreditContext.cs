using MvcCreditApp1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCreditApp1.Data
{
    public class OldCreditContext : DbContext
    {
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Credit> Credits { get; set; }
    }
}
