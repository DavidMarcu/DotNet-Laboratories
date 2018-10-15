using System;
using System.Collections.Generic;
    
namespace Lab2Ex2
{
    public class ProductRepository
    {
        private List<Product> prods = new List<Product>();
        public List<Product> Prods
        {
            get => prods;
            private set { prods = value; }
        }
        
        public ProductRepository()
        {
            Product prod1 = new Product("prod1", 2.22f);
            Product prod2 = new Product("prod2", 5f);
            Product prod3 = new Product("prod3", 5.5f);
            prods.Add(prod1);
            prods.Add(prod2);
            prods.Add(prod3);
        }

        public Product GetProductByName(string name)
        {
            for(int i = 0; i < prods.Count; i++)
            {
                if(prods[i].Name == name)
                {
                    return prods[i];
                }
            }
            return null;
        }

        public List<Product> FindAllProducts()
        {
            return prods;
        }

        public void AddProduct(Product prod)
        {
            if (prod == null)
                throw new NullReferenceException();
            prods.Add(prod);
        }

        public Product GetProductByPosition(int pos)
        {
            if(pos >= prods.Count || pos < 0)
            {
                return null;
            }
            return prods[pos];
        }

        public void RemoveProductByName(string name)
        {
            for(int i = 0; i < prods.Count; i++)
            {
                if(prods[i].Name == name)
                {
                    prods.Remove(prods[i]);
                }
            }
        }
    }
}
