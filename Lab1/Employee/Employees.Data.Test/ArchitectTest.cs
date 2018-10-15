using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;

namespace Employees.Data.Test
{
    [TestClass]
    public class ArchitectTest
    {
        [TestMethod]
        public void GettersTest(){
            Employee architect = new Architect();
            architect.Id = 2;
            // architect.Id.Should().Be(2);
            Assert.AreEqual(2, architect.Id);
            architect.StartDate = DateTime.Parse("10/06/2018");
            // architect.StartDate.Should().HaveDay(6);
            // architect.StartDate.Should().HaveMonth(10);
            // architect.StartDate.Should().HaveYear(2018);
            Assert.AreEqual(6, architect.StartDate.Day);
            Assert.AreEqual(10, architect.StartDate.Month);
            Assert.AreEqual(2018, architect.StartDate.Year);

            architect.EndDate = DateTime.Parse("10/08/2018");
            // architect.EndDate.Should().HaveDay(8); 
            // architect.EndDate.Should().HaveMonth(10);
            // architect.EndDate.Should().HaveYear(2018);
            Assert.AreEqual(8, architect.EndDate.Day);
            Assert.AreEqual(10, architect.EndDate.Month);
            Assert.AreEqual(2018, architect.EndDate.Year);

            architect.Salary = 22.22;
            // architect.Salary.Should().Be(22.22);
            Assert.AreEqual(22.22, architect.Salary);
        }
        [TestMethod]
        public void GetFullNameTest()
        {
            Employee architect = new Architect();
            architect.FirstName = "Micheal";
            architect.LastName = "Baumann";
            string fullName = architect.GetFullName();
            // fullName.Should().Be("Micheal Baumann");
            Assert.AreEqual("Micheal Baumann", fullName);
        }

        [TestMethod]
        public void IsActiveTest1()
        {
            Employee architect = new Architect();
            architect.EndDate = DateTime.Parse("10/08/2018");
            // architect.IsActive().Should().BeTrue();
            Assert.IsTrue(architect.IsActive());
        }

        [TestMethod]
        public void IsActiveTest2()
        {
            Employee architect = new Architect();
            architect.EndDate = DateTime.Parse("10/06/2018");
            // architect.IsActive().Should().BeFalse();
            Assert.IsFalse(architect.IsActive());
        }

        [TestMethod]
        public void IsActiveTest3()
        {
            Employee architect = new Architect();
            architect.EndDate = DateTime.Parse("10/07/2018");
            // architect.IsActive().Should().BeTrue();
            Assert.IsTrue(architect.IsActive());
        }
    }
}
