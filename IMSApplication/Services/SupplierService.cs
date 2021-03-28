using IMSApplication.Models;
using IMSApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMSApplication.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _repository;
        public SupplierService(ISupplierRepository repository)
        {
            _repository = repository;
        }

        public List<Supplier> GetSuppliers()
        {
            return _repository.GetSuppliers();
        }

        public Supplier GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Insert(Supplier supplier)
        {
            _repository.Insert(supplier);
        }

        public void Update(Supplier supplier)
        {
            _repository.Update(supplier);
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public void SaveChanges()
        {
            _repository.SaveChanges();
        }
    }
}
