using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week3Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneCo = "";
            double planAmt = 0;
            GetPhonePlan(ref phoneCo, ref planAmt);
            WriteLine("you are a " + phoneCo + " customer paying " + planAmt);
            ReadKey();
        }

        public static void GetPhonePlan(ref string company, ref double amt)
        {
            company = "telus";
            amt = 50;
        }
    }
}
