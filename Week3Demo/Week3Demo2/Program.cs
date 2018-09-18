using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week3Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello Demo2");
            ReadKey();

            WriteLine("Please enter 3 number");
            string readValue = ReadLine();

            string[] numArr = readValue.Split();
            double smallestNum = FindSmallest(numArr[0], numArr[1], numArr[2]);
            WriteLine("The smallest value is " + smallestNum);
            ReadKey();
        }

        public static double FindSmallest(string var1, string var2, string var3)
        {
            double num1 = double.Parse(var1);
            double num2 = double.Parse(var2);
            double num3 = double.Parse(var3);

            double smallestNum = num1;
            if(smallestNum > num2)
            {
                smallestNum = num2;
            }

            if(smallestNum > num3)
            {
                smallestNum = num3;
            }

            return smallestNum;
        }
    }
}
