using IMSApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMSApplication.Repository
{
    public interface IProductRepository
    {
        public List<Product> GetProducts();

        void Insert(Product product);

        void Update(Product product);

        void Delete(int id);

        Product GetById(int id);

        void SaveChanges();

    }
}