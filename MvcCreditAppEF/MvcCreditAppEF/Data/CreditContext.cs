using Microsoft.EntityFrameworkCore;
using MvcCreditAppEF.Models;

namespace MvcCreditAppEF.Data
{
    public class CreditContext : DbContext
    {
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Bid> Bids{ get; set; }

        public CreditContext(DbContextOptions<CreditContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
