using System;
using Xunit;

namespace ConsoleCalculator.Tests.XUnitTests
{
    public class CalculatorShould
    {
        [Fact]
        public void ThrowsWhenUnsupportedOperation()
        {
            var sut = new Calculator();

            Assert.Throws<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "+"));
            Assert.ThrowsAny<CalculationException>(() => sut.Calculate(1, 1, "+"));
        }
    }
}
