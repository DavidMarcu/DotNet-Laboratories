using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab4
{
    public class Customer
    {
        public Guid Id { get; private set;}
        public String Name { get; set; }
        public String Address { get; set; }

        [RegularExpression("^\\+40([22,33]{1}[4,5]{1}[0-9]{6} | [7]{1}[2-7]{1}[0-9]{7})$")]
        public String PhoneNumber { get; set; }

        [RegularExpression("^[A-Za-z0-9_]+@[a-z]+\\..+$")]
        public String Email { get; set; }

        private Customer() { }

        public Customer(Guid id, string name, string address, string phoneNumber, string email)
        {
            Id = id;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }

    }
}
