using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
       public class CustomerRepository : IRepository<Customer>
        {
            private readonly ApplicationContext _context;

            public CustomerRepository()
            {
                _context = new ApplicationContext();
            }
            public void Create(Customer customer)
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
            }

            public void Delete(Customer customer)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }

            public List<Customer> GetAll()
            {
                IQueryable<Customer> queriesCustomers = _context.Customers;
                return queriesCustomers.ToList();
            }

            public List<Customer> GetCustomerByEmail(String email)
            {
                IQueryable<Customer> queriesCustomers = _context.Customers.Where(customer => customer.Email.Equals(email));
                return queriesCustomers.ToList();
            }

            public Customer GetById(Guid id)
            {
                return _context.Customers.First(employee => employee.Id == id);
            }

            public void Update(Customer customer)
            {
                var existingCustomer = _context.Customers.First(t => t.Id == customer.Id);
                existingCustomer.Name = customer.Name;
                existingCustomer.Address = customer.Address;
                existingCustomer.Email = customer.Email;
                existingCustomer.PhoneNumber = customer.PhoneNumber;
                _context.SaveChanges();
            }
        }
    }
