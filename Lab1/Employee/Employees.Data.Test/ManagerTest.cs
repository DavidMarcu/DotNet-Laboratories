using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;

namespace Employees.Data.Test
{
    [TestClass]
    public class ManagerTest
    {
        [TestMethod]
        public void GettersTest(){
            Employee manager = new Manager();
            manager.Id = 2;
            // manager.Id.Should().Be(2);
            Assert.AreEqual(2, manager.Id);
            manager.StartDate = DateTime.Parse("10/06/2018");
            // manager.StartDate.Should().HaveDay(6);
            // manager.StartDate.Should().HaveMonth(10);
            // manager.StartDate.Should().HaveYear(2018);
            Assert.AreEqual(6, manager.StartDate.Day);
            Assert.AreEqual(10, manager.StartDate.Month);
            Assert.AreEqual(2018, manager.StartDate.Year);

            manager.EndDate = DateTime.Parse("10/08/2018");
            // manager.EndDate.Should().HaveDay(8); 
            // manager.EndDate.Should().HaveMonth(10);
            // manager.EndDate.Should().HaveYear(2018);
            Assert.AreEqual(8, manager.EndDate.Day);
            Assert.AreEqual(10, manager.EndDate.Month);
            Assert.AreEqual(2018, manager.EndDate.Year);

            manager.Salary = 22.22;
            // manager.Salary.Should().Be(22.22);
            Assert.AreEqual(22.22, manager.Salary);
        }
        [TestMethod]
        public void GetFullNameTest()
        {
            Employee manager = new Manager();
            manager.FirstName = "Micheal";
            manager.LastName = "Baumann";
            string fullName = manager.GetFullName();
            fullName.Should().Be("Micheal Baumann");
            //Assert.AreEqual("Micheal Baumann", fullName);
        }

        [TestMethod]
        public void IsActiveTest1()
        {
            Employee manager = new Manager();
            manager.EndDate = DateTime.Parse("10/08/2018");
            //manager.IsActive().Should().BeTrue();
            Assert.IsFalse(manager.IsActive());
        }

        [TestMethod]
        public void IsActiveTest2()
        {
            Employee manager = new Manager();
            manager.EndDate = DateTime.Parse("10/06/2018");
            //manager.IsActive().Should().BeFalse();
            Assert.IsFalse(manager.IsActive());
        }

        [TestMethod]
        public void IsActiveTest3()
        {
            Employee manager = new Manager();
            manager.EndDate = DateTime.Parse("10/07/2018");
            manager.IsActive().Should().BeTrue();
            //Assert.IsTrue(manager.IsActive());
        }
    }
}
