using System;

namespace Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.Id = "11111111111";
            customer1.Name = "Ayse";
            customer1.Surname = "xxx";

            Customer customer2 = new Customer();

            customer2.Id = "222222222";
            customer2.Name = "Ali";
            customer2.Surname = "yyy";

            Customer customer3 = new Customer();

            customer3.Id = "333333333";
            customer3.Name = "Emre";
            customer3.Surname = "zzz";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();

            foreach (var i in customers)
            {
                customerManager.Add(i);
            }
            Console.WriteLine("-----------------------");

            foreach (var i in customers)
            {
                customerManager.List(i);
            }
            Console.WriteLine("-----------------------");
            customerManager.Delete(customer2);
        }
    }
}
