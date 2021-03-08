using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsolUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach (var i in productManager.GetAll())
            {
                Console.WriteLine(i.ProductName); ;
            }
        }
    }
}
