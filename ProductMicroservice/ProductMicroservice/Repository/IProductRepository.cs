using ProductMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMicroservice.Repository
{
    public interface IProductRepository
    {
        public void DeleteProduct(int productId);
        public Product GetProductByID(int productId);
        public IEnumerable<Product> GetProducts();
        public void InsertProduct(Product product);
        public void Save();
        public void UpdateProduct(Product product);
    }
}
