using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concerete;
using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Entities;

namespace InterfaceAndAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisAdapterService());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "" });
            Console.ReadLine();
        }
    }
}