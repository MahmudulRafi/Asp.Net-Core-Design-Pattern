using IMSApplication.Models;
using IMSApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMSApplication.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public List<Product> GetProducts()
        {
           return _repository.GetProducts();
        }

        public Product GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Insert(Product product)
        {
            _repository.Insert(product);
        }
        
        public void Update(Product product)
        {
            _repository.Update(product);
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
