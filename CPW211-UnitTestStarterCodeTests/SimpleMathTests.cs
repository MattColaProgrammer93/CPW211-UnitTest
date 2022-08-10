using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)] // 15
        [DataRow(0, 100)] // 100
        [DataRow(-1, -10)] // -11
        [DataRow(0, -0)] // 0
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Use the DataRow values to test the Add method
            double test = num1 + num2;
            double sum = SimpleMath.Add(num1, num2);

            Assert.AreEqual(sum, test);
        }

        [TestMethod]
        [DataRow(2, 4)] // 8
        [DataRow(1, 9)] // 9
        [DataRow(9, 4)] // 36 
        [DataRow(2, 100)] // 200
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            // Use a few pairs of values to test the Multiply method
            double test = num1 * num2;
            double sum = SimpleMath.Multiply(num1, num2);

            Assert.AreEqual(sum, test);
        }

        [TestMethod]
        [DataRow(50, 0)]
        [DataRow(0, 10)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            Assert.ThrowsException<ArgumentException> (() => SimpleMath.Divide(num1, num2));
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(6, 2)] // 3
        [DataRow(8, 4)] // 2
        [DataRow(10, 100)] // 0.1
        public void Divide_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            double test = num1 / num2;
            double sum = SimpleMath.Divide(num1, num2);

            Assert.AreEqual(sum, test);
        }
        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(10, 4)] // 6
        [DataRow(20, 1)] // 19
        [DataRow(40, 41)] // -1
        public void Subtract_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            double test = num1 - num2;
            double sum = SimpleMath.Subtract(num1, num2);

            Assert.AreEqual(sum, test);
        }
    }
}