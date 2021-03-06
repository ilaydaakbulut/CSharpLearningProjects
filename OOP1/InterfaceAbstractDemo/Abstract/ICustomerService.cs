using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
