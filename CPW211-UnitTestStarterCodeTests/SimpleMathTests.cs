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
        [DataRow(5, 10, 15)]
        [DataRow(0, 100, 100)]
        [DataRow(-1, -10, -11)]
        [DataRow(0, -0, 0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2, double correctAnswer)
        {
            // Use the DataRow values to test the Add method
            double testSum = SimpleMath.Add(num1, num2);
            Assert.AreEqual(testSum, correctAnswer);
        }

        [TestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(2, 5, 10)]
        [DataRow(5, 9, 45)]
        [DataRow(0, 1000, 0)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2, double correctAnswer)
        {
            // Use a few pairs of values to test the Multiply method
            double test = SimpleMath.Multiply(num1, num2);
            Assert.AreEqual(test, correctAnswer);
        }

        [TestMethod]
        [DataRow(1, 0)]
        [DataRow(10, 0)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(num1, num2));
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(16, 4, 4)]
        [DataRow(32, 8, 4)]
        [DataRow(100, 5, 20)]
        public void Divide_TwoNumbers_ReturnsQuotient(double num1, double num2, double correctAnswer)
        {
            double test = SimpleMath.Divide(num1, num2);
            Assert.AreEqual(test, correctAnswer);
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(1, 1, 0)]
        [DataRow(39, 6, 33)]
        [DataRow(50, 25, 25)]
        [DataRow(16, 7, 9)]
        public void Subtract_TwoNumbers_ReturnsDifference(double num1, double num2, double correctAnswer)
        {
            double test = SimpleMath.Subtract(num1, num2);
            Assert.AreEqual(test, correctAnswer);
        }
    }
}