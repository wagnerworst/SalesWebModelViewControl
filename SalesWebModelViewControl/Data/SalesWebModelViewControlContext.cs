using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<SalesWebModelViewControl.Models.Department> Department { get; set; }
    }
}
