using Capgemini.Domain;
using Microsoft.EntityFrameworkCore;

namespace Capgemini.API.Infastructure
{
    public class CapgeminiContext :DbContext
    {
        public CapgeminiContext(DbContextOptions<CapgeminiContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderHeder> OrderHeders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
    }
}