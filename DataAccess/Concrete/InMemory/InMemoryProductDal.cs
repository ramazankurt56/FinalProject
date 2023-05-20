using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>() 
            {
                new Product() {ProductId=1,CategoryId=1,ProductName="Bardak",UnitsInStock=20,UnitPrice=30},
                new Product() {ProductId=2,CategoryId=1,ProductName="Çatal",UnitsInStock=180,UnitPrice=60},
                new Product() {ProductId=3,CategoryId=2,ProductName="Laptop",UnitsInStock=60,UnitPrice=4660},
                new Product() {ProductId=4,CategoryId=2,ProductName="Mouse",UnitsInStock=540,UnitPrice=380},
                new Product() {ProductId=5,CategoryId=2,ProductName="Klavye",UnitsInStock=370,UnitPrice=190},

            };
            
        }
        public void Add(Product product)
        {
           _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDeleted = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            _products.Remove(productToDeleted);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _products;
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate=_products.SingleOrDefault(p=> p.ProductId==product.ProductId);
            productToUpdate.ProductId=product.ProductId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId=product.CategoryId;
            productToUpdate.UnitsInStock=product.UnitsInStock;
            productToUpdate.UnitPrice=product.UnitPrice;
        }
    }
}
