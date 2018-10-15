using System;

namespace Lab2Ex2
{
    public class Product
    {
        public int Id { get; private set;}
        public string Name { get; private set;}
        public string Description { get; private set;}
        public DateTime StartDate { get; private set;}
        public DateTime EndDate { get; private set;}
        public float Price { get; private set;}
        public float VAT { get; private set;}

        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public bool IsValid()
        {
            return this.StartDate < this.EndDate;
        }

        public float ComputeVat()
        {
            return this.Price * 0.1f;
        }
    }
}

