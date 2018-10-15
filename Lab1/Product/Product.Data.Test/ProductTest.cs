using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;

namespace Product.Data.Test
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void gettersTest(){
            Product prod = new Product();
            prod.Id = 1;
            //prod.Id.Should().Be(1);
            Assert.AreEqual(1, prod.Id);
            prod.Name = "jonas";
            // prod.Name.Should().Be("jonas");
            Assert.AreEqual("jonas", prod.Name);
            prod.Description = "good";
            // prod.Description.Should().Be("good");
            Assert.AreEqual("good", prod.Description);
            
            prod.Price = 10f;
            // prod.Price.Should().Be(10f);
            Assert.AreEqual(10f, prod.Price);

            prod.VAT = 0.2f;
            // prod.VAT.Should().Be(0.2f);
            Assert.AreEqual(0.2f, prod.VAT);

            prod.StartDate = DateTime.Parse("08/18/2018");
            // prod.StartDate.Should().HaveDay(18);
            // prod.StartDate.Should().HaveMonth(8);
            // prod.StartDate.Should().HaveYear(2018);
            Assert.AreEqual(18, prod.StartDate.Day);
            Assert.AreEqual(8, prod.StartDate.Month);
            Assert.AreEqual(2018, prod.StartDate.Year);

            prod.EndDate = DateTime.Parse("08/19/2018");
            // prod.EndDate.Should().HaveDay(19);
            // prod.EndDate.Should().HaveMonth(8);
            // prod.EndDate.Should().HaveYear(2018);
            Assert.AreEqual(19, prod.EndDate.Day);
            Assert.AreEqual(8, prod.EndDate.Month);
            Assert.AreEqual(2018, prod.EndDate.Year);

        }
        [TestMethod]
        public void isValidTest1()
        {
            Product prod = new Product();
            prod.StartDate = DateTime.Parse("08/18/2018");
            prod.EndDate = DateTime.Parse("08/19/2018");
            bool validDate = prod.IsValid();
           // validDate.Should().BeTrue("End date greater than Start date");
            Assert.IsTrue(validDate);
        }

        [TestMethod]
        public void isValidTest2()
        {
            Product prod = new Product();
            prod.StartDate = DateTime.Parse("08/18/2018");
            prod.EndDate = DateTime.Parse("08/18/2018");
            bool validDate = prod.IsValid();
            //validDate.Should().BeFalse("End date is equal to start date");
            Assert.IsFalse(validDate);
        }

        [TestMethod]
        public void isValidTest3()
        {
            Product prod = new Product();
            prod.StartDate = DateTime.Parse("08/18/2018");
            prod.EndDate = DateTime.Parse("08/17/2018");
            bool validDate = prod.IsValid();
           // validDate.Should().BeFalse("End date is smaller than start date");
            Assert.IsFalse(validDate);
        }

        [TestMethod]
        public void ComputeVatTest()
        {
            Product prod = new Product();
            prod.Price = 10f;
            float VAT_value = prod.ComputeVat();
            //VAT_value.Should().Be(prod.Price * 0.1f);
            Assert.AreEqual(prod.Price * 0.1f, VAT_value);
        }
    }
}
