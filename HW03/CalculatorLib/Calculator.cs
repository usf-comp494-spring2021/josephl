/*
Joseph LePage
2/15/21
C# and .net programming
Homework 3
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
    }
}
