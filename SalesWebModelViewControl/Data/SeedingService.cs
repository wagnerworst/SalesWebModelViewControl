using SalesWebModelViewControl.Models;
using System;

namespace SalesWebModelViewControl.Data
{
    public class SeedingService
    {
        private SalesWebModelViewControlContext _context;

        public SeedingService(SalesWebModelViewControlContext context)
        {
            _context = context;
        }

        public void Seed() //popula a base de dados não é usado pois o Any não funciona mais para dbsets
        {
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1);

            _context.SaveChanges();
        }
    }
}
