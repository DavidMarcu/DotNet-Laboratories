using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Product.Tests
{
    [TestClass]
    public class ProductTests
    {
        private readonly List<Product> _products;

        public ProductTests()
        {
            _products = new List<Product> {
                new Product(11, "prod 11", "description 11", new DateTime(2012, 1, 1), new DateTime(2013, 1, 1), 10.15),
                new Product(12, "prod 12", "description 12", new DateTime(2013, 1, 1), new DateTime(2014, 1, 1), 11.25),
                new Product(13, "prod 13", "description 13", new DateTime(2014, 1, 1), new DateTime(2015, 1, 1), 12.35),
                new Product(14, "prod 14", "description 14", new DateTime(2015, 1, 1), new DateTime(2016, 1, 1), 13.45),
                new Product(15, "prod 15", "description 15", new DateTime(2016, 1, 1), new DateTime(2017, 1, 1), 14.55),
                new Product(16, "prod 16", "description 16", new DateTime(2017, 1, 1), new DateTime(2018, 1, 1), 15.65),
                new Product(17, "prod 17", "description 17", new DateTime(2018, 1, 1), new DateTime(2019, 1, 1), 16.75),
                new Product(18, "prod 18", "description 18", new DateTime(2019, 1, 1), new DateTime(2020, 1, 1), 17.85),
                new Product(19, "prod 19", "description 19", new DateTime(2020, 1, 1), new DateTime(2021, 1, 1), 18.95),
                new Product(20, "prod 20", "description 20", new DateTime(2021, 1, 1), new DateTime(2022, 1, 1), 19.35),
            };
        }

        [TestMethod]
        public void TestMethod1()
        {
            var x = new ProductRepositoryM(_products);
            var y = x.RetrieveActiveProducts();
            Assert.IsTrue(y.First().IsActive(DateTime.Now));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var x = new ProductRepositoryM(_products);
            var y = x.RetrieveInactiveProducts();
            Assert.IsTrue(!y.First().IsActive(DateTime.Now));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var x = new ProductRepositoryM(_products);
            var y = x.RetrieveAllByName("prod 11");
            Assert.AreEqual("prod 11", y.First().Name);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var x = new ProductRepositoryM(_products);
            var y = x.RetrieveAllByDate(new DateTime(2013, 1, 1), new DateTime(2014, 1, 1));
            Assert.AreEqual(new DateTime(2013, 1, 1), y.First().StartDate);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var x = new ProductRepositoryM(_products);
            var y = x.RetrieveAllOrderByPriceAscending();
            Assert.AreEqual(10.15, y.First().Price);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var x = new ProductRepositoryM(_products);
            var y = x.RetrieveAllOrderByPriceDescending();
            Assert.AreEqual(19.35, y.First().Price);
        }

    }
}
