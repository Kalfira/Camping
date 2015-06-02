using System;
using System.Transactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxRulesTests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly string _fname = "Zane";
        private readonly string _lname = "Degner";
        private readonly int _age = 25;
        private readonly DateTime _date = DateTime.Parse("6/1/15");
        private readonly double _cost = 100;
        [TestMethod]
        public void TestFirstName()
        {
            var test = new TaxRules.Transaction("John", _lname, _age, _date, _cost);
            var result = test.Calculate();
            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void TestLastName()
        {
            var test = new TaxRules.Transaction(_fname, "Wilson", _age, _date, _cost);
            var result = test.Calculate();
            Assert.AreEqual(7, result);
        }
        [TestMethod]
        public void TestDate()
        {
            var test = new TaxRules.Transaction(_fname, _lname, _age, DateTime.Parse("6/4/15"), _cost);
            var result = test.Calculate();
            Assert.AreEqual(16, result);
        }
        [TestMethod]
        public void TestAge()
        {
            var test = new TaxRules.Transaction(_fname, _lname, 4, _date, _cost);
            var result = test.Calculate();
            Assert.AreEqual(0, result);
        }
    }
}
