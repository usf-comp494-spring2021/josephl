/*
Joseph LePage
2/15/21
C# and .net programming
Homework 3
 */

using CalculatorLib;
using System;
using Xunit;

namespace CalculatorLibTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdding2and4()
        {
            //Arrange
            double a = 2;
            double b = 4;
            double expectedSum = 6;
            var calc = new Calculator();

            //Act
            double actualSum = calc.Add(a, b);

            //Assert
            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void TestMultiplying2and4()
        {
            //Arrange
            double a = 2;
            double b = 4;
            double expectedProduct = 8;
            var calc = new Calculator();

            //Act
            double actualProduct = calc.Multiply(a, b);

            //Assert
            Assert.Equal(expectedProduct, actualProduct);
        }

        [Fact]
        public void Test2from4()
        {
            //Arrange
            double a = 4;
            double b = 2;
            double expectedDifference = 2;
            var calc = new Calculator();

            //Act
            double actualDifference = calc.Subtract(a, b);

            //Assert
            Assert.Equal(expectedDifference, actualDifference);
        }

        [Fact]
        public void TestDividing8by4()
        {
            //Arrange
            double a = 8;
            double b = 4;
            double expectedQuotient = 2;
            var calc = new Calculator();

            //Act
            double actualQuotient = calc.Divide(a, b);

            //Assert
            Assert.Equal(expectedQuotient, actualQuotient);
        }
    }
}
