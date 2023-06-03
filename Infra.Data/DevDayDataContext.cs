using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data
{
    public class DevDayDataContext : DbContext
    {
        public DevDayDataContext(DbContextOptions<DevDayDataContext> options) : base (options)
        {            
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new CustomerMap);
        }
    }
}
