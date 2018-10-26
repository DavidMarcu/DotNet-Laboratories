using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Lab4
{
    public class EmployeeRepository : IRepository<Employee>
    {
        private readonly ApplicationContext _context;

        public EmployeeRepository()
        {
            _context = new ApplicationContext();
        }
        public void Create(Employee entity)
        {
            _context.Employees.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Employee entity)
        {
            _context.Employees.Remove(entity);
            _context.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            IQueryable<Employee> queriesEmployees = _context.Employees;
            return queriesEmployees.ToList();
        }

        public Employee GetById(Guid id)
        {
            return _context.Employees.First(employee => employee.Id == id);
        }

        public List<Employee> GetBySalary(double salary)
        {
            IQueryable<Employee> queriesEmployees = _context.Employees.Where(employee => employee.Salary == salary);
            return queriesEmployees.ToList();
        }

        public void Update(Employee entity)
        {
            var existingEmployee = _context.Employees.First(t => t.Id == entity.Id);
            existingEmployee.FirstName = entity.FirstName;
            existingEmployee.LastName = entity.LastName;
            existingEmployee.StartDate = entity.StartDate;
            existingEmployee.EndDate = entity.EndDate;
            existingEmployee.Salary = entity.Salary;
            _context.SaveChanges();
        }
    }
}
