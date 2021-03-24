/*
Joseph LePage
3/19/21
C# and .net programming
Midterm
 */

using System;

namespace CalculatorLib
{
    public class Calculator
    {
        /*<summary>
         *This method will return the sum of A and B
         *</summary>
         *<param name = "a"> Value A</param>
         *<param name = "b"> Value B</param>
         *<returns>The sum
         **/
        public double Add(double a, double b)
        {
            return a + b;
        }

        /*<summary>
        *This method will return the product of A and B
        *</summary>
        *<param name = "a"> Value A</param>
        *<param name = "b"> Value B</param>
        *<returns>The product
        **/
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        /*<summary>
        *This method will return the difference of A and B
        *</summary>
        *<param name = "a"> Value A</param>
        *<param name = "b"> Value B</param>
        *<returns>The difference
        **/
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        /*<summary>
        *This method will return the quotient of A and B
        *</summary>
        *<param name = "a"> Value A</param>
        *<param name = "b"> Value B</param>
        *<returns>The quotient
        **/
        public double Divide(double a, double b)
        {
            return a / b;
        }

        /*<summary>
        *This method will find the mean of a set of numbers
        *</summary>
        *<param name = "numberArray"> Array of numbers </param>
        *<returns>The Mean of the set of numbers passed to the function
        **/
        public double findMean(double[] numberArray)
        {
            double total = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                total = numberArray[i] + total;
            }
            return total / numberArray.Length;
        }

        /*<summary>
        *This method will find the median of a set of numbers
        *</summary>
        *<param name = "numberArray"> Array of numbers </param>
        *<returns>The Median of the set of numbers passed to the function
        **/
        public double findMedian(double[] numberArray)
        {
            Array.Sort(numberArray);
            int Median;
            if (numberArray.Length % 2 == 1)
            {
                Median = numberArray.Length - ((numberArray.Length - 1) / 2);
            }
            else
            {
                Median = numberArray.Length - (numberArray.Length / 2);
            }
            return numberArray[Median];
        }
    }
}
