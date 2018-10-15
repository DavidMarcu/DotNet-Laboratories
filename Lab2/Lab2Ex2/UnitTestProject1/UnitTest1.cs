using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Lab2Ex2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetProductByNameTest1()
        {
            ProductRepository prods = new ProductRepository();
            Product prodResult = prods.GetProductByName("prod1");
            Assert.AreSame(prods.Prods[0], prodResult);
        }

        [TestMethod]
        public void GetProductByNameTest2()
        {
            ProductRepository prods = new ProductRepository();
            Product prodResult = prods.GetProductByName(null);
            Assert.IsNull(prodResult);
        }

        [TestMethod]
        public void GetProductByNameTest3()
        {
            ProductRepository prods = new ProductRepository();
            Product prodResult = prods.GetProductByName("sfasfsafas");
            Assert.IsNull(prodResult);
        }

        [TestMethod]
        public void FindAllProductsTest()
        {
            ProductRepository prodsrep = new ProductRepository();
            List<Product> prodResult = prodsrep.FindAllProducts();
            Assert.AreEqual(prodsrep.Prods, prodResult);
        }

        [TestMethod]
        public void AddProductTest1()
        {
            Product prod1 = new Product("prod1", 2.22f);
            ProductRepository prodsrep = new ProductRepository();
            prodsrep.AddProduct(prod1);
            Assert.IsTrue(prodsrep.Prods.Contains(prod1));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddProductTest2()
        {
            ProductRepository prodsrep = new ProductRepository();
            prodsrep.AddProduct(null);
        }

        [TestMethod]
        public void GetProductByPositionTest1()
        {
            ProductRepository prodsrep = new ProductRepository();
            Product prod = prodsrep.GetProductByPosition(1);
            Assert.AreSame(prodsrep.Prods[1], prod);
        }

        [TestMethod]
        public void GetProductByPositionTest2()
        {
            ProductRepository prodsrep = new ProductRepository();
            Product prod = prodsrep.GetProductByPosition(9999);
            Assert.IsNull(prod);
        }

        [TestMethod]
        public void GetProductByPositionTest3()
        {
            ProductRepository prodsrep = new ProductRepository();
            Product prod = prodsrep.GetProductByPosition(-1);
            Assert.IsNull(prod);
        }

        [TestMethod]
        public void RemoveProductByNameTest1()
        {
            ProductRepository prodsrep = new ProductRepository();
            Product product = prodsrep.GetProductByName("prod1");
            prodsrep.RemoveProductByName("prod1");
            Assert.IsFalse(prodsrep.Prods.Contains(product));
        }

        [TestMethod]
        public void RemoveProductByNameTest2()
        {
            ProductRepository prodsrep = new ProductRepository();
            int prodsrepCount = prodsrep.Prods.Count;
            prodsrep.RemoveProductByName("sfasgasgasg");
            Assert.AreEqual(prodsrepCount, prodsrep.Prods.Count);
        }
    }
}
