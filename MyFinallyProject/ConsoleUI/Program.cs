﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductManager productManager = ProductTest();
            
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static ProductManager ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("----------------------");
            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("----------------------");
            foreach (var product in productManager.GetByUnitPrice(80, 100))
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("----------------------");
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/"+product.CategoryName);
            }

            return productManager;
        }
    }
}