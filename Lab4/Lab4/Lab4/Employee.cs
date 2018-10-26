using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Lab4
{
    public class Employee
    {
        [Key]
        public Guid Id { get; private set; }

        [Required]
        [StringLength(50, ErrorMessage = "FirstName can't be longer than 50 characters")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(70, ErrorMessage = "LastName can't be longer than 70 characters")]
        public string LastName { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }
        public double Salary { get; set; }

        private Employee() { }

        public Employee(Guid id, string firstName, string lastName, DateTime startDate, double salary, DateTime? endDate = null)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            StartDate = startDate;
            EndDate = endDate;
            Salary = salary;
        }

        public bool IsActive(DateTime d)
        {
            return EndDate == null || d <= EndDate;
        }
    }
}
