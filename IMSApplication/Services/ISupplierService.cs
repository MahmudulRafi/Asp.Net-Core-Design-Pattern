using IMSApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMSApplication.Services
{
    public interface ISupplierService
    {
        public List<Supplier> GetSuppliers();
        
        void Insert(Supplier supplier);
        
        void Update(Supplier supplier);
        
        void Delete(int id);
        
        void SaveChanges();
        
        Supplier GetById(int id);
    }
}
