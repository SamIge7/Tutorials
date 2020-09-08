using NUnit.Framework;
using System;
using System.Collections.Specialized;

namespace ConsoleCalculator.Tests.NUnitTests
{
    public class CalculatorShould
    {
        [Test]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();

            Assert.That(() => sut.Calculate(1, 1, "+"), Throws.TypeOf<CalculationOperationNotSupportedException>());
            Assert.That(() => sut.Calculate(1, 1, "+"), Throws.InstanceOf<CalculationException>());
        }
    }
}
