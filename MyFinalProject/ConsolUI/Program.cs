using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsolUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());//veri tabanindaki nesneler geldi

            foreach (var i in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(i.ProductName); ;
            }
        }
    }
}
