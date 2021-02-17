using CrudWithDI.Data;
using CrudWithDI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithDI.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly ApplicationDbContext _context;

        public SupplierRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Supplier>> GetSuppliers()
        {
            return await _context.Suppliers.ToListAsync();
            //throw new NotImplementedException();
        }

        public async Task<Supplier> GetSupplier(int? id)
        {
            var dept = await _context.Suppliers
                 .FirstOrDefaultAsync(m => m.Id == id);

            return dept;
        }

        public async Task Save(Supplier supplier)
        {
            _context.Add(supplier);
            await _context.SaveChangesAsync();
        }
    }
}
