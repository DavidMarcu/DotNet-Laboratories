using System;
using System.Collections.Generic;
using Lab4;

namespace Lab4App
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(Guid.NewGuid(), "Dave", "Mortimer", DateTime.Parse("10/24/2018"), 2.33);
            Employee emp2 = new Employee(Guid.NewGuid(), "Nemo", "Mortimer", DateTime.Parse("10/25/2018"), 2.33);
            Employee emp3 = new Employee(Guid.NewGuid(), "Mimo", "Mortimer", DateTime.Parse("10/25/2018"), 2.33);
            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.Create(emp);
            employeeRepository.Create(emp2);
            employeeRepository.Create(emp3);
            emp2.Salary = 3.01;
            employeeRepository.Update(emp2);
            employeeRepository.Delete(emp3);
            List<Employee> emps = employeeRepository.GetAll();
            Console.WriteLine(emps[1].Salary);
            Console.WriteLine(emps.Count);
        }
    }
}
