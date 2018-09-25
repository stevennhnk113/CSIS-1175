using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodMultipleRef
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void payroll(string grade, ref string title, double hrs, double rate, ref double amt)
        {
            amt = hrs * rate;
            switch(grade)
            {
                case "A":
                    title = "staff";
                    if (hrs > 35) amt = hrs * 35 + (hrs - 35) * rate * 2;
                    break;
                case "B":
                    title = "staff";
                    if (hrs > 35) amt = hrs * 35 + (hrs - 35) * rate * 1.5;
                    break;
                case "A":
                    title = "senior staff";
                    break;


            }
        }
    }
}
