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
        public void TestMeanAndMedianFunctions()
        {
            //Arrange
            string[] initialArray = System.IO.File.ReadAllLines("C: /Users/joesc/OneDrive/Desktop/C#/gitRepo/HW03/CalculatorLibTest/CalcInput.txt");
            double[] numberArray = new double[15];
            for (int i = 0; i < initialArray.Length; i++)
            {
                numberArray[i] = Convert.ToDouble(initialArray[i]);
            }
            var calc = new Calculator();
 
            //Act
            double expectedMeanResult = 8.0;
            double actualMeanResult = calc.findMean(numberArray);

            //Assert
            Assert.Equal(expectedMeanResult, actualMeanResult);

            //Act
            double expectedMedianResult = 8.0;
            double actualMedianResult = calc.findMedian(numberArray);

            //Assert
            Assert.Equal(expectedMedianResult, actualMedianResult);

            System.Console.WriteLine($"{actualMeanResult}, {actualMedianResult}");

        }
    }
}
