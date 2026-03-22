
using Blazor26.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor26.DataAccess.Repository
{
    public interface IProductRepo : IRepository<Product>
    {
        void Update(Product product);
        List<Product> GetAllInfo();
        Product GetProductCategory(int id);
        void AssignSuppliers(int productId, List<int> supplierIds);
        IEnumerable<Product> ListofProductsCategory();
    }
}
