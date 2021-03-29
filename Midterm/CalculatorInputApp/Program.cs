/*
Joseph LePage
3/19/21
C# and .net programming
Midterm
*/

using CalculatorLib;
using System.Threading.Tasks;
using System;
using System.IO;

namespace CalculatorInputApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //opens file and reads numbers into an array
            string filePath = @"C:\Users\joesc\OneDrive\Desktop\C#\gitRepo\Midterm\CalcInput.txt";
            string[] initialArray = File.ReadAllLines(filePath);
            double[] numberArray = new double[initialArray.Length];

            //converts elements of array into double values
            for(int i = 0; i < initialArray.Length; i++)
            {
                numberArray[i] = Convert.ToDouble(initialArray[i]);
            }

            //uses mean and median functions from library
            var calc = new Calculator();
            double mean = calc.findMean(numberArray);
            double median;

            if (numberArray.Length % 2 == 1)
            {
                median = calc.findMedianOddNumOfEntries(numberArray);
            }
            else
            {
                median = calc.findMedianEvenNumOfEntries(numberArray);
            }

            //writes results to a file
            string medianResult = median.ToString("##.#", System.Globalization.CultureInfo.InvariantCulture);
            string meanResult = mean.ToString("##.#", System.Globalization.CultureInfo.InvariantCulture);
            using (StreamWriter writer = new StreamWriter(@"C:\Users\joesc\OneDrive\Desktop\C#\gitRepo\Midterm\CalcOutput.txt"))
            {
                writer.WriteLine($"The mean of the numbers from the input file is:   {meanResult}");
                writer.WriteLine($"The median of the numbers from the input file is: {medianResult}");
            }
        }
    }
}
