using System;
using System.Collections.Generic;
using System.Linq;

namespace Product
{
    public class ProductRepositoryM : IProductRepository
    {
        private readonly IEnumerable<Product> products;

        public ProductRepositoryM(IEnumerable<Product> list)
        {
            products = list;
        }

        public IEnumerable<Product> RetrieveActiveProducts()
        {
            return products.Where(p => p.IsActive(DateTime.Now));
        }

        public IEnumerable<Product> RetrieveInactiveProducts()
        {
            return products.Where(p => !p.IsActive(DateTime.Now));
        }

        public IEnumerable<Product> RetrieveAllByDate(DateTime start, DateTime end)
        {
            return products.Where(p => p.StartDate >= start && p.EndDate <= end);
        }

        public IEnumerable<Product> RetrieveAllByName(string name)
        {
            return products.Where(p => p.Name.Contains(name));
        }

        public IEnumerable<Product> RetrieveAllOrderByPriceAscending()
        {
            return products.OrderBy(p => p.Price);
        }

        public IEnumerable<Product> RetrieveAllOrderByPriceDescending()
        {
            return products.OrderByDescending(p => p.Price);
        }

    }
}
