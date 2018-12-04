using System;
using static System.Console;
using System.IO;

namespace Week5Demo1Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an obj myStaff based on Employee class
            Employee myStaff = new Employee("123","Simon Li", "S", 40,10);
            WriteLine(myStaff.getFirstName() + " is " 
                + myStaff.getTitle() + " makes " + myStaff.getPayAmt());
            ReadKey();
        }
    }
}
