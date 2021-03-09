/*
Joseph LePage
3/8/21
C# and .net programming
Homework 4
 */

using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HW04
{
    class Server:Computer
    {
        public new string manufacturer;
        public new string model;
        public new string purposeCode;
        public new string cpuCode;
        public string CPUCount;

        public Server()
        {
            manufacturer = "";
            model = "";
            purposeCode = "";
            cpuCode = "";
            CPUCount = "";
        }


        public virtual void WriteToConsole()
        {
            WriteLine($"This Server computer has a {CPUCount} CPUCout.");
        }
    }
}
