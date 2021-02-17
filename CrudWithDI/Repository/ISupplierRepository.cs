using CrudWithDI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithDI.Repository
{
        public interface ISupplierRepository
        {
            public Task<List<Supplier>> GetSuppliers();
            public Task<Supplier> GetSupplier(int? id);

            public Task Save(Supplier supplier);

        }
}
