using Microsoft.EntityFrameworkCore;
using Shop;
using System;
using System.ComponentModel.DataAnnotations;

namespace ShopApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee x = new Employee(
                "f111111111111111111111111111111111111111111111111111111111111111111",
                "l",
                DateTime.Now,
                null,
                15.25
            );
            EmployeeRepository r = new EmployeeRepository();
            try
            {
                r.Create(x);
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine("employee: {0}", e.InnerException.Message);
            }

            Customer c1 = new Customer(
                "name",
                "address",
                "1234",
                "l@example.com"
            );
            CustomerRepository cr = new CustomerRepository();
            try
            {
                cr.Create(c1);
            }
            catch (ValidationException e)
            {
                cr.Delete(c1);
                Console.WriteLine("c1: {0}", e.Message);
            }

            Customer c2 = new Customer(
                "name",
                "address",
                "0712345678",
                "l"
            );
            try
            {
                cr.Create(c2);
            }
            catch (ValidationException e)
            {
                Console.WriteLine("c2: {0}", e.Message);
            }
        }
    }
}

