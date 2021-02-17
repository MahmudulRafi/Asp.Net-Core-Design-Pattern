using CrudWithDI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithDI.Services
{
        public interface ISupplierService
        {
            public Task<List<Supplier>> GetSuppliers();
            public Task<Supplier> GetSupplier(int? id);
            public Task Add(Supplier supplier);
        }
    }