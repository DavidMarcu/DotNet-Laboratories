using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab2Ex1;

namespace Lab2Ex1Test
{
    [TestClass]
    public class ManagerTest
    {
        [TestMethod]
        public void GettersTest()
        {
           Employee manager = new Manager(2, "Samuel", "Sewall", DateTime.Parse("10/06/2018"),
                DateTime.Parse("10/08/2018"), 22.22);

            Assert.AreEqual(2, manager.Id);
            Assert.AreEqual("Samuel", manager.FirstName);
            Assert.AreEqual("Sewall", manager.LastName);

            DateTime expectedDate = DateTime.Parse("10/06/2018");
            Assert.AreEqual(expectedDate, manager.StartDate);

            expectedDate = DateTime.Parse("10/08/2018");
            Assert.AreEqual(expectedDate, manager.EndDate);
            
            Assert.AreEqual(22.22, manager.Salary);
        }

        [TestMethod]
        public void GetFullNameTest()
        {
            Employee manager = new Manager(2, "Samuel", "Sewall", DateTime.Parse("10/06/2018"),
                DateTime.Parse("10/08/2018"), 22.22);

            string fullName = manager.GetFullName();
            Assert.AreEqual("Samuel Sewall", fullName);
        }

        [TestMethod]
        public void IsActiveTest1()
        {
            Employee manager = new Manager(2, "Samuel", "Sewall", DateTime.Parse("10/06/2018"),
                DateTime.Parse("10/08/2018"), 22.22);
            Assert.IsFalse(manager.IsActive());
        }

        [TestMethod]
        public void IsActiveTest2()
        {
            Employee manager = new Manager(2, "Samuel", "Sewall", DateTime.Parse("10/06/2018"),
                DateTime.Today, 22.22);
            Assert.IsTrue(manager.IsActive());
        }

        [TestMethod]
        public void IsActiveTest3()
        {
            Employee manager = new Manager(2, "Samuel", "Sewall", DateTime.Parse("10/06/2018"),
                DateTime.Today.AddDays(1), 22.22);
            Assert.IsTrue(manager.IsActive());
        }

        [TestMethod]
        public void SalutationTest()
        {
            Employee manager = new Manager(2, "Samuel", "Sewall", DateTime.Parse("10/06/2018"),
                DateTime.Parse("10/08/2018"), 22.22);
            string result = manager.Salutation();
            Assert.AreEqual("Hello manager!", result);
        }
    }
}
