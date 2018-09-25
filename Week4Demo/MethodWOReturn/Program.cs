using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MethodWOReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourName, firstName = "";
            WriteLine("What is your name?");
            yourName = ReadLine();

            getFirstName(yourName, ref firstName);

            WriteLine("Your first name is " + firstName);
            ReadKey();
        }

        static void getFirstName(string myName, ref string myFirstName)
        {
            string[] newName;
            newName = myName.Split(' ');
            myFirstName = newName[0];
        }
    }
}
