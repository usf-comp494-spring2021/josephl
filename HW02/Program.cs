using System;

namespace HW02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < 10; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    string eNum = numbers[i].ToString();
                    System.Console.WriteLine($"{eNum} is even");
                }
                else
                {
                    string oNum = numbers[i].ToString();
                    System.Console.WriteLine($"{oNum} is odd");
                }//end if/else statement
            }//end for loop
        }
    }
}
