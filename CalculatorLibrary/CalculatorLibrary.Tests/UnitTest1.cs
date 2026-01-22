using NUnit.Framework;
using CalculatorLibrary;
using System;

namespace CalculatorLibrary.Tests
{
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            Assert.That(calculator.Add(5, 3), Is.EqualTo(8));
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnsCorrectDifference()
        {
            Assert.That(calculator.Subtract(5, 3), Is.EqualTo(2));
        }

        [Test]
        public void Multiply_TwoNumbers_ReturnsCorrectProduct()
        {
            Assert.That(calculator.Multiply(5, 3), Is.EqualTo(15));
        }

        [Test]
        public void Divide_TwoNumbers_ReturnsCorrectQuotient()
        {
            Assert.That(calculator.Divide(6, 3), Is.EqualTo(2));
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.That(() => calculator.Divide(5, 0),
                Throws.TypeOf<DivideByZeroException>());
        }
    }
}
