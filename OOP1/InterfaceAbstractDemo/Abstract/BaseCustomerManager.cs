using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Concrete;


namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("saved to db : "+ customer.FirstName);
        }
    }
}
