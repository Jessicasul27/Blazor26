
using Blazor26.DataAccess.DataAccess;
using Blazor26.Models.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor26.DataAccess.Repository
{
    public class ProductRepo: Repository<Product>, IProductRepo
    {
        private readonly AppDBContext _dbContext;
        public ProductRepo(AppDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Product> GetAllInfo()
        {
            var products = _dbContext.Products
                .Include(p => p.Category)
                .ToList();

            return products;
        }
                

        public void Update(Product product)
        {
            var prodFromDb = _dbContext.Products.FirstOrDefault(p => p.ID == product.ID);
            prodFromDb.Name = product.Name;
            prodFromDb.CategoryID = product.CategoryID;
            prodFromDb.Price = product.Price;

            if (product.Image != null)
            {
                prodFromDb.Image = product.Image;
            }
        }

        

        void IProductRepo.AssignSuppliers(int productId, List<int> supplierIds)
        {
            
           
        }

        public Product GetProductCategory(int id)
        {
            var product = _dbContext.Products.Include(c => c.Category).FirstOrDefault(p => p.ID == id);
            return product;
        }

        public IEnumerable<Product> ListofProductsCategory()
        {
                var listproduct = _dbContext.Products.Include(c => c.Category);
                return listproduct;
          
        }
    }
}
