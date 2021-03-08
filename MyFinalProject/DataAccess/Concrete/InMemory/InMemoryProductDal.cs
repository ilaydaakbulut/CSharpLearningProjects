using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //global degisken
        public InMemoryProductDal()
        {
            //basit veri tabanı olusturma
            _products = new List<Product> { 
                   new Product{ProductId=1, CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                   new Product{ProductId=1, CategoryId=2,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                   new Product{ProductId=1, CategoryId=3,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                   new Product{ProductId=1, CategoryId=4,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                   new Product{ProductId=1, CategoryId=5,ProductName="Fare",UnitPrice=85,UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete=null;
            /*
            foreach (var i in _products)
            {
                if (product.ProductId == i.ProductId)
                {
                    productToDelete = product;
                }
            }
            */
            productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }
        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate;
            productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
