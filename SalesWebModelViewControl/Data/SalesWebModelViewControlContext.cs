using Microsoft.EntityFrameworkCore;
using SalesWebModelViewControl.Models;

namespace SalesWebModelViewControl.Data
{
    public class SalesWebModelViewControlContext : DbContext
    {
        public SalesWebModelViewControlContext (DbContextOptions<SalesWebModelViewControlContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
