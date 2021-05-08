using ReCapProject.Entities;
using ReCapProject.Business;
using ReCapProject.DataAccess;

using System;
using ReCapProject.Business.Concrete;
using ReCapProject.DataAccess.Concrete;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var i in carManager.GetAll())
            {
                Console.WriteLine(i.Id);
                Console.WriteLine(i.ColorId);
                Console.WriteLine(i.BrandId);
                Console.WriteLine(i.DailyPrice);
                Console.WriteLine(i.Description);
            }
            
        }
    }
}
