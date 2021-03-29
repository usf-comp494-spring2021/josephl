/*
Joseph LePage
3/19/21
C# and .net programming
Midterm
*/

using CalculatorLib;
using System;
using Xunit;
using System.IO;

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

        [Fact]
        public void TestMeanFunction()
        {
            //Arrange

            double[] numberArray = {1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0,
            11.0, 12.0, 13.0, 14.0, 15.0};
            var calc = new Calculator();

            //Act
            double expectedMean = 8.0;
            double actualMean = calc.findMean(numberArray);

            //Assert
            Assert.Equal(expectedMean, actualMean);
        }

        [Fact]
        public void TestMedianOddEntriesFunction()
        {
            //Arrange
            double[] numberArray = {1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0,
            11.0, 12.0, 13.0, 14.0, 15.0};
            var calc = new Calculator();


            //Act
            double expectedMedian = 8.0;
            double actualMedian = calc.findMedianOddNumOfEntries(numberArray);

            //Assert
            Assert.Equal(expectedMedian, actualMedian);
        }

        [Fact]
        public void TestMedianEvenEntriesFunction()
        {
            //Arrange
            double[] numberArray = {1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0,
            11.0, 12.0, 13.0, 14.0};
            var calc = new Calculator();

            //Act
            double expectedMedian = 7.0;
            double actualMedian = calc.findMedianEvenNumOfEntries(numberArray);

            //Assert
            Assert.Equal(expectedMedian, actualMedian);
        }
    }
}
