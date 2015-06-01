using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;

namespace UniteTestingTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddNumbers()
        {
            var calculator = new Calculator();

            var result = calculator.AddNumbers(0, 0);

            Assert.AreEqual(0, result);
        }
    }
}
