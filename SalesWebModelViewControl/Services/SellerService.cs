using SalesWebModelViewControl.Data;
using SalesWebModelViewControl.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebModelViewControl.Services
{
    public class SellerService
    {
        private readonly SalesWebModelViewControlContext _context;

        public SellerService (SalesWebModelViewControlContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
