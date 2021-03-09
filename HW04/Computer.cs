/*
Joseph LePage
3/8/21
C# and .net programming
Homework 4
 */

using System;
using static System.Console;

namespace HW04
{
    public class Computer
    {
        public string manufacturer;
        public string model;
        public string purposeCode;
        public string cpuCode;

        public Computer()
        {
            manufacturer = "";
            model = "";
            purposeCode = "";
            cpuCode = "";
        }

        public virtual void WriteToConsole()
        {
            WriteLine($"{model} was made by: {manufacturer} purpose code: {purposeCode} cpu code: {cpuCode}.");
        }

    }
}
