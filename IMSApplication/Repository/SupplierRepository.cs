using IMSApplication.Data;
using IMSApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMSApplication.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly ApplicationDbContext _context;
       
        public SupplierRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Supplier> GetSuppliers()
        {
            return _context.Suppliers.ToList();
        }

        public Supplier GetById(int id)
        {
            return _context.Suppliers.Where(supplier => supplier.SupplierID == id).SingleOrDefault();
        }

        public void Insert(Supplier supplier)
        {
            _context.Add(supplier);
        }

        public void Update(Supplier supplier)
        {
            _context.Update(supplier);
        }

        public void Delete(int id)
        {
            Supplier supplier = GetById(id);
            _context.Remove(supplier);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
