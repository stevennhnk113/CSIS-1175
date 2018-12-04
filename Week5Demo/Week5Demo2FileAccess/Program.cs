using System;
using static System.Console;
using System.IO;

namespace Week5Demo2FileAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader inFile = File.OpenText(@"E:\1175-008\repos\week5DemoData.csv");
            while (!inFile.EndOfStream)
            {
                Staff myStaff = new Staff(inFile.ReadLine());
                WriteLine(myStaff.getFirstName() + " is "
                    + myStaff.getTitle() + " makes " + myStaff.getPayAmt());
                // WriteLine(inFile.ReadLine());
            }
            inFile.Close();
            ReadKey();
        }
    }
}
