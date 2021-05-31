using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SatisSistemiDemo
{
    class ProductRepositoryBase : IProductRepositoryBase<Product>
    
    {
        public void Add(List<Product> products, Product product)
        {
           products.Add(product);
        }

        public void Update(List<Product> products, Product product)
        {
            Product findedProduct = products.FirstOrDefault(p => p.ProductCode == product.ProductCode);

            if (findedProduct != null)
            {
                findedProduct.ProductName = product.ProductName;
                findedProduct.Quantity = product.Quantity;
                findedProduct.UnitPrice = product.UnitPrice;
            }
            
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Product product)
        {
            throw new NotImplementedException();
        }


    }
}
