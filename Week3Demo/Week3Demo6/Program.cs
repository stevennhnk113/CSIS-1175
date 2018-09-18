using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week3Demo6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok = false;
            string[] readValue;
            while (!ok)
            {
                WriteLine("Please enter between 1 to 3 name?");
                readValue = ReadLine().Split(' ');

                if (readValue.Length > 0 & readValue.Length < 4)
                {

                    if (readValue[0] != "")
                    {
                        WriteLine("Good job");
                        ReadKey();
                        ok = true;
                    }
                }
            }
        }
    }
}
