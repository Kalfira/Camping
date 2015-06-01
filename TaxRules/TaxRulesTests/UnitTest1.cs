using System;
using System.Transactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxRulesTests
{
    [TestClass]
    public class UnitTest1
    {
        private string fname = "Zane";
        private string lname = "Degner";
        private int age = 25;
        private DateTime date = DateTime.Parse("6/1/15");
        private double cost = 100;
        [TestMethod]
        public void TestFirstName()
        {
            var test = new TaxRules.Transaction("John", lname, age, date, cost);
            var result = test.Calculate();
            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void TestLastName()
        {
            var test = new TaxRules.Transaction(fname, "Wilson", age, date, cost);
            var result = test.Calculate();
            Assert.AreEqual(7, result);
        }
        [TestMethod]
        public void TestDate()
        {
            var test = new TaxRules.Transaction(fname, lname, age, DateTime.Parse("6/4/15"), cost);
            var result = test.Calculate();
            Assert.AreEqual(16, result);
        }
        [TestMethod]
        public void TestAge()
        {
            var test = new TaxRules.Transaction(fname, lname, 4, date, cost);
            var result = test.Calculate();
            Assert.AreEqual(0, result);
        }
    }
}
