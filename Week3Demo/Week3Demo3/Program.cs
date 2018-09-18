using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week3Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            string readValue;
            WriteLine("Please enter 4 values, each serpated by a space");
            readValue = ReadLine();

            FindLargestValue(readValue);
        }

        public static void FindLargestValue(string readValue)
        {
            string[] valueArr = readValue.Split();
            int var1 = int.Parse(valueArr[0]);
            int var2 = int.Parse(valueArr[1]);
            int var3 = int.Parse(valueArr[2]);
            int var4 = int.Parse(valueArr[3]);

            int largestNum = var1;
            if(largestNum < var2)
            {
                largestNum = var2;
            }

            if (largestNum < var3)
            {
                largestNum = var3;
            }

            if (largestNum < var4)
            {
                largestNum = var4;
            }

            WriteLine("The largest num is " + largestNum);
            ReadKey();
        }
    }
}
