using System;

namespace Product
{
    public class Product
    {
        public int Id { get; private set; }
        private string _name;
        public string Name
        {
            get => _name;
            private set {
                if (value.Length > 50)
                {
                    throw new InvalidOperationException("name must be less than 50 characters");
                }
                _name = value;
            }
        }
        private string _description;
        public string Description
        {
            get => _description;
            private set
            {
                if (value.Length > 200)
                {
                    throw new InvalidOperationException("name must be less than 200 characters");
                }
                _description = value;
            }
        }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public double Price { get; private set; }

        public Product(int id, string name, string description, DateTime startDate, DateTime endDate, double price)
        {
            Id = id;
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Price = price;
        }

        public bool IsActive(DateTime d)
        {
            return (StartDate <= d) && (d < EndDate);
        }
    }
}
