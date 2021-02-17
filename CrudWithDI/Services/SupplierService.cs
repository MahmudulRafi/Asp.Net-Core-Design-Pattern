using CrudWithDI.Models;
using CrudWithDI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithDI.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _repository;

        public SupplierService(ISupplierRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Supplier>> GetSuppliers()
        {
            return await _repository.GetSuppliers();
        }

        public async Task<Supplier> GetSupplier(int? id)
        {
            return await _repository.GetSupplier(id);
        }

        public async Task Add(Supplier supplier)
        {
            await _repository.Save(supplier);
        }
    }
}
