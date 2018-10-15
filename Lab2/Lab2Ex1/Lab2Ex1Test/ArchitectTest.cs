using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab2Ex1;

namespace Lab2Ex1Test
{
    [TestClass]
    public class ArchitectTest
    {
        [TestMethod]
        public void GettersTest()
        {
            Employee architect = new Architect(2, "Samuel", "Sewall", DateTime.Parse("10/06/2018"),
                 DateTime.Parse("10/08/2018"), 22.22);

            Assert.AreEqual(2, architect.Id);
            Assert.AreEqual("Samuel", architect.FirstName);
            Assert.AreEqual("Sewall", architect.LastName);

            DateTime expectedDate = DateTime.Parse("10/06/2018");
            Assert.AreEqual(expectedDate, architect.StartDate);

            expectedDate = DateTime.Parse("10/08/2018");
            Assert.AreEqual(expectedDate, architect.EndDate);

            Assert.AreEqual(22.22, architect.Salary);
        }

        [TestMethod]
        public void GetFullNameTest()
        {
            Employee architect = new Architect(2, "Samuel", "Sewall", DateTime.Parse("10/06/2018"),
                DateTime.Parse("10/08/2018"), 22.22);

            string fullName = architect.GetFullName();
            Assert.AreEqual("Samuel Sewall", fullName);
        }

        [TestMethod]
        public void IsActiveTest1()
        {
            Employee architect = new Architect(2, "Samuel", "Sewall", DateTime.Parse("10/06/2018"),
                DateTime.Parse("10/08/2018"), 22.22);
            Assert.IsFalse(architect.IsActive());
        }

        [TestMethod]
        public void IsActiveTest2()
        {
            Employee architect = new Architect(2, "Samuel", "Sewall", DateTime.Parse("10/06/2018"),
                DateTime.Today, 22.22);
            Assert.IsTrue(architect.IsActive());
        }

        [TestMethod]
        public void IsActiveTest3()
        {
            Employee architect = new Architect(2, "Samuel", "Sewall", DateTime.Parse("10/06/2018"),
                DateTime.Today.AddDays(1), 22.22);
            Assert.IsTrue(architect.IsActive());
        }

        [TestMethod]
        public void SalutationTest()
        {
            Employee architect = new Architect(2, "Samuel", "Sewall", DateTime.Parse("10/06/2018"),
                DateTime.Parse("10/08/2018"), 22.22);
            string result = architect.Salutation();
            Assert.AreEqual("Hello architect!", result);
        }
    }
}
