using System;

namespace Lab2Ex1
{
    public abstract class Employee
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public double Salary { get; private set; }

        public Employee(int id, string firstName, string lastName, DateTime startDate,
            DateTime endDate, double salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            StartDate = startDate;
            EndDate = endDate;
            Salary = salary;
        }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public bool IsActive()
        {
            return this.EndDate >= DateTime.Today;
        }

        public abstract string Salutation();
    }
}
