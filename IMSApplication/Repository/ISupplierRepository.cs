using IMSApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMSApplication.Repository
{
    public interface ISupplierRepository
    {
        public List<Supplier> GetSuppliers();

        void Insert(Supplier supplier);

        void Update(Supplier supplier);

        void Delete(int id);

        Supplier GetById(int id);

        void SaveChanges();
    }
}
