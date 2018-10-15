using System;

namespace Employees.Data
{
    public abstract class Employee
    {
        public int Id{get; set;}
        public String FirstName{get; set;}
        public String LastName{get; set;}
        public DateTime StartDate{get; set;}
        public DateTime EndDate{get; set;}
        public double Salary{get; set;}

        public String GetFullName(){
            return this.FirstName + " " + this.LastName;
        }

        public bool IsActive(){
            return this.EndDate >= DateTime.Today;
        }
    }
}
