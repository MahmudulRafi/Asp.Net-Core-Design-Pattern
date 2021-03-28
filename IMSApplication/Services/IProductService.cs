using IMSApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMSApplication.Services
{
    public interface IProductService
    {
        public List<Product> GetProducts();

        void Insert(Product product);
        
        void Update(Product product);
        
        void Delete(int id);
        
        void SaveChanges();
        
        Product GetById(int id);
    }
}
