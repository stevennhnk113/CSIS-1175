using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week2Turtorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteLine("What is your full name");
            //string fullName = ReadLine();

            //string firstName = fullName.Split()[0];
            //WriteLine("Hi " + firstName);
            //ReadKey();

            //double taxRate = .12;
            //double unitPrice = 50;
            //decimal surCharge = 5.5M;
            //int units = 3000;

            //double amt = unitPrice * units;

            //amt = amt + (double)surCharge;
            //WriteLine("The amt is " + amt);
            //WriteLine("The amt is {0:c}" + amt);
            //WriteLine("The amt is {0:c}", amt);
            //WriteLine("The unit price is {0:c}", unitPrice);


            //string location = @"c:\users\...";
            //string newLocation = "c:\\users\\...";

            //WriteLine(location);
            //WriteLine(newLocation);

            double var1 = 14;
            double var2 = 13;

            showLarger(var1, var2);

            ReadKey();
        }

        static void showLarger(double v1, double v2)
        {
            if(v1 > v2)
            {
                WriteLine("The bigger number is " + v1);
            }
            else
            {
                WriteLine("The bigger number is " + v2);
            }
        }

        static void showLargest(double[] numbersList)
        {

        }

        static void showSmallest()
        {

        }
    }
}
