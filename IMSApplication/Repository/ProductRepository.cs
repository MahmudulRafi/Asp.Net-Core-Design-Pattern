using IMSApplication.Data;
using IMSApplication.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMSApplication.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public List<Product> GetProducts()
        {
            return _context.Products.Include(p => p.Supplier).ToList();
        }

        public void Insert(Product product)
        {
            _context.Add(product);
        }

        public void Update(Product product)
        {
            _context.Update(product);
        }

        public void Delete(int id)
        {
            Product product = GetById(id);
            _context.Remove(product);
        }

        public Product GetById(int id)
        {

            return _context.Products.Where(product => product.ProductID == id).Include(s => s.Supplier).SingleOrDefault();
        }
        
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
