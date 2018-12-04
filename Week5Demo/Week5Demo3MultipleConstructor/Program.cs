using System;
using static System.Console;

namespace Week5Demo3MultipleConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myStaff = new Employee("Simon", "S", 20, 10);
            WriteLine(myStaff.getName() + " " + myStaff.getAmt());

            Employee myStaff2 = new Employee("Ray", "S", 200);
            WriteLine(myStaff2.getName() + " " + myStaff2.getAmt());

            ReadKey();
        }
    }
}
